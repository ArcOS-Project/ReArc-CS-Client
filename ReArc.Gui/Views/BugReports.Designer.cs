namespace ReArc.Gui.Views
{
    partial class BugReports
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
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            groupBox1 = new GroupBox();
            label1 = new Label();
            ClosedLabel = new Label();
            label4 = new Label();
            OpenedLabel = new Label();
            ApisLabel = new Label();
            label3 = new Label();
            label7 = new Label();
            TotalLabel = new Label();
            panel2 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel3 = new Panel();
            FilterDropdown = new ComboBox();
            SearchButton = new Button();
            SearchBox = new TextBox();
            ReportListView = new DataGridView();
            Logo = new DataGridViewImageColumn();
            Timestamp = new DataGridViewTextBoxColumn();
            Title = new DataGridViewTextBoxColumn();
            Author = new DataGridViewTextBoxColumn();
            Opened = new DataGridViewCheckBoxColumn();
            UserData = new DataGridViewCheckBoxColumn();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ReportListView).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 250F));
            tableLayoutPanel1.Controls.Add(panel1, 1, 0);
            tableLayoutPanel1.Controls.Add(panel2, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(884, 546);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.dashboardstatbg2;
            panel1.BackgroundImageLayout = ImageLayout.None;
            panel1.Controls.Add(groupBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(634, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(15);
            panel1.Size = new Size(250, 546);
            panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            groupBox1.BackColor = Color.Transparent;
            groupBox1.BackgroundImageLayout = ImageLayout.None;
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(ClosedLabel);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(OpenedLabel);
            groupBox1.Controls.Add(ApisLabel);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(TotalLabel);
            groupBox1.Location = new Point(15, 15);
            groupBox1.Margin = new Padding(0);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(8);
            groupBox1.Size = new Size(220, 516);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Report Statistics";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(11, 24);
            label1.Name = "label1";
            label1.Size = new Size(92, 15);
            label1.TabIndex = 10;
            label1.Text = "Opened Reports";
            // 
            // ClosedLabel
            // 
            ClosedLabel.AutoSize = true;
            ClosedLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            ClosedLabel.Location = new Point(11, 95);
            ClosedLabel.Name = "ClosedLabel";
            ClosedLabel.Size = new Size(25, 32);
            ClosedLabel.TabIndex = 13;
            ClosedLabel.Text = "?";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Navy;
            label4.Location = new Point(11, 80);
            label4.Name = "label4";
            label4.Size = new Size(86, 15);
            label4.TabIndex = 12;
            label4.Text = "Closed Reports";
            // 
            // OpenedLabel
            // 
            OpenedLabel.AutoSize = true;
            OpenedLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            OpenedLabel.Location = new Point(11, 39);
            OpenedLabel.Name = "OpenedLabel";
            OpenedLabel.Size = new Size(25, 32);
            OpenedLabel.TabIndex = 11;
            OpenedLabel.Text = "?";
            // 
            // ApisLabel
            // 
            ApisLabel.AutoSize = true;
            ApisLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            ApisLabel.Location = new Point(11, 207);
            ApisLabel.Name = "ApisLabel";
            ApisLabel.Size = new Size(25, 32);
            ApisLabel.TabIndex = 19;
            ApisLabel.Text = "?";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Navy;
            label3.Location = new Point(11, 136);
            label3.Name = "label3";
            label3.Size = new Size(75, 15);
            label3.TabIndex = 16;
            label3.Text = "Total Reports";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.Navy;
            label7.Location = new Point(11, 192);
            label7.Name = "label7";
            label7.Size = new Size(30, 15);
            label7.TabIndex = 18;
            label7.Text = "APIs";
            // 
            // TotalLabel
            // 
            TotalLabel.AutoSize = true;
            TotalLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            TotalLabel.Location = new Point(11, 151);
            TotalLabel.Name = "TotalLabel";
            TotalLabel.Size = new Size(25, 32);
            TotalLabel.TabIndex = 17;
            TotalLabel.Text = "?";
            // 
            // panel2
            // 
            panel2.Controls.Add(tableLayoutPanel2);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(634, 546);
            panel2.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(panel3, 0, 0);
            tableLayoutPanel2.Controls.Add(ReportListView, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 55F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(634, 546);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(FilterDropdown);
            panel3.Controls.Add(SearchButton);
            panel3.Controls.Add(SearchBox);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 0);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(15, 15, 0, 15);
            panel3.Size = new Size(634, 55);
            panel3.TabIndex = 0;
            // 
            // FilterDropdown
            // 
            FilterDropdown.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            FilterDropdown.DropDownStyle = ComboBoxStyle.DropDownList;
            FilterDropdown.FormattingEnabled = true;
            FilterDropdown.Items.AddRange(new object[] { "All", "System", "Apps", "Opened", "Closed", "With user data", "No user data" });
            FilterDropdown.Location = new Point(510, 18);
            FilterDropdown.Name = "FilterDropdown";
            FilterDropdown.Size = new Size(121, 23);
            FilterDropdown.TabIndex = 4;
            FilterDropdown.SelectedIndexChanged += FilterDropdown_SelectedIndexChanged;
            // 
            // SearchButton
            // 
            SearchButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            SearchButton.Image = Properties.Resources.search16;
            SearchButton.Location = new Point(480, 17);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(25, 25);
            SearchButton.TabIndex = 3;
            SearchButton.UseVisualStyleBackColor = true;
            SearchButton.Click += SearchButton_Click;
            // 
            // SearchBox
            // 
            SearchBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            SearchBox.Location = new Point(18, 18);
            SearchBox.Name = "SearchBox";
            SearchBox.Size = new Size(457, 23);
            SearchBox.TabIndex = 0;
            SearchBox.KeyDown += SearchBox_KeyDown;
            // 
            // ReportListView
            // 
            ReportListView.AllowUserToAddRows = false;
            ReportListView.AllowUserToDeleteRows = false;
            ReportListView.BackgroundColor = Color.White;
            ReportListView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ReportListView.Columns.AddRange(new DataGridViewColumn[] { Logo, Timestamp, Title, Author, Opened, UserData });
            ReportListView.Dock = DockStyle.Fill;
            ReportListView.Location = new Point(15, 55);
            ReportListView.Margin = new Padding(15, 0, 0, 15);
            ReportListView.Name = "ReportListView";
            ReportListView.ReadOnly = true;
            ReportListView.RowHeadersVisible = false;
            ReportListView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ReportListView.Size = new Size(619, 476);
            ReportListView.TabIndex = 1;
            // 
            // Logo
            // 
            Logo.HeaderText = "";
            Logo.Image = Properties.Resources.crash16;
            Logo.MinimumWidth = 16;
            Logo.Name = "Logo";
            Logo.ReadOnly = true;
            Logo.Width = 24;
            // 
            // Timestamp
            // 
            Timestamp.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Timestamp.HeaderText = "Timestamp";
            Timestamp.Name = "Timestamp";
            Timestamp.ReadOnly = true;
            Timestamp.SortMode = DataGridViewColumnSortMode.NotSortable;
            Timestamp.Width = 72;
            // 
            // Title
            // 
            Title.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Title.HeaderText = "Title";
            Title.Name = "Title";
            Title.ReadOnly = true;
            // 
            // Author
            // 
            Author.HeaderText = "Author";
            Author.Name = "Author";
            Author.ReadOnly = true;
            // 
            // Opened
            // 
            Opened.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Opened.HeaderText = "Opened";
            Opened.Name = "Opened";
            Opened.ReadOnly = true;
            Opened.Width = 55;
            // 
            // UserData
            // 
            UserData.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            UserData.HeaderText = "User Data?";
            UserData.Name = "UserData";
            UserData.ReadOnly = true;
            UserData.Resizable = DataGridViewTriState.True;
            UserData.SortMode = DataGridViewColumnSortMode.Automatic;
            UserData.Width = 87;
            // 
            // BugReports
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(tableLayoutPanel1);
            Name = "BugReports";
            Size = new Size(884, 546);
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel2.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ReportListView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private GroupBox groupBox1;
        private Panel panel2;
        private Label label1;
        private Label ClosedLabel;
        private Label label4;
        private Label OpenedLabel;
        private Label ApisLabel;
        private Label label3;
        private Label label7;
        private Label TotalLabel;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel3;
        private TextBox SearchBox;
        private ComboBox FilterDropdown;
        private Button SearchButton;
        private DataGridView ReportListView;
        private DataGridViewImageColumn Logo;
        private DataGridViewTextBoxColumn Timestamp;
        private DataGridViewTextBoxColumn Title;
        private DataGridViewTextBoxColumn Author;
        private DataGridViewCheckBoxColumn Opened;
        private DataGridViewCheckBoxColumn UserData;
    }
}
