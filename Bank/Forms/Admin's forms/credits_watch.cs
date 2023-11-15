using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bank.Data;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace Bank.Forms.Admin_s_forms
{
    public partial class Credits_watch : Form
    {
        Credits_enter_form credits_enter_form;
        public Credits_watch()
        {
            InitializeComponent();
            credits_enter_form = new Credits_enter_form(this);
        }

        public void Display_credit()
        {
            Connection.Display("SELECT * FROM credits", dataGridCredit);
        }

        private void dataGridMort_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != String.Empty && textBox1.Text != "Поиск")
            {
                public_class.Search = textBox1.Text;
                Connection.Search("SELECT * FROM credits WHERE summ LIKE @search", dataGridCredit);
            }
            else
            {
                Connection.Display("SELECT * FROM credits", dataGridCredit);
            }
        }

        private void Credits_watch_Shown(object sender, EventArgs e)
        {
            Display_credit();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Form_for_admin for_Admin = new Form_for_admin();
            for_Admin.Show();
            this.Close();
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            textBox1.Text = "Поиск";
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            textBox1.Text = String.Empty;
        }
    }
}
