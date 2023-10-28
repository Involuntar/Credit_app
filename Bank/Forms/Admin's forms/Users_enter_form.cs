using Bank.Data;
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
        public string id, firstname, middlename, lastname, login, password, email;
        public Users_enter_form(users_watch parent)
        {
            InitializeComponent();
            _parent = parent;
        }

        public void UpdateUserInfo()
        {
            Save.Text = "Обвновить";
            firstnametxt.Text = firstname;
            middlenametxt.Text = middlename;
            lastnametxt.Text = lastname;
            logintxt.Text = login;
            passwordtxt.Text = password;
            emailtxt.Text = email;
        }

        public void Clear()
        {
            firstnametxt.Text = middlenametxt.Text = lastnametxt.Text = logintxt.Text = passwordtxt.Text = emailtxt.Text = string.Empty;
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (Save.Text == "Сохранить")
            {
                Users users = new Users(firstnametxt.Text.Trim(), middlenametxt.Text.Trim(),
                lastnametxt.Text.Trim(), logintxt.Text.Trim(), passwordtxt.Text.Trim(), emailtxt.Text.Trim());
                Connection.Add_user(users);
                Clear();
            }
            if (Save.Text == "Обвновить")
            {
                Users users = new Users(firstnametxt.Text.Trim(), middlenametxt.Text.Trim(),
                lastnametxt.Text.Trim(), logintxt.Text.Trim(), passwordtxt.Text.Trim(), emailtxt.Text.Trim());
                Connection.Update_users(users, id);
            }
            _parent.Display_users();
        }
    }
}
