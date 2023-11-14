using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bank.Data;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace Bank.Forms.Admin_s_forms
{
    public partial class Credits_watch : Form
    {
        Credits_enter_form credits_enter_form;
        public Credits_watch()
        {
            InitializeComponent();
            credits_enter_form = new Credits_enter_form(this);/**/

        }

        private void dataGridMort_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Credits_watch_Load(object sender, EventArgs e)
        {

        }
    }
}
