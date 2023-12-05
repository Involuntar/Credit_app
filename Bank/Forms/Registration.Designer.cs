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
            this.reg = new Bank.RoundButton();
            this.Back = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Product_head
            // 
            this.Product_head.AutoSize = true;
            this.Product_head.Font = new System.Drawing.Font("Goudy Stout", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Product_head.ForeColor = System.Drawing.Color.Black;
            this.Product_head.Location = new System.Drawing.Point(355, 11);
            this.Product_head.Name = "Product_head";
            this.Product_head.Size = new System.Drawing.Size(266, 51);
            this.Product_head.TabIndex = 5;
            this.Product_head.Text = "Регистрация";
            // 
            // mail
            // 
            this.mail.AutoSize = true;
            this.mail.Font = new System.Drawing.Font("Goudy Stout", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mail.ForeColor = System.Drawing.Color.Black;
            this.mail.Location = new System.Drawing.Point(418, 74);
            this.mail.Name = "mail";
            this.mail.Size = new System.Drawing.Size(81, 28);
            this.mail.TabIndex = 6;
            this.mail.Text = "Почта";
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(422, 107);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(405, 22);
            this.email.TabIndex = 7;
            this.email.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lgn
            // 
            this.lgn.AutoSize = true;
            this.lgn.Font = new System.Drawing.Font("Goudy Stout", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lgn.ForeColor = System.Drawing.Color.Black;
            this.lgn.Location = new System.Drawing.Point(418, 129);
            this.lgn.Name = "lgn";
            this.lgn.Size = new System.Drawing.Size(81, 28);
            this.lgn.TabIndex = 8;
            this.lgn.Text = "Логин";
            // 
            // new_login
            // 
            this.new_login.Location = new System.Drawing.Point(422, 165);
            this.new_login.Name = "new_login";
            this.new_login.Size = new System.Drawing.Size(405, 22);
            this.new_login.TabIndex = 9;
            this.new_login.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // pswrd
            // 
            this.pswrd.AutoSize = true;
            this.pswrd.Font = new System.Drawing.Font("Goudy Stout", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pswrd.ForeColor = System.Drawing.Color.Black;
            this.pswrd.Location = new System.Drawing.Point(418, 189);
            this.pswrd.Name = "pswrd";
            this.pswrd.Size = new System.Drawing.Size(95, 28);
            this.pswrd.TabIndex = 10;
            this.pswrd.Text = "Пароль";
            // 
            // new_password
            // 
            this.new_password.Location = new System.Drawing.Point(422, 217);
            this.new_password.Name = "new_password";
            this.new_password.PasswordChar = '*';
            this.new_password.Size = new System.Drawing.Size(405, 22);
            this.new_password.TabIndex = 11;
            this.new_password.TextChanged += new System.EventHandler(this.new_password_TextChanged);
            // 
            // pswrd_2
            // 
            this.pswrd_2.AutoSize = true;
            this.pswrd_2.Font = new System.Drawing.Font("Goudy Stout", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pswrd_2.ForeColor = System.Drawing.Color.Black;
            this.pswrd_2.Location = new System.Drawing.Point(418, 251);
            this.pswrd_2.Name = "pswrd_2";
            this.pswrd_2.Size = new System.Drawing.Size(226, 28);
            this.pswrd_2.TabIndex = 12;
            this.pswrd_2.Text = "Повторите пароль";
            // 
            // confirm_password
            // 
            this.confirm_password.Location = new System.Drawing.Point(422, 288);
            this.confirm_password.Name = "confirm_password";
            this.confirm_password.PasswordChar = '*';
            this.confirm_password.Size = new System.Drawing.Size(405, 22);
            this.confirm_password.TabIndex = 13;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(117, 165);
            this.name.Margin = new System.Windows.Forms.Padding(2);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(200, 22);
            this.name.TabIndex = 15;
            // 
            // middlename
            // 
            this.middlename.Location = new System.Drawing.Point(116, 228);
            this.middlename.Margin = new System.Windows.Forms.Padding(2);
            this.middlename.Name = "middlename";
            this.middlename.Size = new System.Drawing.Size(200, 22);
            this.middlename.TabIndex = 16;
            this.middlename.TextChanged += new System.EventHandler(this.middlename_TextChanged);
            // 
            // lastname
            // 
            this.lastname.Location = new System.Drawing.Point(116, 107);
            this.lastname.Margin = new System.Windows.Forms.Padding(2);
            this.lastname.Name = "lastname";
            this.lastname.Size = new System.Drawing.Size(200, 22);
            this.lastname.TabIndex = 17;
            // 
            // reg
            // 
            this.reg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.reg.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.reg.ButtonBorderColor = System.Drawing.Color.White;
            this.reg.ButtonHighlightColor = System.Drawing.Color.SaddleBrown;
            this.reg.ButtonHighlightColor2 = System.Drawing.Color.SaddleBrown;
            this.reg.ButtonHighlightForeColor = System.Drawing.Color.White;
            this.reg.ButtonPressedColor = System.Drawing.Color.Chocolate;
            this.reg.ButtonPressedColor2 = System.Drawing.Color.Chocolate;
            this.reg.ButtonPressedForeColor = System.Drawing.Color.White;
            this.reg.ButtonRoundRadius = 30;
            this.reg.Font = new System.Drawing.Font("Goudy Stout", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reg.ForeColor = System.Drawing.Color.White;
            this.reg.Location = new System.Drawing.Point(244, 352);
            this.reg.Margin = new System.Windows.Forms.Padding(2);
            this.reg.Name = "reg";
            this.reg.Size = new System.Drawing.Size(264, 62);
            this.reg.TabIndex = 14;
            this.reg.Text = "Зарегистрироваться";
            this.reg.Click += new System.EventHandler(this.reg_Click);
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.Back.Font = new System.Drawing.Font("Goudy Stout", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.ForeColor = System.Drawing.Color.White;
            this.Back.Location = new System.Drawing.Point(960, 11);
            this.Back.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(95, 34);
            this.Back.TabIndex = 18;
            this.Back.Text = "Назад";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Goudy Stout", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(112, 129);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 28);
            this.label5.TabIndex = 19;
            this.label5.Text = "Имя";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Goudy Stout", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(113, 189);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 28);
            this.label6.TabIndex = 20;
            this.label6.Text = "Отчество";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Goudy Stout", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(112, 74);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 28);
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
            this.Controls.Add(this.reg);
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
            this.Text = "Регистрация";
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
        private RoundButton reg;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox middlename;
        private System.Windows.Forms.TextBox lastname;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}