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
            this.SuspendLayout();
            // 
            // Summ
            // 
            this.Summ.AutoSize = true;
            this.Summ.Location = new System.Drawing.Point(319, 106);
            this.Summ.Name = "Summ";
            this.Summ.Size = new System.Drawing.Size(48, 16);
            this.Summ.TabIndex = 0;
            this.Summ.Text = "сумма";
            // 
            // Rate
            // 
            this.Rate.AutoSize = true;
            this.Rate.Location = new System.Drawing.Point(319, 157);
            this.Rate.Name = "Rate";
            this.Rate.Size = new System.Drawing.Size(52, 16);
            this.Rate.TabIndex = 1;
            this.Rate.Text = "ставка";
            // 
            // Term
            // 
            this.Term.AutoSize = true;
            this.Term.Location = new System.Drawing.Point(322, 205);
            this.Term.Name = "Term";
            this.Term.Size = new System.Drawing.Size(37, 16);
            this.Term.TabIndex = 2;
            this.Term.Text = "срок";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(112, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Срок";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(109, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ставка";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(109, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "Сумма кредита";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(167, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Ежемесячный платёж";
            // 
            // Payment
            // 
            this.Payment.AutoSize = true;
            this.Payment.Location = new System.Drawing.Point(361, 58);
            this.Payment.Name = "Payment";
            this.Payment.Size = new System.Drawing.Size(55, 16);
            this.Payment.TabIndex = 9;
            this.Payment.Text = "платёж";
            // 
            // Send_req
            // 
            this.Send_req.BackColor = System.Drawing.Color.Gainsboro;
            this.Send_req.BackColor2 = System.Drawing.Color.Silver;
            this.Send_req.ButtonBorderColor = System.Drawing.Color.Black;
            this.Send_req.ButtonHighlightColor = System.Drawing.Color.Orange;
            this.Send_req.ButtonHighlightColor2 = System.Drawing.Color.OrangeRed;
            this.Send_req.ButtonHighlightForeColor = System.Drawing.Color.Black;
            this.Send_req.ButtonPressedColor = System.Drawing.Color.Red;
            this.Send_req.ButtonPressedColor2 = System.Drawing.Color.Maroon;
            this.Send_req.ButtonPressedForeColor = System.Drawing.Color.White;
            this.Send_req.ButtonRoundRadius = 30;
            this.Send_req.Location = new System.Drawing.Point(262, 312);
            this.Send_req.Name = "Send_req";
            this.Send_req.Size = new System.Drawing.Size(100, 40);
            this.Send_req.TabIndex = 8;
            this.Send_req.Text = "Оставить заявку";
            this.Send_req.Click += new System.EventHandler(this.Send_req_Click);
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.Gainsboro;
            this.Back.BackColor2 = System.Drawing.Color.Silver;
            this.Back.ButtonBorderColor = System.Drawing.Color.Black;
            this.Back.ButtonHighlightColor = System.Drawing.Color.Orange;
            this.Back.ButtonHighlightColor2 = System.Drawing.Color.OrangeRed;
            this.Back.ButtonHighlightForeColor = System.Drawing.Color.Black;
            this.Back.ButtonPressedColor = System.Drawing.Color.Red;
            this.Back.ButtonPressedColor2 = System.Drawing.Color.Maroon;
            this.Back.ButtonPressedForeColor = System.Drawing.Color.White;
            this.Back.ButtonRoundRadius = 30;
            this.Back.Location = new System.Drawing.Point(95, 312);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(100, 40);
            this.Back.TabIndex = 7;
            this.Back.Text = "Вернуться к расчёту";
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Credit_counted
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Name = "Credit_counted";
            this.Text = "Credit_counted";
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
    }
}