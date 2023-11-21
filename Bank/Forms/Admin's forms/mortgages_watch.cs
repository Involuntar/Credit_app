using Bank.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Globalization;


namespace Bank.Forms.Admin_s_forms
{
    public partial class Mortgages_watch : Form
    {
        Mortgages_enter_form mortgages_enter_form;
        public Mortgages_watch()
        {
            InitializeComponent();
            mortgages_enter_form = new Mortgages_enter_form(this);
        }

        public void Display_mort()
        {
            Connection.Display("SELECT mortgages.id, mortgages.cost, mortgages.init_fee, mortgages.credit_summ, " +
                "terms.len, rates.coefficient, credits_types.name, users.login, statuses.name " +
                "FROM mortgages " +
                "JOIN terms ON mortgages.term_id = terms.id " +
                "JOIN rates ON mortgages.rate_id = rates.id " +
                "JOIN users ON mortgages.users_id = users.id " +
                "JOIN statuses ON mortgages.statuses_id = statuses.id " +
                "JOIN credits_types ON mortgages.credit_type_id = credits_types.id", dataGridMort);
        }

        private void dataGridMort_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            if (e.ColumnIndex == 0)

            {
                mortgages_enter_form.Clear();
                mortgages_enter_form.id = dataGridMort.Rows[e.RowIndex].Cells[2].Value.ToString();
                mortgages_enter_form.cost = dataGridMort.Rows[e.RowIndex].Cells[3].Value.ToString();
                mortgages_enter_form.init_fee = dataGridMort.Rows[e.RowIndex].Cells[4].Value.ToString();
                mortgages_enter_form.credit_summ = dataGridMort.Rows[e.RowIndex].Cells[5].Value.ToString();

                mortgages_enter_form.term_id = dataGridMort.Rows[e.RowIndex].Cells[6].Value.ToString();
                mortgages_enter_form.rate_id = dataGridMort.Rows[e.RowIndex].Cells[7].Value.ToString();
                mortgages_enter_form.credit_type_id = dataGridMort.Rows[e.RowIndex].Cells[8].Value.ToString();
                mortgages_enter_form.users_id = dataGridMort.Rows[e.RowIndex].Cells[9].Value.ToString();
                mortgages_enter_form.statuses_id = dataGridMort.Rows[e.RowIndex].Cells[10].Value.ToString();

                mortgages_enter_form.UpdateMortInfo();
                mortgages_enter_form.ShowDialog();
                return;
            }
            if (e.ColumnIndex == 1)
            {
                if (MessageBox.Show("Вы уверены, что хотите удалить ипотеку?", "Информация", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    Connection.Delete_mortgages(dataGridMort.Rows[e.RowIndex].Cells[2].Value.ToString());
                    Display_mort();
                }
                return;
            }
        }

        private void Add_new_Click(object sender, EventArgs e)
        {
            mortgages_enter_form.Clear();
            mortgages_enter_form.ShowDialog();
        }

        private void Mortgages_watch_Shown(object sender, EventArgs e)
        {
            Display_mort();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
            Form_for_admin for_Admin = new Form_for_admin();
            for_Admin.Show();
        }

        private void dataGridMort_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != String.Empty && textBox1.Text != "Поиск")
            {
                public_class.Search = textBox1.Text;
                Connection.Search("SELECT mortgages.id, mortgages.cost, mortgages.init_fee, mortgages.credit_summ, " + 
                "terms.len, rates.coefficient, credits_types.name, users.login, statuses.name " +
                "FROM mortgages " +
                "JOIN terms ON mortgages.term_id = terms.id " +
                "JOIN rates ON mortgages.rate_id = rates.id " +
                "JOIN users ON mortgages.users_id = users.id " +
                "JOIN statuses ON mortgages.statuses_id = statuses.id " +
                "JOIN credits_types ON mortgages.credit_type_id = credits_types.id WHERE " +
                "users.login LIKE @search OR " +
                "mortgages.cost = @search OR " +
                "credits_types.name LIKE @search OR " +
                "rates.coefficient = @search OR " +
                "statuses.name LIKE @search", dataGridMort);
            }
            else
            {
                Connection.Display("SELECT mortgages.id, mortgages.cost, mortgages.init_fee, mortgages.credit_summ, " +
                "terms.len, rates.coefficient, credits_types.name, users.login, statuses.name " +
                "FROM mortgages " +
                "JOIN terms ON mortgages.term_id = terms.id " +
                "JOIN rates ON mortgages.rate_id = rates.id " +
                "JOIN users ON mortgages.users_id = users.id " +
                "JOIN statuses ON mortgages.statuses_id = statuses.id " +
                "JOIN credits_types ON mortgages.credit_type_id = credits_types.id", dataGridMort);
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            textBox1.Text = String.Empty;
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            textBox1.Text = "Поиск";
        }
    }
}
