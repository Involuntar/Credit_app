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
    public partial class Credit_counted : Form
    {
        public Credit_counted()
        {
            InitializeComponent();
        }

        private void Credit_counted_Load(object sender, EventArgs e)
        {
            Summ.Text = public_class.End_Summ;
            Rate.Text = public_class.Rate + '%';
            Term.Text = public_class.Term + " лет";
            Payment.Text = public_class.monthly_pay;
        }
    }
}
