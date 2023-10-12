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
            this.Exit = new System.Windows.Forms.Button();
            this.Login_txt = new System.Windows.Forms.Label();
            this.Password_txt = new System.Windows.Forms.Label();
            this.User = new System.Windows.Forms.RadioButton();
            this.Admin = new System.Windows.Forms.RadioButton();
            this.Log_in = new System.Windows.Forms.Button();
            this.Reg = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(156, 183);
            this.Password.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(238, 28);
            this.Password.TabIndex = 0;
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(156, 135);
            this.Login.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(238, 28);
            this.Login.TabIndex = 1;
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Exit.FlatAppearance.BorderSize = 3;
            this.Exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Chocolate;
            this.Exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SaddleBrown;
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.ForeColor = System.Drawing.Color.White;
            this.Exit.Location = new System.Drawing.Point(425, 12);
            this.Exit.Name = "Exit";
            this.Exit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Exit.Size = new System.Drawing.Size(95, 35);
            this.Exit.TabIndex = 2;
            this.Exit.Text = "Выход";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Login_txt
            // 
            this.Login_txt.AutoSize = true;
            this.Login_txt.Font = new System.Drawing.Font("Georgia", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Login_txt.Location = new System.Drawing.Point(62, 142);
            this.Login_txt.Name = "Login_txt";
            this.Login_txt.Size = new System.Drawing.Size(69, 21);
            this.Login_txt.TabIndex = 3;
            this.Login_txt.Text = "Логин";
            // 
            // Password_txt
            // 
            this.Password_txt.AutoSize = true;
            this.Password_txt.Font = new System.Drawing.Font("Georgia", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Password_txt.Location = new System.Drawing.Point(52, 191);
            this.Password_txt.Name = "Password_txt";
            this.Password_txt.Size = new System.Drawing.Size(84, 21);
            this.Password_txt.TabIndex = 4;
            this.Password_txt.Text = "Пароль";
            // 
            // User
            // 
            this.User.AutoSize = true;
            this.User.Cursor = System.Windows.Forms.Cursors.Hand;
            this.User.ForeColor = System.Drawing.SystemColors.ControlText;
            this.User.Location = new System.Drawing.Point(156, 224);
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
            this.Admin.Location = new System.Drawing.Point(156, 256);
            this.Admin.Name = "Admin";
            this.Admin.Size = new System.Drawing.Size(201, 25);
            this.Admin.TabIndex = 6;
            this.Admin.TabStop = true;
            this.Admin.Text = "Администратор";
            this.Admin.UseVisualStyleBackColor = true;
            // 
            // Log_in
            // 
            this.Log_in.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.Log_in.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Log_in.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Log_in.FlatAppearance.BorderSize = 3;
            this.Log_in.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOliveGreen;
            this.Log_in.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SaddleBrown;
            this.Log_in.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Log_in.ForeColor = System.Drawing.Color.White;
            this.Log_in.Location = new System.Drawing.Point(110, 330);
            this.Log_in.Name = "Log_in";
            this.Log_in.Size = new System.Drawing.Size(98, 47);
            this.Log_in.TabIndex = 7;
            this.Log_in.Text = "Войти";
            this.Log_in.UseVisualStyleBackColor = false;
            // 
            // Reg
            // 
            this.Reg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.Reg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Reg.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Reg.FlatAppearance.BorderSize = 3;
            this.Reg.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.Reg.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SaddleBrown;
            this.Reg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Reg.ForeColor = System.Drawing.Color.White;
            this.Reg.Location = new System.Drawing.Point(229, 330);
            this.Reg.Name = "Reg";
            this.Reg.Size = new System.Drawing.Size(172, 47);
            this.Reg.TabIndex = 8;
            this.Reg.Text = "Регистрация";
            this.Reg.UseVisualStyleBackColor = false;
            // 
            // Login_form
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.ClientSize = new System.Drawing.Size(532, 503);
            this.ControlBox = false;
            this.Controls.Add(this.Reg);
            this.Controls.Add(this.Log_in);
            this.Controls.Add(this.Admin);
            this.Controls.Add(this.User);
            this.Controls.Add(this.Password_txt);
            this.Controls.Add(this.Login_txt);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.Password);
            this.Font = new System.Drawing.Font("Georgia", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Login_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Вход";
            this.Load += new System.EventHandler(this.Login_form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.TextBox Login;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Label Login_txt;
        private System.Windows.Forms.Label Password_txt;
        private System.Windows.Forms.RadioButton User;
        private System.Windows.Forms.RadioButton Admin;
        private System.Windows.Forms.Button Log_in;
        private System.Windows.Forms.Button Reg;
    }
}