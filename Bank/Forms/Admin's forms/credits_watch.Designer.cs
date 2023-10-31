namespace Bank.Forms.Admin_s_forms
{
    partial class Credits_watch
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridCredit = new System.Windows.Forms.DataGridView();
            this.Back = new System.Windows.Forms.Button();
            this.Mortgagestxt = new System.Windows.Forms.Label();
            this.Add_new2 = new Bank.RoundButton();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCredit)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.Add_new2);
            this.panel1.Controls.Add(this.dataGridCredit);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 114);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(904, 252);
            this.panel1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(712, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(166, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "Поиск";
            // 
            // dataGridCredit
            // 
            this.dataGridCredit.AllowUserToAddRows = false;
            this.dataGridCredit.AllowUserToDeleteRows = false;
            this.dataGridCredit.AllowUserToResizeColumns = false;
            this.dataGridCredit.AllowUserToResizeRows = false;
            this.dataGridCredit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridCredit.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridCredit.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.dataGridCredit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridCredit.ColumnHeadersHeight = 35;
            this.dataGridCredit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridCredit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column8,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dataGridCredit.Location = new System.Drawing.Point(12, 68);
            this.dataGridCredit.MultiSelect = false;
            this.dataGridCredit.Name = "dataGridCredit";
            this.dataGridCredit.RowHeadersVisible = false;
            this.dataGridCredit.RowHeadersWidth = 51;
            this.dataGridCredit.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridCredit.RowTemplate.Height = 24;
            this.dataGridCredit.ShowEditingIcon = false;
            this.dataGridCredit.Size = new System.Drawing.Size(880, 172);
            this.dataGridCredit.TabIndex = 0;
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(817, 12);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(75, 23);
            this.Back.TabIndex = 1;
            this.Back.Text = "Назад";
            this.Back.UseVisualStyleBackColor = true;
            // 
            // Mortgagestxt
            // 
            this.Mortgagestxt.AutoSize = true;
            this.Mortgagestxt.Font = new System.Drawing.Font("Goudy Stout", 21.75F);
            this.Mortgagestxt.ForeColor = System.Drawing.Color.White;
            this.Mortgagestxt.Location = new System.Drawing.Point(44, 39);
            this.Mortgagestxt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Mortgagestxt.Name = "Mortgagestxt";
            this.Mortgagestxt.Size = new System.Drawing.Size(151, 40);
            this.Mortgagestxt.TabIndex = 4;
            this.Mortgagestxt.Text = "Кредиты";
            // 
            // Add_new2
            // 
            this.Add_new2.BackColor = System.Drawing.Color.DimGray;
            this.Add_new2.BackColor2 = System.Drawing.Color.DimGray;
            this.Add_new2.ButtonBorderColor = System.Drawing.Color.Black;
            this.Add_new2.ButtonHighlightColor = System.Drawing.Color.Orange;
            this.Add_new2.ButtonHighlightColor2 = System.Drawing.Color.OrangeRed;
            this.Add_new2.ButtonHighlightForeColor = System.Drawing.Color.Black;
            this.Add_new2.ButtonPressedColor = System.Drawing.Color.Red;
            this.Add_new2.ButtonPressedColor2 = System.Drawing.Color.Maroon;
            this.Add_new2.ButtonPressedForeColor = System.Drawing.Color.White;
            this.Add_new2.ButtonRoundRadius = 30;
            this.Add_new2.Font = new System.Drawing.Font("Goudy Stout", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_new2.ForeColor = System.Drawing.Color.White;
            this.Add_new2.Location = new System.Drawing.Point(38, 8);
            this.Add_new2.Margin = new System.Windows.Forms.Padding(2);
            this.Add_new2.Name = "Add_new2";
            this.Add_new2.Size = new System.Drawing.Size(105, 36);
            this.Add_new2.TabIndex = 4;
            this.Add_new2.Text = "Добавить";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "#";
            this.Column1.Name = "Column1";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Сумма займа";
            this.Column8.Name = "Column8";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Итоговая сумма";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Срок выплаты";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Ставка";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Тип кредита";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Код пользователя";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Статус";
            this.Column7.Name = "Column7";
            // 
            // Credits_watch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(904, 366);
            this.Controls.Add(this.Mortgagestxt);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.panel1);
            this.Name = "Credits_watch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "credits_watch";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCredit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridCredit;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Label Mortgagestxt;
        private RoundButton Add_new2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}