namespace Bank.Forms
{
    partial class mortgage_counted
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
            this.Credit_summ = new System.Windows.Forms.Label();
            this.Rate = new System.Windows.Forms.Label();
            this.Term = new System.Windows.Forms.Label();
            this.Summ_show = new System.Windows.Forms.Label();
            this.Rate_show = new System.Windows.Forms.Label();
            this.Term_show = new System.Windows.Forms.Label();
            this.Back = new Bank.RoundButton();
            this.Send_req = new Bank.RoundButton();
            this.SuspendLayout();
            // 
            // Credit_summ
            // 
            this.Credit_summ.AutoSize = true;
            this.Credit_summ.Location = new System.Drawing.Point(74, 80);
            this.Credit_summ.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Credit_summ.Name = "Credit_summ";
            this.Credit_summ.Size = new System.Drawing.Size(85, 13);
            this.Credit_summ.TabIndex = 1;
            this.Credit_summ.Text = "Сумма кредита";
            // 
            // Rate
            // 
            this.Rate.AutoSize = true;
            this.Rate.Location = new System.Drawing.Point(74, 168);
            this.Rate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Rate.Name = "Rate";
            this.Rate.Size = new System.Drawing.Size(43, 13);
            this.Rate.TabIndex = 2;
            this.Rate.Text = "Ставка";
            // 
            // Term
            // 
            this.Term.AutoSize = true;
            this.Term.Location = new System.Drawing.Point(74, 191);
            this.Term.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Term.Name = "Term";
            this.Term.Size = new System.Drawing.Size(32, 13);
            this.Term.TabIndex = 3;
            this.Term.Text = "Срок";
            // 
            // Summ_show
            // 
            this.Summ_show.AutoSize = true;
            this.Summ_show.Location = new System.Drawing.Point(191, 80);
            this.Summ_show.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Summ_show.Name = "Summ_show";
            this.Summ_show.Size = new System.Drawing.Size(35, 13);
            this.Summ_show.TabIndex = 4;
            this.Summ_show.Text = "label4";
            // 
            // Rate_show
            // 
            this.Rate_show.AutoSize = true;
            this.Rate_show.Location = new System.Drawing.Point(153, 168);
            this.Rate_show.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Rate_show.Name = "Rate_show";
            this.Rate_show.Size = new System.Drawing.Size(25, 13);
            this.Rate_show.TabIndex = 5;
            this.Rate_show.Text = "rate";
            // 
            // Term_show
            // 
            this.Term_show.AutoSize = true;
            this.Term_show.Location = new System.Drawing.Point(153, 190);
            this.Term_show.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Term_show.Name = "Term_show";
            this.Term_show.Size = new System.Drawing.Size(35, 13);
            this.Term_show.TabIndex = 6;
            this.Term_show.Text = "label6";
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
            this.Back.Location = new System.Drawing.Point(176, 300);
            this.Back.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(75, 32);
            this.Back.TabIndex = 9;
            this.Back.Text = "Вернуться к расчёту";
            this.Back.Click += new System.EventHandler(this.Back_Click_1);
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
            this.Send_req.Location = new System.Drawing.Point(59, 300);
            this.Send_req.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Send_req.Name = "Send_req";
            this.Send_req.Size = new System.Drawing.Size(75, 32);
            this.Send_req.TabIndex = 8;
            this.Send_req.Text = "Оставить заявку";
            this.Send_req.Click += new System.EventHandler(this.Send_req_Click);
            // 
            // mortgage_counted
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Send_req);
            this.Controls.Add(this.Term_show);
            this.Controls.Add(this.Rate_show);
            this.Controls.Add(this.Summ_show);
            this.Controls.Add(this.Term);
            this.Controls.Add(this.Rate);
            this.Controls.Add(this.Credit_summ);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "mortgage_counted";
            this.Text = "mortgage_counted";
            this.Load += new System.EventHandler(this.mortgage_counted_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Credit_summ;
        private System.Windows.Forms.Label Rate;
        private System.Windows.Forms.Label Term;
        private System.Windows.Forms.Label Summ_show;
        private System.Windows.Forms.Label Rate_show;
        private System.Windows.Forms.Label Term_show;
        private RoundButton Send_req;
        private RoundButton Back;
    }
}