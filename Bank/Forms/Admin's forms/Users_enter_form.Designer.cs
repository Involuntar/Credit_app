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
            this.firstnametxt = new System.Windows.Forms.TextBox();
            this.middlenametxt = new System.Windows.Forms.TextBox();
            this.lastnametxt = new System.Windows.Forms.TextBox();
            this.logintxt = new System.Windows.Forms.TextBox();
            this.passwordtxt = new System.Windows.Forms.TextBox();
            this.emailtxt = new System.Windows.Forms.TextBox();
            this.Save = new System.Windows.Forms.Button();
            this.firstname_txt = new System.Windows.Forms.Label();
            this.middlename_txt = new System.Windows.Forms.Label();
            this.lastname_txt = new System.Windows.Forms.Label();
            this.login_txt = new System.Windows.Forms.Label();
            this.password_txt = new System.Windows.Forms.Label();
            this.email_txt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // firstnametxt
            // 
            this.firstnametxt.Location = new System.Drawing.Point(162, 73);
            this.firstnametxt.Name = "firstnametxt";
            this.firstnametxt.Size = new System.Drawing.Size(100, 22);
            this.firstnametxt.TabIndex = 0;
            // 
            // middlenametxt
            // 
            this.middlenametxt.Location = new System.Drawing.Point(162, 122);
            this.middlenametxt.Name = "middlenametxt";
            this.middlenametxt.Size = new System.Drawing.Size(100, 22);
            this.middlenametxt.TabIndex = 1;
            // 
            // lastnametxt
            // 
            this.lastnametxt.Location = new System.Drawing.Point(162, 170);
            this.lastnametxt.Name = "lastnametxt";
            this.lastnametxt.Size = new System.Drawing.Size(100, 22);
            this.lastnametxt.TabIndex = 2;
            // 
            // logintxt
            // 
            this.logintxt.Location = new System.Drawing.Point(162, 220);
            this.logintxt.Name = "logintxt";
            this.logintxt.Size = new System.Drawing.Size(100, 22);
            this.logintxt.TabIndex = 3;
            // 
            // passwordtxt
            // 
            this.passwordtxt.Location = new System.Drawing.Point(162, 272);
            this.passwordtxt.Name = "passwordtxt";
            this.passwordtxt.Size = new System.Drawing.Size(100, 22);
            this.passwordtxt.TabIndex = 4;
            // 
            // emailtxt
            // 
            this.emailtxt.Location = new System.Drawing.Point(162, 322);
            this.emailtxt.Name = "emailtxt";
            this.emailtxt.Size = new System.Drawing.Size(100, 22);
            this.emailtxt.TabIndex = 5;
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
            this.Controls.Add(this.emailtxt);
            this.Controls.Add(this.passwordtxt);
            this.Controls.Add(this.logintxt);
            this.Controls.Add(this.lastnametxt);
            this.Controls.Add(this.middlenametxt);
            this.Controls.Add(this.firstnametxt);
            this.Name = "Users_enter_form";
            this.Text = "Ввод пользователей";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox firstnametxt;
        private System.Windows.Forms.TextBox middlenametxt;
        private System.Windows.Forms.TextBox lastnametxt;
        private System.Windows.Forms.TextBox logintxt;
        private System.Windows.Forms.TextBox passwordtxt;
        private System.Windows.Forms.TextBox emailtxt;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Label firstname_txt;
        private System.Windows.Forms.Label middlename_txt;
        private System.Windows.Forms.Label lastname_txt;
        private System.Windows.Forms.Label login_txt;
        private System.Windows.Forms.Label password_txt;
        private System.Windows.Forms.Label email_txt;
    }
}