namespace Bank
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
            this.Exit = new System.Windows.Forms.Button();
            this.Log_in_txt = new System.Windows.Forms.Label();
            this.Check_c = new System.Windows.Forms.Button();
            this.Reg = new Bank.RoundButton();
            this.Log_in = new Bank.RoundButton();
            this.SuspendLayout();
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(152, 187);
            this.Password.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '*';
            this.Password.Size = new System.Drawing.Size(287, 24);
            this.Password.TabIndex = 0;
            this.Password.TextChanged += new System.EventHandler(this.Password_TextChanged);
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(152, 139);
            this.Login.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(287, 24);
            this.Login.TabIndex = 1;
            // 
            // Login_txt
            // 
            this.Login_txt.AutoSize = true;
            this.Login_txt.Font = new System.Drawing.Font("Goudy Stout", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_txt.Location = new System.Drawing.Point(71, 137);
            this.Login_txt.Name = "Login_txt";
            this.Login_txt.Size = new System.Drawing.Size(60, 22);
            this.Login_txt.TabIndex = 3;
            this.Login_txt.Text = "Логин";
            // 
            // Password_txt
            // 
            this.Password_txt.AutoSize = true;
            this.Password_txt.Font = new System.Drawing.Font("Goudy Stout", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password_txt.Location = new System.Drawing.Point(71, 188);
            this.Password_txt.Name = "Password_txt";
            this.Password_txt.Size = new System.Drawing.Size(73, 22);
            this.Password_txt.TabIndex = 4;
            this.Password_txt.Text = "Пароль";
            // 
            // User
            // 
            this.User.AutoSize = true;
            this.User.Cursor = System.Windows.Forms.Cursors.Hand;
            this.User.Font = new System.Drawing.Font("Goudy Stout", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.User.ForeColor = System.Drawing.Color.Black;
            this.User.Location = new System.Drawing.Point(152, 233);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(129, 24);
            this.User.TabIndex = 5;
            this.User.TabStop = true;
            this.User.Text = "Пользователь";
            this.User.UseVisualStyleBackColor = true;
            this.User.CheckedChanged += new System.EventHandler(this.User_CheckedChanged);
            // 
            // Admin
            // 
            this.Admin.AutoSize = true;
            this.Admin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Admin.Font = new System.Drawing.Font("Goudy Stout", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Admin.ForeColor = System.Drawing.Color.Black;
            this.Admin.Location = new System.Drawing.Point(152, 265);
            this.Admin.Name = "Admin";
            this.Admin.Size = new System.Drawing.Size(135, 24);
            this.Admin.TabIndex = 6;
            this.Admin.TabStop = true;
            this.Admin.Text = "Администратор";
            this.Admin.UseVisualStyleBackColor = true;
            this.Admin.CheckedChanged += new System.EventHandler(this.Admin_CheckedChanged);
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
            this.Exit.Font = new System.Drawing.Font("Goudy Stout", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.ForeColor = System.Drawing.Color.White;
            this.Exit.Location = new System.Drawing.Point(441, 8);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(78, 30);
            this.Exit.TabIndex = 12;
            this.Exit.Text = "Выход";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Log_in_txt
            // 
            this.Log_in_txt.Font = new System.Drawing.Font("Goudy Stout", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Log_in_txt.ForeColor = System.Drawing.Color.Black;
            this.Log_in_txt.Location = new System.Drawing.Point(111, 76);
            this.Log_in_txt.Name = "Log_in_txt";
            this.Log_in_txt.Size = new System.Drawing.Size(328, 53);
            this.Log_in_txt.TabIndex = 13;
            this.Log_in_txt.Text = "Вход в личный кабинет";
            this.Log_in_txt.Click += new System.EventHandler(this.Log_in_txt_Click);
            // 
            // Check_c
            // 
            this.Check_c.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Check_c.FlatAppearance.BorderSize = 0;
            this.Check_c.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.Check_c.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.Check_c.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Check_c.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Check_c.Location = new System.Drawing.Point(43, 8);
            this.Check_c.Name = "Check_c";
            this.Check_c.Size = new System.Drawing.Size(132, 45);
            this.Check_c.TabIndex = 14;
            this.Check_c.Text = " ";
            this.Check_c.UseVisualStyleBackColor = false;
            this.Check_c.Click += new System.EventHandler(this.button1_Click);
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
            this.Reg.Font = new System.Drawing.Font("Goudy Stout", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reg.ForeColor = System.Drawing.Color.White;
            this.Reg.Location = new System.Drawing.Point(257, 330);
            this.Reg.Name = "Reg";
            this.Reg.Size = new System.Drawing.Size(158, 47);
            this.Reg.TabIndex = 10;
            this.Reg.Text = "Регистрация";
            this.Reg.Click += new System.EventHandler(this.Reg_Click);
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
            this.Log_in.Font = new System.Drawing.Font("Goudy Stout", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Log_in.ForeColor = System.Drawing.Color.White;
            this.Log_in.Location = new System.Drawing.Point(105, 330);
            this.Log_in.Name = "Log_in";
            this.Log_in.Size = new System.Drawing.Size(118, 47);
            this.Log_in.TabIndex = 9;
            this.Log_in.Text = "Войти";
            this.Log_in.Click += new System.EventHandler(this.Log_in_Click);
            // 
            // Login_form
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.ClientSize = new System.Drawing.Size(527, 407);
            this.ControlBox = false;
            this.Controls.Add(this.Check_c);
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
        private System.Windows.Forms.Button Check_c;
    }
}