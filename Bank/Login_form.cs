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
    public partial class Login_form : Form
    {
        public Login_form()
        {
            InitializeComponent();
        }

        private void Login_form_Load(object sender, EventArgs e)
        {

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Log_in_Click(object sender, EventArgs e)
        {
            if (User.Checked == true)
            {
                string login_check = Login.Text;
                string password_check = Password.Text;
                MySqlConnection con = Connection.GetConnection();
                string sql = $"SELECT login, password FROM users " +
                    $"WHERE login LIKE @login AND password LIKE @password";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.Add("@login", MySqlDbType.VarChar).Value = login_check;
                cmd.Parameters.Add("@password", MySqlDbType.VarChar).Value = password_check;

                try
                {
                    object pass_check = cmd.ExecuteScalar();
                    if (pass_check != null)
                    {
                        MessageBox.Show("Login successful", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Login denied", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch
                {

                }
            }
            else if (Admin.Checked == true)
            {
                string login_check = Login.Text;
                string password_check = Password.Text;
                MySqlConnection con = Connection.GetConnection();
                string sql = $"SELECT login, password FROM admins " +
                    $"WHERE login LIKE @login AND password LIKE @password";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.Add("@login", MySqlDbType.VarChar).Value = login_check;
                cmd.Parameters.Add("@password", MySqlDbType.VarChar).Value = password_check;

                try
                {
                    object pass_check = cmd.ExecuteScalar();
                    if (pass_check != null)
                    {
                        MessageBox.Show("Login successful", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Login denied", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch
                {

                }
            }
            else
            {
                MessageBox.Show("Chose your role", "Recomendation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Check_conn check = new Check_conn();
            check.Show();
        }
    }
}
