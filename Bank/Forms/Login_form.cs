using Bank.Data;
using Bank.Forms;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Crypto.Generators;
using Org.BouncyCastle.Tls.Crypto;
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
            Application.Exit();
        }

        private void Log_in_Click(object sender, EventArgs e)
        {
            if (User.Checked == true)
            {
                public_class.Login = Login.Text;
                public_class.Password = Password.Text;
                MySqlConnection con = Connection.GetConnection();
                
                string sql_2 = $"SELECT password FROM users WHERE login LIKE @login";
                MySqlCommand cmd_2 = new MySqlCommand(sql_2, con);
                cmd_2.Parameters.Add("@login", MySqlDbType.VarChar).Value = public_class.Login;
                string passwords = (string)cmd_2.ExecuteScalar();

                string sql_lastname = "SELECT lastname FROM users WHERE login LIKE @login";
                MySqlCommand cmd_last = new MySqlCommand(sql_lastname, con);
                cmd_last.Parameters.Add("@login", MySqlDbType.VarChar).Value = public_class.Login;
                public_class.Lastname = (string)cmd_last.ExecuteScalar();

                string sql_middle = "SELECT middlename FROM users WHERE login LIKE @login";
                MySqlCommand cmd_mid = new MySqlCommand(sql_middle, con);
                cmd_mid.Parameters.Add("@login", MySqlDbType.VarChar).Value = public_class.Login;
                public_class.Middlename = (string)cmd_mid.ExecuteScalar();

                string sql_frst = "SELECT firstname FROM users WHERE login LIKE @login";
                MySqlCommand cmd_frst = new MySqlCommand(sql_frst, con);
                cmd_frst.Parameters.Add("@login", MySqlDbType.VarChar).Value = public_class.Login;
                public_class.Firstname = (string)cmd_last.ExecuteScalar();

                string sql_mail = "SELECT email FROM users WHERE login LIKE @login";
                MySqlCommand cmd_mail = new MySqlCommand(sql_mail, con);
                cmd_mail.Parameters.Add("@login", MySqlDbType.VarChar).Value = public_class.Login;
                public_class.Mail = (string)cmd_mail.ExecuteScalar();

                if (passwords != null && BCrypt.Net.BCrypt.Verify(public_class.Password, passwords) == true)
                {
                    MessageBox.Show("Вход успешен", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    Product_choice pr_ch = new Product_choice();
                    pr_ch.Show();
                }

                else
                {
                    MessageBox.Show("Неверный логин или пароль", "Ошибка входа!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                con.Close();
            }

            else if (Admin.Checked == true)
            {
                public_class.Login = Login.Text;
                public_class.Password = Password.Text;
                MySqlConnection con = Connection.GetConnection();
                string sql = $"SELECT login, password FROM admins " +
                    $"WHERE login LIKE @login AND password LIKE @password";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.Add("@login", MySqlDbType.VarChar).Value = public_class.Login;
                string sql_2 = $"SELECT password FROM admins";
                MySqlCommand cmd_2 = new MySqlCommand(sql_2, con);
                string passwords = (string)cmd_2.ExecuteScalar();

                if (passwords != null && BCrypt.Net.BCrypt.Verify(public_class.Password, passwords) == true)
                {
                    MessageBox.Show("Вход успешен", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    Form_for_admin for_Admin = new Form_for_admin();
                    for_Admin.Show();
                }

                else
                {
                    MessageBox.Show("Неверный логин или пароль", "Ошибка входа!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                con.Close();
            }

            else
            {
                MessageBox.Show("Выберите роль!", "Рекомендация", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Check_conn check = new Check_conn();
            check.Show();
        }

        private void Reg_Click(object sender, EventArgs e)
        {
            Registration reg = new Registration();
            reg.Show();
            this.Hide();
        }

        private void Log_in_txt_Click(object sender, EventArgs e)
        {

        }

        private void Admin_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Password_TextChanged(object sender, EventArgs e)
        {

        }

        private void User_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
