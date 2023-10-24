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
    public partial class mortgage_counted : Form
    {
        public mortgage_counted()
        {
            InitializeComponent();
        }

        private void mortgage_counted_Load(object sender, EventArgs e)
        {
            Summ_show.Text = public_class.End_Summ;
            Rate_show.Text = public_class.Rate + '%';
            Term_show.Text = public_class.Term + " лет";
        }
    }
}
