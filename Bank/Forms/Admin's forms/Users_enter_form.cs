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
        public Users_enter_form(users_watch parent)
        {
            InitializeComponent();
            _parent = parent;
        }

        public void Clear()
        {
            firstname.Text = middlename.Text = lastname.Text = login.Text = password.Text = email.Text = string.Empty;
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (Save.Text == "Сохранить")
            {
                Users users = new Users(firstname.Text.Trim(), middlename.Text.Trim(),
                lastname.Text.Trim(), login.Text.Trim(), password.Text.Trim(), email.Text.Trim());
                Connection.Add_user(users);
                Clear();
            }
            _parent.Display_users();
        }
    }
}
