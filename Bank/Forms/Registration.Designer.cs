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
            this.label1 = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.new_login = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.new_password = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.confirm_password = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.middlename = new System.Windows.Forms.TextBox();
            this.lastname = new System.Windows.Forms.TextBox();
            this.credit = new Bank.RoundButton();
            this.Back = new System.Windows.Forms.Button();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 14.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(268, 71);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Почта";
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(273, 111);
            this.email.Margin = new System.Windows.Forms.Padding(4);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(405, 22);
            this.email.TabIndex = 7;
            this.email.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 14.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(268, 139);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 29);
            this.label2.TabIndex = 8;
            this.label2.Text = "Логин";
            // 
            // new_login
            // 
            this.new_login.Location = new System.Drawing.Point(273, 183);
            this.new_login.Margin = new System.Windows.Forms.Padding(4);
            this.new_login.Name = "new_login";
            this.new_login.Size = new System.Drawing.Size(405, 22);
            this.new_login.TabIndex = 9;
            this.new_login.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 14.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(268, 212);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 29);
            this.label3.TabIndex = 10;
            this.label3.Text = "Пароль";
            // 
            // new_password
            // 
            this.new_password.Location = new System.Drawing.Point(273, 247);
            this.new_password.Margin = new System.Windows.Forms.Padding(4);
            this.new_password.Name = "new_password";
            this.new_password.Size = new System.Drawing.Size(405, 22);
            this.new_password.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 14.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(268, 289);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(273, 29);
            this.label4.TabIndex = 12;
            this.label4.Text = "Повторите пароль";
            // 
            // confirm_password
            // 
            this.confirm_password.Location = new System.Drawing.Point(273, 334);
            this.confirm_password.Margin = new System.Windows.Forms.Padding(4);
            this.confirm_password.Name = "confirm_password";
            this.confirm_password.Size = new System.Drawing.Size(405, 22);
            this.confirm_password.TabIndex = 13;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(806, 201);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(100, 22);
            this.name.TabIndex = 15;
            // 
            // middlename
            // 
            this.middlename.Location = new System.Drawing.Point(806, 246);
            this.middlename.Name = "middlename";
            this.middlename.Size = new System.Drawing.Size(100, 22);
            this.middlename.TabIndex = 16;
            // 
            // lastname
            // 
            this.lastname.Location = new System.Drawing.Point(806, 289);
            this.lastname.Name = "lastname";
            this.lastname.Size = new System.Drawing.Size(100, 22);
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
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.lastname);
            this.Controls.Add(this.middlename);
            this.Controls.Add(this.name);
            this.Controls.Add(this.credit);
            this.Controls.Add(this.confirm_password);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.new_password);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.new_login);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.email);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox new_login;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox new_password;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox confirm_password;
        private RoundButton credit;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox middlename;
        private System.Windows.Forms.TextBox lastname;
        private System.Windows.Forms.Button Back;
    }
}