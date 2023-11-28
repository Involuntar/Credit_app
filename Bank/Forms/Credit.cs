using Bank.Data;
using Bank.Forms;
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
    public partial class Credit : Form
    {

        public Credit()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void roundButton1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Credit_Load(object sender, EventArgs e)
        {

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
            Product_choice product_ = new Product_choice();
            product_.Show();
        }


        private void Count_Click(object sender, EventArgs e)
        {
            try
            {
                if (Annuit.Checked == true)
                {
                    public_class.Credit_Type = 1;

                    public_class.End_Summ = Summ.Text;

                    public_class.Term = (term.Text).Substring(0, (term.Text).IndexOf('л'));
                    public_class.Rate = (rate.Text).Substring(0, (rate.Text).IndexOf('%'));

                    public_class.credit_type_id = "3";

                    double abs_rate = Math.Pow(1 + Convert.ToDouble(public_class.Rate) * 0.01 / 12, Convert.ToUInt16(public_class.Term) * 12);
                    public_class.monthly_pay =
                        Convert.ToString(Math.Round(Convert.ToDouble(public_class.End_Summ) * Convert.ToDouble(public_class.Rate) * 0.01 / 12 * abs_rate / (abs_rate - 1), 2));
                    public_class.End_Summ =
                        Convert.ToString(Convert.ToDouble(public_class.monthly_pay) * 12 * Convert.ToUInt16(public_class.Term));

                    this.Hide();
                    Credit_counted counted = new Credit_counted();
                    counted.Show();
                }

                else if (Diff.Checked == true)
                {
                    double end_summ = 0;

                    public_class.Credit_Type = 2;
                    public_class.Start_Summ = Convert.ToUInt32(Summ.Text);

                    public_class.Term = (term.Text).Substring(0, (term.Text).IndexOf('л'));
                    public_class.Rate = (rate.Text).Substring(0, (rate.Text).IndexOf('%'));

                    public_class.credit_type_id = "5";

                    int Term = Convert.ToUInt16(public_class.Term) * 12;

                    for (int i = 0; i < Convert.ToUInt16(public_class.Term) * 12; ++i)
                    {
                        double summ = Convert.ToDouble(public_class.Start_Summ);
                        double perc = summ * Convert.ToDouble(public_class.Rate) / 12 * 0.01;
                        double debt = Math.Round(summ / Term, 2);

                        end_summ += perc + debt;
                    }

                    public_class.End_Summ = Convert.ToString(end_summ);

                    Grafic_show grafic = new Grafic_show();
                    this.Hide();
                    grafic.Show();
                }

                else
                {
                    MessageBox.Show("Выберите тип платежа", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

            catch (System.FormatException)
            {
                MessageBox.Show("Введите сумму кредита", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            catch (System.ArgumentOutOfRangeException)
            {
                MessageBox.Show("Выберите ставку и срок", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void term5_Click(object sender, EventArgs e)
        {
            term.Text = "5 лет";
            term.Visible = true;
        }

        private void term10_Click(object sender, EventArgs e)
        {
            term.Text = "10 лет";
            term.Visible = true;
        }

        private void term15_Click(object sender, EventArgs e)
        {
            term.Text = "15 лет";
            term.Visible = true;
        }

        private void term20_Click(object sender, EventArgs e)
        {
            term.Text = "20 лет";
            term.Visible = true;
        }

        private void term30_Click(object sender, EventArgs e)
        {
            term.Text = "30 лет";
            term.Visible = true;
        }

        private void rate5_Click(object sender, EventArgs e)
        {
            rate.Text = "5%";
            rate.Visible = true;
        }

        private void rate8_Click(object sender, EventArgs e)
        {
            rate.Text = "8%";
            rate.Visible = true;
        }

        private void rate136_Click(object sender, EventArgs e)
        {
            rate.Text = "13,6%";
            rate.Visible = true;
        }

        private void rate142_Click(object sender, EventArgs e)
        {
            rate.Text = "14,2%";
            rate.Visible = true;
        }

        private void rate155_Click(object sender, EventArgs e)
        {
            rate.Text = "15,5%";
            rate.Visible = true;
        }
    }
}
