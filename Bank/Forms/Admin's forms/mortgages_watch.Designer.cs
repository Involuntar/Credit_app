﻿namespace Bank.Forms.Admin_s_forms
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridMort = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.init_fee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.credit_summ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.term_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rate_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.credit_type_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statuses_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.name,
            this.statuses_id,
            this.Edit,
            this.Delete});
            this.dataGridMort.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.dataGridMort.Location = new System.Drawing.Point(12, 84);
            this.dataGridMort.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridMort.MultiSelect = false;
            this.dataGridMort.Name = "dataGridMort";
            this.dataGridMort.RowHeadersVisible = false;
            this.dataGridMort.RowHeadersWidth = 51;
            this.dataGridMort.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridMort.RowTemplate.Height = 24;
            this.dataGridMort.ShowEditingIcon = false;
            this.dataGridMort.Size = new System.Drawing.Size(1183, 214);
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
            this.term_id.DataPropertyName = "len";
            this.term_id.HeaderText = "Срок выплаты";
            this.term_id.MinimumWidth = 6;
            this.term_id.Name = "term_id";
            // 
            // rate_id
            // 
            this.rate_id.DataPropertyName = "coefficient";
            this.rate_id.HeaderText = "Ставка";
            this.rate_id.MinimumWidth = 6;
            this.rate_id.Name = "rate_id";
            // 
            // credit_type_id
            // 
            this.credit_type_id.DataPropertyName = "name";
            this.credit_type_id.HeaderText = "Тип кредита";
            this.credit_type_id.MinimumWidth = 6;
            this.credit_type_id.Name = "credit_type_id";
            // 
            // name
            // 
            this.name.DataPropertyName = "login";
            this.name.HeaderText = "Код пользователя";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            // 
            // statuses_id
            // 
            this.statuses_id.DataPropertyName = "name1";
            this.statuses_id.HeaderText = "Статус";
            this.statuses_id.MinimumWidth = 6;
            this.statuses_id.Name = "statuses_id";
            // 
            // Edit
            // 
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.Sienna;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Chocolate;
            this.Edit.DefaultCellStyle = dataGridViewCellStyle11;
            this.Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Edit.HeaderText = "";
            this.Edit.MinimumWidth = 6;
            this.Edit.Name = "Edit";
            this.Edit.Text = "Изменить";
            this.Edit.UseColumnTextForButtonValue = true;
            // 
            // Delete
            // 
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.Sienna;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Chocolate;
            this.Delete.DefaultCellStyle = dataGridViewCellStyle12;
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
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.Add_new);
            this.panel1.Controls.Add(this.dataGridMort);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 143);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1207, 310);
            this.panel1.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(949, 30);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(240, 22);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "\r\nПоиск";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.Enter += new System.EventHandler(this.textBox1_Enter);
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
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
            this.Add_new.Location = new System.Drawing.Point(51, 10);
            this.Add_new.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Add_new.Name = "Add_new";
            this.Add_new.Size = new System.Drawing.Size(140, 44);
            this.Add_new.TabIndex = 1;
            this.Add_new.Text = "Добавить";
            this.Add_new.Click += new System.EventHandler(this.Add_new_Click);
            // 
            // Mortgagestxt
            // 
            this.Mortgagestxt.AutoSize = true;
            this.Mortgagestxt.Font = new System.Drawing.Font("Goudy Stout", 21.75F);
            this.Mortgagestxt.ForeColor = System.Drawing.Color.White;
            this.Mortgagestxt.Location = new System.Drawing.Point(59, 48);
            this.Mortgagestxt.Name = "Mortgagestxt";
            this.Mortgagestxt.Size = new System.Drawing.Size(184, 51);
            this.Mortgagestxt.TabIndex = 2;
            this.Mortgagestxt.Text = "Ипотеки";
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(1115, 11);
            this.Back.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(81, 27);
            this.Back.TabIndex = 3;
            this.Back.Text = "Назад";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Mortgages_watch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1207, 453);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Mortgagestxt);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Mortgages_watch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Просмотр ипотеки";
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
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn init_fee;
        private System.Windows.Forms.DataGridViewTextBoxColumn credit_summ;
        private System.Windows.Forms.DataGridViewTextBoxColumn term_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn rate_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn credit_type_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn statuses_id;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}