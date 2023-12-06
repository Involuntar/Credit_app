namespace Bank
{
    partial class Credit
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
            this.label2 = new System.Windows.Forms.Label();
            this.Summ = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Diff = new System.Windows.Forms.RadioButton();
            this.Annuit = new System.Windows.Forms.RadioButton();
            this.term5 = new Bank.RoundButton();
            this.term10 = new Bank.RoundButton();
            this.term15 = new Bank.RoundButton();
            this.term20 = new Bank.RoundButton();
            this.term30 = new Bank.RoundButton();
            this.rate5 = new Bank.RoundButton();
            this.rate8 = new Bank.RoundButton();
            this.rate136 = new Bank.RoundButton();
            this.rate142 = new Bank.RoundButton();
            this.rate155 = new Bank.RoundButton();
            this.Count = new Bank.RoundButton();
            this.Exit = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.term = new System.Windows.Forms.Label();
            this.rate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Goudy Stout", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(28, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Сумма кредита";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Goudy Stout", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(30, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "Срок кредита";
            // 
            // Summ
            // 
            this.Summ.Location = new System.Drawing.Point(36, 59);
            this.Summ.Name = "Summ";
            this.Summ.Size = new System.Drawing.Size(305, 20);
            this.Summ.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Goudy Stout", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(28, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(234, 28);
            this.label3.TabIndex = 6;
            this.label3.Text = "Процентная ставка";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Goudy Stout", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(29, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 28);
            this.label4.TabIndex = 8;
            this.label4.Text = "Тип платежа";
            // 
            // Diff
            // 
            this.Diff.AutoSize = true;
            this.Diff.Font = new System.Drawing.Font("Goudy Stout", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Diff.Location = new System.Drawing.Point(36, 334);
            this.Diff.Name = "Diff";
            this.Diff.Size = new System.Drawing.Size(189, 24);
            this.Diff.TabIndex = 10;
            this.Diff.TabStop = true;
            this.Diff.Text = "Дифференцированный";
            this.Diff.UseVisualStyleBackColor = true;
            // 
            // Annuit
            // 
            this.Annuit.AutoSize = true;
            this.Annuit.Font = new System.Drawing.Font("Goudy Stout", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Annuit.Location = new System.Drawing.Point(36, 311);
            this.Annuit.Name = "Annuit";
            this.Annuit.Size = new System.Drawing.Size(116, 24);
            this.Annuit.TabIndex = 13;
            this.Annuit.TabStop = true;
            this.Annuit.Text = "Аннуитетный";
            this.Annuit.UseVisualStyleBackColor = true;
            this.Annuit.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // term5
            // 
            this.term5.BackColor = System.Drawing.Color.White;
            this.term5.BackColor2 = System.Drawing.Color.Silver;
            this.term5.ButtonBorderColor = System.Drawing.Color.Black;
            this.term5.ButtonHighlightColor = System.Drawing.Color.Orange;
            this.term5.ButtonHighlightColor2 = System.Drawing.Color.OrangeRed;
            this.term5.ButtonHighlightForeColor = System.Drawing.Color.Black;
            this.term5.ButtonPressedColor = System.Drawing.Color.Red;
            this.term5.ButtonPressedColor2 = System.Drawing.Color.Maroon;
            this.term5.ButtonPressedForeColor = System.Drawing.Color.White;
            this.term5.ButtonRoundRadius = 30;
            this.term5.Location = new System.Drawing.Point(32, 152);
            this.term5.Name = "term5";
            this.term5.Size = new System.Drawing.Size(39, 27);
            this.term5.TabIndex = 14;
            this.term5.Text = "5 лет";
            this.term5.Click += new System.EventHandler(this.term5_Click);
            // 
            // term10
            // 
            this.term10.BackColor = System.Drawing.Color.White;
            this.term10.BackColor2 = System.Drawing.Color.Silver;
            this.term10.ButtonBorderColor = System.Drawing.Color.Black;
            this.term10.ButtonHighlightColor = System.Drawing.Color.Orange;
            this.term10.ButtonHighlightColor2 = System.Drawing.Color.OrangeRed;
            this.term10.ButtonHighlightForeColor = System.Drawing.Color.Black;
            this.term10.ButtonPressedColor = System.Drawing.Color.Red;
            this.term10.ButtonPressedColor2 = System.Drawing.Color.Maroon;
            this.term10.ButtonPressedForeColor = System.Drawing.Color.White;
            this.term10.ButtonRoundRadius = 30;
            this.term10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.term10.Location = new System.Drawing.Point(77, 152);
            this.term10.Name = "term10";
            this.term10.Size = new System.Drawing.Size(56, 27);
            this.term10.TabIndex = 15;
            this.term10.Text = "10 лет";
            this.term10.Click += new System.EventHandler(this.term10_Click);
            // 
            // term15
            // 
            this.term15.BackColor = System.Drawing.Color.White;
            this.term15.BackColor2 = System.Drawing.Color.Silver;
            this.term15.ButtonBorderColor = System.Drawing.Color.Black;
            this.term15.ButtonHighlightColor = System.Drawing.Color.Orange;
            this.term15.ButtonHighlightColor2 = System.Drawing.Color.OrangeRed;
            this.term15.ButtonHighlightForeColor = System.Drawing.Color.Black;
            this.term15.ButtonPressedColor = System.Drawing.Color.Red;
            this.term15.ButtonPressedColor2 = System.Drawing.Color.Maroon;
            this.term15.ButtonPressedForeColor = System.Drawing.Color.White;
            this.term15.ButtonRoundRadius = 30;
            this.term15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.term15.Location = new System.Drawing.Point(139, 152);
            this.term15.Name = "term15";
            this.term15.Size = new System.Drawing.Size(56, 27);
            this.term15.TabIndex = 16;
            this.term15.Text = "15 лет";
            this.term15.Click += new System.EventHandler(this.term15_Click);
            // 
            // term20
            // 
            this.term20.BackColor = System.Drawing.Color.White;
            this.term20.BackColor2 = System.Drawing.Color.Silver;
            this.term20.ButtonBorderColor = System.Drawing.Color.Black;
            this.term20.ButtonHighlightColor = System.Drawing.Color.Orange;
            this.term20.ButtonHighlightColor2 = System.Drawing.Color.OrangeRed;
            this.term20.ButtonHighlightForeColor = System.Drawing.Color.Black;
            this.term20.ButtonPressedColor = System.Drawing.Color.Red;
            this.term20.ButtonPressedColor2 = System.Drawing.Color.Maroon;
            this.term20.ButtonPressedForeColor = System.Drawing.Color.White;
            this.term20.ButtonRoundRadius = 30;
            this.term20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.term20.Location = new System.Drawing.Point(201, 152);
            this.term20.Name = "term20";
            this.term20.Size = new System.Drawing.Size(56, 27);
            this.term20.TabIndex = 17;
            this.term20.Text = "20 лет";
            this.term20.Click += new System.EventHandler(this.term20_Click);
            // 
            // term30
            // 
            this.term30.BackColor = System.Drawing.Color.White;
            this.term30.BackColor2 = System.Drawing.Color.Silver;
            this.term30.ButtonBorderColor = System.Drawing.Color.Black;
            this.term30.ButtonHighlightColor = System.Drawing.Color.Orange;
            this.term30.ButtonHighlightColor2 = System.Drawing.Color.OrangeRed;
            this.term30.ButtonHighlightForeColor = System.Drawing.Color.Black;
            this.term30.ButtonPressedColor = System.Drawing.Color.Red;
            this.term30.ButtonPressedColor2 = System.Drawing.Color.Maroon;
            this.term30.ButtonPressedForeColor = System.Drawing.Color.White;
            this.term30.ButtonRoundRadius = 30;
            this.term30.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.term30.Location = new System.Drawing.Point(263, 152);
            this.term30.Name = "term30";
            this.term30.Size = new System.Drawing.Size(56, 27);
            this.term30.TabIndex = 18;
            this.term30.Text = "30 лет";
            this.term30.Click += new System.EventHandler(this.term30_Click);
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
            this.rate5.Location = new System.Drawing.Point(32, 243);
            this.rate5.Name = "rate5";
            this.rate5.Size = new System.Drawing.Size(39, 27);
            this.rate5.TabIndex = 19;
            this.rate5.Text = "5 %";
            this.rate5.Click += new System.EventHandler(this.rate5_Click);
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
            this.rate8.Location = new System.Drawing.Point(77, 243);
            this.rate8.Name = "rate8";
            this.rate8.Size = new System.Drawing.Size(39, 27);
            this.rate8.TabIndex = 20;
            this.rate8.Text = "8 %";
            this.rate8.Click += new System.EventHandler(this.rate8_Click);
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
            this.rate136.Location = new System.Drawing.Point(122, 243);
            this.rate136.Name = "rate136";
            this.rate136.Size = new System.Drawing.Size(56, 27);
            this.rate136.TabIndex = 21;
            this.rate136.Text = "13,6%";
            this.rate136.Click += new System.EventHandler(this.rate136_Click);
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
            this.rate142.Location = new System.Drawing.Point(183, 243);
            this.rate142.Name = "rate142";
            this.rate142.Size = new System.Drawing.Size(56, 27);
            this.rate142.TabIndex = 22;
            this.rate142.Text = "14,2%";
            this.rate142.Click += new System.EventHandler(this.rate142_Click);
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
            this.rate155.Location = new System.Drawing.Point(245, 243);
            this.rate155.Name = "rate155";
            this.rate155.Size = new System.Drawing.Size(56, 27);
            this.rate155.TabIndex = 23;
            this.rate155.Text = "15,5%";
            this.rate155.Click += new System.EventHandler(this.rate155_Click);
            // 
            // Count
            // 
            this.Count.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.Count.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.Count.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Count.ButtonBorderColor = System.Drawing.Color.Black;
            this.Count.ButtonHighlightColor = System.Drawing.Color.Orange;
            this.Count.ButtonHighlightColor2 = System.Drawing.Color.OrangeRed;
            this.Count.ButtonHighlightForeColor = System.Drawing.Color.Black;
            this.Count.ButtonPressedColor = System.Drawing.Color.Red;
            this.Count.ButtonPressedColor2 = System.Drawing.Color.Maroon;
            this.Count.ButtonPressedForeColor = System.Drawing.Color.White;
            this.Count.ButtonRoundRadius = 30;
            this.Count.Font = new System.Drawing.Font("Goudy Stout", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Count.ForeColor = System.Drawing.Color.White;
            this.Count.Location = new System.Drawing.Point(36, 381);
            this.Count.Name = "Count";
            this.Count.Size = new System.Drawing.Size(134, 44);
            this.Count.TabIndex = 24;
            this.Count.Text = "Рассчитать";
            this.Count.Click += new System.EventHandler(this.Count_Click);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.Exit.Font = new System.Drawing.Font("Goudy Stout", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.ForeColor = System.Drawing.Color.White;
            this.Exit.Location = new System.Drawing.Point(470, 9);
            this.Exit.Margin = new System.Windows.Forms.Padding(2);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(69, 25);
            this.Exit.TabIndex = 26;
            this.Exit.Text = "Выход";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.Back.Font = new System.Drawing.Font("Goudy Stout", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.ForeColor = System.Drawing.Color.White;
            this.Back.Location = new System.Drawing.Point(397, 9);
            this.Back.Margin = new System.Windows.Forms.Padding(2);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(69, 25);
            this.Back.TabIndex = 27;
            this.Back.Text = "Назад";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // term
            // 
            this.term.AutoSize = true;
            this.term.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.term.Location = new System.Drawing.Point(39, 133);
            this.term.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.term.Name = "term";
            this.term.Size = new System.Drawing.Size(39, 16);
            this.term.TabIndex = 28;
            this.term.Text = "Срок";
            this.term.Visible = false;
            // 
            // rate
            // 
            this.rate.AutoSize = true;
            this.rate.Location = new System.Drawing.Point(39, 219);
            this.rate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.rate.Name = "rate";
            this.rate.Size = new System.Drawing.Size(43, 13);
            this.rate.TabIndex = 29;
            this.rate.Text = "Ставка";
            this.rate.Visible = false;
            // 
            // Credit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.ClientSize = new System.Drawing.Size(555, 450);
            this.Controls.Add(this.rate);
            this.Controls.Add(this.term);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Count);
            this.Controls.Add(this.rate155);
            this.Controls.Add(this.rate142);
            this.Controls.Add(this.rate136);
            this.Controls.Add(this.rate8);
            this.Controls.Add(this.rate5);
            this.Controls.Add(this.term30);
            this.Controls.Add(this.term20);
            this.Controls.Add(this.term15);
            this.Controls.Add(this.term10);
            this.Controls.Add(this.term5);
            this.Controls.Add(this.Annuit);
            this.Controls.Add(this.Diff);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Summ);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "Credit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Рассчёт кредита";
            this.Load += new System.EventHandler(this.Credit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Summ;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton Diff;
        private System.Windows.Forms.RadioButton Annuit;
        private RoundButton term5;
        private RoundButton term10;
        private RoundButton term15;
        private RoundButton term20;
        private RoundButton term30;
        private RoundButton rate5;
        private RoundButton rate8;
        private RoundButton rate136;
        private RoundButton rate142;
        private RoundButton rate155;
        private RoundButton Count;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Label term;
        private System.Windows.Forms.Label rate;
    }
}