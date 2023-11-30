namespace Bank.Forms
{
    partial class Form_for_admin
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
            this.credits = new Bank.RoundButton();
            this.ipoteka = new Bank.RoundButton();
            this.users = new Bank.RoundButton();
            this.Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // credits
            // 
            this.credits.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.credits.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.credits.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.credits.ButtonBorderColor = System.Drawing.Color.Black;
            this.credits.ButtonHighlightColor = System.Drawing.Color.Orange;
            this.credits.ButtonHighlightColor2 = System.Drawing.Color.OrangeRed;
            this.credits.ButtonHighlightForeColor = System.Drawing.Color.Black;
            this.credits.ButtonPressedColor = System.Drawing.Color.Red;
            this.credits.ButtonPressedColor2 = System.Drawing.Color.Maroon;
            this.credits.ButtonPressedForeColor = System.Drawing.Color.White;
            this.credits.ButtonRoundRadius = 30;
            this.credits.Font = new System.Drawing.Font("Goudy Stout", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.credits.ForeColor = System.Drawing.Color.White;
            this.credits.Location = new System.Drawing.Point(515, 180);
            this.credits.Margin = new System.Windows.Forms.Padding(10, 4, 10, 4);
            this.credits.Name = "credits";
            this.credits.Size = new System.Drawing.Size(223, 68);
            this.credits.TabIndex = 27;
            this.credits.Text = "Кредиты";
            this.credits.Click += new System.EventHandler(this.credits_Click);
            // 
            // ipoteka
            // 
            this.ipoteka.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.ipoteka.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.ipoteka.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ipoteka.ButtonBorderColor = System.Drawing.Color.Black;
            this.ipoteka.ButtonHighlightColor = System.Drawing.Color.Orange;
            this.ipoteka.ButtonHighlightColor2 = System.Drawing.Color.OrangeRed;
            this.ipoteka.ButtonHighlightForeColor = System.Drawing.Color.Black;
            this.ipoteka.ButtonPressedColor = System.Drawing.Color.Red;
            this.ipoteka.ButtonPressedColor2 = System.Drawing.Color.Maroon;
            this.ipoteka.ButtonPressedForeColor = System.Drawing.Color.White;
            this.ipoteka.ButtonRoundRadius = 30;
            this.ipoteka.Font = new System.Drawing.Font("Goudy Stout", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ipoteka.ForeColor = System.Drawing.Color.White;
            this.ipoteka.Location = new System.Drawing.Point(272, 180);
            this.ipoteka.Margin = new System.Windows.Forms.Padding(10, 4, 10, 4);
            this.ipoteka.Name = "ipoteka";
            this.ipoteka.Size = new System.Drawing.Size(223, 70);
            this.ipoteka.TabIndex = 26;
            this.ipoteka.Text = "Ипотеки";
            this.ipoteka.Click += new System.EventHandler(this.ipoteka_Click);
            // 
            // users
            // 
            this.users.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.users.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.users.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.users.ButtonBorderColor = System.Drawing.Color.Black;
            this.users.ButtonHighlightColor = System.Drawing.Color.Orange;
            this.users.ButtonHighlightColor2 = System.Drawing.Color.OrangeRed;
            this.users.ButtonHighlightForeColor = System.Drawing.Color.Black;
            this.users.ButtonPressedColor = System.Drawing.Color.Red;
            this.users.ButtonPressedColor2 = System.Drawing.Color.Maroon;
            this.users.ButtonPressedForeColor = System.Drawing.Color.White;
            this.users.ButtonRoundRadius = 30;
            this.users.Font = new System.Drawing.Font("Goudy Stout", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.users.ForeColor = System.Drawing.Color.White;
            this.users.Location = new System.Drawing.Point(36, 182);
            this.users.Margin = new System.Windows.Forms.Padding(10, 4, 10, 4);
            this.users.Name = "users";
            this.users.Size = new System.Drawing.Size(216, 68);
            this.users.TabIndex = 25;
            this.users.Text = "Пользователи";
            this.users.Click += new System.EventHandler(this.users_Click);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.Exit.Font = new System.Drawing.Font("Goudy Stout", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.ForeColor = System.Drawing.Color.White;
            this.Exit.Location = new System.Drawing.Point(677, 14);
            this.Exit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(108, 30);
            this.Exit.TabIndex = 30;
            this.Exit.Text = "Выйти";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Back_Click);
            // 
            // Form_for_admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.credits);
            this.Controls.Add(this.ipoteka);
            this.Controls.Add(this.users);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form_for_admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Для администратора";
            this.ResumeLayout(false);

        }

        #endregion

        private RoundButton users;
        private RoundButton ipoteka;
        private RoundButton credits;
        private System.Windows.Forms.Button Exit;
    }
}