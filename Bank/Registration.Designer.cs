﻿namespace Bank
{
    partial class Registration
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
            this.roundButton1 = new Bank.RoundButton();
            this.SuspendLayout();
            // 
            // roundButton1
            // 
            this.roundButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.roundButton1.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.roundButton1.ButtonBorderColor = System.Drawing.Color.White;
            this.roundButton1.ButtonHighlightColor = System.Drawing.Color.SaddleBrown;
            this.roundButton1.ButtonHighlightColor2 = System.Drawing.Color.SaddleBrown;
            this.roundButton1.ButtonHighlightForeColor = System.Drawing.Color.White;
            this.roundButton1.ButtonPressedColor = System.Drawing.Color.MidnightBlue;
            this.roundButton1.ButtonPressedColor2 = System.Drawing.Color.MidnightBlue;
            this.roundButton1.ButtonPressedForeColor = System.Drawing.Color.White;
            this.roundButton1.ButtonRoundRadius = 30;
            this.roundButton1.Font = new System.Drawing.Font("Georgia", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.roundButton1.Location = new System.Drawing.Point(257, 355);
            this.roundButton1.Name = "roundButton1";
            this.roundButton1.Size = new System.Drawing.Size(268, 47);
            this.roundButton1.TabIndex = 0;
            this.roundButton1.Text = "Зарегистрироваться";
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 450);
            this.Controls.Add(this.roundButton1);
            this.Name = "Registration";
            this.Text = "Регистрация";
            this.ResumeLayout(false);

        }

        #endregion

        private RoundButton roundButton1;
    }
}