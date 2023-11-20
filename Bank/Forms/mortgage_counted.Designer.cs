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
            this.Back = new Bank.RoundButton();
            this.Send_req = new Bank.RoundButton();
            this.label1 = new System.Windows.Forms.Label();
            this.Monthly_pay = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Term_show = new System.Windows.Forms.Label();
            this.Start_summ = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Credit_summ
            // 
            this.Credit_summ.AutoSize = true;
            this.Credit_summ.Font = new System.Drawing.Font("Goudy Stout", 14.25F);
            this.Credit_summ.ForeColor = System.Drawing.Color.Black;
            this.Credit_summ.Location = new System.Drawing.Point(43, 110);
            this.Credit_summ.Name = "Credit_summ";
            this.Credit_summ.Size = new System.Drawing.Size(162, 26);
            this.Credit_summ.TabIndex = 1;
            this.Credit_summ.Text = "Сумма кредита:";
            // 
            // Rate
            // 
            this.Rate.AutoSize = true;
            this.Rate.Font = new System.Drawing.Font("Goudy Stout", 14.25F);
            this.Rate.ForeColor = System.Drawing.Color.Black;
            this.Rate.Location = new System.Drawing.Point(43, 155);
            this.Rate.Name = "Rate";
            this.Rate.Size = new System.Drawing.Size(240, 26);
            this.Rate.TabIndex = 2;
            this.Rate.Text = "Начисленные проценты:";
            // 
            // Term
            // 
            this.Term.AutoSize = true;
            this.Term.Font = new System.Drawing.Font("Goudy Stout", 14.25F);
            this.Term.ForeColor = System.Drawing.Color.Black;
            this.Term.Location = new System.Drawing.Point(43, 204);
            this.Term.Name = "Term";
            this.Term.Size = new System.Drawing.Size(214, 26);
            this.Term.TabIndex = 3;
            this.Term.Text = "Кредит + Проценты:";
            // 
            // Summ_show
            // 
            this.Summ_show.AutoSize = true;
            this.Summ_show.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.Summ_show.Location = new System.Drawing.Point(264, 113);
            this.Summ_show.Name = "Summ_show";
            this.Summ_show.Size = new System.Drawing.Size(140, 20);
            this.Summ_show.TabIndex = 4;
            this.Summ_show.Text = "Итого_платить";
            this.Summ_show.Click += new System.EventHandler(this.Summ_show_Click);
            // 
            // Rate_show
            // 
            this.Rate_show.AutoSize = true;
            this.Rate_show.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.Rate_show.Location = new System.Drawing.Point(368, 159);
            this.Rate_show.Name = "Rate_show";
            this.Rate_show.Size = new System.Drawing.Size(94, 20);
            this.Rate_show.TabIndex = 5;
            this.Rate_show.Text = "Проценты";
            this.Rate_show.Click += new System.EventHandler(this.Rate_show_Click);
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
            this.Back.Font = new System.Drawing.Font("Goudy Stout", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.ForeColor = System.Drawing.Color.White;
            this.Back.Location = new System.Drawing.Point(36, 272);
            this.Back.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(201, 52);
            this.Back.TabIndex = 9;
            this.Back.Text = "Вернуться к расчёту";
            this.Back.Click += new System.EventHandler(this.Back_Click_1);
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
            this.Send_req.Font = new System.Drawing.Font("Goudy Stout", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Send_req.ForeColor = System.Drawing.Color.White;
            this.Send_req.Location = new System.Drawing.Point(254, 272);
            this.Send_req.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Send_req.Name = "Send_req";
            this.Send_req.Size = new System.Drawing.Size(188, 52);
            this.Send_req.TabIndex = 8;
            this.Send_req.Text = "Оставить заявку";
            this.Send_req.Click += new System.EventHandler(this.Send_req_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.label1.Font = new System.Drawing.Font("Goudy Stout", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(97, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(418, 37);
            this.label1.TabIndex = 10;
            this.label1.Text = "Ваш ежемесячный платеж";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Monthly_pay
            // 
            this.Monthly_pay.AutoSize = true;
            this.Monthly_pay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Monthly_pay.Location = new System.Drawing.Point(178, 56);
            this.Monthly_pay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Monthly_pay.Name = "Monthly_pay";
            this.Monthly_pay.Size = new System.Drawing.Size(197, 20);
            this.Monthly_pay.TabIndex = 11;
            this.Monthly_pay.Text = "ежемесячный_платёж";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Goudy Stout", 14.25F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(41, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(244, 32);
            this.label3.TabIndex = 12;
            this.label3.Text = "График платежей:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Goudy Stout", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(505, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 27);
            this.label2.TabIndex = 14;
            this.label2.Text = "тыс";
            // 
            // Term_show
            // 
            this.Term_show.AutoSize = true;
            this.Term_show.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.Term_show.Location = new System.Drawing.Point(333, 208);
            this.Term_show.Name = "Term_show";
            this.Term_show.Size = new System.Drawing.Size(135, 20);
            this.Term_show.TabIndex = 6;
            this.Term_show.Text = "Срок_выплаты";
            this.Term_show.Click += new System.EventHandler(this.Term_show_Click);
            // 
            // Start_summ
            // 
            this.Start_summ.AutoSize = true;
            this.Start_summ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.Start_summ.Location = new System.Drawing.Point(267, 157);
            this.Start_summ.Name = "Start_summ";
            this.Start_summ.Size = new System.Drawing.Size(153, 25);
            this.Start_summ.TabIndex = 15;
            this.Start_summ.Text = "Сумма займа";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Goudy Stout", 14.25F);
            this.label3.Location = new System.Drawing.Point(50, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(219, 32);
            this.label3.TabIndex = 16;
            this.label3.Text = "Количество лет:";
            // 
            // mortgage_counted
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Monthly_pay);
            this.Controls.Add(this.label1);
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
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Рассчёт ипотеки";
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
        private RoundButton Send_req;
        private RoundButton Back;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Monthly_pay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Term_show;
        private System.Windows.Forms.Label Start_summ;
    }
}