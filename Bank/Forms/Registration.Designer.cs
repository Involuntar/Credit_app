namespace Bank
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
            this.Product_head = new System.Windows.Forms.Label();
            this.mail = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.TextBox();
            this.lgn = new System.Windows.Forms.Label();
            this.new_login = new System.Windows.Forms.TextBox();
            this.pswrd = new System.Windows.Forms.Label();
            this.new_password = new System.Windows.Forms.TextBox();
            this.pswrd_2 = new System.Windows.Forms.Label();
            this.confirm_password = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.middlename = new System.Windows.Forms.TextBox();
            this.lastname = new System.Windows.Forms.TextBox();
            this.credit = new Bank.RoundButton();
            this.Back = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Product_head
            // 
            this.Product_head.AutoSize = true;
            this.Product_head.Font = new System.Drawing.Font("Georgia", 19.8F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))));
            this.Product_head.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Product_head.Location = new System.Drawing.Point(347, 11);
            this.Product_head.Name = "Product_head";
            this.Product_head.Size = new System.Drawing.Size(260, 38);
            this.Product_head.TabIndex = 5;
            this.Product_head.Text = "Регистрация";
            // 
            // mail
            // 
            this.mail.AutoSize = true;
            this.mail.Font = new System.Drawing.Font("Georgia", 14.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mail.Location = new System.Drawing.Point(443, 74);
            this.mail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mail.Name = "mail";
            this.mail.Size = new System.Drawing.Size(106, 29);
            this.mail.TabIndex = 6;
            this.mail.Text = "Почта";
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(448, 114);
            this.email.Margin = new System.Windows.Forms.Padding(4);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(405, 22);
            this.email.TabIndex = 7;
            this.email.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lgn
            // 
            this.lgn.AutoSize = true;
            this.lgn.Font = new System.Drawing.Font("Georgia", 14.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lgn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lgn.Location = new System.Drawing.Point(443, 142);
            this.lgn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lgn.Name = "lgn";
            this.lgn.Size = new System.Drawing.Size(94, 29);
            this.lgn.TabIndex = 8;
            this.lgn.Text = "Логин";
            // 
            // new_login
            // 
            this.new_login.Location = new System.Drawing.Point(448, 186);
            this.new_login.Margin = new System.Windows.Forms.Padding(4);
            this.new_login.Name = "new_login";
            this.new_login.Size = new System.Drawing.Size(405, 22);
            this.new_login.TabIndex = 9;
            this.new_login.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // pswrd
            // 
            this.pswrd.AutoSize = true;
            this.pswrd.Font = new System.Drawing.Font("Georgia", 14.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pswrd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pswrd.Location = new System.Drawing.Point(443, 215);
            this.pswrd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pswrd.Name = "pswrd";
            this.pswrd.Size = new System.Drawing.Size(113, 29);
            this.pswrd.TabIndex = 10;
            this.pswrd.Text = "Пароль";
            // 
            // new_password
            // 
            this.new_password.Location = new System.Drawing.Point(448, 250);
            this.new_password.Margin = new System.Windows.Forms.Padding(4);
            this.new_password.Name = "new_password";
            this.new_password.Size = new System.Drawing.Size(405, 22);
            this.new_password.TabIndex = 11;
            // 
            // pswrd_2
            // 
            this.pswrd_2.AutoSize = true;
            this.pswrd_2.Font = new System.Drawing.Font("Georgia", 14.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pswrd_2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pswrd_2.Location = new System.Drawing.Point(443, 292);
            this.pswrd_2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pswrd_2.Name = "pswrd_2";
            this.pswrd_2.Size = new System.Drawing.Size(273, 29);
            this.pswrd_2.TabIndex = 12;
            this.pswrd_2.Text = "Повторите пароль";
            // 
            // confirm_password
            // 
            this.confirm_password.Location = new System.Drawing.Point(448, 337);
            this.confirm_password.Margin = new System.Windows.Forms.Padding(4);
            this.confirm_password.Name = "confirm_password";
            this.confirm_password.Size = new System.Drawing.Size(405, 22);
            this.confirm_password.TabIndex = 13;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(219, 114);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(200, 22);
            this.name.TabIndex = 15;
            // 
            // middlename
            // 
            this.middlename.Location = new System.Drawing.Point(219, 186);
            this.middlename.Name = "middlename";
            this.middlename.Size = new System.Drawing.Size(200, 22);
            this.middlename.TabIndex = 16;
            // 
            // lastname
            // 
            this.lastname.Location = new System.Drawing.Point(219, 250);
            this.lastname.Name = "lastname";
            this.lastname.Size = new System.Drawing.Size(200, 22);
            this.lastname.TabIndex = 17;
            // 
            // credit
            // 
            this.credit.BackColor = System.Drawing.Color.DarkGray;
            this.credit.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.credit.ButtonBorderColor = System.Drawing.Color.Black;
            this.credit.ButtonHighlightColor = System.Drawing.Color.SaddleBrown;
            this.credit.ButtonHighlightColor2 = System.Drawing.Color.SaddleBrown;
            this.credit.ButtonHighlightForeColor = System.Drawing.Color.Black;
            this.credit.ButtonPressedColor = System.Drawing.Color.Chocolate;
            this.credit.ButtonPressedColor2 = System.Drawing.Color.Chocolate;
            this.credit.ButtonPressedForeColor = System.Drawing.Color.Black;
            this.credit.ButtonRoundRadius = 30;
            this.credit.Font = new System.Drawing.Font("Georgia", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.credit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.credit.Location = new System.Drawing.Point(297, 377);
            this.credit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.credit.Name = "credit";
            this.credit.Size = new System.Drawing.Size(352, 76);
            this.credit.TabIndex = 14;
            this.credit.Text = "Зарегистрироваться";
            this.credit.Click += new System.EventHandler(this.credit_Click);
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(980, 11);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(75, 23);
            this.Back.TabIndex = 18;
            this.Back.Text = "Назад";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Georgia", 14.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))));
            this.label5.Location = new System.Drawing.Point(214, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 29);
            this.label5.TabIndex = 19;
            this.label5.Text = "Имя";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Georgia", 14.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))));
            this.label6.Location = new System.Drawing.Point(214, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 29);
            this.label6.TabIndex = 20;
            this.label6.Text = "Отчество";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Georgia", 14.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))));
            this.label7.Location = new System.Drawing.Point(224, 215);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 29);
            this.label7.TabIndex = 21;
            this.label7.Text = "Фамилия";
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.lastname);
            this.Controls.Add(this.middlename);
            this.Controls.Add(this.name);
            this.Controls.Add(this.credit);
            this.Controls.Add(this.confirm_password);
            this.Controls.Add(this.pswrd_2);
            this.Controls.Add(this.new_password);
            this.Controls.Add(this.pswrd);
            this.Controls.Add(this.new_login);
            this.Controls.Add(this.lgn);
            this.Controls.Add(this.email);
            this.Controls.Add(this.mail);
            this.Controls.Add(this.Product_head);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Registration";
            this.Text = "Registration";
            this.Load += new System.EventHandler(this.Registration_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Product_head;
        private System.Windows.Forms.Label mail;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Label lgn;
        private System.Windows.Forms.TextBox new_login;
        private System.Windows.Forms.Label pswrd;
        private System.Windows.Forms.TextBox new_password;
        private System.Windows.Forms.Label pswrd_2;
        private System.Windows.Forms.TextBox confirm_password;
        private RoundButton credit;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox middlename;
        private System.Windows.Forms.TextBox lastname;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}