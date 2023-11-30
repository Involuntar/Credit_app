namespace Bank.Forms
{
    partial class Graphic
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
            this.dataGridGraphic = new System.Windows.Forms.DataGridView();
            this.Month = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remain = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Payment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Percents = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Debt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Balance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridGraphic)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridGraphic
            // 
            this.dataGridGraphic.AllowUserToAddRows = false;
            this.dataGridGraphic.AllowUserToDeleteRows = false;
            this.dataGridGraphic.AllowUserToResizeColumns = false;
            this.dataGridGraphic.AllowUserToResizeRows = false;
            this.dataGridGraphic.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridGraphic.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridGraphic.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridGraphic.ColumnHeadersHeight = 29;
            this.dataGridGraphic.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridGraphic.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Month,
            this.Remain,
            this.Payment,
            this.Percents,
            this.Debt,
            this.Balance});
            this.dataGridGraphic.Location = new System.Drawing.Point(12, 151);
            this.dataGridGraphic.MultiSelect = false;
            this.dataGridGraphic.Name = "dataGridGraphic";
            this.dataGridGraphic.RowHeadersVisible = false;
            this.dataGridGraphic.RowHeadersWidth = 51;
            this.dataGridGraphic.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridGraphic.RowTemplate.Height = 24;
            this.dataGridGraphic.ShowEditingIcon = false;
            this.dataGridGraphic.Size = new System.Drawing.Size(977, 287);
            this.dataGridGraphic.TabIndex = 0;
            // 
            // Month
            // 
            this.Month.HeaderText = "Месяц";
            this.Month.MinimumWidth = 6;
            this.Month.Name = "Month";
            // 
            // Remain
            // 
            this.Remain.HeaderText = "Остаток";
            this.Remain.MinimumWidth = 6;
            this.Remain.Name = "Remain";
            // 
            // Payment
            // 
            this.Payment.HeaderText = "Платёж";
            this.Payment.MinimumWidth = 6;
            this.Payment.Name = "Payment";
            // 
            // Percents
            // 
            this.Percents.HeaderText = "Проценты";
            this.Percents.MinimumWidth = 6;
            this.Percents.Name = "Percents";
            // 
            // Debt
            // 
            this.Debt.HeaderText = "Долг";
            this.Debt.MinimumWidth = 6;
            this.Debt.Name = "Debt";
            // 
            // Balance
            // 
            this.Balance.HeaderText = "Остаток долга";
            this.Balance.MinimumWidth = 6;
            this.Balance.Name = "Balance";
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(913, 13);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(75, 23);
            this.Back.TabIndex = 1;
            this.Back.Text = "Назад";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.button1_Click);
            // 
            // Graphic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 450);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.dataGridGraphic);
            this.Name = "Graphic";
            this.Text = "Graphic";
            this.Load += new System.EventHandler(this.Graphic_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridGraphic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridGraphic;
        private System.Windows.Forms.DataGridViewTextBoxColumn Month;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remain;
        private System.Windows.Forms.DataGridViewTextBoxColumn Payment;
        private System.Windows.Forms.DataGridViewTextBoxColumn Percents;
        private System.Windows.Forms.DataGridViewTextBoxColumn Debt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Balance;
        private System.Windows.Forms.Button Back;
    }
}