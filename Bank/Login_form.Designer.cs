﻿namespace Bank
{
    partial class Login_form
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
            this.Password = new System.Windows.Forms.TextBox();
            this.Login = new System.Windows.Forms.TextBox();
            this.Login_txt = new System.Windows.Forms.Label();
            this.Password_txt = new System.Windows.Forms.Label();
            this.User = new System.Windows.Forms.RadioButton();
            this.Admin = new System.Windows.Forms.RadioButton();
            this.Reg = new Bank.RoundButton();
            this.Log_in = new Bank.RoundButton();
            this.Exit = new System.Windows.Forms.Button();
            this.Log_in_txt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(156, 183);
            this.Password.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(287, 28);
            this.Password.TabIndex = 0;
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(156, 135);
            this.Login.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(287, 28);
            this.Login.TabIndex = 1;
            // 
            // Login_txt
            // 
            this.Login_txt.AutoSize = true;
            this.Login_txt.Font = new System.Drawing.Font("Georgia", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Login_txt.Location = new System.Drawing.Point(67, 147);
            this.Login_txt.Name = "Login_txt";
            this.Login_txt.Size = new System.Drawing.Size(69, 21);
            this.Login_txt.TabIndex = 3;
            this.Login_txt.Text = "Логин";
            // 
            // Password_txt
            // 
            this.Password_txt.AutoSize = true;
            this.Password_txt.Font = new System.Drawing.Font("Georgia", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Password_txt.Location = new System.Drawing.Point(57, 196);
            this.Password_txt.Name = "Password_txt";
            this.Password_txt.Size = new System.Drawing.Size(84, 21);
            this.Password_txt.TabIndex = 4;
            this.Password_txt.Text = "Пароль";
            // 
            // User
            // 
            this.User.AutoSize = true;
            this.User.Cursor = System.Windows.Forms.Cursors.Hand;
            this.User.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.User.Location = new System.Drawing.Point(161, 229);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(176, 25);
            this.User.TabIndex = 5;
            this.User.TabStop = true;
            this.User.Text = "Пользователь";
            this.User.UseVisualStyleBackColor = true;
            // 
            // Admin
            // 
            this.Admin.AutoSize = true;
            this.Admin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Admin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.Admin.Location = new System.Drawing.Point(161, 261);
            this.Admin.Name = "Admin";
            this.Admin.Size = new System.Drawing.Size(201, 25);
            this.Admin.TabIndex = 6;
            this.Admin.TabStop = true;
            this.Admin.Text = "Администратор";
            this.Admin.UseVisualStyleBackColor = true;
            // 
            // Reg
            // 
            this.Reg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.Reg.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.Reg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Reg.ButtonBorderColor = System.Drawing.Color.White;
            this.Reg.ButtonHighlightColor = System.Drawing.Color.SaddleBrown;
            this.Reg.ButtonHighlightColor2 = System.Drawing.Color.SaddleBrown;
            this.Reg.ButtonHighlightForeColor = System.Drawing.Color.White;
            this.Reg.ButtonPressedColor = System.Drawing.Color.MidnightBlue;
            this.Reg.ButtonPressedColor2 = System.Drawing.Color.MidnightBlue;
            this.Reg.ButtonPressedForeColor = System.Drawing.Color.White;
            this.Reg.ButtonRoundRadius = 30;
            this.Reg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Reg.ForeColor = System.Drawing.Color.White;
            this.Reg.Location = new System.Drawing.Point(271, 330);
            this.Reg.Name = "Reg";
            this.Reg.Size = new System.Drawing.Size(172, 47);
            this.Reg.TabIndex = 10;
            this.Reg.Text = "Регистрация";
            // 
            // Log_in
            // 
            this.Log_in.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.Log_in.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.Log_in.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Log_in.ButtonBorderColor = System.Drawing.Color.White;
            this.Log_in.ButtonHighlightColor = System.Drawing.Color.SaddleBrown;
            this.Log_in.ButtonHighlightColor2 = System.Drawing.Color.SaddleBrown;
            this.Log_in.ButtonHighlightForeColor = System.Drawing.Color.White;
            this.Log_in.ButtonPressedColor = System.Drawing.Color.DarkGreen;
            this.Log_in.ButtonPressedColor2 = System.Drawing.Color.DarkGreen;
            this.Log_in.ButtonPressedForeColor = System.Drawing.Color.White;
            this.Log_in.ButtonRoundRadius = 30;
            this.Log_in.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Log_in.ForeColor = System.Drawing.Color.White;
            this.Log_in.Location = new System.Drawing.Point(92, 330);
            this.Log_in.Name = "Log_in";
            this.Log_in.Size = new System.Drawing.Size(132, 47);
            this.Log_in.TabIndex = 9;
            this.Log_in.Text = "Войти";
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.Exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Exit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Exit.FlatAppearance.BorderSize = 3;
            this.Exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SaddleBrown;
            this.Exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Chocolate;
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.ForeColor = System.Drawing.Color.White;
            this.Exit.Location = new System.Drawing.Point(424, 8);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(95, 35);
            this.Exit.TabIndex = 12;
            this.Exit.Text = "Выход";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Log_in_txt
            // 
            this.Log_in_txt.Font = new System.Drawing.Font("Georgia", 19.8F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Log_in_txt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.Log_in_txt.Location = new System.Drawing.Point(85, 72);
            this.Log_in_txt.Name = "Log_in_txt";
            this.Log_in_txt.Size = new System.Drawing.Size(467, 53);
            this.Log_in_txt.TabIndex = 13;
            this.Log_in_txt.Text = "Вход в личный кабинет";
            // 
            // Login_form
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.ClientSize = new System.Drawing.Size(527, 407);
            this.ControlBox = false;
            this.Controls.Add(this.Log_in_txt);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Reg);
            this.Controls.Add(this.Log_in);
            this.Controls.Add(this.Admin);
            this.Controls.Add(this.User);
            this.Controls.Add(this.Password_txt);
            this.Controls.Add(this.Login_txt);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.Password);
            this.Font = new System.Drawing.Font("Georgia", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Login_form";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Вход";
            this.Load += new System.EventHandler(this.Login_form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.TextBox Login;
        private System.Windows.Forms.Label Login_txt;
        private System.Windows.Forms.Label Password_txt;
        private System.Windows.Forms.RadioButton User;
        private System.Windows.Forms.RadioButton Admin;
        private RoundButton Log_in;
        private RoundButton Reg;
        private System.Windows.Forms.Label Log_in_txt;
        private System.Windows.Forms.Button Exit;
    }
}