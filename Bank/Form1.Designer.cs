namespace Bank
{
    partial class Check_conn
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Check = new System.Windows.Forms.Button();
            this.Success = new System.Windows.Forms.Label();
            this.Error = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Check
            // 
            this.Check.Location = new System.Drawing.Point(312, 198);
            this.Check.Name = "Check";
            this.Check.Size = new System.Drawing.Size(75, 23);
            this.Check.TabIndex = 0;
            this.Check.Text = "Check";
            this.Check.UseVisualStyleBackColor = true;
            this.Check.Click += new System.EventHandler(this.button1_Click);
            // 
            // Success
            // 
            this.Success.AutoSize = true;
            this.Success.Location = new System.Drawing.Point(226, 259);
            this.Success.Name = "Success";
            this.Success.Size = new System.Drawing.Size(59, 16);
            this.Success.TabIndex = 1;
            this.Success.Text = "Success";
            this.Success.Visible = false;
            this.Success.Click += new System.EventHandler(this.label1_Click);
            // 
            // Error
            // 
            this.Error.AutoSize = true;
            this.Error.Location = new System.Drawing.Point(431, 259);
            this.Error.Name = "Error";
            this.Error.Size = new System.Drawing.Size(36, 16);
            this.Error.TabIndex = 2;
            this.Error.Text = "Error";
            this.Error.Visible = false;
            // 
            // Check_conn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Error);
            this.Controls.Add(this.Success);
            this.Controls.Add(this.Check);
            this.Name = "Check_conn";
            this.Text = "Проверка соединения";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Check;
        private System.Windows.Forms.Label Success;
        private System.Windows.Forms.Label Error;
    }
}

