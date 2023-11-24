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

namespace Bank
{
    public partial class Grafic_show : Form
    {
        public Grafic_show()
        {
            InitializeComponent();
        }

        private void Grafic_show_Load(object sender, EventArgs e)
        {
            int term = Convert.ToUInt16(public_class.Term) * 12;
            double summ = Convert.ToDouble(public_class.Start_Summ);
            double perc = summ * Convert.ToDouble(public_class.Rate) / 12 / 100;
            double debt = summ / term;
            for (int i = 0; i < Convert.ToUInt16(public_class.Term) * 12; ++i)
            {
                int RowIndex = dataGridGraf.Rows.Add();

                dataGridGraf.Rows[RowIndex].Cells["month"].Value = i + 1;
                dataGridGraf.Rows[RowIndex].Cells["ost_debt"].Value = summ;
                dataGridGraf.Rows[RowIndex].Cells["payment"].Value = perc + debt;
                dataGridGraf.Rows[RowIndex].Cells["procent_part"].Value = perc;
                dataGridGraf.Rows[RowIndex].Cells["debt_part"].Value = debt;
                dataGridGraf.Rows[RowIndex].Cells["end_debt"].Value = summ - debt;
                summ -= debt;
            }
        }
    }   

                
}