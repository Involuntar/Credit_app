namespace Bank.Forms.Admin_s_forms
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridUsers = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.middlename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.login = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Add_new = new Bank.RoundButton();
            this.Users_text = new System.Windows.Forms.Label();
            this.Back = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
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
            this.password,
            this.email,
            this.Edit,
            this.Delete});
            this.dataGridUsers.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.dataGridUsers.Location = new System.Drawing.Point(0, 85);
            this.dataGridUsers.MultiSelect = false;
            this.dataGridUsers.Name = "dataGridUsers";
            this.dataGridUsers.RowHeadersVisible = false;
            this.dataGridUsers.RowHeadersWidth = 51;
            this.dataGridUsers.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridUsers.RowTemplate.Height = 24;
            this.dataGridUsers.ShowEditingIcon = false;
            this.dataGridUsers.Size = new System.Drawing.Size(1149, 253);
            this.dataGridUsers.TabIndex = 0;
            this.dataGridUsers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridUsers_CellClick);
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
            // password
            // 
            this.password.DataPropertyName = "password";
            this.password.HeaderText = "Пароль";
            this.password.MinimumWidth = 6;
            this.password.Name = "password";
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Sienna;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Chocolate;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.SaddleBrown;
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
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Sienna;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Chocolate;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.SaddleBrown;
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
            this.panel1.BackColor = System.Drawing.Color.SaddleBrown;
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.Add_new);
            this.panel1.Controls.Add(this.dataGridUsers);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 112);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1149, 338);
            this.panel1.TabIndex = 1;
            // 
            // Add_new
            // 
            this.Add_new.BackColor = System.Drawing.Color.Gainsboro;
            this.Add_new.BackColor2 = System.Drawing.Color.Silver;
            this.Add_new.ButtonBorderColor = System.Drawing.Color.Black;
            this.Add_new.ButtonHighlightColor = System.Drawing.Color.Orange;
            this.Add_new.ButtonHighlightColor2 = System.Drawing.Color.OrangeRed;
            this.Add_new.ButtonHighlightForeColor = System.Drawing.Color.Black;
            this.Add_new.ButtonPressedColor = System.Drawing.Color.Red;
            this.Add_new.ButtonPressedColor2 = System.Drawing.Color.Maroon;
            this.Add_new.ButtonPressedForeColor = System.Drawing.Color.White;
            this.Add_new.ButtonRoundRadius = 30;
            this.Add_new.Location = new System.Drawing.Point(33, 26);
            this.Add_new.Name = "Add_new";
            this.Add_new.Size = new System.Drawing.Size(100, 40);
            this.Add_new.TabIndex = 1;
            this.Add_new.Text = "Добавить";
            this.Add_new.Click += new System.EventHandler(this.Add_new_Click);
            // 
            // Users_text
            // 
            this.Users_text.AutoSize = true;
            this.Users_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Users_text.Location = new System.Drawing.Point(38, 41);
            this.Users_text.Name = "Users_text";
            this.Users_text.Size = new System.Drawing.Size(267, 42);
            this.Users_text.TabIndex = 2;
            this.Users_text.Text = "Пользователи";
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(1062, 13);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(75, 23);
            this.Back.TabIndex = 3;
            this.Back.Text = "Назад";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(894, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 2;
            // 
            // users_watch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Sienna;
            this.ClientSize = new System.Drawing.Size(1149, 450);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Users_text);
            this.Controls.Add(this.panel1);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstname;
        private System.Windows.Forms.DataGridViewTextBoxColumn middlename;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastname;
        private System.Windows.Forms.DataGridViewTextBoxColumn login;
        private System.Windows.Forms.DataGridViewTextBoxColumn password;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.TextBox textBox1;
    }
}