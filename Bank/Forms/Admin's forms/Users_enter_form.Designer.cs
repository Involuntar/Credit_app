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
            this.firstname_txt = new System.Windows.Forms.Label();
            this.middlename_txt = new System.Windows.Forms.Label();
            this.lastname_txt = new System.Windows.Forms.Label();
            this.login_txt = new System.Windows.Forms.Label();
            this.password_txt = new System.Windows.Forms.Label();
            this.email_txt = new System.Windows.Forms.Label();
            this.Back = new System.Windows.Forms.Button();
            this.Save = new Bank.RoundButton();
            this.SuspendLayout();
            // 
            // firstnametxt
            // 
            this.firstnametxt.Location = new System.Drawing.Point(58, 91);
            this.firstnametxt.Margin = new System.Windows.Forms.Padding(2);
            this.firstnametxt.Name = "firstnametxt";
            this.firstnametxt.Size = new System.Drawing.Size(76, 20);
            this.firstnametxt.TabIndex = 0;
            this.firstnametxt.Text = "Фамилия";
            // 
            // middlenametxt
            // 
            this.middlenametxt.Location = new System.Drawing.Point(228, 115);
            this.middlenametxt.Margin = new System.Windows.Forms.Padding(2);
            this.middlenametxt.Name = "middlenametxt";
            this.middlenametxt.Size = new System.Drawing.Size(76, 20);
            this.middlenametxt.TabIndex = 1;
            // 
            // lastnametxt
            // 
            this.lastnametxt.Location = new System.Drawing.Point(216, 153);
            this.lastnametxt.Margin = new System.Windows.Forms.Padding(2);
            this.lastnametxt.Name = "lastnametxt";
            this.lastnametxt.Size = new System.Drawing.Size(76, 20);
            this.lastnametxt.TabIndex = 2;
            // 
            // logintxt
            // 
            this.logintxt.Location = new System.Drawing.Point(228, 186);
            this.logintxt.Margin = new System.Windows.Forms.Padding(2);
            this.logintxt.Name = "logintxt";
            this.logintxt.Size = new System.Drawing.Size(76, 20);
            this.logintxt.TabIndex = 3;
            this.logintxt.TextChanged += new System.EventHandler(this.logintxt_TextChanged);
            // 
            // passwordtxt
            // 
            this.passwordtxt.Location = new System.Drawing.Point(216, 221);
            this.passwordtxt.Margin = new System.Windows.Forms.Padding(2);
            this.passwordtxt.Name = "passwordtxt";
            this.passwordtxt.Size = new System.Drawing.Size(76, 20);
            this.passwordtxt.TabIndex = 4;
            // 
            // emailtxt
            // 
            this.emailtxt.Location = new System.Drawing.Point(216, 271);
            this.emailtxt.Margin = new System.Windows.Forms.Padding(2);
            this.emailtxt.Name = "emailtxt";
            this.emailtxt.Size = new System.Drawing.Size(76, 20);
            this.emailtxt.TabIndex = 5;
            // 
            // firstname_txt
            // 
            this.firstname_txt.AutoSize = true;
            this.firstname_txt.Font = new System.Drawing.Font("Goudy Stout", 14.25F);
            this.firstname_txt.ForeColor = System.Drawing.Color.Black;
            this.firstname_txt.Location = new System.Drawing.Point(53, 63);
            this.firstname_txt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.firstname_txt.Name = "firstname_txt";
            this.firstname_txt.Size = new System.Drawing.Size(48, 26);
            this.firstname_txt.TabIndex = 7;
            this.firstname_txt.Text = "Имя";
            // 
            // middlename_txt
            // 
            this.middlename_txt.AutoSize = true;
            this.middlename_txt.Font = new System.Drawing.Font("Goudy Stout", 14.25F);
            this.middlename_txt.ForeColor = System.Drawing.Color.Black;
            this.middlename_txt.Location = new System.Drawing.Point(79, 112);
            this.middlename_txt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.middlename_txt.Name = "middlename_txt";
            this.middlename_txt.Size = new System.Drawing.Size(100, 26);
            this.middlename_txt.TabIndex = 8;
            this.middlename_txt.Text = "Отчество";
            // 
            // lastname_txt
            // 
            this.lastname_txt.AutoSize = true;
            this.lastname_txt.Font = new System.Drawing.Font("Goudy Stout", 14.25F);
            this.lastname_txt.ForeColor = System.Drawing.Color.Black;
            this.lastname_txt.Location = new System.Drawing.Point(79, 148);
            this.lastname_txt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lastname_txt.Name = "lastname_txt";
            this.lastname_txt.Size = new System.Drawing.Size(93, 26);
            this.lastname_txt.TabIndex = 9;
            this.lastname_txt.Text = "Фамилия";
            // 
            // login_txt
            // 
            this.login_txt.AutoSize = true;
            this.login_txt.Font = new System.Drawing.Font("Goudy Stout", 14.25F);
            this.login_txt.ForeColor = System.Drawing.Color.Black;
            this.login_txt.Location = new System.Drawing.Point(79, 183);
            this.login_txt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.login_txt.Name = "login_txt";
            this.login_txt.Size = new System.Drawing.Size(66, 26);
            this.login_txt.TabIndex = 10;
            this.login_txt.Text = "Логин";
            // 
            // password_txt
            // 
            this.password_txt.AutoSize = true;
            this.password_txt.Font = new System.Drawing.Font("Goudy Stout", 14.25F);
            this.password_txt.ForeColor = System.Drawing.Color.Black;
            this.password_txt.Location = new System.Drawing.Point(79, 216);
            this.password_txt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.password_txt.Name = "password_txt";
            this.password_txt.Size = new System.Drawing.Size(78, 26);
            this.password_txt.TabIndex = 11;
            this.password_txt.Text = "Пароль";
            // 
            // email_txt
            // 
            this.email_txt.AutoSize = true;
            this.email_txt.Font = new System.Drawing.Font("Goudy Stout", 14.25F);
            this.email_txt.ForeColor = System.Drawing.Color.Black;
            this.email_txt.Location = new System.Drawing.Point(79, 252);
            this.email_txt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.email_txt.Name = "email_txt";
            this.email_txt.Size = new System.Drawing.Size(66, 26);
            this.email_txt.TabIndex = 12;
            this.email_txt.Text = "Почта";
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.Back.Font = new System.Drawing.Font("Goudy Stout", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.ForeColor = System.Drawing.Color.White;
            this.Back.Location = new System.Drawing.Point(415, 10);
            this.Back.Margin = new System.Windows.Forms.Padding(2);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(76, 23);
            this.Back.TabIndex = 13;
            this.Back.Text = "Назад";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Save
            // 
            this.Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.Save.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.Save.ButtonBorderColor = System.Drawing.Color.Black;
            this.Save.ButtonHighlightColor = System.Drawing.Color.Orange;
            this.Save.ButtonHighlightColor2 = System.Drawing.Color.OrangeRed;
            this.Save.ButtonHighlightForeColor = System.Drawing.Color.Black;
            this.Save.ButtonPressedColor = System.Drawing.Color.Red;
            this.Save.ButtonPressedColor2 = System.Drawing.Color.Maroon;
            this.Save.ButtonPressedForeColor = System.Drawing.Color.White;
            this.Save.ButtonRoundRadius = 30;
            this.Save.Font = new System.Drawing.Font("Goudy Stout", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save.ForeColor = System.Drawing.Color.White;
            this.Save.Location = new System.Drawing.Point(118, 325);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(139, 50);
            this.Save.TabIndex = 14;
            this.Save.Text = "Сохранить";
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Users_enter_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.ClientSize = new System.Drawing.Size(500, 437);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.email_txt);
            this.Controls.Add(this.password_txt);
            this.Controls.Add(this.login_txt);
            this.Controls.Add(this.lastname_txt);
            this.Controls.Add(this.middlename_txt);
            this.Controls.Add(this.firstname_txt);
            this.Controls.Add(this.emailtxt);
            this.Controls.Add(this.passwordtxt);
            this.Controls.Add(this.logintxt);
            this.Controls.Add(this.lastnametxt);
            this.Controls.Add(this.middlenametxt);
            this.Controls.Add(this.firstnametxt);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Users_enter_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Label firstname_txt;
        private System.Windows.Forms.Label middlename_txt;
        private System.Windows.Forms.Label lastname_txt;
        private System.Windows.Forms.Label login_txt;
        private System.Windows.Forms.Label password_txt;
        private System.Windows.Forms.Label email_txt;
        private System.Windows.Forms.Button Back;
        private RoundButton Save;
    }
}