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

    public partial class Check_conn : Form
    {
        Data.Connection con = new Data.Connection();
        public Check_conn()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Data.Connection.dataSource();
                con.connOpen();
                Success.Visible = true;
                Error.Visible = false;
                con.connClose();
            }
            catch (Exception)
            {
                Error.Visible = true;
                Success.Visible = false;
                con.connClose();
            }
            finally
            {
                con.connClose();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
