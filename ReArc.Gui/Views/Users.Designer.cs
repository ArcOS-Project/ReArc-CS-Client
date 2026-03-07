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
            ((System.ComponentModel.ISupportInitialize)UserListView).BeginInit();
            SuspendLayout();
            // 
            // UserListView
            // 
            UserListView.AllowUserToAddRows = false;
            UserListView.AllowUserToDeleteRows = false;
            UserListView.BackgroundColor = SystemColors.Control;
            UserListView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            UserListView.Columns.AddRange(new DataGridViewColumn[] { ProfilePicture, Username, Email, Created, Approved, Admin, View, Copy });
            UserListView.Dock = DockStyle.Fill;
            UserListView.Location = new Point(0, 0);
            UserListView.Name = "UserListView";
            UserListView.ReadOnly = true;
            UserListView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            UserListView.Size = new Size(647, 267);
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
            // Users
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(UserListView);
            Name = "Users";
            Size = new Size(647, 267);
            ((System.ComponentModel.ISupportInitialize)UserListView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView UserListView;
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
