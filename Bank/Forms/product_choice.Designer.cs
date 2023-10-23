namespace Bank
{
    partial class Product_choice
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
            this.credit = new Bank.RoundButton();
            this.mortgages = new Bank.RoundButton();
            this.Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Product_head
            // 
            this.Product_head.AutoSize = true;
            this.Product_head.Font = new System.Drawing.Font("Georgia", 19.8F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))));
            this.Product_head.Location = new System.Drawing.Point(72, 66);
            this.Product_head.Name = "Product_head";
            this.Product_head.Size = new System.Drawing.Size(637, 38);
            this.Product_head.TabIndex = 0;
            this.Product_head.Text = "Выберите интересующую услугу";
            // 
            // credit
            // 
            this.credit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.credit.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.credit.ButtonBorderColor = System.Drawing.Color.Black;
            this.credit.ButtonHighlightColor = System.Drawing.Color.SaddleBrown;
            this.credit.ButtonHighlightColor2 = System.Drawing.Color.SaddleBrown;
            this.credit.ButtonHighlightForeColor = System.Drawing.Color.Black;
            this.credit.ButtonPressedColor = System.Drawing.Color.Chocolate;
            this.credit.ButtonPressedColor2 = System.Drawing.Color.Chocolate;
            this.credit.ButtonPressedForeColor = System.Drawing.Color.Black;
            this.credit.ButtonRoundRadius = 30;
            this.credit.Font = new System.Drawing.Font("Georgia", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.credit.Location = new System.Drawing.Point(113, 212);
            this.credit.Name = "credit";
            this.credit.Size = new System.Drawing.Size(154, 62);
            this.credit.TabIndex = 1;
            this.credit.Text = "Кредит";
            this.credit.Click += new System.EventHandler(this.credit_Click);
            // 
            // mortgages
            // 
            this.mortgages.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.mortgages.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.mortgages.ButtonBorderColor = System.Drawing.Color.Black;
            this.mortgages.ButtonHighlightColor = System.Drawing.Color.SaddleBrown;
            this.mortgages.ButtonHighlightColor2 = System.Drawing.Color.SaddleBrown;
            this.mortgages.ButtonHighlightForeColor = System.Drawing.Color.Black;
            this.mortgages.ButtonPressedColor = System.Drawing.Color.Chocolate;
            this.mortgages.ButtonPressedColor2 = System.Drawing.Color.Chocolate;
            this.mortgages.ButtonPressedForeColor = System.Drawing.Color.Black;
            this.mortgages.ButtonRoundRadius = 30;
            this.mortgages.Font = new System.Drawing.Font("Georgia", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mortgages.Location = new System.Drawing.Point(490, 212);
            this.mortgages.Name = "mortgages";
            this.mortgages.Size = new System.Drawing.Size(154, 62);
            this.mortgages.TabIndex = 2;
            this.mortgages.Text = "Ипотека";
            this.mortgages.Click += new System.EventHandler(this.mortgages_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(695, 13);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 3;
            this.Exit.Text = "Выход";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Product_choice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.mortgages);
            this.Controls.Add(this.credit);
            this.Controls.Add(this.Product_head);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.Name = "Product_choice";
            this.Text = "Продукты";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Product_head;
        private RoundButton credit;
        private RoundButton mortgages;
        private System.Windows.Forms.Button Exit;
    }
}