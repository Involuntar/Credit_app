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
using System.Globalization;

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
            Connection.Display("SELECT credits.id, terms.len, credits.summ, rates.coefficient, credits_types.name, statuses.name, users.lastname" +
                " FROM credits " +
                " JOIN terms ON credits.term_id = terms.id" +
                " JOIN rates ON credits.rate_id = rates.id" +
                " JOIN users ON credits.users_id = users.id" +
                " JOIN statuses ON credits.statuses_id = statuses.id" +
                " JOIN credits_types ON credits.credit_type_id = credits_types.id", dataGridCredit);
        }

        private void dataGridCredit_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            if (e.ColumnIndex == 0)
            {
                credits_enter_form.Clear();
                credits_enter_form.id = dataGridCredit.Rows[e.RowIndex].Cells[2].Value.ToString();
                credits_enter_form.summ  = dataGridCredit.Rows[e.RowIndex].Cells[4].Value.ToString();
                credits_enter_form.term_id = dataGridCredit.Rows[e.RowIndex].Cells[3].Value.ToString();
                credits_enter_form.rate_id = dataGridCredit.Rows[e.RowIndex].Cells[5].Value.ToString();

                credits_enter_form.credit_type_id = dataGridCredit.Rows[e.RowIndex].Cells[6].Value.ToString();
                credits_enter_form.users_id = dataGridCredit.Rows[e.RowIndex].Cells[8].Value.ToString();
                credits_enter_form.statuses_id = dataGridCredit.Rows[e.RowIndex].Cells[7].Value.ToString();

                credits_enter_form.UpdateCreditInfo();
                credits_enter_form.ShowDialog();
                return;
            }
            if(e.ColumnIndex == 1)
            {
                if(MessageBox.Show("Вы уверены, что хотите удалить кредит?", "Информация", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    Connection.Delete_credit(dataGridCredit.Rows[e.RowIndex].Cells[2].Value.ToString());
                    Display_credit();
                }
                return;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != String.Empty && textBox1.Text != "Поиск")
            {
                public_class.Search = textBox1.Text;
                Connection.Search("SELECT credits.id, terms.len, credits.summ, rates.coefficient, credits_types.name, statuses.name, users.lastname" +
                " FROM credits " +
                " JOIN terms ON credits.term_id = terms.id" +
                " JOIN rates ON credits.rate_id = rates.id" +
                " JOIN users ON credits.users_id = users.id" +
                " JOIN statuses ON credits.statuses_id = statuses.id" +
                " JOIN credits_types ON credits.credit_type_id = credits_types.id WHERE summ LIKE @search", dataGridCredit);
            }
            else
            {
                Connection.Display("SELECT credits.id, terms.len, credits.summ, rates.coefficient, credits_types.name, statuses.name, users.lastname" +
                " FROM credits " +
                " JOIN terms ON credits.term_id = terms.id" +
                " JOIN rates ON credits.rate_id = rates.id" +
                " JOIN users ON credits.users_id = users.id" +
                " JOIN statuses ON credits.statuses_id = statuses.id" +
                " JOIN credits_types ON credits.credit_type_id = credits_types.id", dataGridCredit);
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

        private void Add_new2_Click(object sender, EventArgs e)
        {
            credits_enter_form.Clear();
            credits_enter_form.ShowDialog();
        }
    }
}
