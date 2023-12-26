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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registration));
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Product_head
            // 
            this.Product_head.AutoSize = true;
            this.Product_head.Font = new System.Drawing.Font("Goudy Stout", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Product_head.ForeColor = System.Drawing.Color.Black;
            this.Product_head.Location = new System.Drawing.Point(161, 29);
            this.Product_head.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Product_head.Name = "Product_head";
            this.Product_head.Size = new System.Drawing.Size(167, 32);
            this.Product_head.TabIndex = 5;
            this.Product_head.Text = "Регистрация";
            // 
            // mail
            // 
            this.mail.AutoSize = true;
            this.mail.Font = new System.Drawing.Font("Goudy Stout", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mail.ForeColor = System.Drawing.Color.Black;
            this.mail.Location = new System.Drawing.Point(289, 93);
            this.mail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mail.Name = "mail";
            this.mail.Size = new System.Drawing.Size(63, 22);
            this.mail.TabIndex = 6;
            this.mail.Text = "Почта";
            this.mail.Click += new System.EventHandler(this.mail_Click);
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(291, 121);
            this.email.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(151, 20);
            this.email.TabIndex = 7;
            this.email.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lgn
            // 
            this.lgn.AutoSize = true;
            this.lgn.Font = new System.Drawing.Font("Goudy Stout", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lgn.ForeColor = System.Drawing.Color.Black;
            this.lgn.Location = new System.Drawing.Point(289, 143);
            this.lgn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lgn.Name = "lgn";
            this.lgn.Size = new System.Drawing.Size(60, 22);
            this.lgn.TabIndex = 8;
            this.lgn.Text = "Логин";
            this.lgn.Click += new System.EventHandler(this.lgn_Click);
            // 
            // new_login
            // 
            this.new_login.Location = new System.Drawing.Point(291, 171);
            this.new_login.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.new_login.Name = "new_login";
            this.new_login.Size = new System.Drawing.Size(151, 20);
            this.new_login.TabIndex = 9;
            this.new_login.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // pswrd
            // 
            this.pswrd.AutoSize = true;
            this.pswrd.Font = new System.Drawing.Font("Goudy Stout", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pswrd.ForeColor = System.Drawing.Color.Black;
            this.pswrd.Location = new System.Drawing.Point(289, 193);
            this.pswrd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pswrd.Name = "pswrd";
            this.pswrd.Size = new System.Drawing.Size(73, 22);
            this.pswrd.TabIndex = 10;
            this.pswrd.Text = "Пароль";
            this.pswrd.Click += new System.EventHandler(this.pswrd_Click);
            // 
            // new_password
            // 
            this.new_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.new_password.Location = new System.Drawing.Point(291, 221);
            this.new_password.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.new_password.Name = "new_password";
            this.new_password.PasswordChar = '*';
            this.new_password.Size = new System.Drawing.Size(151, 22);
            this.new_password.TabIndex = 11;
            this.new_password.TextChanged += new System.EventHandler(this.new_password_TextChanged);
            // 
            // pswrd_2
            // 
            this.pswrd_2.AutoSize = true;
            this.pswrd_2.Font = new System.Drawing.Font("Goudy Stout", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pswrd_2.ForeColor = System.Drawing.Color.Black;
            this.pswrd_2.Location = new System.Drawing.Point(286, 243);
            this.pswrd_2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pswrd_2.Name = "pswrd_2";
            this.pswrd_2.Size = new System.Drawing.Size(171, 22);
            this.pswrd_2.TabIndex = 12;
            this.pswrd_2.Text = "Повторите пароль";
            this.pswrd_2.Click += new System.EventHandler(this.pswrd_2_Click);
            // 
            // confirm_password
            // 
            this.confirm_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.confirm_password.Location = new System.Drawing.Point(291, 271);
            this.confirm_password.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.confirm_password.Name = "confirm_password";
            this.confirm_password.PasswordChar = '*';
            this.confirm_password.Size = new System.Drawing.Size(151, 22);
            this.confirm_password.TabIndex = 13;
            this.confirm_password.TextChanged += new System.EventHandler(this.confirm_password_TextChanged);
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(71, 171);
            this.name.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(151, 20);
            this.name.TabIndex = 15;
            this.name.TextChanged += new System.EventHandler(this.name_TextChanged);
            // 
            // middlename
            // 
            this.middlename.Location = new System.Drawing.Point(71, 221);
            this.middlename.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.middlename.Name = "middlename";
            this.middlename.Size = new System.Drawing.Size(151, 20);
            this.middlename.TabIndex = 16;
            this.middlename.TextChanged += new System.EventHandler(this.middlename_TextChanged);
            // 
            // lastname
            // 
            this.lastname.Location = new System.Drawing.Point(69, 121);
            this.lastname.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lastname.Name = "lastname";
            this.lastname.Size = new System.Drawing.Size(151, 20);
            this.lastname.TabIndex = 17;
            this.lastname.TextChanged += new System.EventHandler(this.lastname_TextChanged);
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
            this.reg.Font = new System.Drawing.Font("Goudy Stout", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reg.ForeColor = System.Drawing.Color.White;
            this.reg.Location = new System.Drawing.Point(141, 317);
            this.reg.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.reg.Name = "reg";
            this.reg.Size = new System.Drawing.Size(187, 51);
            this.reg.TabIndex = 14;
            this.reg.Text = "Зарегистрироваться";
            this.reg.Click += new System.EventHandler(this.reg_Click);
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.Back.Font = new System.Drawing.Font("Goudy Stout", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.ForeColor = System.Drawing.Color.White;
            this.Back.Location = new System.Drawing.Point(430, 11);
            this.Back.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(71, 26);
            this.Back.TabIndex = 18;
            this.Back.Text = "Назад";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Goudy Stout", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(67, 143);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 22);
            this.label5.TabIndex = 19;
            this.label5.Text = "Имя";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Goudy Stout", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(66, 193);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 22);
            this.label6.TabIndex = 20;
            this.label6.Text = "Отчество";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Goudy Stout", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(66, 93);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 22);
            this.label7.TabIndex = 21;
            this.label7.Text = "Фамилия";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(414, 221);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(28, 20);
            this.button1.TabIndex = 22;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(414, 221);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(28, 22);
            this.button2.TabIndex = 23;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(414, 271);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(28, 22);
            this.button3.TabIndex = 24;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(414, 271);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(28, 20);
            this.button4.TabIndex = 25;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.ClientSize = new System.Drawing.Size(512, 418);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}