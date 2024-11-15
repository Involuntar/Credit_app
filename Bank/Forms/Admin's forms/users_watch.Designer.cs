﻿namespace Bank.Forms.Admin_s_forms
{
    partial class users_watch
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridUsers = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.middlename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.login = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Add_new = new Bank.RoundButton();
            this.Users_text = new System.Windows.Forms.Label();
            this.Back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUsers)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridUsers
            // 
            this.dataGridUsers.AllowUserToAddRows = false;
            this.dataGridUsers.AllowUserToDeleteRows = false;
            this.dataGridUsers.AllowUserToResizeColumns = false;
            this.dataGridUsers.AllowUserToResizeRows = false;
            this.dataGridUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridUsers.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.dataGridUsers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridUsers.ColumnHeadersHeight = 39;
            this.dataGridUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.firstname,
            this.middlename,
            this.lastname,
            this.login,
            this.email,
            this.Edit,
            this.Delete});
            this.dataGridUsers.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.dataGridUsers.Location = new System.Drawing.Point(0, 85);
            this.dataGridUsers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridUsers.MultiSelect = false;
            this.dataGridUsers.Name = "dataGridUsers";
            this.dataGridUsers.RowHeadersVisible = false;
            this.dataGridUsers.RowHeadersWidth = 51;
            this.dataGridUsers.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridUsers.RowTemplate.Height = 24;
            this.dataGridUsers.ShowEditingIcon = false;
            this.dataGridUsers.Size = new System.Drawing.Size(1207, 226);
            this.dataGridUsers.TabIndex = 0;
            this.dataGridUsers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridUsers_CellClick);
            this.dataGridUsers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridUsers_CellContentClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "#";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            // 
            // firstname
            // 
            this.firstname.DataPropertyName = "firstname";
            this.firstname.HeaderText = "Имя";
            this.firstname.MinimumWidth = 6;
            this.firstname.Name = "firstname";
            // 
            // middlename
            // 
            this.middlename.DataPropertyName = "middlename";
            this.middlename.HeaderText = "Отчество(при наличии)";
            this.middlename.MinimumWidth = 6;
            this.middlename.Name = "middlename";
            // 
            // lastname
            // 
            this.lastname.DataPropertyName = "lastname";
            this.lastname.HeaderText = "Фамилия";
            this.lastname.MinimumWidth = 6;
            this.lastname.Name = "lastname";
            // 
            // login
            // 
            this.login.DataPropertyName = "login";
            this.login.HeaderText = "Логин";
            this.login.MinimumWidth = 6;
            this.login.Name = "login";
            // 
            // email
            // 
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "Почта";
            this.email.MinimumWidth = 6;
            this.email.Name = "email";
            // 
            // Edit
            // 
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.Sienna;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.Chocolate;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.SaddleBrown;
            this.Edit.DefaultCellStyle = dataGridViewCellStyle15;
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
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.Sienna;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.Chocolate;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.SaddleBrown;
            this.Delete.DefaultCellStyle = dataGridViewCellStyle16;
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
            this.panel1.Controls.Add(this.dataGridUsers);
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
            this.textBox1.Text = "Поиск";
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
            // Users_text
            // 
            this.Users_text.AutoSize = true;
            this.Users_text.BackColor = System.Drawing.Color.DimGray;
            this.Users_text.Font = new System.Drawing.Font("Goudy Stout", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Users_text.ForeColor = System.Drawing.Color.White;
            this.Users_text.Location = new System.Drawing.Point(59, 48);
            this.Users_text.Name = "Users_text";
            this.Users_text.Size = new System.Drawing.Size(296, 51);
            this.Users_text.TabIndex = 2;
            this.Users_text.Text = "Пользователи";
            this.Users_text.Click += new System.EventHandler(this.Users_text_Click);
            // 
            // Back
            // 
            this.Back.Font = new System.Drawing.Font("Goudy Stout", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.Location = new System.Drawing.Point(1115, 11);
            this.Back.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(81, 27);
            this.Back.TabIndex = 3;
            this.Back.Text = "Назад";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // users_watch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1207, 453);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Users_text);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "users_watch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Пользователи";
            this.Shown += new System.EventHandler(this.users_watch_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUsers)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridUsers;
        private System.Windows.Forms.Panel panel1;
        private RoundButton Add_new;
        private System.Windows.Forms.Label Users_text;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstname;
        private System.Windows.Forms.DataGridViewTextBoxColumn middlename;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastname;
        private System.Windows.Forms.DataGridViewTextBoxColumn login;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}