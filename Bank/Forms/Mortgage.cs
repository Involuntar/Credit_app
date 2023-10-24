using Bank.Data;
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
            public_class.Start_Summ = Convert.ToUInt32(Summ_morts.Text);
            public_class.Rate = (rate.Text).Substring(0, 0);

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
            rate.Text = "13.6%";
            rate.Visible = true;
        }

        private void rate142_Click(object sender, EventArgs e)
        {
            rate.Text = "14.2%";
            rate.Visible = true;
        }

        private void rate155_Click(object sender, EventArgs e)
        {
            rate.Text = "15.5%";
            rate.Visible = true;
        }
    }
}
