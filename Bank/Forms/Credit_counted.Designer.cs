namespace Bank.Forms
{
    partial class Credit_counted
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
            this.Summ = new System.Windows.Forms.Label();
            this.Rate = new System.Windows.Forms.Label();
            this.Term = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Payment = new System.Windows.Forms.Label();
            this.Send_req = new Bank.RoundButton();
            this.Back = new Bank.RoundButton();
            this.graf_cr = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Summ
            // 
            this.Summ.AutoSize = true;
            this.Summ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.Summ.Location = new System.Drawing.Point(262, 130);
            this.Summ.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Summ.Name = "Summ";
            this.Summ.Size = new System.Drawing.Size(60, 20);
            this.Summ.TabIndex = 0;
            this.Summ.Text = "сумма";
            // 
            // Rate
            // 
            this.Rate.AutoSize = true;
            this.Rate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.Rate.Location = new System.Drawing.Point(190, 172);
            this.Rate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Rate.Name = "Rate";
            this.Rate.Size = new System.Drawing.Size(67, 20);
            this.Rate.TabIndex = 1;
            this.Rate.Text = "ставка";
            // 
            // Term
            // 
            this.Term.AutoSize = true;
            this.Term.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.Term.Location = new System.Drawing.Point(190, 211);
            this.Term.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Term.Name = "Term";
            this.Term.Size = new System.Drawing.Size(47, 20);
            this.Term.TabIndex = 2;
            this.Term.Text = "срок";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Goudy Stout", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(85, 208);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 26);
            this.label4.TabIndex = 5;
            this.label4.Text = "Срок:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Goudy Stout", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(85, 169);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 26);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ставка:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Goudy Stout", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(85, 127);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 26);
            this.label6.TabIndex = 3;
            this.label6.Text = "Сумма кредита:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Goudy Stout", 20.25F);
            this.label7.Location = new System.Drawing.Point(83, 31);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(418, 37);
            this.label7.TabIndex = 6;
            this.label7.Text = "Ваш ежемесячный платёж";
            // 
            // Payment
            // 
            this.Payment.AutoSize = true;
            this.Payment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.Payment.Location = new System.Drawing.Point(262, 80);
            this.Payment.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Payment.Name = "Payment";
            this.Payment.Size = new System.Drawing.Size(72, 20);
            this.Payment.TabIndex = 9;
            this.Payment.Text = "платёж";
            // 
            // Send_req
            // 
            this.Send_req.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.Send_req.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.Send_req.ButtonBorderColor = System.Drawing.Color.Black;
            this.Send_req.ButtonHighlightColor = System.Drawing.Color.Orange;
            this.Send_req.ButtonHighlightColor2 = System.Drawing.Color.OrangeRed;
            this.Send_req.ButtonHighlightForeColor = System.Drawing.Color.Black;
            this.Send_req.ButtonPressedColor = System.Drawing.Color.Red;
            this.Send_req.ButtonPressedColor2 = System.Drawing.Color.Maroon;
            this.Send_req.ButtonPressedForeColor = System.Drawing.Color.White;
            this.Send_req.ButtonRoundRadius = 30;
            this.Send_req.Font = new System.Drawing.Font("Goudy Stout", 12F);
            this.Send_req.ForeColor = System.Drawing.Color.White;
            this.Send_req.Location = new System.Drawing.Point(307, 275);
            this.Send_req.Margin = new System.Windows.Forms.Padding(2);
            this.Send_req.Name = "Send_req";
            this.Send_req.Size = new System.Drawing.Size(194, 51);
            this.Send_req.TabIndex = 8;
            this.Send_req.Text = "Оставить заявку";
            this.Send_req.Click += new System.EventHandler(this.Send_req_Click);
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.Back.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.Back.ButtonBorderColor = System.Drawing.Color.Black;
            this.Back.ButtonHighlightColor = System.Drawing.Color.Orange;
            this.Back.ButtonHighlightColor2 = System.Drawing.Color.OrangeRed;
            this.Back.ButtonHighlightForeColor = System.Drawing.Color.Black;
            this.Back.ButtonPressedColor = System.Drawing.Color.Red;
            this.Back.ButtonPressedColor2 = System.Drawing.Color.Maroon;
            this.Back.ButtonPressedForeColor = System.Drawing.Color.White;
            this.Back.ButtonRoundRadius = 30;
            this.Back.Font = new System.Drawing.Font("Goudy Stout", 12F);
            this.Back.ForeColor = System.Drawing.Color.White;
            this.Back.Location = new System.Drawing.Point(90, 275);
            this.Back.Margin = new System.Windows.Forms.Padding(2);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(194, 51);
            this.Back.TabIndex = 7;
            this.Back.Text = "Вернуться к расчёту";
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // graf_cr
            // 
            this.graf_cr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.graf_cr.Font = new System.Drawing.Font("Goudy Stout", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.graf_cr.ForeColor = System.Drawing.Color.White;
            this.graf_cr.Location = new System.Drawing.Point(341, 207);
            this.graf_cr.Name = "graf_cr";
            this.graf_cr.Size = new System.Drawing.Size(160, 32);
            this.graf_cr.TabIndex = 10;
            this.graf_cr.Text = "График платежей";
            this.graf_cr.UseVisualStyleBackColor = false;
            this.graf_cr.Click += new System.EventHandler(this.graf_cr_Click);
            // 
            // Credit_counted
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.graf_cr);
            this.Controls.Add(this.Payment);
            this.Controls.Add(this.Send_req);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Term);
            this.Controls.Add(this.Rate);
            this.Controls.Add(this.Summ);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Credit_counted";
            this.Text = "Расчёт кредита";
            this.Load += new System.EventHandler(this.Credit_counted_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Summ;
        private System.Windows.Forms.Label Rate;
        private System.Windows.Forms.Label Term;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private RoundButton Back;
        private RoundButton Send_req;
        private System.Windows.Forms.Label Payment;
        private System.Windows.Forms.Button graf_cr;
    }
}