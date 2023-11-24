namespace Bank
{
    partial class Grafic_show
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
            this.dataGridGraf = new System.Windows.Forms.DataGridView();
            this.month = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ost_debt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.procent_part = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.debt_part = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.end_debt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridGraf)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridGraf
            // 
            this.dataGridGraf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridGraf.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.month,
            this.ost_debt,
            this.payment,
            this.procent_part,
            this.debt_part,
            this.end_debt});
            this.dataGridGraf.Location = new System.Drawing.Point(22, 23);
            this.dataGridGraf.Name = "dataGridGraf";
            this.dataGridGraf.Size = new System.Drawing.Size(644, 392);
            this.dataGridGraf.TabIndex = 0;
            // 
            // month
            // 
            this.month.HeaderText = "Месяцы";
            this.month.Name = "month";
            // 
            // ost_debt
            // 
            this.ost_debt.HeaderText = "Остаток долга";
            this.ost_debt.Name = "ost_debt";
            // 
            // payment
            // 
            this.payment.HeaderText = "Платеж";
            this.payment.Name = "payment";
            // 
            // procent_part
            // 
            this.procent_part.HeaderText = "Процентная часть";
            this.procent_part.Name = "procent_part";
            // 
            // debt_part
            // 
            this.debt_part.HeaderText = "Долговая часть";
            this.debt_part.Name = "debt_part";
            // 
            // end_debt
            // 
            this.end_debt.HeaderText = "Остаток долга на конец периода";
            this.end_debt.Name = "end_debt";
            // 
            // Grafic_show
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridGraf);
            this.Name = "Grafic_show";
            this.Text = "Вывод графика";
            this.Load += new System.EventHandler(this.Grafic_show_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridGraf)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridGraf;
        private System.Windows.Forms.DataGridViewTextBoxColumn month;
        private System.Windows.Forms.DataGridViewTextBoxColumn ost_debt;
        private System.Windows.Forms.DataGridViewTextBoxColumn payment;
        private System.Windows.Forms.DataGridViewTextBoxColumn procent_part;
        private System.Windows.Forms.DataGridViewTextBoxColumn debt_part;
        private System.Windows.Forms.DataGridViewTextBoxColumn end_debt;
    }
}