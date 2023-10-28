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
    public partial class users_watch : Form
    {
        public users_watch()
        {
            InitializeComponent();
        }

        public void Display_users()
        {
            Connection.Display("SELECT * FROM users", dataGridUsers);
        }

        private void Add_new_Click(object sender, EventArgs e)
        {
            Users_enter_form users_Enter = new Users_enter_form(this);
            users_Enter.ShowDialog();
        }

        private void users_watch_Shown(object sender, EventArgs e)
        {
            Display_users();
        }
    }
}
