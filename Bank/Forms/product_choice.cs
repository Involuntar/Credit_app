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
    public partial class Product_choice : Form
    {
        public Product_choice()
        {
            InitializeComponent();
        }

        private void credit_Click(object sender, EventArgs e)
        {
            Credit crdt = new Credit();
            this.Hide();
            crdt.Show();
        }

        private void mortgages_Click(object sender, EventArgs e)
        {
            Mortgage mrtg = new Mortgage();
            this.Hide();
            mrtg.Show();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Product_head_Click(object sender, EventArgs e)
        {

        }

        private void Product_choice_Load(object sender, EventArgs e)
        {

        }
    }
}
