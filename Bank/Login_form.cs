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
    public partial class Login_form : Form
    {
        Data.Connection con = new Data.Connection();
        public Login_form()
        {
            InitializeComponent();
        }

        private void Login_form_Load(object sender, EventArgs e)
        {

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Log_in_Click(object sender, EventArgs e)
        {
            try
            {
                string login_check = Login.Text;
                string password_check = Password.Text;
                Data.Connection.dataSource();
                con.connOpen();

            }
            catch
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Check_conn check = new Check_conn();
            check.Show();
        }
    }
}
