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

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void users_id_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void credit_type_id_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void rate_id_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void term_id_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void statuses_id_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void summ_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

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
            //term_id_txt.Text = term_id;
            //rate_id_txt.Text = rate_id;
            //credit_type_id_txt.Text = credit_type_id;
            users_id_txt.Text = users_id;
            //statuses_id_txt.Text = statuses_id;
        }

        private void Credits_enter_form_Load(object sender, EventArgs e)
        {
            Connection.SelectInComboBox("SELECT * FROM terms", term_combox, "len", "id");
            Connection.SelectInComboBox("SELECT * FROM rates", rate_combox, "coefficient", "id");
            Connection.SelectInComboBox("SELECT * FROM statuses", status_combox, "name", "id");
            Connection.SelectInComboBox("SELECT * FROM credits_types", type_combox, "name", "id");
        }

        private void save_cr_Click(object sender, EventArgs e)
        {
            if (save_cr.Text == "Сохранить")
            {
                Credits credits = new Credits(term_combox.SelectedValue.ToString(), summ_txt.Text.Trim(),
                rate_combox.SelectedValue.ToString(), type_combox.SelectedValue.ToString(), status_combox.SelectedValue.ToString(), 
                users_id_txt.Text.Trim());
                Connection.Add_credit(credits);
                Clear();
            }
            if (save_cr.Text == "Обновить")
            {
                Credits credits = new Credits(term_combox.SelectedValue.ToString(), summ_txt.Text.Trim(),
                rate_combox.SelectedValue.ToString(), type_combox.SelectedValue.ToString(), status_combox.SelectedValue.ToString(),
                users_id_txt.Text.Trim());
                Connection.Update_credit(credits, id);
            }
            _Watch.Display_credit();
        }

        public void Clear()
        {
            summ_txt.Text = users_id_txt.Text = string.Empty;
        }
    }
}
