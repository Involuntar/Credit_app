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
    public partial class mortgage_counted : Form
    {
        public mortgage_counted()
        {
            InitializeComponent();
        }

        private void mortgage_counted_Load(object sender, EventArgs e)
        {
            Summ_show.Text = public_class.End_Summ;
            Rate_show.Text = public_class.Rate + '%';
            Term_show.Text = public_class.Term + " лет";
        }

        private void Back_Click(object sender, EventArgs e)
        {
        }

        private void Back_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Mortgage mortgage = new Mortgage();
            mortgage.Show();
        }

        private void Send_req_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = Connection.GetConnection();
            string sql = $"INSERT INTO mortgages (cost, init_fee, credit_summ, term_id, rate_id, credit_type_id) " +
                $"VALUES (@cost, @init_fee, @credit_summ, (SELECT id FROM terms WHERE len LIKE @len), " +
                $"(SELECT id FROM rates WHERE coefficient LIKE @coeff), @credit_type_id)";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.Add("@cost", MySqlDbType.UInt64).Value = Convert.ToString(public_class.Start_Summ);
            cmd.Parameters.Add("@init_fee", MySqlDbType.UInt64).Value = public_class.init_fee;
            cmd.Parameters.Add("@credit_summ", MySqlDbType.UInt64).Value = public_class.End_Summ;
            
            cmd.Parameters.Add("@len", MySqlDbType.Double).Value = public_class.Term;
            cmd.Parameters.Add("@coeff", MySqlDbType.Double).Value = public_class.Rate;
            cmd.Parameters.Add("@credit_type_id", MySqlDbType.Int64).Value = public_class.credit_type_id;

            cmd.ExecuteScalar();
            MessageBox.Show("Заявка отправлена на рассмотрение", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Term_show_Click(object sender, EventArgs e)
        {

        }

        private void Summ_show_Click(object sender, EventArgs e)
        {

        }
    }
}
