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
        Users_enter_form enter_Form;
        public users_watch()
        {
            InitializeComponent();
            enter_Form = new Users_enter_form(this);
        }

        public void Display_users()
        {
            Connection.Display("SELECT * FROM users", dataGridUsers);
        }

        private void Add_new_Click(object sender, EventArgs e)
        {
            enter_Form.Clear();
            enter_Form.ShowDialog();
        }

        private void users_watch_Shown(object sender, EventArgs e)
        {
            Display_users();
        }

        private void dataGridUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                enter_Form.Clear();
                enter_Form.id = dataGridUsers.Rows[e.RowIndex].Cells[2].Value.ToString();
                enter_Form.firstname = dataGridUsers.Rows[e.RowIndex].Cells[3].Value.ToString();
                enter_Form.middlename = dataGridUsers.Rows[e.RowIndex].Cells[4].Value.ToString();
                enter_Form.lastname = dataGridUsers.Rows[e.RowIndex].Cells[5].Value.ToString();
                enter_Form.login = dataGridUsers.Rows[e.RowIndex].Cells[6].Value.ToString();
                enter_Form.password = dataGridUsers.Rows[e.RowIndex].Cells[7].Value.ToString();
                enter_Form.email = dataGridUsers.Rows[e.RowIndex].Cells[8].Value.ToString();

                enter_Form.UpdateUserInfo();
                enter_Form.ShowDialog();
                return;
            }
            if (e.ColumnIndex == 1)
            {
                if (MessageBox.Show("Вы уверены, что хотите удалить пользователя?", "Информация", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    Connection.Delete_user(dataGridUsers.Rows[e.RowIndex].Cells[2].Value.ToString());
                    Display_users();
                }
                return;
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
            Form_for_admin for_Admin = new Form_for_admin();
            for_Admin.Show();
        }

        private void Users_text_Click(object sender, EventArgs e)
        {

        }

        private void dataGridUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != String.Empty && textBox1.Text != "Поиск")
            {
                public_class.Search = textBox1.Text;
                Connection.Search("SELECT * FROM users WHERE firstname LIKE @search", dataGridUsers);
            }
            else 
            {
                Connection.Display("SELECT * FROM users", dataGridUsers);
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
