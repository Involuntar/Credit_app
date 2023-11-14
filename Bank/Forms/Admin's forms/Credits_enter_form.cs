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

namespace Bank.Forms.Admin_s_forms
{
    public partial class Credits_enter_form : Form
    {
        private readonly Credits_watch _Watch;
        public string id, summ, term_id, rate_id, credit_type_id, users_id, statuses_id;
        
        public Credits_enter_form(Credits_watch Watch)
        {
            InitializeComponent();
            _Watch = Watch;
        }

        private void Credits_enter_form_Load(object sender, EventArgs e)
        {
            
        }

        private void save_cr_Click(object sender, EventArgs e)
        {
            if (summ_txt.Text.Trim().Length < 100000)
            {
                MessageBox.Show("Минимальная сумма кредита 100.000");
                return;
            }
            if (save_cr.Text == "Сохранить")
            {
                Credits credits = new Credits(summ_txt.Text.Trim(), term_id_txt.Text.Trim(),
                rate_id_txt.Text.Trim(), credit_type_id_txt.Text.Trim(), users_id_txt.Text.Trim(),
                statuses_id_txt.Text.Trim());
                Connection.Add_credit(credits);
                Clear();
            }
            if (save_cr.Text == "Обновить")
            {
                Credits credits = new Credits(summ_txt.Text.Trim(), term_id_txt.Text.Trim(),
                rate_id_txt.Text.Trim(), credit_type_id_txt.Text.Trim(), users_id_txt.Text.Trim(),
                statuses_id_txt.Text.Trim());
                Connection.Update_credit(credits, id);
            }
            _Watch.Display_credit();
        }

        public void Clear()
        {
            summ_txt.Text = term_id_txt.Text = rate_id_txt.Text = credit_type_id_txt.Text = users_id_txt.Text =
                statuses_id_txt.Text = string.Empty;
        }
    }
}
