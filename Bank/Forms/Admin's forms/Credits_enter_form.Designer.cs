namespace Bank.Forms.Admin_s_forms
{
    partial class Credits_enter_form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label9 = new System.Windows.Forms.Label();
            this.cancel_cr = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.summ_txt = new System.Windows.Forms.TextBox();
            this.users_id_txt = new System.Windows.Forms.TextBox();
            this.save_cr = new Bank.RoundButton();
            this.term_combox = new System.Windows.Forms.ComboBox();
            this.rate_combox = new System.Windows.Forms.ComboBox();
            this.type_combox = new System.Windows.Forms.ComboBox();
            this.status_combox = new System.Windows.Forms.ComboBox();
            this.years = new System.Windows.Forms.Label();
            this.percents = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Goudy Stout", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(240, 80);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(270, 47);
            this.label9.TabIndex = 38;
            this.label9.Text = "Ввод кредита";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // cancel_cr
            // 
            this.cancel_cr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.cancel_cr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cancel_cr.ForeColor = System.Drawing.Color.White;
            this.cancel_cr.Location = new System.Drawing.Point(709, 11);
            this.cancel_cr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cancel_cr.Name = "cancel_cr";
            this.cancel_cr.Size = new System.Drawing.Size(101, 28);
            this.cancel_cr.TabIndex = 37;
            this.cancel_cr.Text = "Назад";
            this.cancel_cr.UseVisualStyleBackColor = false;
            this.cancel_cr.Click += new System.EventHandler(this.cancel_cr_Click);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Goudy Stout", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(413, 290);
            this.label8.Margin = new System.Windows.Forms.Padding(10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 27);
            this.label8.TabIndex = 36;
            this.label8.Text = "Статус";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Goudy Stout", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(413, 240);
            this.label7.Margin = new System.Windows.Forms.Padding(10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(210, 27);
            this.label7.TabIndex = 35;
            this.label7.Text = "Логин пользователя";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Goudy Stout", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(413, 190);
            this.label6.Margin = new System.Windows.Forms.Padding(10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 27);
            this.label6.TabIndex = 34;
            this.label6.Text = "Тип кредита";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Goudy Stout", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(40, 290);
            this.label5.Margin = new System.Windows.Forms.Padding(10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 27);
            this.label5.TabIndex = 33;
            this.label5.Text = "Ставка";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Goudy Stout", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(40, 240);
            this.label4.Margin = new System.Windows.Forms.Padding(10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 27);
            this.label4.TabIndex = 32;
            this.label4.Text = "Срок";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Goudy Stout", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 190);
            this.label3.Margin = new System.Windows.Forms.Padding(10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 27);
            this.label3.TabIndex = 31;
            this.label3.Text = "Сумма кредита";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // summ_txt
            // 
            this.summ_txt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.summ_txt.Location = new System.Drawing.Point(240, 190);
            this.summ_txt.Margin = new System.Windows.Forms.Padding(10);
            this.summ_txt.Name = "summ_txt";
            this.summ_txt.Size = new System.Drawing.Size(100, 22);
            this.summ_txt.TabIndex = 22;
            this.summ_txt.TextChanged += new System.EventHandler(this.summ_txt_TextChanged);
            // 
            // users_id_txt
            // 
            this.users_id_txt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.users_id_txt.Location = new System.Drawing.Point(668, 240);
            this.users_id_txt.Margin = new System.Windows.Forms.Padding(10);
            this.users_id_txt.Name = "users_id_txt";
            this.users_id_txt.Size = new System.Drawing.Size(120, 22);
            this.users_id_txt.TabIndex = 42;
            this.users_id_txt.TextChanged += new System.EventHandler(this.users_id_txt_TextChanged);
            // 
            // save_cr
            // 
            this.save_cr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.save_cr.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.save_cr.ButtonBorderColor = System.Drawing.Color.Black;
            this.save_cr.ButtonHighlightColor = System.Drawing.Color.Orange;
            this.save_cr.ButtonHighlightColor2 = System.Drawing.Color.OrangeRed;
            this.save_cr.ButtonHighlightForeColor = System.Drawing.Color.Black;
            this.save_cr.ButtonPressedColor = System.Drawing.Color.Red;
            this.save_cr.ButtonPressedColor2 = System.Drawing.Color.Maroon;
            this.save_cr.ButtonPressedForeColor = System.Drawing.Color.White;
            this.save_cr.ButtonRoundRadius = 30;
            this.save_cr.Font = new System.Drawing.Font("Goudy Stout", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_cr.ForeColor = System.Drawing.Color.White;
            this.save_cr.Location = new System.Drawing.Point(280, 385);
            this.save_cr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.save_cr.Name = "save_cr";
            this.save_cr.Size = new System.Drawing.Size(211, 59);
            this.save_cr.TabIndex = 28;
            this.save_cr.Text = "Сохранить";
            this.save_cr.Click += new System.EventHandler(this.save_cr_Click);
            // 
            // term_combox
            // 
            this.term_combox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.term_combox.FormattingEnabled = true;
            this.term_combox.Location = new System.Drawing.Point(240, 240);
            this.term_combox.Margin = new System.Windows.Forms.Padding(10);
            this.term_combox.Name = "term_combox";
            this.term_combox.Size = new System.Drawing.Size(100, 24);
            this.term_combox.TabIndex = 44;
            // 
            // rate_combox
            // 
            this.rate_combox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rate_combox.FormattingEnabled = true;
            this.rate_combox.Location = new System.Drawing.Point(240, 290);
            this.rate_combox.Margin = new System.Windows.Forms.Padding(10);
            this.rate_combox.Name = "rate_combox";
            this.rate_combox.Size = new System.Drawing.Size(100, 24);
            this.rate_combox.TabIndex = 45;
            this.rate_combox.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // type_combox
            // 
            this.type_combox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.type_combox.FormattingEnabled = true;
            this.type_combox.Location = new System.Drawing.Point(668, 190);
            this.type_combox.Margin = new System.Windows.Forms.Padding(10);
            this.type_combox.Name = "type_combox";
            this.type_combox.Size = new System.Drawing.Size(120, 24);
            this.type_combox.TabIndex = 46;
            // 
            // status_combox
            // 
            this.status_combox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.status_combox.FormattingEnabled = true;
            this.status_combox.Location = new System.Drawing.Point(668, 290);
            this.status_combox.Margin = new System.Windows.Forms.Padding(10);
            this.status_combox.Name = "status_combox";
            this.status_combox.Size = new System.Drawing.Size(120, 24);
            this.status_combox.TabIndex = 47;
            // 
            // years
            // 
            this.years.AutoSize = true;
            this.years.Location = new System.Drawing.Point(353, 247);
            this.years.Name = "years";
            this.years.Size = new System.Drawing.Size(30, 16);
            this.years.TabIndex = 48;
            this.years.Text = "лет";
            // 
            // percents
            // 
            this.percents.AutoSize = true;
            this.percents.Location = new System.Drawing.Point(353, 297);
            this.percents.Name = "percents";
            this.percents.Size = new System.Drawing.Size(19, 16);
            this.percents.TabIndex = 49;
            this.percents.Text = "%";
            // 
            // Credits_enter_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.ClientSize = new System.Drawing.Size(822, 503);
            this.Controls.Add(this.percents);
            this.Controls.Add(this.years);
            this.Controls.Add(this.status_combox);
            this.Controls.Add(this.type_combox);
            this.Controls.Add(this.rate_combox);
            this.Controls.Add(this.term_combox);
            this.Controls.Add(this.users_id_txt);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cancel_cr);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.save_cr);
            this.Controls.Add(this.summ_txt);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Credits_enter_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Credits_enter_form";
            this.Load += new System.EventHandler(this.Credits_enter_form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button cancel_cr;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private RoundButton save_cr;
        private System.Windows.Forms.TextBox summ_txt;
        private System.Windows.Forms.TextBox users_id_txt;
        private System.Windows.Forms.ComboBox term_combox;
        private System.Windows.Forms.ComboBox rate_combox;
        private System.Windows.Forms.ComboBox type_combox;
        private System.Windows.Forms.ComboBox status_combox;
        private System.Windows.Forms.Label years;
        private System.Windows.Forms.Label percents;
    }
}