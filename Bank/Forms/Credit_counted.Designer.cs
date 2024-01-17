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
            this.Summ.Location = new System.Drawing.Point(330, 134);
            this.Summ.Margin = new System.Windows.Forms.Padding(50, 0, 3, 0);
            this.Summ.Name = "Summ";
            this.Summ.Size = new System.Drawing.Size(80, 25);
            this.Summ.TabIndex = 0;
            this.Summ.Text = "сумма";
            // 
            // Rate
            // 
            this.Rate.AutoSize = true;
            this.Rate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.Rate.Location = new System.Drawing.Point(430, 189);
            this.Rate.Margin = new System.Windows.Forms.Padding(50, 0, 3, 0);
            this.Rate.Name = "Rate";
            this.Rate.Size = new System.Drawing.Size(113, 25);
            this.Rate.TabIndex = 1;
            this.Rate.Text = "проценты";
            // 
            // Term
            // 
            this.Term.AutoSize = true;
            this.Term.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.Term.Location = new System.Drawing.Point(197, 244);
            this.Term.Margin = new System.Windows.Forms.Padding(50, 0, 3, 0);
            this.Term.Name = "Term";
            this.Term.Size = new System.Drawing.Size(58, 25);
            this.Term.TabIndex = 2;
            this.Term.Text = "срок";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Goudy Stout", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(60, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 32);
            this.label4.TabIndex = 5;
            this.label4.Text = "Срок:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Goudy Stout", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(60, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(317, 32);
            this.label5.TabIndex = 4;
            this.label5.Text = "Начисленные проценты:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Goudy Stout", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(60, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(217, 32);
            this.label6.TabIndex = 3;
            this.label6.Text = "Сумма кредита:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Goudy Stout", 20.25F);
            this.label7.Location = new System.Drawing.Point(130, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(505, 47);
            this.label7.TabIndex = 6;
            this.label7.Text = "Ваш ежемесячный платёж";
            // 
            // Payment
            // 
            this.Payment.AutoSize = true;
            this.Payment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.Payment.Location = new System.Drawing.Point(240, 80);
            this.Payment.Name = "Payment";
            this.Payment.Size = new System.Drawing.Size(91, 25);
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
            this.Send_req.Location = new System.Drawing.Point(340, 335);
            this.Send_req.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Send_req.Name = "Send_req";
            this.Send_req.Size = new System.Drawing.Size(265, 65);
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
            this.Back.Location = new System.Drawing.Point(50, 335);
            this.Back.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(265, 65);
            this.Back.TabIndex = 7;
            this.Back.Text = "Вернуться к расчёту";
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // graf_cr
            // 
            this.graf_cr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.graf_cr.Font = new System.Drawing.Font("Goudy Stout", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.graf_cr.ForeColor = System.Drawing.Color.White;
            this.graf_cr.Location = new System.Drawing.Point(422, 240);
            this.graf_cr.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.graf_cr.Name = "graf_cr";
            this.graf_cr.Size = new System.Drawing.Size(213, 39);
            this.graf_cr.TabIndex = 10;
            this.graf_cr.Text = "График платежей";
            this.graf_cr.UseVisualStyleBackColor = false;
            this.graf_cr.Click += new System.EventHandler(this.graf_cr_Click);
            // 
            // Credit_counted
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Credit_counted";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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