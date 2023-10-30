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
            this.dataGridCredit = new System.Windows.Forms.DataGridView();
            this.Back = new System.Windows.Forms.Button();
            this.Add_new = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCredit)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.Add_new);
            this.panel1.Controls.Add(this.dataGridCredit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 165);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 285);
            this.panel1.TabIndex = 0;
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
            this.dataGridCredit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridCredit.ColumnHeadersHeight = 29;
            this.dataGridCredit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridCredit.Location = new System.Drawing.Point(12, 68);
            this.dataGridCredit.MultiSelect = false;
            this.dataGridCredit.Name = "dataGridCredit";
            this.dataGridCredit.RowHeadersVisible = false;
            this.dataGridCredit.RowHeadersWidth = 51;
            this.dataGridCredit.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridCredit.RowTemplate.Height = 24;
            this.dataGridCredit.ShowEditingIcon = false;
            this.dataGridCredit.Size = new System.Drawing.Size(776, 205);
            this.dataGridCredit.TabIndex = 0;
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(712, 13);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(75, 23);
            this.Back.TabIndex = 1;
            this.Back.Text = "Назад";
            this.Back.UseVisualStyleBackColor = true;
            // 
            // Add_new
            // 
            this.Add_new.Location = new System.Drawing.Point(25, 30);
            this.Add_new.Name = "Add_new";
            this.Add_new.Size = new System.Drawing.Size(95, 23);
            this.Add_new.TabIndex = 2;
            this.Add_new.Text = "Добавить";
            this.Add_new.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(598, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 3;
            // 
            // Credits_watch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.panel1);
            this.Name = "Credits_watch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "credits_watch";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCredit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridCredit;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Add_new;
        private System.Windows.Forms.Button Back;
    }
}