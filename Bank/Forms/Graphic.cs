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

namespace Bank.Forms
{
    public partial class Graphic : Form
    {
        public Graphic()
        {
            InitializeComponent();
        }

        private void Graphic_Load(object sender, EventArgs e)
        {
            double remain = Convert.ToDouble(public_class.Start_Summ);
            double perc = remain * Convert.ToDouble(public_class.Rate) * 0.01 / 12;
            double debt = remain / (Convert.ToUInt16(public_class.Term) * 12);
            for (int i = 0; i < Convert.ToUInt16(public_class.Term) * 12; ++i)
            {
                int rowIndex = dataGridGraphic.Rows.Add();
                dataGridGraphic.Rows[rowIndex].Cells["Month"].Value = i + 1;
                dataGridGraphic.Rows[rowIndex].Cells["Remain"].Value = remain;
                dataGridGraphic.Rows[rowIndex].Cells["Payment"].Value = perc + debt;
                dataGridGraphic.Rows[rowIndex].Cells["Percents"].Value = perc;
                dataGridGraphic.Rows[rowIndex].Cells["Debt"].Value = debt;
                dataGridGraphic.Rows[rowIndex].Cells["Balance"].Value = remain - debt;
                remain -= debt;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
