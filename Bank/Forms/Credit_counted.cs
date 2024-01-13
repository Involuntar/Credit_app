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

namespace Bank.Forms
{
    public partial class Credit_counted : Form
    {
        public Credit_counted()
        {
            InitializeComponent();
        }

        private void Credit_counted_Load(object sender, EventArgs e)
        {
            Summ.Text = public_class.End_Summ;
            //Rate.Text = public_class.Rate + '%';
            Term.Text = public_class.Term + " лет";
            Payment.Text = public_class.monthly_pay;
            double Percents = Convert.ToDouble(public_class.monthly_pay) * 12 * Convert.ToUInt32(public_class.Term) - Convert.ToDouble(public_class.Start_Summ);

            Rate.Text = Convert.ToString(Percents);
        }

        private void Send_req_Click(object sender, EventArgs e)
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
            try 
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Заявка отправлена на рассмотрение", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Ошибка отправки \n" + ex, "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            Connection.Create_pdf(public_class.Start_Summ, Convert.ToUInt16(public_class.Term) * 12, 
                $"Annuit_credit{public_class.Lastname}_{public_class.Firstname}.pdf");

            con.Close();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Credit credit = new Credit();
            credit.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void graf_cr_Click(object sender, EventArgs e)
        {
            Grafic_show grafic = new Grafic_show();
            grafic.ShowDialog();
        }
    }
}
