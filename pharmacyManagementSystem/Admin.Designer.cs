
namespace pharmacyManagementSystem
{
    partial class Admin
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.User_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date_Of_Birth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.User_Role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvUsers = new Guna.UI.WinForms.GunaDataGridView();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel7 = new Guna.UI.WinForms.GunaLabel();
            this.idTxtBox = new Guna.UI.WinForms.GunaLineTextBox();
            this.nameTxtBox = new Guna.UI.WinForms.GunaLineTextBox();
            this.passwordTxtBox = new Guna.UI.WinForms.GunaLineTextBox();
            this.emailTxtBox = new Guna.UI.WinForms.GunaLineTextBox();
            this.roleComboBox = new Guna.UI.WinForms.GunaComboBox();
            this.dobDateTimePicker = new Guna.UI.WinForms.GunaDateTimePicker();
            this.searchTxtBtn = new MetroFramework.Controls.MetroTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sellsDGV = new Guna.UI.WinForms.GunaDataGridView();
            this.Mname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PricePerUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resetUserBtn = new Guna.UI.WinForms.GunaGradientButton();
            this.sellHistoryBtn = new Guna.UI.WinForms.GunaButton();
            this.updateBtn = new Guna.UI.WinForms.GunaButton();
            this.DashBoard = new Guna.UI.WinForms.GunaButton();
            this.addUserBtn = new Guna.UI.WinForms.GunaButton();
            this.searchBtn = new Guna.UI.WinForms.GunaButton();
            this.deleteBtn = new Guna.UI.WinForms.GunaButton();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.logoutBtn = new Guna.UI.WinForms.GunaButton();
            this.label2 = new System.Windows.Forms.Label();
            this.gunaPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellsDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(41)))), ((int)(((byte)(43)))));
            this.gunaPanel1.Controls.Add(this.sellHistoryBtn);
            this.gunaPanel1.Controls.Add(this.updateBtn);
            this.gunaPanel1.Controls.Add(this.gunaLabel1);
            this.gunaPanel1.Controls.Add(this.DashBoard);
            this.gunaPanel1.Controls.Add(this.addUserBtn);
            this.gunaPanel1.Controls.Add(this.searchBtn);
            this.gunaPanel1.Controls.Add(this.deleteBtn);
            this.gunaPanel1.Controls.Add(this.gunaPictureBox1);
            this.gunaPanel1.Controls.Add(this.logoutBtn);
            this.gunaPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(406, 773);
            this.gunaPanel1.TabIndex = 0;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.White;
            this.gunaLabel1.Location = new System.Drawing.Point(120, 249);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(124, 42);
            this.gunaLabel1.TabIndex = 6;
            this.gunaLabel1.Text = "Admin";
            // 
            // User_Name
            // 
            this.User_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.User_Name.DataPropertyName = "User_Name";
            this.User_Name.HeaderText = "Name";
            this.User_Name.MinimumWidth = 6;
            this.User_Name.Name = "User_Name";
            this.User_Name.ReadOnly = true;
            // 
            // Date_Of_Birth
            // 
            this.Date_Of_Birth.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Date_Of_Birth.DataPropertyName = "Date_Of_Birth";
            this.Date_Of_Birth.HeaderText = "Date Of Birth";
            this.Date_Of_Birth.MinimumWidth = 6;
            this.Date_Of_Birth.Name = "Date_Of_Birth";
            this.Date_Of_Birth.ReadOnly = true;
            // 
            // Password
            // 
            this.Password.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Password.DataPropertyName = "Password";
            this.Password.HeaderText = "Password";
            this.Password.MinimumWidth = 6;
            this.Password.Name = "Password";
            this.Password.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email Address";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // User_Role
            // 
            this.User_Role.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.User_Role.DataPropertyName = "User_Role";
            this.User_Role.HeaderText = "User Role";
            this.User_Role.MinimumWidth = 6;
            this.User_Role.Name = "User_Role";
            this.User_Role.ReadOnly = true;
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "User Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // dgvUsers
            // 
            this.dgvUsers.AllowUserToAddRows = false;
            this.dgvUsers.AllowUserToDeleteRows = false;
            this.dgvUsers.AllowUserToResizeColumns = false;
            this.dgvUsers.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvUsers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsers.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(41)))), ((int)(((byte)(43)))));
            this.dgvUsers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUsers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvUsers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvUsers.ColumnHeadersHeight = 27;
            this.dgvUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.User_Role,
            this.Email,
            this.Password,
            this.Date_Of_Birth,
            this.User_Name});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUsers.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvUsers.EnableHeadersVisualStyles = false;
            this.dgvUsers.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvUsers.Location = new System.Drawing.Point(512, 565);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.ReadOnly = true;
            this.dgvUsers.RowHeadersVisible = false;
            this.dgvUsers.RowHeadersWidth = 51;
            this.dgvUsers.RowTemplate.Height = 24;
            this.dgvUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsers.Size = new System.Drawing.Size(926, 208);
            this.dgvUsers.TabIndex = 1;
            this.dgvUsers.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dgvUsers.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvUsers.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvUsers.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvUsers.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvUsers.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvUsers.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(41)))), ((int)(((byte)(43)))));
            this.dgvUsers.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvUsers.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvUsers.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvUsers.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvUsers.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvUsers.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvUsers.ThemeStyle.HeaderStyle.Height = 27;
            this.dgvUsers.ThemeStyle.ReadOnly = true;
            this.dgvUsers.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvUsers.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvUsers.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvUsers.ThemeStyle.RowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dgvUsers.ThemeStyle.RowsStyle.Height = 24;
            this.dgvUsers.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvUsers.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvUsers.DoubleClick += new System.EventHandler(this.dgvUsers_DoubleClick);
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.Location = new System.Drawing.Point(425, 27);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(31, 25);
            this.gunaLabel2.TabIndex = 2;
            this.gunaLabel2.Text = "Id";
            this.gunaLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.Location = new System.Drawing.Point(425, 101);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(55, 25);
            this.gunaLabel3.TabIndex = 3;
            this.gunaLabel3.Text = "Role";
            this.gunaLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.Location = new System.Drawing.Point(425, 165);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(138, 25);
            this.gunaLabel4.TabIndex = 4;
            this.gunaLabel4.Text = "Date Of Birth";
            this.gunaLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel5.Location = new System.Drawing.Point(425, 288);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(104, 25);
            this.gunaLabel5.TabIndex = 5;
            this.gunaLabel5.Text = "Password";
            this.gunaLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.AutoSize = true;
            this.gunaLabel6.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel6.Location = new System.Drawing.Point(439, 327);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(65, 25);
            this.gunaLabel6.TabIndex = 6;
            this.gunaLabel6.Text = "Email";
            this.gunaLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaLabel7
            // 
            this.gunaLabel7.AutoSize = true;
            this.gunaLabel7.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel7.Location = new System.Drawing.Point(439, 219);
            this.gunaLabel7.Name = "gunaLabel7";
            this.gunaLabel7.Size = new System.Drawing.Size(69, 25);
            this.gunaLabel7.TabIndex = 7;
            this.gunaLabel7.Text = "Name";
            this.gunaLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // idTxtBox
            // 
            this.idTxtBox.BackColor = System.Drawing.Color.White;
            this.idTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.idTxtBox.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.idTxtBox.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idTxtBox.LineColor = System.Drawing.Color.DarkGray;
            this.idTxtBox.Location = new System.Drawing.Point(582, 16);
            this.idTxtBox.Name = "idTxtBox";
            this.idTxtBox.PasswordChar = '\0';
            this.idTxtBox.SelectedText = "";
            this.idTxtBox.Size = new System.Drawing.Size(208, 36);
            this.idTxtBox.TabIndex = 8;
            this.idTxtBox.Text = " ";
            this.idTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nameTxtBox
            // 
            this.nameTxtBox.BackColor = System.Drawing.Color.White;
            this.nameTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nameTxtBox.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.nameTxtBox.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTxtBox.LineColor = System.Drawing.Color.DarkGray;
            this.nameTxtBox.Location = new System.Drawing.Point(593, 219);
            this.nameTxtBox.Name = "nameTxtBox";
            this.nameTxtBox.PasswordChar = '\0';
            this.nameTxtBox.SelectedText = "";
            this.nameTxtBox.Size = new System.Drawing.Size(208, 36);
            this.nameTxtBox.TabIndex = 13;
            this.nameTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // passwordTxtBox
            // 
            this.passwordTxtBox.BackColor = System.Drawing.Color.White;
            this.passwordTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordTxtBox.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.passwordTxtBox.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTxtBox.LineColor = System.Drawing.Color.DarkGray;
            this.passwordTxtBox.Location = new System.Drawing.Point(582, 261);
            this.passwordTxtBox.Name = "passwordTxtBox";
            this.passwordTxtBox.PasswordChar = '●';
            this.passwordTxtBox.SelectedText = "";
            this.passwordTxtBox.Size = new System.Drawing.Size(208, 36);
            this.passwordTxtBox.TabIndex = 14;
            this.passwordTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.passwordTxtBox.UseSystemPasswordChar = true;
            // 
            // emailTxtBox
            // 
            this.emailTxtBox.BackColor = System.Drawing.Color.White;
            this.emailTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.emailTxtBox.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.emailTxtBox.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTxtBox.LineColor = System.Drawing.Color.DarkGray;
            this.emailTxtBox.Location = new System.Drawing.Point(567, 345);
            this.emailTxtBox.Name = "emailTxtBox";
            this.emailTxtBox.PasswordChar = '\0';
            this.emailTxtBox.SelectedText = "";
            this.emailTxtBox.Size = new System.Drawing.Size(208, 36);
            this.emailTxtBox.TabIndex = 15;
            this.emailTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // roleComboBox
            // 
            this.roleComboBox.BackColor = System.Drawing.Color.Transparent;
            this.roleComboBox.BaseColor = System.Drawing.Color.White;
            this.roleComboBox.BorderColor = System.Drawing.Color.Silver;
            this.roleComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.roleComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.roleComboBox.FocusedColor = System.Drawing.Color.Transparent;
            this.roleComboBox.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roleComboBox.ForeColor = System.Drawing.Color.Black;
            this.roleComboBox.FormattingEnabled = true;
            this.roleComboBox.Items.AddRange(new object[] {
            "Admin",
            "Pharmacist"});
            this.roleComboBox.Location = new System.Drawing.Point(582, 92);
            this.roleComboBox.Name = "roleComboBox";
            this.roleComboBox.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.roleComboBox.OnHoverItemForeColor = System.Drawing.Color.White;
            this.roleComboBox.Radius = 9;
            this.roleComboBox.Size = new System.Drawing.Size(208, 34);
            this.roleComboBox.TabIndex = 16;
            // 
            // dobDateTimePicker
            // 
            this.dobDateTimePicker.BackColor = System.Drawing.Color.Transparent;
            this.dobDateTimePicker.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(179)))), ((int)(((byte)(66)))));
            this.dobDateTimePicker.BorderColor = System.Drawing.Color.Silver;
            this.dobDateTimePicker.CustomFormat = null;
            this.dobDateTimePicker.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dobDateTimePicker.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dobDateTimePicker.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dobDateTimePicker.ForeColor = System.Drawing.Color.Black;
            this.dobDateTimePicker.Location = new System.Drawing.Point(582, 165);
            this.dobDateTimePicker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dobDateTimePicker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dobDateTimePicker.Name = "dobDateTimePicker";
            this.dobDateTimePicker.OnHoverBaseColor = System.Drawing.Color.White;
            this.dobDateTimePicker.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dobDateTimePicker.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dobDateTimePicker.OnPressedColor = System.Drawing.Color.Black;
            this.dobDateTimePicker.Radius = 9;
            this.dobDateTimePicker.Size = new System.Drawing.Size(243, 33);
            this.dobDateTimePicker.TabIndex = 17;
            this.dobDateTimePicker.Text = "18 August 2021";
            this.dobDateTimePicker.Value = new System.DateTime(2021, 8, 18, 20, 30, 18, 766);
            // 
            // searchTxtBtn
            // 
            // 
            // 
            // 
            this.searchTxtBtn.CustomButton.Image = null;
            this.searchTxtBtn.CustomButton.Location = new System.Drawing.Point(166, 1);
            this.searchTxtBtn.CustomButton.Name = "";
            this.searchTxtBtn.CustomButton.Size = new System.Drawing.Size(41, 41);
            this.searchTxtBtn.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.searchTxtBtn.CustomButton.TabIndex = 1;
            this.searchTxtBtn.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.searchTxtBtn.CustomButton.UseSelectable = true;
            this.searchTxtBtn.CustomButton.Visible = false;
            this.searchTxtBtn.Lines = new string[0];
            this.searchTxtBtn.Location = new System.Drawing.Point(412, 508);
            this.searchTxtBtn.MaxLength = 32767;
            this.searchTxtBtn.Name = "searchTxtBtn";
            this.searchTxtBtn.PasswordChar = '\0';
            this.searchTxtBtn.PromptText = "Search by id";
            this.searchTxtBtn.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.searchTxtBtn.SelectedText = "";
            this.searchTxtBtn.SelectionLength = 0;
            this.searchTxtBtn.SelectionStart = 0;
            this.searchTxtBtn.ShortcutsEnabled = true;
            this.searchTxtBtn.Size = new System.Drawing.Size(208, 43);
            this.searchTxtBtn.TabIndex = 20;
            this.searchTxtBtn.UseSelectable = true;
            this.searchTxtBtn.WaterMark = "Search by id";
            this.searchTxtBtn.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.searchTxtBtn.WaterMarkFont = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(679, 526);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(568, 25);
            this.label1.TabIndex = 45;
            this.label1.Text = "Please hit the view users button to see all the information";
            // 
            // sellsDGV
            // 
            this.sellsDGV.AllowUserToAddRows = false;
            this.sellsDGV.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.sellsDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.sellsDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.sellsDGV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(41)))), ((int)(((byte)(43)))));
            this.sellsDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sellsDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.sellsDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.sellsDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.sellsDGV.ColumnHeadersHeight = 52;
            this.sellsDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Mname,
            this.Quantity,
            this.PricePerUnit,
            this.TotalPrice});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.sellsDGV.DefaultCellStyle = dataGridViewCellStyle6;
            this.sellsDGV.EnableHeadersVisualStyles = false;
            this.sellsDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.sellsDGV.Location = new System.Drawing.Point(918, 104);
            this.sellsDGV.Name = "sellsDGV";
            this.sellsDGV.ReadOnly = true;
            this.sellsDGV.RowHeadersVisible = false;
            this.sellsDGV.RowHeadersWidth = 51;
            this.sellsDGV.RowTemplate.Height = 24;
            this.sellsDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.sellsDGV.Size = new System.Drawing.Size(520, 209);
            this.sellsDGV.TabIndex = 46;
            this.sellsDGV.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.sellsDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.sellsDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.sellsDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.sellsDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.sellsDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.sellsDGV.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(41)))), ((int)(((byte)(43)))));
            this.sellsDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.sellsDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.sellsDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.sellsDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.sellsDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.sellsDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.sellsDGV.ThemeStyle.HeaderStyle.Height = 52;
            this.sellsDGV.ThemeStyle.ReadOnly = true;
            this.sellsDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.sellsDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.sellsDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.sellsDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.sellsDGV.ThemeStyle.RowsStyle.Height = 24;
            this.sellsDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.sellsDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // Mname
            // 
            this.Mname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Mname.DataPropertyName = "Mname";
            this.Mname.HeaderText = "Name";
            this.Mname.MinimumWidth = 6;
            this.Mname.Name = "Mname";
            this.Mname.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.MinimumWidth = 6;
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // PricePerUnit
            // 
            this.PricePerUnit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PricePerUnit.DataPropertyName = "PricePerUnit";
            this.PricePerUnit.HeaderText = "Price Per Unit";
            this.PricePerUnit.MinimumWidth = 6;
            this.PricePerUnit.Name = "PricePerUnit";
            this.PricePerUnit.ReadOnly = true;
            // 
            // TotalPrice
            // 
            this.TotalPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TotalPrice.DataPropertyName = "TotalPrice";
            this.TotalPrice.HeaderText = "TotalPrice";
            this.TotalPrice.MinimumWidth = 6;
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.ReadOnly = true;
            // 
            // resetUserBtn
            // 
            this.resetUserBtn.AnimationHoverSpeed = 0.07F;
            this.resetUserBtn.AnimationSpeed = 0.03F;
            this.resetUserBtn.BackColor = System.Drawing.Color.Transparent;
            this.resetUserBtn.BaseColor1 = System.Drawing.Color.SlateBlue;
            this.resetUserBtn.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.resetUserBtn.BorderColor = System.Drawing.Color.Black;
            this.resetUserBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.resetUserBtn.FocusedColor = System.Drawing.Color.Empty;
            this.resetUserBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.resetUserBtn.ForeColor = System.Drawing.Color.White;
            this.resetUserBtn.Image = global::pharmacyManagementSystem.Properties.Resources.reset_25px;
            this.resetUserBtn.ImageSize = new System.Drawing.Size(45, 45);
            this.resetUserBtn.Location = new System.Drawing.Point(1339, 501);
            this.resetUserBtn.Name = "resetUserBtn";
            this.resetUserBtn.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.resetUserBtn.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.resetUserBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.resetUserBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.resetUserBtn.OnHoverImage = null;
            this.resetUserBtn.OnPressedColor = System.Drawing.Color.Black;
            this.resetUserBtn.Radius = 15;
            this.resetUserBtn.Size = new System.Drawing.Size(200, 50);
            this.resetUserBtn.TabIndex = 21;
            this.resetUserBtn.Text = "Reset";
            this.resetUserBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.resetUserBtn.Click += new System.EventHandler(this.resetUserBtn_Click);
            // 
            // sellHistoryBtn
            // 
            this.sellHistoryBtn.AnimationHoverSpeed = 0.07F;
            this.sellHistoryBtn.AnimationSpeed = 0.03F;
            this.sellHistoryBtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(41)))), ((int)(((byte)(43)))));
            this.sellHistoryBtn.BorderColor = System.Drawing.Color.Black;
            this.sellHistoryBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.sellHistoryBtn.FocusedColor = System.Drawing.Color.Empty;
            this.sellHistoryBtn.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Bold);
            this.sellHistoryBtn.ForeColor = System.Drawing.Color.White;
            this.sellHistoryBtn.Image = global::pharmacyManagementSystem.Properties.Resources._4110457;
            this.sellHistoryBtn.ImageOffsetX = -10;
            this.sellHistoryBtn.ImageSize = new System.Drawing.Size(25, 25);
            this.sellHistoryBtn.Location = new System.Drawing.Point(63, 588);
            this.sellHistoryBtn.Name = "sellHistoryBtn";
            this.sellHistoryBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.sellHistoryBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.sellHistoryBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.sellHistoryBtn.OnHoverImage = null;
            this.sellHistoryBtn.OnPressedColor = System.Drawing.Color.Black;
            this.sellHistoryBtn.Size = new System.Drawing.Size(217, 45);
            this.sellHistoryBtn.TabIndex = 8;
            this.sellHistoryBtn.Text = "Sells History";
            this.sellHistoryBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.sellHistoryBtn.Click += new System.EventHandler(this.sellHistoryBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.AnimationHoverSpeed = 0.07F;
            this.updateBtn.AnimationSpeed = 0.03F;
            this.updateBtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(41)))), ((int)(((byte)(43)))));
            this.updateBtn.BorderColor = System.Drawing.Color.Black;
            this.updateBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.updateBtn.FocusedColor = System.Drawing.Color.Empty;
            this.updateBtn.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Bold);
            this.updateBtn.ForeColor = System.Drawing.Color.White;
            this.updateBtn.Image = global::pharmacyManagementSystem.Properties.Resources.update_64px;
            this.updateBtn.ImageOffsetX = -10;
            this.updateBtn.ImageSize = new System.Drawing.Size(25, 25);
            this.updateBtn.Location = new System.Drawing.Point(63, 526);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.updateBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.updateBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.updateBtn.OnHoverImage = null;
            this.updateBtn.OnPressedColor = System.Drawing.Color.Black;
            this.updateBtn.Size = new System.Drawing.Size(217, 45);
            this.updateBtn.TabIndex = 7;
            this.updateBtn.Text = "Update";
            this.updateBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // DashBoard
            // 
            this.DashBoard.AnimationHoverSpeed = 0.07F;
            this.DashBoard.AnimationSpeed = 0.03F;
            this.DashBoard.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(41)))), ((int)(((byte)(43)))));
            this.DashBoard.BorderColor = System.Drawing.Color.Black;
            this.DashBoard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DashBoard.DialogResult = System.Windows.Forms.DialogResult.None;
            this.DashBoard.FocusedColor = System.Drawing.Color.Empty;
            this.DashBoard.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Bold);
            this.DashBoard.ForeColor = System.Drawing.Color.White;
            this.DashBoard.Image = global::pharmacyManagementSystem.Properties.Resources.view_64px2;
            this.DashBoard.ImageOffsetX = -10;
            this.DashBoard.ImageSize = new System.Drawing.Size(25, 25);
            this.DashBoard.Location = new System.Drawing.Point(63, 393);
            this.DashBoard.Name = "DashBoard";
            this.DashBoard.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.DashBoard.OnHoverBorderColor = System.Drawing.Color.Black;
            this.DashBoard.OnHoverForeColor = System.Drawing.Color.White;
            this.DashBoard.OnHoverImage = null;
            this.DashBoard.OnPressedColor = System.Drawing.Color.Black;
            this.DashBoard.Size = new System.Drawing.Size(217, 45);
            this.DashBoard.TabIndex = 5;
            this.DashBoard.Text = "View Users";
            this.DashBoard.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DashBoard.Click += new System.EventHandler(this.DashBoard_Click);
            // 
            // addUserBtn
            // 
            this.addUserBtn.AnimationHoverSpeed = 0.07F;
            this.addUserBtn.AnimationSpeed = 0.03F;
            this.addUserBtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(41)))), ((int)(((byte)(43)))));
            this.addUserBtn.BorderColor = System.Drawing.Color.Black;
            this.addUserBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addUserBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.addUserBtn.FocusedColor = System.Drawing.Color.Empty;
            this.addUserBtn.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Bold);
            this.addUserBtn.ForeColor = System.Drawing.Color.White;
            this.addUserBtn.Image = global::pharmacyManagementSystem.Properties.Resources.addUser1;
            this.addUserBtn.ImageOffsetX = -10;
            this.addUserBtn.ImageSize = new System.Drawing.Size(25, 25);
            this.addUserBtn.Location = new System.Drawing.Point(63, 327);
            this.addUserBtn.Name = "addUserBtn";
            this.addUserBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.addUserBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.addUserBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.addUserBtn.OnHoverImage = null;
            this.addUserBtn.OnPressedColor = System.Drawing.Color.Black;
            this.addUserBtn.Size = new System.Drawing.Size(217, 45);
            this.addUserBtn.TabIndex = 4;
            this.addUserBtn.Text = "Add User";
            this.addUserBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.addUserBtn.Click += new System.EventHandler(this.addUserBtn_Click);
            // 
            // searchBtn
            // 
            this.searchBtn.AnimationHoverSpeed = 0.07F;
            this.searchBtn.AnimationSpeed = 0.03F;
            this.searchBtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(41)))), ((int)(((byte)(43)))));
            this.searchBtn.BorderColor = System.Drawing.Color.Black;
            this.searchBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.searchBtn.FocusedColor = System.Drawing.Color.Empty;
            this.searchBtn.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Bold);
            this.searchBtn.ForeColor = System.Drawing.Color.White;
            this.searchBtn.Image = global::pharmacyManagementSystem.Properties.Resources.search_25px;
            this.searchBtn.ImageOffsetX = -10;
            this.searchBtn.ImageSize = new System.Drawing.Size(25, 25);
            this.searchBtn.Location = new System.Drawing.Point(63, 459);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.searchBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.searchBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.searchBtn.OnHoverImage = null;
            this.searchBtn.OnPressedColor = System.Drawing.Color.Black;
            this.searchBtn.Size = new System.Drawing.Size(217, 45);
            this.searchBtn.TabIndex = 3;
            this.searchBtn.Text = "Search";
            this.searchBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.AnimationHoverSpeed = 0.07F;
            this.deleteBtn.AnimationSpeed = 0.03F;
            this.deleteBtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(41)))), ((int)(((byte)(43)))));
            this.deleteBtn.BorderColor = System.Drawing.Color.Black;
            this.deleteBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.deleteBtn.FocusedColor = System.Drawing.Color.Empty;
            this.deleteBtn.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Bold);
            this.deleteBtn.ForeColor = System.Drawing.Color.White;
            this.deleteBtn.Image = global::pharmacyManagementSystem.Properties.Resources.remove_25px2;
            this.deleteBtn.ImageOffsetX = -10;
            this.deleteBtn.ImageSize = new System.Drawing.Size(25, 25);
            this.deleteBtn.Location = new System.Drawing.Point(63, 655);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.deleteBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.deleteBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.deleteBtn.OnHoverImage = null;
            this.deleteBtn.OnPressedColor = System.Drawing.Color.Black;
            this.deleteBtn.Size = new System.Drawing.Size(217, 45);
            this.deleteBtn.TabIndex = 2;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Image = global::pharmacyManagementSystem.Properties.Resources.admin31;
            this.gunaPictureBox1.Location = new System.Drawing.Point(63, 12);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(200, 208);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaPictureBox1.TabIndex = 1;
            this.gunaPictureBox1.TabStop = false;
            // 
            // logoutBtn
            // 
            this.logoutBtn.AnimationHoverSpeed = 0.07F;
            this.logoutBtn.AnimationSpeed = 0.03F;
            this.logoutBtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(41)))), ((int)(((byte)(43)))));
            this.logoutBtn.BorderColor = System.Drawing.Color.Black;
            this.logoutBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.logoutBtn.FocusedColor = System.Drawing.Color.Empty;
            this.logoutBtn.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutBtn.ForeColor = System.Drawing.Color.White;
            this.logoutBtn.Image = global::pharmacyManagementSystem.Properties.Resources.logout1;
            this.logoutBtn.ImageOffsetX = -10;
            this.logoutBtn.ImageSize = new System.Drawing.Size(25, 25);
            this.logoutBtn.Location = new System.Drawing.Point(63, 706);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.logoutBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.logoutBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.logoutBtn.OnHoverImage = null;
            this.logoutBtn.OnPressedColor = System.Drawing.Color.Black;
            this.logoutBtn.Size = new System.Drawing.Size(217, 45);
            this.logoutBtn.TabIndex = 0;
            this.logoutBtn.Text = "Logout";
            this.logoutBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(1064, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 25);
            this.label2.TabIndex = 47;
            this.label2.Text = "Selling History Info\r\n";
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1530, 774);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sellsDGV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.resetUserBtn);
            this.Controls.Add(this.searchTxtBtn);
            this.Controls.Add(this.dobDateTimePicker);
            this.Controls.Add(this.roleComboBox);
            this.Controls.Add(this.emailTxtBox);
            this.Controls.Add(this.passwordTxtBox);
            this.Controls.Add(this.nameTxtBox);
            this.Controls.Add(this.idTxtBox);
            this.Controls.Add(this.gunaLabel7);
            this.Controls.Add(this.gunaLabel6);
            this.Controls.Add(this.gunaLabel5);
            this.Controls.Add(this.gunaLabel4);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.dgvUsers);
            this.Controls.Add(this.gunaPanel1);
            this.Name = "Admin";
            this.Text = "Admin";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Admin_FormClosed);
            this.Load += new System.EventHandler(this.Admin_Load);
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellsDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaButton logoutBtn;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private Guna.UI.WinForms.GunaButton deleteBtn;
        private Guna.UI.WinForms.GunaButton addUserBtn;
        private Guna.UI.WinForms.GunaButton searchBtn;
        private Guna.UI.WinForms.GunaButton DashBoard;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaDataGridView dgvUsers;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn User_Role;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date_Of_Birth;
        private System.Windows.Forms.DataGridViewTextBoxColumn User_Name;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        private Guna.UI.WinForms.GunaLabel gunaLabel7;
        private Guna.UI.WinForms.GunaLineTextBox idTxtBox;
        private Guna.UI.WinForms.GunaLineTextBox nameTxtBox;
        private Guna.UI.WinForms.GunaLineTextBox passwordTxtBox;
        private Guna.UI.WinForms.GunaLineTextBox emailTxtBox;
        private Guna.UI.WinForms.GunaComboBox roleComboBox;
        private Guna.UI.WinForms.GunaDateTimePicker dobDateTimePicker;
        private MetroFramework.Controls.MetroTextBox searchTxtBtn;
        private Guna.UI.WinForms.GunaButton updateBtn;
        private Guna.UI.WinForms.GunaGradientButton resetUserBtn;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaDataGridView sellsDGV;
        private Guna.UI.WinForms.GunaButton sellHistoryBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn PricePerUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPrice;
        private System.Windows.Forms.Label label2;
    }
}