namespace ReArc.Gui.Views
{
    partial class Users
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            UserListView = new DataGridView();
            ProfilePicture = new DataGridViewImageColumn();
            Username = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            Created = new DataGridViewTextBoxColumn();
            Approved = new DataGridViewCheckBoxColumn();
            Admin = new DataGridViewCheckBoxColumn();
            View = new DataGridViewImageColumn();
            Copy = new DataGridViewImageColumn();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            FilterDropdown = new ComboBox();
            SearchButton = new Button();
            SearchBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)UserListView).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // UserListView
            // 
            UserListView.AllowUserToAddRows = false;
            UserListView.AllowUserToDeleteRows = false;
            UserListView.BackgroundColor = Color.White;
            UserListView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            UserListView.Columns.AddRange(new DataGridViewColumn[] { ProfilePicture, Username, Email, Created, Approved, Admin, View, Copy });
            UserListView.Dock = DockStyle.Fill;
            UserListView.Location = new Point(15, 55);
            UserListView.Margin = new Padding(15, 0, 15, 15);
            UserListView.Name = "UserListView";
            UserListView.ReadOnly = true;
            UserListView.RowHeadersVisible = false;
            UserListView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            UserListView.Size = new Size(854, 476);
            UserListView.TabIndex = 0;
            UserListView.CellClick += UserListView_CellContentClick;
            // 
            // ProfilePicture
            // 
            ProfilePicture.HeaderText = "";
            ProfilePicture.Image = Properties.Resources.user;
            ProfilePicture.ImageLayout = DataGridViewImageCellLayout.Zoom;
            ProfilePicture.MinimumWidth = 16;
            ProfilePicture.Name = "ProfilePicture";
            ProfilePicture.ReadOnly = true;
            ProfilePicture.Resizable = DataGridViewTriState.False;
            ProfilePicture.Width = 24;
            // 
            // Username
            // 
            Username.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Username.HeaderText = "Username";
            Username.Name = "Username";
            Username.ReadOnly = true;
            Username.Width = 85;
            // 
            // Email
            // 
            Email.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Email.HeaderText = "Email";
            Email.Name = "Email";
            Email.ReadOnly = true;
            Email.Width = 61;
            // 
            // Created
            // 
            Created.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Created.HeaderText = "Created";
            Created.Name = "Created";
            Created.ReadOnly = true;
            Created.Resizable = DataGridViewTriState.False;
            Created.Width = 73;
            // 
            // Approved
            // 
            Approved.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Approved.HeaderText = "Approved";
            Approved.Name = "Approved";
            Approved.ReadOnly = true;
            Approved.Resizable = DataGridViewTriState.False;
            Approved.SortMode = DataGridViewColumnSortMode.Automatic;
            Approved.Width = 84;
            // 
            // Admin
            // 
            Admin.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Admin.HeaderText = "Admin";
            Admin.Name = "Admin";
            Admin.ReadOnly = true;
            Admin.Resizable = DataGridViewTriState.False;
            Admin.SortMode = DataGridViewColumnSortMode.Automatic;
            Admin.Width = 68;
            // 
            // View
            // 
            View.HeaderText = "";
            View.Image = Properties.Resources.id16;
            View.MinimumWidth = 16;
            View.Name = "View";
            View.ReadOnly = true;
            View.Resizable = DataGridViewTriState.False;
            View.ToolTipText = "View User";
            View.Width = 24;
            // 
            // Copy
            // 
            Copy.HeaderText = "";
            Copy.Image = Properties.Resources.copy16;
            Copy.MinimumWidth = 16;
            Copy.Name = "Copy";
            Copy.ReadOnly = true;
            Copy.Resizable = DataGridViewTriState.False;
            Copy.ToolTipText = "Copy...";
            Copy.Width = 24;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(UserListView, 0, 1);
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 55F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(884, 546);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(FilterDropdown);
            panel1.Controls.Add(SearchButton);
            panel1.Controls.Add(SearchBox);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(15);
            panel1.Size = new Size(884, 55);
            panel1.TabIndex = 1;
            // 
            // FilterDropdown
            // 
            FilterDropdown.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            FilterDropdown.DropDownStyle = ComboBoxStyle.DropDownList;
            FilterDropdown.FormattingEnabled = true;
            FilterDropdown.Items.AddRange(new object[] { "All", "Regular", "Admins", "Approved", "Disapproved" });
            FilterDropdown.Location = new Point(748, 18);
            FilterDropdown.Margin = new Padding(0);
            FilterDropdown.Name = "FilterDropdown";
            FilterDropdown.Size = new Size(121, 23);
            FilterDropdown.TabIndex = 2;
            FilterDropdown.SelectedIndexChanged += FilterDropdown_SelectedIndexChanged;
            // 
            // SearchButton
            // 
            SearchButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            SearchButton.Image = Properties.Resources.search16;
            SearchButton.Location = new Point(720, 17);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(25, 25);
            SearchButton.TabIndex = 1;
            SearchButton.UseVisualStyleBackColor = true;
            SearchButton.Click += SearchButton_Click;
            // 
            // SearchBox
            // 
            SearchBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            SearchBox.CharacterCasing = CharacterCasing.Lower;
            SearchBox.Location = new Point(15, 18);
            SearchBox.Margin = new Padding(0);
            SearchBox.Name = "SearchBox";
            SearchBox.Size = new Size(702, 23);
            SearchBox.TabIndex = 0;
            SearchBox.KeyDown += SearchBox_KeyDown;
            // 
            // Users
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "Users";
            Size = new Size(884, 546);
            ((System.ComponentModel.ISupportInitialize)UserListView).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView UserListView;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Button SearchButton;
        private TextBox SearchBox;
        private ComboBox FilterDropdown;
        private DataGridViewImageColumn ProfilePicture;
        private DataGridViewTextBoxColumn Username;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Created;
        private DataGridViewCheckBoxColumn Approved;
        private DataGridViewCheckBoxColumn Admin;
        private DataGridViewImageColumn View;
        private DataGridViewImageColumn Copy;
    }
}
