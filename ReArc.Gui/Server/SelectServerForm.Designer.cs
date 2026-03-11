namespace ReArc.Gui.Server
{
    partial class SelectServerForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectServerForm));
            label1 = new Label();
            ConnectButton = new Button();
            ExitButton = new Button();
            DeleteButton = new Button();
            AddButton = new Button();
            EditButton = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            ServerListBox = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            imageList1 = new ImageList(components);
            pictureBox1 = new PictureBox();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 20);
            label1.Name = "label1";
            label1.Size = new Size(256, 15);
            label1.TabIndex = 0;
            label1.Text = "Select the server to which you want to connect:";
            // 
            // ConnectButton
            // 
            ConnectButton.Enabled = false;
            ConnectButton.Location = new Point(302, 244);
            ConnectButton.Name = "ConnectButton";
            ConnectButton.Size = new Size(75, 23);
            ConnectButton.TabIndex = 2;
            ConnectButton.Text = "Connect";
            ConnectButton.UseVisualStyleBackColor = true;
            ConnectButton.Click += ConnectButton_Click;
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(221, 244);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(75, 23);
            ExitButton.TabIndex = 3;
            ExitButton.Text = "Exit";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += CancelButton_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.Enabled = false;
            DeleteButton.Location = new Point(80, 244);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(52, 23);
            DeleteButton.TabIndex = 4;
            DeleteButton.Text = "Delete";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // AddButton
            // 
            AddButton.Location = new Point(23, 244);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(51, 23);
            AddButton.TabIndex = 5;
            AddButton.Text = "Add...";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // EditButton
            // 
            EditButton.Enabled = false;
            EditButton.Location = new Point(138, 244);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(42, 23);
            EditButton.TabIndex = 6;
            EditButton.Text = "Edit";
            EditButton.UseVisualStyleBackColor = true;
            EditButton.Click += EditButton_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(panel1, 0, 1);
            tableLayoutPanel1.Controls.Add(pictureBox1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(400, 360);
            tableLayoutPanel1.TabIndex = 7;
            // 
            // panel1
            // 
            panel1.Controls.Add(ServerListBox);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(EditButton);
            panel1.Controls.Add(AddButton);
            panel1.Controls.Add(ConnectButton);
            panel1.Controls.Add(DeleteButton);
            panel1.Controls.Add(ExitButton);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 70);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(20);
            panel1.Size = new Size(400, 290);
            panel1.TabIndex = 0;
            // 
            // ServerListBox
            // 
            ServerListBox.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
            ServerListBox.Location = new Point(23, 50);
            ServerListBox.MultiSelect = false;
            ServerListBox.Name = "ServerListBox";
            ServerListBox.Size = new Size(354, 184);
            ServerListBox.SmallImageList = imageList1;
            ServerListBox.TabIndex = 7;
            ServerListBox.UseCompatibleStateImageBehavior = false;
            ServerListBox.View = View.Details;
            ServerListBox.SelectedIndexChanged += ServerListBox_SelectedIndexChanged;
            ServerListBox.DoubleClick += ServerListBox_DoubleClick;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Server";
            columnHeader1.Width = 250;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Logged in as";
            columnHeader2.Width = 100;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "lock16.png");
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.banner;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(400, 70);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // SelectServerForm
            // 
            AcceptButton = ConnectButton;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = ExitButton;
            ClientSize = new Size(400, 360);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SelectServerForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Choose Server";
            Load += SelectServerForm_Load;
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button ConnectButton;
        private Button ExitButton;
        private Button DeleteButton;
        private Button AddButton;
        private Button EditButton;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private PictureBox pictureBox1;
        private ListView ServerListBox;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ImageList imageList1;
    }
}
