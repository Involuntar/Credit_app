using Bank.Forms.Admin_s_forms;
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
    public partial class Form_for_admin : Form
    {
        public Form_for_admin()
        {
            InitializeComponent();
        }

        private void users_Click(object sender, EventArgs e)
        {
            users_watch users = new users_watch();
            users.Show();
            this.Hide();
        }

        private void ipoteka_Click(object sender, EventArgs e)
        {
            Mortgages_watch mortgages = new Mortgages_watch();
            mortgages.Show();
            this.Hide();
        }

        private void credits_Click(object sender, EventArgs e)
        {
            Credits_watch credits = new Credits_watch();
            credits.Show();
            this.Hide();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
