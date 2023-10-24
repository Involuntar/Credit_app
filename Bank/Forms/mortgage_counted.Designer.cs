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
            this.Send_req = new System.Windows.Forms.Button();
            this.Credit_summ = new System.Windows.Forms.Label();
            this.Rate = new System.Windows.Forms.Label();
            this.Term = new System.Windows.Forms.Label();
            this.Summ_show = new System.Windows.Forms.Label();
            this.Rate_show = new System.Windows.Forms.Label();
            this.Term_show = new System.Windows.Forms.Label();
            this.Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Send_req
            // 
            this.Send_req.Location = new System.Drawing.Point(85, 369);
            this.Send_req.Name = "Send_req";
            this.Send_req.Size = new System.Drawing.Size(130, 44);
            this.Send_req.TabIndex = 0;
            this.Send_req.Text = "Оставить\r\nзаявку";
            this.Send_req.UseVisualStyleBackColor = true;
            // 
            // Credit_summ
            // 
            this.Credit_summ.AutoSize = true;
            this.Credit_summ.Location = new System.Drawing.Point(98, 99);
            this.Credit_summ.Name = "Credit_summ";
            this.Credit_summ.Size = new System.Drawing.Size(107, 16);
            this.Credit_summ.TabIndex = 1;
            this.Credit_summ.Text = "Сумма кредита";
            // 
            // Rate
            // 
            this.Rate.AutoSize = true;
            this.Rate.Location = new System.Drawing.Point(98, 207);
            this.Rate.Name = "Rate";
            this.Rate.Size = new System.Drawing.Size(54, 16);
            this.Rate.TabIndex = 2;
            this.Rate.Text = "Ставка";
            // 
            // Term
            // 
            this.Term.AutoSize = true;
            this.Term.Location = new System.Drawing.Point(98, 235);
            this.Term.Name = "Term";
            this.Term.Size = new System.Drawing.Size(39, 16);
            this.Term.TabIndex = 3;
            this.Term.Text = "Срок";
            // 
            // Summ_show
            // 
            this.Summ_show.AutoSize = true;
            this.Summ_show.Location = new System.Drawing.Point(255, 99);
            this.Summ_show.Name = "Summ_show";
            this.Summ_show.Size = new System.Drawing.Size(44, 16);
            this.Summ_show.TabIndex = 4;
            this.Summ_show.Text = "label4";
            // 
            // Rate_show
            // 
            this.Rate_show.AutoSize = true;
            this.Rate_show.Location = new System.Drawing.Point(204, 207);
            this.Rate_show.Name = "Rate_show";
            this.Rate_show.Size = new System.Drawing.Size(30, 16);
            this.Rate_show.TabIndex = 5;
            this.Rate_show.Text = "rate";
            // 
            // Term_show
            // 
            this.Term_show.AutoSize = true;
            this.Term_show.Location = new System.Drawing.Point(204, 234);
            this.Term_show.Name = "Term_show";
            this.Term_show.Size = new System.Drawing.Size(44, 16);
            this.Term_show.TabIndex = 6;
            this.Term_show.Text = "label6";
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(227, 369);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(108, 44);
            this.Back.TabIndex = 7;
            this.Back.Text = "Вернуться\r\nк расчёту";
            this.Back.UseVisualStyleBackColor = true;
            // 
            // mortgage_counted
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Term_show);
            this.Controls.Add(this.Rate_show);
            this.Controls.Add(this.Summ_show);
            this.Controls.Add(this.Term);
            this.Controls.Add(this.Rate);
            this.Controls.Add(this.Credit_summ);
            this.Controls.Add(this.Send_req);
            this.Name = "mortgage_counted";
            this.Text = "mortgage_counted";
            this.Load += new System.EventHandler(this.mortgage_counted_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Send_req;
        private System.Windows.Forms.Label Credit_summ;
        private System.Windows.Forms.Label Rate;
        private System.Windows.Forms.Label Term;
        private System.Windows.Forms.Label Summ_show;
        private System.Windows.Forms.Label Rate_show;
        private System.Windows.Forms.Label Term_show;
        private System.Windows.Forms.Button Back;
    }
}