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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.roundButton1 = new Bank.RoundButton();
            this.roundButton2 = new Bank.RoundButton();
            this.roundButton3 = new Bank.RoundButton();
            this.roundButton4 = new Bank.RoundButton();
            this.roundButton5 = new Bank.RoundButton();
            this.roundButton6 = new Bank.RoundButton();
            this.roundButton7 = new Bank.RoundButton();
            this.roundButton8 = new Bank.RoundButton();
            this.roundButton9 = new Bank.RoundButton();
            this.roundButton10 = new Bank.RoundButton();
            this.roundButton11 = new Bank.RoundButton();
            this.Exit = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Goudy Stout", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(33, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Сумма кредита";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Goudy Stout", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(33, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Срок кредита";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(37, 48);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(305, 20);
            this.textBox1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Goudy Stout", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(35, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(250, 32);
            this.label3.TabIndex = 6;
            this.label3.Text = "Процентная ставка";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Goudy Stout", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(34, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 32);
            this.label4.TabIndex = 8;
            this.label4.Text = "Тип платежа";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Goudy Stout", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(38, 319);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(189, 24);
            this.radioButton2.TabIndex = 10;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Дифференцированный";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Goudy Stout", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(38, 296);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(116, 24);
            this.radioButton1.TabIndex = 13;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Аннуитетный";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // roundButton1
            // 
            this.roundButton1.BackColor = System.Drawing.Color.Gainsboro;
            this.roundButton1.BackColor2 = System.Drawing.Color.Silver;
            this.roundButton1.ButtonBorderColor = System.Drawing.Color.Black;
            this.roundButton1.ButtonHighlightColor = System.Drawing.Color.Orange;
            this.roundButton1.ButtonHighlightColor2 = System.Drawing.Color.OrangeRed;
            this.roundButton1.ButtonHighlightForeColor = System.Drawing.Color.Black;
            this.roundButton1.ButtonPressedColor = System.Drawing.Color.Red;
            this.roundButton1.ButtonPressedColor2 = System.Drawing.Color.Maroon;
            this.roundButton1.ButtonPressedForeColor = System.Drawing.Color.White;
            this.roundButton1.ButtonRoundRadius = 30;
            this.roundButton1.Location = new System.Drawing.Point(37, 128);
            this.roundButton1.Name = "roundButton1";
            this.roundButton1.Size = new System.Drawing.Size(39, 27);
            this.roundButton1.TabIndex = 14;
            this.roundButton1.Text = "5 лет";
            this.roundButton1.Click += new System.EventHandler(this.roundButton1_Click);
            // 
            // roundButton2
            // 
            this.roundButton2.BackColor = System.Drawing.Color.Gainsboro;
            this.roundButton2.BackColor2 = System.Drawing.Color.Silver;
            this.roundButton2.ButtonBorderColor = System.Drawing.Color.Black;
            this.roundButton2.ButtonHighlightColor = System.Drawing.Color.Orange;
            this.roundButton2.ButtonHighlightColor2 = System.Drawing.Color.OrangeRed;
            this.roundButton2.ButtonHighlightForeColor = System.Drawing.Color.Black;
            this.roundButton2.ButtonPressedColor = System.Drawing.Color.Red;
            this.roundButton2.ButtonPressedColor2 = System.Drawing.Color.Maroon;
            this.roundButton2.ButtonPressedForeColor = System.Drawing.Color.White;
            this.roundButton2.ButtonRoundRadius = 30;
            this.roundButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.roundButton2.Location = new System.Drawing.Point(82, 128);
            this.roundButton2.Name = "roundButton2";
            this.roundButton2.Size = new System.Drawing.Size(56, 27);
            this.roundButton2.TabIndex = 15;
            this.roundButton2.Text = "10 лет";
            // 
            // roundButton3
            // 
            this.roundButton3.BackColor = System.Drawing.Color.Gainsboro;
            this.roundButton3.BackColor2 = System.Drawing.Color.Silver;
            this.roundButton3.ButtonBorderColor = System.Drawing.Color.Black;
            this.roundButton3.ButtonHighlightColor = System.Drawing.Color.Orange;
            this.roundButton3.ButtonHighlightColor2 = System.Drawing.Color.OrangeRed;
            this.roundButton3.ButtonHighlightForeColor = System.Drawing.Color.Black;
            this.roundButton3.ButtonPressedColor = System.Drawing.Color.Red;
            this.roundButton3.ButtonPressedColor2 = System.Drawing.Color.Maroon;
            this.roundButton3.ButtonPressedForeColor = System.Drawing.Color.White;
            this.roundButton3.ButtonRoundRadius = 30;
            this.roundButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.roundButton3.Location = new System.Drawing.Point(144, 128);
            this.roundButton3.Name = "roundButton3";
            this.roundButton3.Size = new System.Drawing.Size(56, 27);
            this.roundButton3.TabIndex = 16;
            this.roundButton3.Text = "15 лет";
            // 
            // roundButton4
            // 
            this.roundButton4.BackColor = System.Drawing.Color.Gainsboro;
            this.roundButton4.BackColor2 = System.Drawing.Color.Silver;
            this.roundButton4.ButtonBorderColor = System.Drawing.Color.Black;
            this.roundButton4.ButtonHighlightColor = System.Drawing.Color.Orange;
            this.roundButton4.ButtonHighlightColor2 = System.Drawing.Color.OrangeRed;
            this.roundButton4.ButtonHighlightForeColor = System.Drawing.Color.Black;
            this.roundButton4.ButtonPressedColor = System.Drawing.Color.Red;
            this.roundButton4.ButtonPressedColor2 = System.Drawing.Color.Maroon;
            this.roundButton4.ButtonPressedForeColor = System.Drawing.Color.White;
            this.roundButton4.ButtonRoundRadius = 30;
            this.roundButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.roundButton4.Location = new System.Drawing.Point(206, 128);
            this.roundButton4.Name = "roundButton4";
            this.roundButton4.Size = new System.Drawing.Size(56, 27);
            this.roundButton4.TabIndex = 17;
            this.roundButton4.Text = "20 лет";
            // 
            // roundButton5
            // 
            this.roundButton5.BackColor = System.Drawing.Color.Gainsboro;
            this.roundButton5.BackColor2 = System.Drawing.Color.Silver;
            this.roundButton5.ButtonBorderColor = System.Drawing.Color.Black;
            this.roundButton5.ButtonHighlightColor = System.Drawing.Color.Orange;
            this.roundButton5.ButtonHighlightColor2 = System.Drawing.Color.OrangeRed;
            this.roundButton5.ButtonHighlightForeColor = System.Drawing.Color.Black;
            this.roundButton5.ButtonPressedColor = System.Drawing.Color.Red;
            this.roundButton5.ButtonPressedColor2 = System.Drawing.Color.Maroon;
            this.roundButton5.ButtonPressedForeColor = System.Drawing.Color.White;
            this.roundButton5.ButtonRoundRadius = 30;
            this.roundButton5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.roundButton5.Location = new System.Drawing.Point(268, 128);
            this.roundButton5.Name = "roundButton5";
            this.roundButton5.Size = new System.Drawing.Size(56, 27);
            this.roundButton5.TabIndex = 18;
            this.roundButton5.Text = "30 лет";
            // 
            // roundButton6
            // 
            this.roundButton6.BackColor = System.Drawing.Color.Gainsboro;
            this.roundButton6.BackColor2 = System.Drawing.Color.Silver;
            this.roundButton6.ButtonBorderColor = System.Drawing.Color.Black;
            this.roundButton6.ButtonHighlightColor = System.Drawing.Color.Orange;
            this.roundButton6.ButtonHighlightColor2 = System.Drawing.Color.OrangeRed;
            this.roundButton6.ButtonHighlightForeColor = System.Drawing.Color.Black;
            this.roundButton6.ButtonPressedColor = System.Drawing.Color.Red;
            this.roundButton6.ButtonPressedColor2 = System.Drawing.Color.Maroon;
            this.roundButton6.ButtonPressedForeColor = System.Drawing.Color.White;
            this.roundButton6.ButtonRoundRadius = 30;
            this.roundButton6.Location = new System.Drawing.Point(35, 221);
            this.roundButton6.Name = "roundButton6";
            this.roundButton6.Size = new System.Drawing.Size(39, 27);
            this.roundButton6.TabIndex = 19;
            this.roundButton6.Text = "5 %";
            // 
            // roundButton7
            // 
            this.roundButton7.BackColor = System.Drawing.Color.Gainsboro;
            this.roundButton7.BackColor2 = System.Drawing.Color.Silver;
            this.roundButton7.ButtonBorderColor = System.Drawing.Color.Black;
            this.roundButton7.ButtonHighlightColor = System.Drawing.Color.Orange;
            this.roundButton7.ButtonHighlightColor2 = System.Drawing.Color.OrangeRed;
            this.roundButton7.ButtonHighlightForeColor = System.Drawing.Color.Black;
            this.roundButton7.ButtonPressedColor = System.Drawing.Color.Red;
            this.roundButton7.ButtonPressedColor2 = System.Drawing.Color.Maroon;
            this.roundButton7.ButtonPressedForeColor = System.Drawing.Color.White;
            this.roundButton7.ButtonRoundRadius = 30;
            this.roundButton7.Location = new System.Drawing.Point(80, 221);
            this.roundButton7.Name = "roundButton7";
            this.roundButton7.Size = new System.Drawing.Size(39, 27);
            this.roundButton7.TabIndex = 20;
            this.roundButton7.Text = "8 %";
            // 
            // roundButton8
            // 
            this.roundButton8.BackColor = System.Drawing.Color.Gainsboro;
            this.roundButton8.BackColor2 = System.Drawing.Color.Silver;
            this.roundButton8.ButtonBorderColor = System.Drawing.Color.Black;
            this.roundButton8.ButtonHighlightColor = System.Drawing.Color.Orange;
            this.roundButton8.ButtonHighlightColor2 = System.Drawing.Color.OrangeRed;
            this.roundButton8.ButtonHighlightForeColor = System.Drawing.Color.Black;
            this.roundButton8.ButtonPressedColor = System.Drawing.Color.Red;
            this.roundButton8.ButtonPressedColor2 = System.Drawing.Color.Maroon;
            this.roundButton8.ButtonPressedForeColor = System.Drawing.Color.White;
            this.roundButton8.ButtonRoundRadius = 30;
            this.roundButton8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.roundButton8.Location = new System.Drawing.Point(125, 221);
            this.roundButton8.Name = "roundButton8";
            this.roundButton8.Size = new System.Drawing.Size(56, 27);
            this.roundButton8.TabIndex = 21;
            this.roundButton8.Text = "13,6%";
            // 
            // roundButton9
            // 
            this.roundButton9.BackColor = System.Drawing.Color.Gainsboro;
            this.roundButton9.BackColor2 = System.Drawing.Color.Silver;
            this.roundButton9.ButtonBorderColor = System.Drawing.Color.Black;
            this.roundButton9.ButtonHighlightColor = System.Drawing.Color.Orange;
            this.roundButton9.ButtonHighlightColor2 = System.Drawing.Color.OrangeRed;
            this.roundButton9.ButtonHighlightForeColor = System.Drawing.Color.Black;
            this.roundButton9.ButtonPressedColor = System.Drawing.Color.Red;
            this.roundButton9.ButtonPressedColor2 = System.Drawing.Color.Maroon;
            this.roundButton9.ButtonPressedForeColor = System.Drawing.Color.White;
            this.roundButton9.ButtonRoundRadius = 30;
            this.roundButton9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.roundButton9.Location = new System.Drawing.Point(187, 221);
            this.roundButton9.Name = "roundButton9";
            this.roundButton9.Size = new System.Drawing.Size(56, 27);
            this.roundButton9.TabIndex = 22;
            this.roundButton9.Text = "14,2%";
            // 
            // roundButton10
            // 
            this.roundButton10.BackColor = System.Drawing.Color.Gainsboro;
            this.roundButton10.BackColor2 = System.Drawing.Color.Silver;
            this.roundButton10.ButtonBorderColor = System.Drawing.Color.Black;
            this.roundButton10.ButtonHighlightColor = System.Drawing.Color.Orange;
            this.roundButton10.ButtonHighlightColor2 = System.Drawing.Color.OrangeRed;
            this.roundButton10.ButtonHighlightForeColor = System.Drawing.Color.Black;
            this.roundButton10.ButtonPressedColor = System.Drawing.Color.Red;
            this.roundButton10.ButtonPressedColor2 = System.Drawing.Color.Maroon;
            this.roundButton10.ButtonPressedForeColor = System.Drawing.Color.White;
            this.roundButton10.ButtonRoundRadius = 30;
            this.roundButton10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.roundButton10.Location = new System.Drawing.Point(249, 221);
            this.roundButton10.Name = "roundButton10";
            this.roundButton10.Size = new System.Drawing.Size(56, 27);
            this.roundButton10.TabIndex = 23;
            this.roundButton10.Text = "15,5%";
            // 
            // roundButton11
            // 
            this.roundButton11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.roundButton11.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.roundButton11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.roundButton11.ButtonBorderColor = System.Drawing.Color.Black;
            this.roundButton11.ButtonHighlightColor = System.Drawing.Color.Orange;
            this.roundButton11.ButtonHighlightColor2 = System.Drawing.Color.OrangeRed;
            this.roundButton11.ButtonHighlightForeColor = System.Drawing.Color.Black;
            this.roundButton11.ButtonPressedColor = System.Drawing.Color.Red;
            this.roundButton11.ButtonPressedColor2 = System.Drawing.Color.Maroon;
            this.roundButton11.ButtonPressedForeColor = System.Drawing.Color.White;
            this.roundButton11.ButtonRoundRadius = 30;
            this.roundButton11.Font = new System.Drawing.Font("Goudy Stout", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundButton11.ForeColor = System.Drawing.Color.White;
            this.roundButton11.Location = new System.Drawing.Point(34, 368);
            this.roundButton11.Name = "roundButton11";
            this.roundButton11.Size = new System.Drawing.Size(155, 52);
            this.roundButton11.TabIndex = 24;
            this.roundButton11.Text = "Рассчитать";
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.Exit.Font = new System.Drawing.Font("Goudy Stout", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.ForeColor = System.Drawing.Color.White;
            this.Exit.Location = new System.Drawing.Point(725, 6);
            this.Exit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(66, 25);
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
            this.Back.Location = new System.Drawing.Point(652, 6);
            this.Back.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(69, 25);
            this.Back.TabIndex = 27;
            this.Back.Text = "Назад";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Credit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.roundButton11);
            this.Controls.Add(this.roundButton10);
            this.Controls.Add(this.roundButton9);
            this.Controls.Add(this.roundButton8);
            this.Controls.Add(this.roundButton7);
            this.Controls.Add(this.roundButton6);
            this.Controls.Add(this.roundButton5);
            this.Controls.Add(this.roundButton4);
            this.Controls.Add(this.roundButton3);
            this.Controls.Add(this.roundButton2);
            this.Controls.Add(this.roundButton1);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private RoundButton roundButton1;
        private RoundButton roundButton2;
        private RoundButton roundButton3;
        private RoundButton roundButton4;
        private RoundButton roundButton5;
        private RoundButton roundButton6;
        private RoundButton roundButton7;
        private RoundButton roundButton8;
        private RoundButton roundButton9;
        private RoundButton roundButton10;
        private RoundButton roundButton11;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button Back;
    }
}