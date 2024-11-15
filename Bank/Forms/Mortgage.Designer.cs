﻿namespace Bank
{
    partial class Mortgage
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
            this.label1 = new System.Windows.Forms.Label();
            this.Summ_morts = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.firstpay = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Back = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.term = new System.Windows.Forms.Label();
            this.rate = new System.Windows.Forms.Label();
            this.perc30 = new Bank.RoundButton();
            this.perc25 = new Bank.RoundButton();
            this.perc20 = new Bank.RoundButton();
            this.perc15 = new Bank.RoundButton();
            this.perc10 = new Bank.RoundButton();
            this.rate155 = new Bank.RoundButton();
            this.rate142 = new Bank.RoundButton();
            this.rate136 = new Bank.RoundButton();
            this.rate8 = new Bank.RoundButton();
            this.rate5 = new Bank.RoundButton();
            this.years30 = new Bank.RoundButton();
            this.years20 = new Bank.RoundButton();
            this.years15 = new Bank.RoundButton();
            this.years10 = new Bank.RoundButton();
            this.years5 = new Bank.RoundButton();
            this.Annuit = new System.Windows.Forms.RadioButton();
            this.Diff = new System.Windows.Forms.RadioButton();
            this.Mortgage_count = new Bank.RoundButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Goudy Stout", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(30, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(414, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "Стоимость недвижимости";
            // 
            // Summ_morts
            // 
            this.Summ_morts.Location = new System.Drawing.Point(40, 65);
            this.Summ_morts.Margin = new System.Windows.Forms.Padding(4);
            this.Summ_morts.MaxLength = 20;
            this.Summ_morts.Name = "Summ_morts";
            this.Summ_morts.Size = new System.Drawing.Size(405, 22);
            this.Summ_morts.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Goudy Stout", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(30, 95);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(365, 37);
            this.label2.TabIndex = 6;
            this.label2.Text = "Первоначальный взнос";
            // 
            // firstpay
            // 
            this.firstpay.Location = new System.Drawing.Point(40, 145);
            this.firstpay.Margin = new System.Windows.Forms.Padding(4);
            this.firstpay.MaxLength = 20;
            this.firstpay.Name = "firstpay";
            this.firstpay.Size = new System.Drawing.Size(405, 22);
            this.firstpay.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Goudy Stout", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(30, 215);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(221, 37);
            this.label3.TabIndex = 8;
            this.label3.Text = "Срок кредита";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Goudy Stout", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(30, 325);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(301, 37);
            this.label4.TabIndex = 10;
            this.label4.Text = "Процентная ставка";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Goudy Stout", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(30, 435);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(209, 37);
            this.label5.TabIndex = 30;
            this.label5.Text = "Тип платежа";
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.Back.Font = new System.Drawing.Font("Goudy Stout", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.ForeColor = System.Drawing.Color.White;
            this.Back.Location = new System.Drawing.Point(538, 11);
            this.Back.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(92, 31);
            this.Back.TabIndex = 35;
            this.Back.Text = "Назад";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.Exit.Font = new System.Drawing.Font("Goudy Stout", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.ForeColor = System.Drawing.Color.White;
            this.Exit.Location = new System.Drawing.Point(637, 11);
            this.Exit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(92, 31);
            this.Exit.TabIndex = 36;
            this.Exit.Text = "Выход";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // term
            // 
            this.term.AutoSize = true;
            this.term.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.term.Location = new System.Drawing.Point(45, 260);
            this.term.Name = "term";
            this.term.Size = new System.Drawing.Size(43, 20);
            this.term.TabIndex = 37;
            this.term.Text = "term";
            this.term.Visible = false;
            // 
            // rate
            // 
            this.rate.AutoSize = true;
            this.rate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rate.Location = new System.Drawing.Point(45, 370);
            this.rate.Name = "rate";
            this.rate.Size = new System.Drawing.Size(38, 20);
            this.rate.TabIndex = 38;
            this.rate.Text = "rate";
            this.rate.Visible = false;
            // 
            // perc30
            // 
            this.perc30.BackColor = System.Drawing.Color.White;
            this.perc30.BackColor2 = System.Drawing.Color.Silver;
            this.perc30.ButtonBorderColor = System.Drawing.Color.Black;
            this.perc30.ButtonHighlightColor = System.Drawing.Color.Orange;
            this.perc30.ButtonHighlightColor2 = System.Drawing.Color.OrangeRed;
            this.perc30.ButtonHighlightForeColor = System.Drawing.Color.Black;
            this.perc30.ButtonPressedColor = System.Drawing.Color.Red;
            this.perc30.ButtonPressedColor2 = System.Drawing.Color.Maroon;
            this.perc30.ButtonPressedForeColor = System.Drawing.Color.White;
            this.perc30.ButtonRoundRadius = 30;
            this.perc30.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.perc30.Location = new System.Drawing.Point(329, 175);
            this.perc30.Margin = new System.Windows.Forms.Padding(4);
            this.perc30.Name = "perc30";
            this.perc30.Size = new System.Drawing.Size(65, 36);
            this.perc30.TabIndex = 29;
            this.perc30.Text = "30%";
            this.perc30.Click += new System.EventHandler(this.perc30_Click);
            // 
            // perc25
            // 
            this.perc25.BackColor = System.Drawing.Color.White;
            this.perc25.BackColor2 = System.Drawing.Color.Silver;
            this.perc25.ButtonBorderColor = System.Drawing.Color.Black;
            this.perc25.ButtonHighlightColor = System.Drawing.Color.Orange;
            this.perc25.ButtonHighlightColor2 = System.Drawing.Color.OrangeRed;
            this.perc25.ButtonHighlightForeColor = System.Drawing.Color.Black;
            this.perc25.ButtonPressedColor = System.Drawing.Color.Red;
            this.perc25.ButtonPressedColor2 = System.Drawing.Color.Maroon;
            this.perc25.ButtonPressedForeColor = System.Drawing.Color.White;
            this.perc25.ButtonRoundRadius = 30;
            this.perc25.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.perc25.Location = new System.Drawing.Point(256, 175);
            this.perc25.Margin = new System.Windows.Forms.Padding(4);
            this.perc25.Name = "perc25";
            this.perc25.Size = new System.Drawing.Size(65, 36);
            this.perc25.TabIndex = 28;
            this.perc25.Text = "25%";
            this.perc25.Click += new System.EventHandler(this.perc25_Click);
            // 
            // perc20
            // 
            this.perc20.BackColor = System.Drawing.Color.White;
            this.perc20.BackColor2 = System.Drawing.Color.Silver;
            this.perc20.ButtonBorderColor = System.Drawing.Color.Black;
            this.perc20.ButtonHighlightColor = System.Drawing.Color.Orange;
            this.perc20.ButtonHighlightColor2 = System.Drawing.Color.OrangeRed;
            this.perc20.ButtonHighlightForeColor = System.Drawing.Color.Black;
            this.perc20.ButtonPressedColor = System.Drawing.Color.Red;
            this.perc20.ButtonPressedColor2 = System.Drawing.Color.Maroon;
            this.perc20.ButtonPressedForeColor = System.Drawing.Color.White;
            this.perc20.ButtonRoundRadius = 30;
            this.perc20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.perc20.Location = new System.Drawing.Point(183, 175);
            this.perc20.Margin = new System.Windows.Forms.Padding(4);
            this.perc20.Name = "perc20";
            this.perc20.Size = new System.Drawing.Size(65, 36);
            this.perc20.TabIndex = 27;
            this.perc20.Text = "20%";
            this.perc20.Click += new System.EventHandler(this.perc20_Click);
            // 
            // perc15
            // 
            this.perc15.BackColor = System.Drawing.Color.White;
            this.perc15.BackColor2 = System.Drawing.Color.Silver;
            this.perc15.ButtonBorderColor = System.Drawing.Color.Black;
            this.perc15.ButtonHighlightColor = System.Drawing.Color.Orange;
            this.perc15.ButtonHighlightColor2 = System.Drawing.Color.OrangeRed;
            this.perc15.ButtonHighlightForeColor = System.Drawing.Color.Black;
            this.perc15.ButtonPressedColor = System.Drawing.Color.Red;
            this.perc15.ButtonPressedColor2 = System.Drawing.Color.Maroon;
            this.perc15.ButtonPressedForeColor = System.Drawing.Color.White;
            this.perc15.ButtonRoundRadius = 30;
            this.perc15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.perc15.Location = new System.Drawing.Point(110, 175);
            this.perc15.Margin = new System.Windows.Forms.Padding(4);
            this.perc15.Name = "perc15";
            this.perc15.Size = new System.Drawing.Size(65, 36);
            this.perc15.TabIndex = 26;
            this.perc15.Text = "15%";
            this.perc15.Click += new System.EventHandler(this.perc15_Click);
            // 
            // perc10
            // 
            this.perc10.BackColor = System.Drawing.Color.White;
            this.perc10.BackColor2 = System.Drawing.Color.Silver;
            this.perc10.ButtonBorderColor = System.Drawing.Color.Black;
            this.perc10.ButtonHighlightColor = System.Drawing.Color.Orange;
            this.perc10.ButtonHighlightColor2 = System.Drawing.Color.OrangeRed;
            this.perc10.ButtonHighlightForeColor = System.Drawing.Color.Black;
            this.perc10.ButtonPressedColor = System.Drawing.Color.Red;
            this.perc10.ButtonPressedColor2 = System.Drawing.Color.Maroon;
            this.perc10.ButtonPressedForeColor = System.Drawing.Color.White;
            this.perc10.ButtonRoundRadius = 30;
            this.perc10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.perc10.Location = new System.Drawing.Point(37, 175);
            this.perc10.Margin = new System.Windows.Forms.Padding(4);
            this.perc10.Name = "perc10";
            this.perc10.Size = new System.Drawing.Size(65, 36);
            this.perc10.TabIndex = 25;
            this.perc10.Text = "10%";
            this.perc10.Click += new System.EventHandler(this.perc10_Click);
            // 
            // rate155
            // 
            this.rate155.BackColor = System.Drawing.Color.White;
            this.rate155.BackColor2 = System.Drawing.Color.Silver;
            this.rate155.ButtonBorderColor = System.Drawing.Color.Black;
            this.rate155.ButtonHighlightColor = System.Drawing.Color.Orange;
            this.rate155.ButtonHighlightColor2 = System.Drawing.Color.OrangeRed;
            this.rate155.ButtonHighlightForeColor = System.Drawing.Color.Black;
            this.rate155.ButtonPressedColor = System.Drawing.Color.Red;
            this.rate155.ButtonPressedColor2 = System.Drawing.Color.Maroon;
            this.rate155.ButtonPressedForeColor = System.Drawing.Color.White;
            this.rate155.ButtonRoundRadius = 30;
            this.rate155.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rate155.Location = new System.Drawing.Point(322, 394);
            this.rate155.Margin = new System.Windows.Forms.Padding(4);
            this.rate155.Name = "rate155";
            this.rate155.Size = new System.Drawing.Size(75, 33);
            this.rate155.TabIndex = 24;
            this.rate155.Text = "15,5%";
            this.rate155.Click += new System.EventHandler(this.rate155_Click);
            // 
            // rate142
            // 
            this.rate142.BackColor = System.Drawing.Color.White;
            this.rate142.BackColor2 = System.Drawing.Color.Silver;
            this.rate142.ButtonBorderColor = System.Drawing.Color.Black;
            this.rate142.ButtonHighlightColor = System.Drawing.Color.Orange;
            this.rate142.ButtonHighlightColor2 = System.Drawing.Color.OrangeRed;
            this.rate142.ButtonHighlightForeColor = System.Drawing.Color.Black;
            this.rate142.ButtonPressedColor = System.Drawing.Color.Red;
            this.rate142.ButtonPressedColor2 = System.Drawing.Color.Maroon;
            this.rate142.ButtonPressedForeColor = System.Drawing.Color.White;
            this.rate142.ButtonRoundRadius = 30;
            this.rate142.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rate142.Location = new System.Drawing.Point(240, 394);
            this.rate142.Margin = new System.Windows.Forms.Padding(4);
            this.rate142.Name = "rate142";
            this.rate142.Size = new System.Drawing.Size(75, 33);
            this.rate142.TabIndex = 23;
            this.rate142.Text = "14,2%";
            this.rate142.Click += new System.EventHandler(this.rate142_Click);
            // 
            // rate136
            // 
            this.rate136.BackColor = System.Drawing.Color.White;
            this.rate136.BackColor2 = System.Drawing.Color.Silver;
            this.rate136.ButtonBorderColor = System.Drawing.Color.Black;
            this.rate136.ButtonHighlightColor = System.Drawing.Color.Orange;
            this.rate136.ButtonHighlightColor2 = System.Drawing.Color.OrangeRed;
            this.rate136.ButtonHighlightForeColor = System.Drawing.Color.Black;
            this.rate136.ButtonPressedColor = System.Drawing.Color.Red;
            this.rate136.ButtonPressedColor2 = System.Drawing.Color.Maroon;
            this.rate136.ButtonPressedForeColor = System.Drawing.Color.White;
            this.rate136.ButtonRoundRadius = 30;
            this.rate136.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rate136.Location = new System.Drawing.Point(157, 394);
            this.rate136.Margin = new System.Windows.Forms.Padding(4);
            this.rate136.Name = "rate136";
            this.rate136.Size = new System.Drawing.Size(75, 33);
            this.rate136.TabIndex = 22;
            this.rate136.Text = "13,6%";
            this.rate136.Click += new System.EventHandler(this.rate136_Click);
            // 
            // rate8
            // 
            this.rate8.BackColor = System.Drawing.Color.White;
            this.rate8.BackColor2 = System.Drawing.Color.Silver;
            this.rate8.ButtonBorderColor = System.Drawing.Color.Black;
            this.rate8.ButtonHighlightColor = System.Drawing.Color.Orange;
            this.rate8.ButtonHighlightColor2 = System.Drawing.Color.OrangeRed;
            this.rate8.ButtonHighlightForeColor = System.Drawing.Color.Black;
            this.rate8.ButtonPressedColor = System.Drawing.Color.Red;
            this.rate8.ButtonPressedColor2 = System.Drawing.Color.Maroon;
            this.rate8.ButtonPressedForeColor = System.Drawing.Color.White;
            this.rate8.ButtonRoundRadius = 30;
            this.rate8.Location = new System.Drawing.Point(97, 394);
            this.rate8.Margin = new System.Windows.Forms.Padding(4);
            this.rate8.Name = "rate8";
            this.rate8.Size = new System.Drawing.Size(52, 33);
            this.rate8.TabIndex = 21;
            this.rate8.Text = "8 %";
            this.rate8.Click += new System.EventHandler(this.rate8_Click);
            // 
            // rate5
            // 
            this.rate5.BackColor = System.Drawing.Color.White;
            this.rate5.BackColor2 = System.Drawing.Color.Silver;
            this.rate5.ButtonBorderColor = System.Drawing.Color.Black;
            this.rate5.ButtonHighlightColor = System.Drawing.Color.Orange;
            this.rate5.ButtonHighlightColor2 = System.Drawing.Color.OrangeRed;
            this.rate5.ButtonHighlightForeColor = System.Drawing.Color.Black;
            this.rate5.ButtonPressedColor = System.Drawing.Color.Red;
            this.rate5.ButtonPressedColor2 = System.Drawing.Color.Maroon;
            this.rate5.ButtonPressedForeColor = System.Drawing.Color.White;
            this.rate5.ButtonRoundRadius = 30;
            this.rate5.Location = new System.Drawing.Point(37, 394);
            this.rate5.Margin = new System.Windows.Forms.Padding(4);
            this.rate5.Name = "rate5";
            this.rate5.Size = new System.Drawing.Size(52, 33);
            this.rate5.TabIndex = 20;
            this.rate5.Text = "5 %";
            this.rate5.Click += new System.EventHandler(this.rate5_Click);
            // 
            // years30
            // 
            this.years30.BackColor = System.Drawing.Color.White;
            this.years30.BackColor2 = System.Drawing.Color.Silver;
            this.years30.ButtonBorderColor = System.Drawing.Color.Black;
            this.years30.ButtonHighlightColor = System.Drawing.Color.Orange;
            this.years30.ButtonHighlightColor2 = System.Drawing.Color.OrangeRed;
            this.years30.ButtonHighlightForeColor = System.Drawing.Color.Black;
            this.years30.ButtonPressedColor = System.Drawing.Color.Red;
            this.years30.ButtonPressedColor2 = System.Drawing.Color.Maroon;
            this.years30.ButtonPressedForeColor = System.Drawing.Color.White;
            this.years30.ButtonRoundRadius = 30;
            this.years30.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.years30.Location = new System.Drawing.Point(345, 284);
            this.years30.Margin = new System.Windows.Forms.Padding(4);
            this.years30.Name = "years30";
            this.years30.Size = new System.Drawing.Size(75, 33);
            this.years30.TabIndex = 19;
            this.years30.Text = "30 лет";
            this.years30.Click += new System.EventHandler(this.years30_Click);
            // 
            // years20
            // 
            this.years20.BackColor = System.Drawing.Color.White;
            this.years20.BackColor2 = System.Drawing.Color.Silver;
            this.years20.ButtonBorderColor = System.Drawing.Color.Black;
            this.years20.ButtonHighlightColor = System.Drawing.Color.Orange;
            this.years20.ButtonHighlightColor2 = System.Drawing.Color.OrangeRed;
            this.years20.ButtonHighlightForeColor = System.Drawing.Color.Black;
            this.years20.ButtonPressedColor = System.Drawing.Color.Red;
            this.years20.ButtonPressedColor2 = System.Drawing.Color.Maroon;
            this.years20.ButtonPressedForeColor = System.Drawing.Color.White;
            this.years20.ButtonRoundRadius = 30;
            this.years20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.years20.Location = new System.Drawing.Point(263, 284);
            this.years20.Margin = new System.Windows.Forms.Padding(4);
            this.years20.Name = "years20";
            this.years20.Size = new System.Drawing.Size(75, 33);
            this.years20.TabIndex = 18;
            this.years20.Text = "20 лет";
            this.years20.Click += new System.EventHandler(this.years20_Click);
            // 
            // years15
            // 
            this.years15.BackColor = System.Drawing.Color.White;
            this.years15.BackColor2 = System.Drawing.Color.Silver;
            this.years15.ButtonBorderColor = System.Drawing.Color.Black;
            this.years15.ButtonHighlightColor = System.Drawing.Color.Orange;
            this.years15.ButtonHighlightColor2 = System.Drawing.Color.OrangeRed;
            this.years15.ButtonHighlightForeColor = System.Drawing.Color.Black;
            this.years15.ButtonPressedColor = System.Drawing.Color.Red;
            this.years15.ButtonPressedColor2 = System.Drawing.Color.Maroon;
            this.years15.ButtonPressedForeColor = System.Drawing.Color.White;
            this.years15.ButtonRoundRadius = 30;
            this.years15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.years15.Location = new System.Drawing.Point(180, 284);
            this.years15.Margin = new System.Windows.Forms.Padding(4);
            this.years15.Name = "years15";
            this.years15.Size = new System.Drawing.Size(75, 33);
            this.years15.TabIndex = 17;
            this.years15.Text = "15 лет";
            this.years15.Click += new System.EventHandler(this.years15_Click);
            // 
            // years10
            // 
            this.years10.BackColor = System.Drawing.Color.White;
            this.years10.BackColor2 = System.Drawing.Color.Silver;
            this.years10.ButtonBorderColor = System.Drawing.Color.Black;
            this.years10.ButtonHighlightColor = System.Drawing.Color.Orange;
            this.years10.ButtonHighlightColor2 = System.Drawing.Color.OrangeRed;
            this.years10.ButtonHighlightForeColor = System.Drawing.Color.Black;
            this.years10.ButtonPressedColor = System.Drawing.Color.Red;
            this.years10.ButtonPressedColor2 = System.Drawing.Color.Maroon;
            this.years10.ButtonPressedForeColor = System.Drawing.Color.White;
            this.years10.ButtonRoundRadius = 30;
            this.years10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.years10.Location = new System.Drawing.Point(97, 284);
            this.years10.Margin = new System.Windows.Forms.Padding(4);
            this.years10.Name = "years10";
            this.years10.Size = new System.Drawing.Size(75, 33);
            this.years10.TabIndex = 16;
            this.years10.Text = "10 лет";
            this.years10.Click += new System.EventHandler(this.years10_Click);
            // 
            // years5
            // 
            this.years5.BackColor = System.Drawing.Color.White;
            this.years5.BackColor2 = System.Drawing.Color.Silver;
            this.years5.ButtonBorderColor = System.Drawing.Color.Black;
            this.years5.ButtonHighlightColor = System.Drawing.Color.Orange;
            this.years5.ButtonHighlightColor2 = System.Drawing.Color.OrangeRed;
            this.years5.ButtonHighlightForeColor = System.Drawing.Color.Black;
            this.years5.ButtonPressedColor = System.Drawing.Color.Red;
            this.years5.ButtonPressedColor2 = System.Drawing.Color.Maroon;
            this.years5.ButtonPressedForeColor = System.Drawing.Color.White;
            this.years5.ButtonRoundRadius = 30;
            this.years5.Location = new System.Drawing.Point(37, 284);
            this.years5.Margin = new System.Windows.Forms.Padding(4);
            this.years5.Name = "years5";
            this.years5.Size = new System.Drawing.Size(52, 33);
            this.years5.TabIndex = 15;
            this.years5.Text = "5 лет";
            this.years5.Click += new System.EventHandler(this.years5_Click);
            // 
            // Annuit
            // 
            this.Annuit.AutoSize = true;
            this.Annuit.Font = new System.Drawing.Font("Goudy Stout", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Annuit.Location = new System.Drawing.Point(45, 475);
            this.Annuit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Annuit.Name = "Annuit";
            this.Annuit.Size = new System.Drawing.Size(152, 27);
            this.Annuit.TabIndex = 39;
            this.Annuit.TabStop = true;
            this.Annuit.Text = "Аннуитетный";
            this.Annuit.UseVisualStyleBackColor = true;
            // 
            // Diff
            // 
            this.Diff.AutoSize = true;
            this.Diff.Font = new System.Drawing.Font("Goudy Stout", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Diff.Location = new System.Drawing.Point(45, 505);
            this.Diff.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Diff.Name = "Diff";
            this.Diff.Size = new System.Drawing.Size(239, 27);
            this.Diff.TabIndex = 40;
            this.Diff.TabStop = true;
            this.Diff.Text = "Дифференцированный";
            this.Diff.UseVisualStyleBackColor = true;
            // 
            // Mortgage_count
            // 
            this.Mortgage_count.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.Mortgage_count.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.Mortgage_count.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Mortgage_count.ButtonBorderColor = System.Drawing.Color.Black;
            this.Mortgage_count.ButtonHighlightColor = System.Drawing.Color.Orange;
            this.Mortgage_count.ButtonHighlightColor2 = System.Drawing.Color.OrangeRed;
            this.Mortgage_count.ButtonHighlightForeColor = System.Drawing.Color.Black;
            this.Mortgage_count.ButtonPressedColor = System.Drawing.Color.Red;
            this.Mortgage_count.ButtonPressedColor2 = System.Drawing.Color.Maroon;
            this.Mortgage_count.ButtonPressedForeColor = System.Drawing.Color.White;
            this.Mortgage_count.ButtonRoundRadius = 30;
            this.Mortgage_count.Font = new System.Drawing.Font("Goudy Stout", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mortgage_count.ForeColor = System.Drawing.Color.White;
            this.Mortgage_count.Location = new System.Drawing.Point(50, 570);
            this.Mortgage_count.Margin = new System.Windows.Forms.Padding(4);
            this.Mortgage_count.Name = "Mortgage_count";
            this.Mortgage_count.Size = new System.Drawing.Size(179, 54);
            this.Mortgage_count.TabIndex = 33;
            this.Mortgage_count.Text = "Рассчитать";
            this.Mortgage_count.Click += new System.EventHandler(this.Mortgage_count_Click);
            // 
            // Mortgage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.ClientSize = new System.Drawing.Size(740, 663);
            this.Controls.Add(this.Diff);
            this.Controls.Add(this.Annuit);
            this.Controls.Add(this.rate);
            this.Controls.Add(this.term);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Mortgage_count);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.perc30);
            this.Controls.Add(this.perc25);
            this.Controls.Add(this.perc20);
            this.Controls.Add(this.perc15);
            this.Controls.Add(this.perc10);
            this.Controls.Add(this.rate155);
            this.Controls.Add(this.rate142);
            this.Controls.Add(this.rate136);
            this.Controls.Add(this.rate8);
            this.Controls.Add(this.rate5);
            this.Controls.Add(this.years30);
            this.Controls.Add(this.years20);
            this.Controls.Add(this.years15);
            this.Controls.Add(this.years10);
            this.Controls.Add(this.years5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.firstpay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Summ_morts);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Mortgage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Рассчёт ипотеки";
            this.Load += new System.EventHandler(this.Mortgage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Summ_morts;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox firstpay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private RoundButton years5;
        private RoundButton years10;
        private RoundButton years15;
        private RoundButton years20;
        private RoundButton years30;
        private RoundButton rate5;
        private RoundButton rate8;
        private RoundButton rate136;
        private RoundButton rate142;
        private RoundButton rate155;
        private RoundButton perc10;
        private RoundButton perc15;
        private RoundButton perc20;
        private RoundButton perc25;
        private RoundButton perc30;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Label term;
        private System.Windows.Forms.Label rate;
        private System.Windows.Forms.RadioButton Annuit;
        private System.Windows.Forms.RadioButton Diff;
        private RoundButton Mortgage_count;
    }
}