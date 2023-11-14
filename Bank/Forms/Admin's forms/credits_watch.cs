﻿using System;
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
            credits_enter_form = new Credits_enter_form(this);
        }

        public void Display_credit()
        {
            Connection.Display("SELECT * FROM mortgages", dataGridCredit);
        }

        private void dataGridMort_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Credits_watch_Load(object sender, EventArgs e)
        {

        }

        private void Credits_watch_Shown(object sender, EventArgs e)
        {
            Display_credit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            public_class.Search = textBox1.Text;
            Connection.Search("SELECT * FROM credits WHERE summ LIKE @search", dataGridCredit);
        }
    }
}
