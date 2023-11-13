namespace Bank.Forms.Admin_s_forms
{
    partial class Mortgages_watch
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
            this.dataGridMort = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.init_fee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.credit_summ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.term_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rate_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.credit_type_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.users_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statuses_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Add_new = new Bank.RoundButton();
            this.Mortgagestxt = new System.Windows.Forms.Label();
            this.Back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMort)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridMort
            // 
            this.dataGridMort.AllowUserToAddRows = false;
            this.dataGridMort.AllowUserToDeleteRows = false;
            this.dataGridMort.AllowUserToResizeColumns = false;
            this.dataGridMort.AllowUserToResizeRows = false;
            this.dataGridMort.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridMort.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridMort.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.dataGridMort.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridMort.ColumnHeadersHeight = 35;
            this.dataGridMort.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridMort.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.cost,
            this.init_fee,
            this.credit_summ,
            this.term_id,
            this.rate_id,
            this.credit_type_id,
            this.users_id,
            this.statuses_id,
            this.Edit,
            this.Delete});
            this.dataGridMort.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.dataGridMort.Location = new System.Drawing.Point(9, 68);
            this.dataGridMort.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridMort.MultiSelect = false;
            this.dataGridMort.Name = "dataGridMort";
            this.dataGridMort.RowHeadersVisible = false;
            this.dataGridMort.RowHeadersWidth = 51;
            this.dataGridMort.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridMort.RowTemplate.Height = 24;
            this.dataGridMort.ShowEditingIcon = false;
            this.dataGridMort.Size = new System.Drawing.Size(886, 174);
            this.dataGridMort.TabIndex = 0;
            this.dataGridMort.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridMort_CellClick);
            this.dataGridMort.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridMort_CellContentClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "#";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            // 
            // cost
            // 
            this.cost.DataPropertyName = "cost";
            this.cost.HeaderText = "Сумма займа";
            this.cost.MinimumWidth = 6;
            this.cost.Name = "cost";
            // 
            // init_fee
            // 
            this.init_fee.DataPropertyName = "init_fee";
            this.init_fee.HeaderText = "Первый взнос";
            this.init_fee.MinimumWidth = 6;
            this.init_fee.Name = "init_fee";
            // 
            // credit_summ
            // 
            this.credit_summ.DataPropertyName = "credit_summ";
            this.credit_summ.HeaderText = "Итоговая сумма кредита";
            this.credit_summ.MinimumWidth = 6;
            this.credit_summ.Name = "credit_summ";
            // 
            // term_id
            // 
            this.term_id.DataPropertyName = "term_id";
            this.term_id.HeaderText = "Срок выплаты";
            this.term_id.MinimumWidth = 6;
            this.term_id.Name = "term_id";
            // 
            // rate_id
            // 
            this.rate_id.DataPropertyName = "rate_id";
            this.rate_id.HeaderText = "Ставка";
            this.rate_id.MinimumWidth = 6;
            this.rate_id.Name = "rate_id";
            // 
            // credit_type_id
            // 
            this.credit_type_id.DataPropertyName = "credit_type_id";
            this.credit_type_id.HeaderText = "Тип кредита";
            this.credit_type_id.MinimumWidth = 6;
            this.credit_type_id.Name = "credit_type_id";
            // 
            // users_id
            // 
            this.users_id.DataPropertyName = "users_id";
            this.users_id.HeaderText = "Код пользователя";
            this.users_id.MinimumWidth = 6;
            this.users_id.Name = "users_id";
            // 
            // statuses_id
            // 
            this.statuses_id.DataPropertyName = "statuses_id";
            this.statuses_id.HeaderText = "Статус";
            this.statuses_id.MinimumWidth = 6;
            this.statuses_id.Name = "statuses_id";
            // 
            // Edit
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Sienna;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Chocolate;
            this.Edit.DefaultCellStyle = dataGridViewCellStyle1;
            this.Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Edit.HeaderText = "";
            this.Edit.MinimumWidth = 6;
            this.Edit.Name = "Edit";
            this.Edit.Text = "Изменить";
            this.Edit.UseColumnTextForButtonValue = true;
            // 
            // Delete
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Sienna;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Chocolate;
            this.Delete.DefaultCellStyle = dataGridViewCellStyle2;
            this.Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete.HeaderText = "";
            this.Delete.MinimumWidth = 6;
            this.Delete.Name = "Delete";
            this.Delete.Text = "Удалить";
            this.Delete.UseColumnTextForButtonValue = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.Add_new);
            this.panel1.Controls.Add(this.dataGridMort);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 114);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(904, 252);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(657, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Поиск";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(717, 23);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(166, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Add_new
            // 
            this.Add_new.BackColor = System.Drawing.Color.DimGray;
            this.Add_new.BackColor2 = System.Drawing.Color.DimGray;
            this.Add_new.ButtonBorderColor = System.Drawing.Color.Black;
            this.Add_new.ButtonHighlightColor = System.Drawing.Color.Orange;
            this.Add_new.ButtonHighlightColor2 = System.Drawing.Color.OrangeRed;
            this.Add_new.ButtonHighlightForeColor = System.Drawing.Color.Black;
            this.Add_new.ButtonPressedColor = System.Drawing.Color.Red;
            this.Add_new.ButtonPressedColor2 = System.Drawing.Color.Maroon;
            this.Add_new.ButtonPressedForeColor = System.Drawing.Color.White;
            this.Add_new.ButtonRoundRadius = 30;
            this.Add_new.Font = new System.Drawing.Font("Goudy Stout", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_new.ForeColor = System.Drawing.Color.White;
            this.Add_new.Location = new System.Drawing.Point(29, 7);
            this.Add_new.Margin = new System.Windows.Forms.Padding(2);
            this.Add_new.Name = "Add_new";
            this.Add_new.Size = new System.Drawing.Size(105, 36);
            this.Add_new.TabIndex = 1;
            this.Add_new.Text = "Добавить";
            this.Add_new.Click += new System.EventHandler(this.Add_new_Click);
            // 
            // Mortgagestxt
            // 
            this.Mortgagestxt.AutoSize = true;
            this.Mortgagestxt.Font = new System.Drawing.Font("Goudy Stout", 21.75F);
            this.Mortgagestxt.ForeColor = System.Drawing.Color.White;
            this.Mortgagestxt.Location = new System.Drawing.Point(41, 43);
            this.Mortgagestxt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Mortgagestxt.Name = "Mortgagestxt";
            this.Mortgagestxt.Size = new System.Drawing.Size(145, 40);
            this.Mortgagestxt.TabIndex = 2;
            this.Mortgagestxt.Text = "Ипотеки";
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(834, 10);
            this.Back.Margin = new System.Windows.Forms.Padding(2);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(61, 22);
            this.Back.TabIndex = 3;
            this.Back.Text = "Назад";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Mortgages_watch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(904, 366);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Mortgagestxt);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Mortgages_watch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "mortgages_watch";
            this.Load += new System.EventHandler(this.Mortgages_watch_Load);
            this.Shown += new System.EventHandler(this.Mortgages_watch_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMort)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridMort;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private RoundButton Add_new;
        private System.Windows.Forms.Label Mortgagestxt;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn init_fee;
        private System.Windows.Forms.DataGridViewTextBoxColumn credit_summ;
        private System.Windows.Forms.DataGridViewTextBoxColumn term_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn rate_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn credit_type_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn users_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn statuses_id;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Label label1;
    }
}