using Bank.Data;
using Bank.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank
{
    public partial class Mortgage : Form
    {
        //и ты засинхронься пжпж
        public Mortgage()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Mortgage_Load(object sender, EventArgs e)
        {

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Product_choice product_ = new Product_choice();
            product_.Show();
            this.Close();
        }

        private void Mortgage_count_Click(object sender, EventArgs e)
        {
            try
            {
                public_class.Start_Summ = Convert.ToUInt32(Summ_morts.Text);
                public_class.Rate = (rate.Text).Substring(0, (rate.Text).IndexOf('%'));
                public_class.Term = (term.Text).Substring(0, (term.Text).IndexOf('л'));
                UInt32 first_payment = Convert.ToUInt32(firstpay.Text);
                public_class.End_Summ = Convert.ToString(Math.Ceiling(public_class.Start_Summ * Double.Parse(public_class.Rate) * 1.01) - Convert.ToDouble(first_payment));

                this.Hide();
                mortgage_counted counted = new mortgage_counted();
                counted.Show();
            }
            catch (FormatException)
            {
                MessageBox.Show("Введите целое число", "Неверная сумма", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rate8_Click(object sender, EventArgs e)
        {
            rate.Text = "8%";
            rate.Visible = true;
        }

        private void rate5_Click(object sender, EventArgs e)
        {
            rate.Text = "5%";
            rate.Visible = true;
        }

        private void rate136_Click(object sender, EventArgs e)
        {
            rate.Text = "13,6%";
            rate.Visible = true;
        }

        private void rate142_Click(object sender, EventArgs e)
        {
            rate.Text = "14,2%";
            rate.Visible = true;
        }

        private void rate155_Click(object sender, EventArgs e)
        {
            rate.Text = "15,5%";
            rate.Visible = true;
        }

        private void years5_Click(object sender, EventArgs e)
        {
            term.Text = "5 лет";
            term.Visible = true;
        }

        private void years10_Click(object sender, EventArgs e)
        {
            term.Text = "10 лет";
            term.Visible = true;
        }

        private void years15_Click(object sender, EventArgs e)
        {
            term.Text = "15 лет";
            term.Visible = true;
        }

        private void years20_Click(object sender, EventArgs e)
        {
            term.Text = "20 лет";
            term.Visible = true;
        }

        private void years30_Click(object sender, EventArgs e)
        {
            term.Text = "30 лет";
            term.Visible = true;
        }

        private void perc10_Click(object sender, EventArgs e)
        {
            /*firstpay.Text = Convert.ToString(Math.Ceiling(Convert.ToUInt32(Summ_morts.Text) 
             * + (Convert.ToUInt32(Summ_morts.Text) * 0.1)));*/ // добавление 10% процентов к сумме ипотеки
            UInt32 first_payment = Convert.ToUInt32(Math.Ceiling(Convert.ToUInt32(Summ_morts.Text) * 0.1));
            firstpay.Text = Convert.ToString(first_payment);
        }
    }
}
