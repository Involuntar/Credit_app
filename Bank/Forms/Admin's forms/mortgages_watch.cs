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
            Connection.Display("SELECT * FROM mortgages", dataGridMort);
        }

        private void dataGridMort_CellClick(object sender, DataGridViewCellEventArgs e)
        {
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
                if (MessageBox.Show("Вы уверены, что хотите удалить пользователя?", "Информация", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    Connection.Delete_user(dataGridMort.Rows[e.RowIndex].Cells[2].Value.ToString());
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
            (DataGridView.DataSource as DataTable).DefaultView.RowFilter = $"user_id LIKE '%{textBox1.Text}%'";
        }
    }
}
