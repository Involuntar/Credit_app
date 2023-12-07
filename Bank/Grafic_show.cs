using Aspose.Pdf;
using Bank.Data;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank
{
    public partial class Grafic_show : Form
    {
        public Grafic_show()
        {
            InitializeComponent();
        }

        private void Grafic_show_Load(object sender, EventArgs e)
        {
            if (public_class.Credit_Type == 2)
            {
                diff_add.Visible = true;

                int term = Convert.ToUInt16(public_class.Term) * 12;
                double summ = Convert.ToDouble(public_class.Start_Summ);
                double debt = summ / term;
                for (int i = 0; i < term - 1; ++i)
                {
                    double perc = summ * Convert.ToDouble(public_class.Rate) / 12 / 100;

                    int RowIndex = dataGridGraf.Rows.Add();

                    dataGridGraf.Rows[RowIndex].Cells["month"].Value = i + 1;
                    dataGridGraf.Rows[RowIndex].Cells["ost_debt"].Value = Math.Round(summ, 2);
                    dataGridGraf.Rows[RowIndex].Cells["payment"].Value = Math.Round(perc + debt, 2);
                    dataGridGraf.Rows[RowIndex].Cells["procent_part"].Value = Math.Round(perc, 2);
                    dataGridGraf.Rows[RowIndex].Cells["debt_part"].Value = Math.Round(debt, 2);
                    dataGridGraf.Rows[RowIndex].Cells["end_debt"].Value = Math.Round(summ - debt, 2);
                    
                    summ -= debt;
                }
                double perc_last = summ * Convert.ToDouble(public_class.Rate) / 12 / 100;

                int RowIndex_last = dataGridGraf.Rows.Add();

                dataGridGraf.Rows[RowIndex_last].Cells["month"].Value = term;
                dataGridGraf.Rows[RowIndex_last].Cells["ost_debt"].Value = Math.Round(summ, 2);
                dataGridGraf.Rows[RowIndex_last].Cells["payment"].Value = Math.Round(perc_last + debt, 2);
                dataGridGraf.Rows[RowIndex_last].Cells["procent_part"].Value = Math.Round(perc_last, 2);
                dataGridGraf.Rows[RowIndex_last].Cells["debt_part"].Value = Math.Round(debt, 2);
                dataGridGraf.Rows[RowIndex_last].Cells["end_debt"].Value = 0;
            }
            else
            {
                diff_add.Visible = false;
                int term = Convert.ToUInt16(public_class.Term) * 12;
                double summ = Convert.ToDouble(public_class.Start_Summ);

                for (int i = 0; i < term - 1; ++i)
                {
                    double perc = summ * Convert.ToDouble(public_class.Rate) / 12 / 100;
                    double debt = Convert.ToDouble(public_class.monthly_pay) - perc;

                    int RowIndex = dataGridGraf.Rows.Add();

                    dataGridGraf.Rows[RowIndex].Cells["month"].Value = i + 1;
                    dataGridGraf.Rows[RowIndex].Cells["ost_debt"].Value = Math.Round(summ, 2);
                    dataGridGraf.Rows[RowIndex].Cells["payment"].Value = Convert.ToDouble(public_class.monthly_pay);
                    dataGridGraf.Rows[RowIndex].Cells["procent_part"].Value = Math.Round(perc, 2);
                    dataGridGraf.Rows[RowIndex].Cells["debt_part"].Value = Math.Round(debt, 2);
                    dataGridGraf.Rows[RowIndex].Cells["end_debt"].Value = Math.Round(summ - debt, 2);

                    summ -= debt;
                }

                double perc_last = summ * Convert.ToDouble(public_class.Rate) / 12 / 100;
                double debt_last = Convert.ToDouble(public_class.monthly_pay) - perc_last;

                int RowIndex_last = dataGridGraf.Rows.Add();

                dataGridGraf.Rows[RowIndex_last].Cells["month"].Value = term;
                dataGridGraf.Rows[RowIndex_last].Cells["ost_debt"].Value = Math.Round(summ, 2);
                dataGridGraf.Rows[RowIndex_last].Cells["payment"].Value = Convert.ToDouble(public_class.monthly_pay);
                dataGridGraf.Rows[RowIndex_last].Cells["procent_part"].Value = Math.Round(perc_last, 2);
                dataGridGraf.Rows[RowIndex_last].Cells["debt_part"].Value = Math.Round(debt_last, 2);
                dataGridGraf.Rows[RowIndex_last].Cells["end_debt"].Value = 0;
            }
        }

        private void Graf_back_Click(object sender, EventArgs e)
        {
            if (public_class.Credit_Type == 1)
            {
                this.Close();
            }

            else
            {
                Credit credit = new Credit();
                this.Close();
                credit.Show();
            }
        }

        private void diff_add_Click(object sender, EventArgs e)
        {
            MySqlConnection con = Connection.GetConnection();

            string sql = $"INSERT INTO credits (term_id, summ, rate_id, credit_type_id, statuses_id, " +
                $"users_id) " +
                $"VALUES (" +
                $"(SELECT id FROM terms WHERE len = @len), " +
                $"@summ, " +
                $"(SELECT id FROM rates WHERE coefficient = @coeff), " +
                $"@credit_type_id, " +
                $"4, " +
                $"(SELECT id FROM users WHERE login LIKE @login))";

            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.Parameters.Add("@len", MySqlDbType.UInt16).Value = public_class.Term;
            cmd.Parameters.Add("@summ", MySqlDbType.Double).Value = public_class.End_Summ;
            cmd.Parameters.Add("@coeff", MySqlDbType.Double).Value = public_class.Rate;

            cmd.Parameters.Add("@credit_type_id", MySqlDbType.UInt16).Value = public_class.credit_type_id;
            cmd.Parameters.Add("@login", MySqlDbType.VarChar).Value = public_class.Login;

            Document doc = new Document();
            Page page = doc.Pages.Add();
            Table table = new Table();
            //table.ColumnWidths = "50 50 50";
            table.ColumnAdjustment = ColumnAdjustment.AutoFitToContent;
            table.DefaultCellBorder = new BorderInfo(BorderSide.All, 0.1F);
            table.Border = new BorderInfo(BorderSide.All, 1F);

            MarginInfo margin = new MarginInfo();
            margin.Top = 5f;
            margin.Bottom = 5f;
            margin.Left = 5f;
            margin.Right = 5f;
            table.DefaultCellPadding = margin;

            Row main_row = table.Rows.Add();
            main_row.Cells.Add("Месяц");
            main_row.Cells.Add("Остаток долга");
            main_row.Cells.Add("Сумма платежа");
            main_row.Cells.Add("Платёж по процентам");
            main_row.Cells.Add("Платёж по основному долгу");
            main_row.Cells.Add("Остаток долга на конец периода");

            if (public_class.Credit_Type == 2)
            {
                int term = Convert.ToUInt16(public_class.Term) * 12;
                double summ = Convert.ToDouble(public_class.Start_Summ);
                double debt = summ / term;
                for (int i = 0; i < term - 1; ++i)
                {
                    double perc = summ * Convert.ToDouble(public_class.Rate) / 12 / 100;

                    Row row = table.Rows.Add();

                    row.Cells.Add(Convert.ToString(i + 1));
                    row.Cells.Add(Convert.ToString(Math.Round(summ, 2)));
                    row.Cells.Add(Convert.ToString(Math.Round(perc + debt, 2)));
                    row.Cells.Add(Convert.ToString(Math.Round(perc, 2)));
                    row.Cells.Add(Convert.ToString(Math.Round(debt, 2)));
                    row.Cells.Add(Convert.ToString(Math.Round(summ - debt, 2)));

                    summ -= debt;
                }
                double perc_last = summ * Convert.ToDouble(public_class.Rate) / 12 / 100;

                Row last_row = table.Rows.Add();

                last_row.Cells.Add(Convert.ToString(term));
                last_row.Cells.Add(Convert.ToString(Math.Round(summ, 2)));
                last_row.Cells.Add(Convert.ToString(Math.Round(perc_last + debt, 2)));
                last_row.Cells.Add(Convert.ToString(Math.Round(perc_last, 2)));
                last_row.Cells.Add(Convert.ToString(Math.Round(debt, 2)));
                last_row.Cells.Add("0");

                page.Paragraphs.Add(table);

                doc.Save("C:\\Users\\Public\\Documents\\Annuit_credit.pdf");
            }
            else
            {
                int term = Convert.ToUInt16(public_class.Term) * 12;
                double summ = Convert.ToDouble(public_class.Start_Summ);

                for (int i = 0; i < term - 1; ++i)
                {
                    double perc = summ * Convert.ToDouble(public_class.Rate) / 12 / 100;
                    double debt = Convert.ToDouble(public_class.monthly_pay) - perc;

                    int RowIndex = dataGridGraf.Rows.Add();

                    dataGridGraf.Rows[RowIndex].Cells["month"].Value = i + 1;
                    dataGridGraf.Rows[RowIndex].Cells["ost_debt"].Value = Math.Round(summ, 2);
                    dataGridGraf.Rows[RowIndex].Cells["payment"].Value = Convert.ToDouble(public_class.monthly_pay);
                    dataGridGraf.Rows[RowIndex].Cells["procent_part"].Value = Math.Round(perc, 2);
                    dataGridGraf.Rows[RowIndex].Cells["debt_part"].Value = Math.Round(debt, 2);
                    dataGridGraf.Rows[RowIndex].Cells["end_debt"].Value = Math.Round(summ - debt, 2);

                    summ -= debt;
                }

                double perc_last = summ * Convert.ToDouble(public_class.Rate) / 12 / 100;
                double debt_last = Convert.ToDouble(public_class.monthly_pay) - perc_last;

                int RowIndex_last = dataGridGraf.Rows.Add();

                dataGridGraf.Rows[RowIndex_last].Cells["month"].Value = term;
                dataGridGraf.Rows[RowIndex_last].Cells["ost_debt"].Value = Math.Round(summ, 2);
                dataGridGraf.Rows[RowIndex_last].Cells["payment"].Value = Convert.ToDouble(public_class.monthly_pay);
                dataGridGraf.Rows[RowIndex_last].Cells["procent_part"].Value = Math.Round(perc_last, 2);
                dataGridGraf.Rows[RowIndex_last].Cells["debt_part"].Value = Math.Round(debt_last, 2);
                dataGridGraf.Rows[RowIndex_last].Cells["end_debt"].Value = 0;
            }

            con.Close();
        }
    }   
}