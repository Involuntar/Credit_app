﻿namespace Bank
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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
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
            this.roundButton12 = new Bank.RoundButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(44, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Сумма кредита";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(44, 102);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Срок кредита";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(49, 59);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(405, 22);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(49, 150);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(405, 22);
            this.textBox2.TabIndex = 5;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(44, 226);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(254, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "Процентная ставка";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(49, 277);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(405, 22);
            this.textBox3.TabIndex = 7;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(44, 346);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 29);
            this.label4.TabIndex = 8;
            this.label4.Text = "Тип платежа";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(49, 421);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(180, 20);
            this.radioButton2.TabIndex = 10;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Дифференцированный";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(49, 393);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(116, 20);
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
            this.roundButton1.Location = new System.Drawing.Point(49, 182);
            this.roundButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.roundButton1.Name = "roundButton1";
            this.roundButton1.Size = new System.Drawing.Size(52, 33);
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
            this.roundButton2.Location = new System.Drawing.Point(109, 182);
            this.roundButton2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.roundButton2.Name = "roundButton2";
            this.roundButton2.Size = new System.Drawing.Size(75, 33);
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
            this.roundButton3.Location = new System.Drawing.Point(192, 182);
            this.roundButton3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.roundButton3.Name = "roundButton3";
            this.roundButton3.Size = new System.Drawing.Size(75, 33);
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
            this.roundButton4.Location = new System.Drawing.Point(275, 182);
            this.roundButton4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.roundButton4.Name = "roundButton4";
            this.roundButton4.Size = new System.Drawing.Size(75, 33);
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
            this.roundButton5.Location = new System.Drawing.Point(357, 182);
            this.roundButton5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.roundButton5.Name = "roundButton5";
            this.roundButton5.Size = new System.Drawing.Size(75, 33);
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
            this.roundButton6.Location = new System.Drawing.Point(49, 309);
            this.roundButton6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.roundButton6.Name = "roundButton6";
            this.roundButton6.Size = new System.Drawing.Size(52, 33);
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
            this.roundButton7.Location = new System.Drawing.Point(109, 309);
            this.roundButton7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.roundButton7.Name = "roundButton7";
            this.roundButton7.Size = new System.Drawing.Size(52, 33);
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
            this.roundButton8.Location = new System.Drawing.Point(169, 309);
            this.roundButton8.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.roundButton8.Name = "roundButton8";
            this.roundButton8.Size = new System.Drawing.Size(75, 33);
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
            this.roundButton9.Location = new System.Drawing.Point(252, 309);
            this.roundButton9.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.roundButton9.Name = "roundButton9";
            this.roundButton9.Size = new System.Drawing.Size(75, 33);
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
            this.roundButton10.Location = new System.Drawing.Point(335, 309);
            this.roundButton10.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.roundButton10.Name = "roundButton10";
            this.roundButton10.Size = new System.Drawing.Size(75, 33);
            this.roundButton10.TabIndex = 23;
            this.roundButton10.Text = "15,5%";
            // 
            // roundButton11
            // 
            this.roundButton11.BackColor = System.Drawing.Color.Silver;
            this.roundButton11.BackColor2 = System.Drawing.Color.Silver;
            this.roundButton11.ButtonBorderColor = System.Drawing.Color.Black;
            this.roundButton11.ButtonHighlightColor = System.Drawing.Color.Orange;
            this.roundButton11.ButtonHighlightColor2 = System.Drawing.Color.OrangeRed;
            this.roundButton11.ButtonHighlightForeColor = System.Drawing.Color.Black;
            this.roundButton11.ButtonPressedColor = System.Drawing.Color.Red;
            this.roundButton11.ButtonPressedColor2 = System.Drawing.Color.Maroon;
            this.roundButton11.ButtonPressedForeColor = System.Drawing.Color.White;
            this.roundButton11.ButtonRoundRadius = 30;
            this.roundButton11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.roundButton11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.roundButton11.Location = new System.Drawing.Point(33, 465);
            this.roundButton11.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.roundButton11.Name = "roundButton11";
            this.roundButton11.Size = new System.Drawing.Size(176, 55);
            this.roundButton11.TabIndex = 24;
            this.roundButton11.Text = "Рассчитать";
            // 
            // roundButton12
            // 
            this.roundButton12.BackColor = System.Drawing.Color.Silver;
            this.roundButton12.BackColor2 = System.Drawing.Color.Silver;
            this.roundButton12.ButtonBorderColor = System.Drawing.Color.Black;
            this.roundButton12.ButtonHighlightColor = System.Drawing.Color.Orange;
            this.roundButton12.ButtonHighlightColor2 = System.Drawing.Color.OrangeRed;
            this.roundButton12.ButtonHighlightForeColor = System.Drawing.Color.Black;
            this.roundButton12.ButtonPressedColor = System.Drawing.Color.Red;
            this.roundButton12.ButtonPressedColor2 = System.Drawing.Color.Maroon;
            this.roundButton12.ButtonPressedForeColor = System.Drawing.Color.White;
            this.roundButton12.ButtonRoundRadius = 30;
            this.roundButton12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.roundButton12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.roundButton12.Location = new System.Drawing.Point(217, 465);
            this.roundButton12.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.roundButton12.Name = "roundButton12";
            this.roundButton12.Size = new System.Drawing.Size(239, 55);
            this.roundButton12.TabIndex = 25;
            this.roundButton12.Text = "Оставить заявку";
            // 
            // Credit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.roundButton12);
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
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Credit";
            this.Text = "Credit";
            this.Load += new System.EventHandler(this.Credit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
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
        private RoundButton roundButton12;
    }
}