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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Bank.Forms.Admin_s_forms
{
    public partial class Mortgages_enter_form : Form
    {
        private readonly Mortgages_watch _Watch;
        public string id, cost, init_fee, credit_summ, term_id, rate_id, credit_type_id, users_id, statuses_id;

        private void Mortgages_enter_form_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void UpdateMortInfo()
        {
            Save.Text = "Обновить";
            Cost_txt.Text = cost;
            Init_fee_txt.Text = init_fee;
            Credit_summ_txt.Text = credit_summ;
            Term_id_txt.Text = term_id;
            Rate_id_txt.Text = rate_id;
            Credit_type_id_txt.Text = credit_type_id;
            Users_id_txt.Text = users_id;
            Statuses_id_txt.Text = statuses_id;
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (Save.Text == "Сохранить")
            {
                Mortgages mortgages = new Mortgages(Cost_txt.Text.Trim(), Init_fee_txt.Text.Trim(),
                Credit_summ_txt.Text.Trim(), Term_id_txt.Text.Trim(), Rate_id_txt.Text.Trim(), 
                Credit_type_id_txt.Text.Trim(), Users_id_txt.Text.Trim(), Statuses_id_txt.Text.Trim());
                Connection.Add_mortgages(mortgages);
                Clear();
            }
            if (Save.Text == "Обновить")
            {
                Mortgages mortgages = new Mortgages(Cost_txt.Text.Trim(), Init_fee_txt.Text.Trim(),
                Credit_summ_txt.Text.Trim(), Term_id_txt.Text.Trim(), Rate_id_txt.Text.Trim(),
                Credit_type_id_txt.Text.Trim(), Users_id_txt.Text.Trim(), Statuses_id_txt.Text.Trim());
                Connection.Update_mortgages(mortgages, id);
            }
            _Watch.Display_mort();
        }

        public Mortgages_enter_form(Mortgages_watch Watch)
        {
            InitializeComponent();
            _Watch = Watch;
        }

        public void Clear()
        {
            Cost_txt.Text = Init_fee_txt.Text = Credit_summ_txt.Text = Term_id_txt.Text = Rate_id_txt.Text =
                Credit_type_id_txt.Text = Users_id_txt.Text = Statuses_id_txt.Text = string.Empty;
        }

    }
}
