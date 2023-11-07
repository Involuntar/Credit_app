using Bank.Data;
using Bank.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
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
                public_class.init_fee = firstpay.Text;
                if (Annuit.Checked == true)
                {
                    public_class.credit_type_id = "3";
                    double credit_summ = public_class.Start_Summ - first_payment;
                    double abs_rate = Math.Pow(1 + Convert.ToDouble(public_class.Rate) * 0.01 / 12, Convert.ToUInt16(public_class.Term) * 12);
                    public_class.monthly_pay = 
                        Convert.ToString(Math.Round(credit_summ * Convert.ToDouble(public_class.Rate) * 0.01 / 12 * abs_rate / (abs_rate - 1), 2));
                    public_class.End_Summ = 
                        Convert.ToString(Convert.ToDouble(public_class.monthly_pay) * 12 * Convert.ToUInt16(public_class.Term));

                    this.Hide();
                    mortgage_counted counted = new mortgage_counted();
                    counted.Show();
                }
                else if (Diff.Checked == true)
                {
                    public_class.End_Summ = Convert.ToString(Math.Ceiling(public_class.Start_Summ * (Double.Parse(public_class.Rate) - 1)) - Convert.ToDouble(first_payment));
                    public_class.credit_type_id = "5";
                    this.Hide();
                    mortgage_counted counted = new mortgage_counted();
                    counted.Show();
                }
                else
                {
                    MessageBox.Show("Выберите тип платежа", "Рекомендация", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Введите целое число", "Неверная сумма", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (System.ArgumentOutOfRangeException)
            {
                MessageBox.Show("Выберите ставку и срок", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        private void perc15_Click(object sender, EventArgs e)
        {
            UInt32 first_payment = Convert.ToUInt32(Math.Ceiling(Convert.ToUInt32(Summ_morts.Text) * 0.15));
            firstpay.Text = Convert.ToString(first_payment);
        }

        private void perc20_Click(object sender, EventArgs e)
        {
            UInt32 first_payment = Convert.ToUInt32(Math.Ceiling(Convert.ToUInt32(Summ_morts.Text) * 0.2));
            firstpay.Text = Convert.ToString(first_payment);
        }

        private void perc25_Click(object sender, EventArgs e)
        {
            UInt32 first_payment = Convert.ToUInt32(Math.Ceiling(Convert.ToUInt32(Summ_morts.Text) * 0.25));
            firstpay.Text = Convert.ToString(first_payment);
        }

        private void perc30_Click(object sender, EventArgs e)
        {
            UInt32 first_payment = Convert.ToUInt32(Math.Ceiling(Convert.ToUInt32(Summ_morts.Text) * 0.3));
            firstpay.Text = Convert.ToString(first_payment);
        }
    }
}
