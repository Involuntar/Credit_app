namespace Bank.Forms.Admin_s_forms
{
    partial class Users_enter_form
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
            this.firstname = new System.Windows.Forms.TextBox();
            this.middlename = new System.Windows.Forms.TextBox();
            this.lastname = new System.Windows.Forms.TextBox();
            this.login = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.Save = new System.Windows.Forms.Button();
            this.firstname_txt = new System.Windows.Forms.Label();
            this.middlename_txt = new System.Windows.Forms.Label();
            this.lastname_txt = new System.Windows.Forms.Label();
            this.login_txt = new System.Windows.Forms.Label();
            this.password_txt = new System.Windows.Forms.Label();
            this.email_txt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // firstname
            // 
            this.firstname.Location = new System.Drawing.Point(162, 73);
            this.firstname.Name = "firstname";
            this.firstname.Size = new System.Drawing.Size(100, 22);
            this.firstname.TabIndex = 0;
            // 
            // middlename
            // 
            this.middlename.Location = new System.Drawing.Point(162, 122);
            this.middlename.Name = "middlename";
            this.middlename.Size = new System.Drawing.Size(100, 22);
            this.middlename.TabIndex = 1;
            // 
            // lastname
            // 
            this.lastname.Location = new System.Drawing.Point(162, 170);
            this.lastname.Name = "lastname";
            this.lastname.Size = new System.Drawing.Size(100, 22);
            this.lastname.TabIndex = 2;
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(162, 220);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(100, 22);
            this.login.TabIndex = 3;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(162, 272);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(100, 22);
            this.password.TabIndex = 4;
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(162, 322);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(100, 22);
            this.email.TabIndex = 5;
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(162, 377);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(120, 23);
            this.Save.TabIndex = 6;
            this.Save.Text = "Сохранить";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // firstname_txt
            // 
            this.firstname_txt.AutoSize = true;
            this.firstname_txt.Location = new System.Drawing.Point(80, 73);
            this.firstname_txt.Name = "firstname_txt";
            this.firstname_txt.Size = new System.Drawing.Size(33, 16);
            this.firstname_txt.TabIndex = 7;
            this.firstname_txt.Text = "Имя";
            // 
            // middlename_txt
            // 
            this.middlename_txt.AutoSize = true;
            this.middlename_txt.Location = new System.Drawing.Point(69, 108);
            this.middlename_txt.Name = "middlename_txt";
            this.middlename_txt.Size = new System.Drawing.Size(70, 16);
            this.middlename_txt.TabIndex = 8;
            this.middlename_txt.Text = "Отчество";
            // 
            // lastname_txt
            // 
            this.lastname_txt.AutoSize = true;
            this.lastname_txt.Location = new System.Drawing.Point(72, 170);
            this.lastname_txt.Name = "lastname_txt";
            this.lastname_txt.Size = new System.Drawing.Size(66, 16);
            this.lastname_txt.TabIndex = 9;
            this.lastname_txt.Text = "Фамилия";
            // 
            // login_txt
            // 
            this.login_txt.AutoSize = true;
            this.login_txt.Location = new System.Drawing.Point(57, 220);
            this.login_txt.Name = "login_txt";
            this.login_txt.Size = new System.Drawing.Size(46, 16);
            this.login_txt.TabIndex = 10;
            this.login_txt.Text = "Логин";
            // 
            // password_txt
            // 
            this.password_txt.AutoSize = true;
            this.password_txt.Location = new System.Drawing.Point(56, 272);
            this.password_txt.Name = "password_txt";
            this.password_txt.Size = new System.Drawing.Size(56, 16);
            this.password_txt.TabIndex = 11;
            this.password_txt.Text = "Пароль";
            // 
            // email_txt
            // 
            this.email_txt.AutoSize = true;
            this.email_txt.Location = new System.Drawing.Point(75, 327);
            this.email_txt.Name = "email_txt";
            this.email_txt.Size = new System.Drawing.Size(48, 16);
            this.email_txt.TabIndex = 12;
            this.email_txt.Text = "Почта";
            // 
            // Users_enter_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 538);
            this.Controls.Add(this.email_txt);
            this.Controls.Add(this.password_txt);
            this.Controls.Add(this.login_txt);
            this.Controls.Add(this.lastname_txt);
            this.Controls.Add(this.middlename_txt);
            this.Controls.Add(this.firstname_txt);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.email);
            this.Controls.Add(this.password);
            this.Controls.Add(this.login);
            this.Controls.Add(this.lastname);
            this.Controls.Add(this.middlename);
            this.Controls.Add(this.firstname);
            this.Name = "Users_enter_form";
            this.Text = "Ввод пользователей";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox firstname;
        private System.Windows.Forms.TextBox middlename;
        private System.Windows.Forms.TextBox lastname;
        private System.Windows.Forms.TextBox login;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Label firstname_txt;
        private System.Windows.Forms.Label middlename_txt;
        private System.Windows.Forms.Label lastname_txt;
        private System.Windows.Forms.Label login_txt;
        private System.Windows.Forms.Label password_txt;
        private System.Windows.Forms.Label email_txt;
    }
}