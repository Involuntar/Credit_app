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
        public string  id, summ, term_id, rate_id, credit_type_id, users_id, statuses_id;

        private void cancel_cr_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public Credits_enter_form(Credits_watch Watch)
        {
            InitializeComponent();
            _Watch = Watch;
        }
        public void UpdateCreditInfo()
        {
            save_cr.Text = "Обновить";
            summ_txt.Text = summ;
            term_id_txt.Text = term_id;
            rate_id_txt.Text = rate_id;
            credit_type_id_txt.Text = credit_type_id;
            users_id_txt.Text = users_id;
            statuses_id_txt.Text = statuses_id;
        }

        private void Credits_enter_form_Load(object sender, EventArgs e)
        {
            
        }

        private void save_cr_Click(object sender, EventArgs e)
        {
            if (save_cr.Text == "Сохранить")
            {
                Credits credits = new Credits(term_id_txt.Text.Trim(), summ_txt.Text.Trim(),
                rate_id_txt.Text.Trim(), credit_type_id_txt.Text.Trim(), statuses_id_txt.Text.Trim(), 
                users_id_txt.Text.Trim());
                Connection.Add_credit(credits);
                Clear();
            }
            if (save_cr.Text == "Обновить")
            {
                Credits credits = new Credits(term_id_txt.Text.Trim(), summ_txt.Text.Trim(),
                rate_id_txt.Text.Trim(), credit_type_id_txt.Text.Trim(), statuses_id_txt.Text.Trim(),
                users_id_txt.Text.Trim());
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
