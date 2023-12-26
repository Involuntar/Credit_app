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
            this.Graf_back = new System.Windows.Forms.Button();
            this.diff_add = new Bank.RoundButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridGraf)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridGraf
            // 
            this.dataGridGraf.AllowUserToAddRows = false;
            this.dataGridGraf.AllowUserToDeleteRows = false;
            this.dataGridGraf.AllowUserToResizeColumns = false;
            this.dataGridGraf.AllowUserToResizeRows = false;
            this.dataGridGraf.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridGraf.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridGraf.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridGraf.ColumnHeadersHeight = 29;
            this.dataGridGraf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridGraf.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.month,
            this.ost_debt,
            this.payment,
            this.procent_part,
            this.debt_part,
            this.end_debt});
            this.dataGridGraf.Location = new System.Drawing.Point(29, 28);
            this.dataGridGraf.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridGraf.MultiSelect = false;
            this.dataGridGraf.Name = "dataGridGraf";
            this.dataGridGraf.RowHeadersVisible = false;
            this.dataGridGraf.RowHeadersWidth = 51;
            this.dataGridGraf.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridGraf.ShowEditingIcon = false;
            this.dataGridGraf.Size = new System.Drawing.Size(859, 482);
            this.dataGridGraf.TabIndex = 0;
            // 
            // month
            // 
            this.month.HeaderText = "Месяц";
            this.month.MinimumWidth = 6;
            this.month.Name = "month";
            // 
            // ost_debt
            // 
            this.ost_debt.HeaderText = "Остаток долга";
            this.ost_debt.MinimumWidth = 6;
            this.ost_debt.Name = "ost_debt";
            // 
            // payment
            // 
            this.payment.HeaderText = "Сумма платежа";
            this.payment.MinimumWidth = 6;
            this.payment.Name = "payment";
            // 
            // procent_part
            // 
            this.procent_part.HeaderText = "Платеж по процентам";
            this.procent_part.MinimumWidth = 6;
            this.procent_part.Name = "procent_part";
            // 
            // debt_part
            // 
            this.debt_part.HeaderText = "Платеж по основному долгу";
            this.debt_part.MinimumWidth = 6;
            this.debt_part.Name = "debt_part";
            // 
            // end_debt
            // 
            this.end_debt.HeaderText = "Остаток долга на конец периода";
            this.end_debt.MinimumWidth = 6;
            this.end_debt.Name = "end_debt";
            // 
            // Graf_back
            // 
            this.Graf_back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.Graf_back.Font = new System.Drawing.Font("Goudy Stout", 9F);
            this.Graf_back.ForeColor = System.Drawing.Color.White;
            this.Graf_back.Location = new System.Drawing.Point(1047, 15);
            this.Graf_back.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Graf_back.Name = "Graf_back";
            this.Graf_back.Size = new System.Drawing.Size(108, 33);
            this.Graf_back.TabIndex = 1;
            this.Graf_back.Text = "Назад";
            this.Graf_back.UseVisualStyleBackColor = false;
            this.Graf_back.Click += new System.EventHandler(this.Graf_back_Click);
            // 
            // diff_add
            // 
            this.diff_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.diff_add.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.diff_add.ButtonBorderColor = System.Drawing.Color.Black;
            this.diff_add.ButtonHighlightColor = System.Drawing.Color.Orange;
            this.diff_add.ButtonHighlightColor2 = System.Drawing.Color.OrangeRed;
            this.diff_add.ButtonHighlightForeColor = System.Drawing.Color.Black;
            this.diff_add.ButtonPressedColor = System.Drawing.Color.Red;
            this.diff_add.ButtonPressedColor2 = System.Drawing.Color.Maroon;
            this.diff_add.ButtonPressedForeColor = System.Drawing.Color.White;
            this.diff_add.ButtonRoundRadius = 30;
            this.diff_add.Font = new System.Drawing.Font("Goudy Stout", 9F);
            this.diff_add.ForeColor = System.Drawing.Color.White;
            this.diff_add.Location = new System.Drawing.Point(972, 457);
            this.diff_add.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.diff_add.Name = "diff_add";
            this.diff_add.Size = new System.Drawing.Size(171, 54);
            this.diff_add.TabIndex = 2;
            this.diff_add.Text = "Оставить заявку";
            this.diff_add.Click += new System.EventHandler(this.diff_add_Click);
            // 
            // Grafic_show
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.ClientSize = new System.Drawing.Size(1171, 554);
            this.Controls.Add(this.diff_add);
            this.Controls.Add(this.Graf_back);
            this.Controls.Add(this.dataGridGraf);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Grafic_show";
            this.Text = "Вывод графика";
            this.Load += new System.EventHandler(this.Grafic_show_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridGraf)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridGraf;
        private System.Windows.Forms.Button Graf_back;
        private System.Windows.Forms.DataGridViewTextBoxColumn month;
        private System.Windows.Forms.DataGridViewTextBoxColumn ost_debt;
        private System.Windows.Forms.DataGridViewTextBoxColumn payment;
        private System.Windows.Forms.DataGridViewTextBoxColumn procent_part;
        private System.Windows.Forms.DataGridViewTextBoxColumn debt_part;
        private System.Windows.Forms.DataGridViewTextBoxColumn end_debt;
        private RoundButton diff_add;
    }
}