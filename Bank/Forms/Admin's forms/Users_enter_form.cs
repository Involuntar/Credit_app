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

namespace Bank.Forms.Admin_s_forms
{
    public partial class Users_enter_form : Form
    {
        private readonly users_watch _parent;
        public string id, firstname, middlename, lastname, login, password, email, chngpswrd;

        private void firstname_txt_Click(object sender, EventArgs e)
        {

        }

        private void logintxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public Users_enter_form(users_watch parent)
        {
            InitializeComponent();
            _parent = parent;
        }

        public void UpdateUserInfo()
        {
            Save.Text = "Обновить";
            firstnametxt.Text = firstname;
            middlenametxt.Text = middlename;
            lastnametxt.Text = lastname;
            logintxt.Text = login;
            passwordtxt.Text = String.Empty;
            emailtxt.Text = email;
        }

        public void Clear()
        {
            firstnametxt.Text = middlenametxt.Text = lastnametxt.Text = logintxt.Text = passwordtxt.Text = emailtxt.Text = string.Empty;
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (lastnametxt.Text.Trim().Length < 3)
            {
                MessageBox.Show("Фамилия должна содердать как минимум 3 символа");
                return;
            }

            if (firstnametxt.Text.Trim().Length < 3)
            {
                MessageBox.Show("Имя должно содержать как минимум 3 символа");
                return;
            }

            if (logintxt.Text.Trim().Length < 5)
            {
                MessageBox.Show("Логин должен содержать как минимум 5 символов");
                return;
            }

            if (emailtxt.Text.Trim().Length < 10)
            {
                MessageBox.Show("Почта должна содержать как минимум 10 символов");
                return;
            }
            /*
            MySqlConnection con = Connection.GetConnection();
            string sql = "SELECT password FROM users WHERE login = @login";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.Parameters.Add("@login", MySqlDbType.VarChar).Value = logintxt.Text.Trim();
            string password = (string)cmd.ExecuteScalar();
            if ((passwordtxt.Text.Trim() == password) || (passwordtxt.Text == String.Empty))
            {
                chngpswrd = password;
            }
            else
            {
                chngpswrd = passwordtxt.Text.Trim();
            }*/
            

            if (Save.Text == "Сохранить")
            {
                Users users = new Users(firstnametxt.Text.Trim(), middlenametxt.Text.Trim(),
                lastnametxt.Text.Trim(), logintxt.Text.Trim(), passwordtxt.Text.Trim(), emailtxt.Text.Trim());
                Connection.Add_user(users);
                Clear();
            }

            if (Save.Text == "Обновить")
            {
                Users users = new Users(firstnametxt.Text.Trim(), middlenametxt.Text.Trim(),
                lastnametxt.Text.Trim(), logintxt.Text.Trim(), passwordtxt.Text.Trim(), emailtxt.Text.Trim());
                Connection.Update_users(users, id);
            }
            _parent.Display_users();
        }
    }
}
