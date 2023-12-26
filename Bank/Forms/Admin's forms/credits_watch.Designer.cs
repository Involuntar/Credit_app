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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Add_new2 = new Bank.RoundButton();
            this.dataGridCredit = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Back = new System.Windows.Forms.Button();
            this.Mortgagestxt = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.term = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itog_sum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.credit_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
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
            this.Add_new2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Add_new2.Name = "Add_new2";
            this.Add_new2.Size = new System.Drawing.Size(105, 36);
            this.Add_new2.TabIndex = 4;
            this.Add_new2.Text = "Добавить";
            this.Add_new2.Click += new System.EventHandler(this.Add_new2_Click);
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
            this.id,
            this.term,
            this.itog_sum,
            this.rate,
            this.credit_type,
            this.status,
            this.user_id,
            this.Edit,
            this.Delete});
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
            this.dataGridCredit.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridCredit_CellClick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(712, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(166, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "Поиск";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.Enter += new System.EventHandler(this.textBox1_Enter);
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(817, 12);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(75, 23);
            this.Back.TabIndex = 1;
            this.Back.Text = "Назад";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
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
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "#";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            // 
            // term
            // 
            this.term.DataPropertyName = "len";
            this.term.HeaderText = "Срок выплаты";
            this.term.MinimumWidth = 6;
            this.term.Name = "term";
            // 
            // itog_sum
            // 
            this.itog_sum.DataPropertyName = "summ";
            this.itog_sum.HeaderText = "Итоговая сумма";
            this.itog_sum.MinimumWidth = 6;
            this.itog_sum.Name = "itog_sum";
            // 
            // rate
            // 
            this.rate.DataPropertyName = "coefficient";
            this.rate.HeaderText = "Ставка";
            this.rate.MinimumWidth = 6;
            this.rate.Name = "rate";
            // 
            // credit_type
            // 
            this.credit_type.DataPropertyName = "name";
            this.credit_type.HeaderText = "Тип кредита";
            this.credit_type.MinimumWidth = 6;
            this.credit_type.Name = "credit_type";
            // 
            // status
            // 
            this.status.DataPropertyName = "name1";
            this.status.HeaderText = "Статус";
            this.status.MinimumWidth = 6;
            this.status.Name = "status";
            // 
            // user_id
            // 
            this.user_id.DataPropertyName = "lastname";
            this.user_id.HeaderText = "Код пользователя";
            this.user_id.MinimumWidth = 6;
            this.user_id.Name = "user_id";
            // 
            // Edit
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Edit.DefaultCellStyle = dataGridViewCellStyle1;
            this.Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Edit.HeaderText = "";
            this.Edit.MinimumWidth = 6;
            this.Edit.Name = "Edit";
            this.Edit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Edit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Edit.Text = "Изменить";
            this.Edit.UseColumnTextForButtonValue = true;
            // 
            // Delete
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Delete.DefaultCellStyle = dataGridViewCellStyle2;
            this.Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete.HeaderText = "";
            this.Delete.MinimumWidth = 6;
            this.Delete.Name = "Delete";
            this.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Delete.Text = "Удалить";
            this.Delete.UseColumnTextForButtonValue = true;
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
            this.Shown += new System.EventHandler(this.Credits_watch_Shown);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn term;
        private System.Windows.Forms.DataGridViewTextBoxColumn itog_sum;
        private System.Windows.Forms.DataGridViewTextBoxColumn rate;
        private System.Windows.Forms.DataGridViewTextBoxColumn credit_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn user_id;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}