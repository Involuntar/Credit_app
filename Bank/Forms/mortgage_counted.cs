﻿using Bank.Data;
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
            Summ_show.Text = public_class.End_Summ + " р.";
            Term_show.Text = public_class.Term + " лет";
            Monthly_pay.Text = public_class.monthly_pay + " р.";

            double Percents = Convert.ToDouble(public_class.monthly_pay) * 12 * Convert.ToUInt32(public_class.Term) - public_class.Start_Summ;

            Rate_show.Text = Convert.ToString(Percents) + " р.";
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
            string sql = $"INSERT INTO mortgages (cost, init_fee, credit_summ, term_id, rate_id, " +
                $"credit_type_id, users_id, statuses_id) " +
                $"VALUES (@cost, " +
                $"@init_fee, " +
                $"@credit_summ, " +
                $"(SELECT id FROM terms WHERE len = @len), " +
                $"(SELECT id FROM rates WHERE coefficient = @coeff), " +
                $"@credit_type_id, " +
                $"(SELECT id FROM users WHERE login LIKE @login), " +
                $"4)";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.Add("@cost", MySqlDbType.VarChar).Value = public_class.Start_Summ;
            cmd.Parameters.Add("@init_fee", MySqlDbType.VarChar).Value = public_class.init_fee;
            cmd.Parameters.Add("@credit_summ", MySqlDbType.Double).Value = public_class.End_Summ;
            
            cmd.Parameters.Add("@len", MySqlDbType.UInt16).Value = public_class.Term;
            cmd.Parameters.Add("@coeff", MySqlDbType.Double).Value = public_class.Rate;
            cmd.Parameters.Add("@credit_type_id", MySqlDbType.VarChar).Value = public_class.credit_type_id;

            cmd.Parameters.Add("@login", MySqlDbType.VarChar).Value = public_class.Login;
            cmd.Parameters.Add("@password", MySqlDbType.VarChar).Value = public_class.Password;

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

            conn.Close();
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

        private void Rate_show_Click(object sender, EventArgs e)
        {

        }

        private void graf_Click(object sender, EventArgs e)
        {
            Grafic_show grafic = new Grafic_show();
            grafic.ShowDialog();
        }
    }
}
