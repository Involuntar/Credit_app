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
    public partial class Credit_types_watch : Form
    {
        public Credit_types_watch()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                return;
            }
            if (e.ColumnIndex == 1)
            {
                if (MessageBox.Show("Вы уверены, что хотите удалить данный тип?", "Информация", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    Connection.Delete_type(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
                    Display_data();
                }
                return;
            }
        }
        public void Display_data()
        {
            Connection.Display("SELECT * FROM credits_types", dataGridView1);
        }

        private void Credit_types_watch_Shown(object sender, EventArgs e)
        {
            Display_data();
        }
    }
}
