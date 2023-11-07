using Bank.Data;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Bcpg.OpenPgp;
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
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Registration_Load(object sender, EventArgs e)
        {

        }

        private void credit_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = Connection.GetConnection();
            string sql_insert = $"INSERT INTO users (firstname, middlename, lastname, email, login, password) " +
                $"VALUES (@name, @middlename, @lastname, @new_email, @new_login, @new_password)";
            string sql_check_user = $"SELECT login FROM users WHERE login LIKE @new_login";
            MySqlCommand cmd_check_user = new MySqlCommand(sql_check_user, conn);
            MySqlCommand cmd_insert = new MySqlCommand(sql_insert, conn);
            cmd_insert.Parameters.Add("@new_email", MySqlDbType.VarChar).Value = email.Text;
            cmd_insert.Parameters.Add("@new_login", MySqlDbType.VarChar).Value = new_login.Text;
            cmd_insert.Parameters.Add("@new_password", MySqlDbType.VarChar).Value = BCrypt.Net.BCrypt.HashPassword(new_password.Text); 
            cmd_insert.Parameters.Add("@name", MySqlDbType.VarChar).Value = name.Text;
            cmd_insert.Parameters.Add("@middlename", MySqlDbType.VarChar).Value = middlename.Text; 
            cmd_insert.Parameters.Add("@lastname", MySqlDbType.VarChar).Value = lastname.Text;
            cmd_check_user.Parameters.Add("@new_login", MySqlDbType.VarChar).Value = new_login.Text;
            object check_user = cmd_check_user.ExecuteScalar();
            if (check_user == null)
            {
                try 
                {
                    cmd_insert.ExecuteScalar();
                } 
                catch 
                {

                }
            }
            else 
            {
                MessageBox.Show("Такой логин уже используется", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            conn.Close();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login_form login = new Login_form();
            login.Show();
        }

        private void new_password_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
