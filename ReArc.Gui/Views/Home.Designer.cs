namespace ReArc.Gui.Views
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            label1 = new Label();
            TokensLabel = new Label();
            UsersLabel = new Label();
            label4 = new Label();
            IndexesLabel = new Label();
            label6 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            groupBox1 = new GroupBox();
            ActivitiesLabel = new Label();
            label13 = new Label();
            AuditLogLabel = new Label();
            label11 = new Label();
            BugReportsLabel = new Label();
            label9 = new Label();
            AccessorsLabel = new Label();
            label3 = new Label();
            label7 = new Label();
            ApprovalsLabel = new Label();
            panel2 = new Panel();
            LoggedInAsLabel = new Label();
            ProfilePictureBox = new PictureBox();
            GreetingBox = new Label();
            groupBox2 = new GroupBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            groupBox3 = new GroupBox();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            groupBox4 = new GroupBox();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ProfilePictureBox).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(11, 24);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 0;
            label1.Text = "User Tokens";
            // 
            // TokensLabel
            // 
            TokensLabel.AutoSize = true;
            TokensLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            TokensLabel.Location = new Point(11, 39);
            TokensLabel.Name = "TokensLabel";
            TokensLabel.Size = new Size(25, 32);
            TokensLabel.TabIndex = 1;
            TokensLabel.Text = "?";
            // 
            // UsersLabel
            // 
            UsersLabel.AutoSize = true;
            UsersLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            UsersLabel.Location = new Point(11, 95);
            UsersLabel.Name = "UsersLabel";
            UsersLabel.Size = new Size(25, 32);
            UsersLabel.TabIndex = 3;
            UsersLabel.Text = "?";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Navy;
            label4.Location = new Point(11, 80);
            label4.Name = "label4";
            label4.Size = new Size(83, 15);
            label4.TabIndex = 2;
            label4.Text = "User Accounts";
            // 
            // IndexesLabel
            // 
            IndexesLabel.AutoSize = true;
            IndexesLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            IndexesLabel.Location = new Point(11, 151);
            IndexesLabel.Name = "IndexesLabel";
            IndexesLabel.Size = new Size(25, 32);
            IndexesLabel.TabIndex = 5;
            IndexesLabel.Text = "?";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.Navy;
            label6.Location = new Point(11, 136);
            label6.Name = "label6";
            label6.Size = new Size(104, 15);
            label6.TabIndex = 4;
            label6.Text = "Filesystem Indexes";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.White;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 250F));
            tableLayoutPanel1.Controls.Add(panel1, 1, 0);
            tableLayoutPanel1.Controls.Add(panel2, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(884, 546);
            tableLayoutPanel1.TabIndex = 6;
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
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
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(ActivitiesLabel);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(UsersLabel);
            groupBox1.Controls.Add(AuditLogLabel);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(BugReportsLabel);
            groupBox1.Controls.Add(TokensLabel);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(IndexesLabel);
            groupBox1.Controls.Add(AccessorsLabel);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(ApprovalsLabel);
            groupBox1.Location = new Point(18, 18);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(8);
            groupBox1.Size = new Size(214, 510);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Server Statistics";
            // 
            // ActivitiesLabel
            // 
            ActivitiesLabel.AutoSize = true;
            ActivitiesLabel.BackColor = Color.Transparent;
            ActivitiesLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            ActivitiesLabel.Location = new Point(11, 431);
            ActivitiesLabel.Name = "ActivitiesLabel";
            ActivitiesLabel.Size = new Size(25, 32);
            ActivitiesLabel.TabIndex = 15;
            ActivitiesLabel.Text = "?";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.ForeColor = Color.Navy;
            label13.Location = new Point(11, 416);
            label13.Name = "label13";
            label13.Size = new Size(88, 15);
            label13.TabIndex = 14;
            label13.Text = "Login Activities";
            // 
            // AuditLogLabel
            // 
            AuditLogLabel.AutoSize = true;
            AuditLogLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            AuditLogLabel.Location = new Point(11, 375);
            AuditLogLabel.Name = "AuditLogLabel";
            AuditLogLabel.Size = new Size(25, 32);
            AuditLogLabel.TabIndex = 13;
            AuditLogLabel.Text = "?";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = Color.Navy;
            label11.Location = new Point(11, 360);
            label11.Name = "label11";
            label11.Size = new Size(64, 15);
            label11.TabIndex = 12;
            label11.Text = "Audit Logs";
            // 
            // BugReportsLabel
            // 
            BugReportsLabel.AutoSize = true;
            BugReportsLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            BugReportsLabel.Location = new Point(11, 319);
            BugReportsLabel.Name = "BugReportsLabel";
            BugReportsLabel.Size = new Size(25, 32);
            BugReportsLabel.TabIndex = 11;
            BugReportsLabel.Text = "?";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.Navy;
            label9.Location = new Point(11, 304);
            label9.Name = "label9";
            label9.Size = new Size(71, 15);
            label9.TabIndex = 10;
            label9.Text = "Bug Reports";
            // 
            // AccessorsLabel
            // 
            AccessorsLabel.AutoSize = true;
            AccessorsLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            AccessorsLabel.Location = new Point(11, 263);
            AccessorsLabel.Name = "AccessorsLabel";
            AccessorsLabel.Size = new Size(25, 32);
            AccessorsLabel.TabIndex = 9;
            AccessorsLabel.Text = "?";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Navy;
            label3.Location = new Point(11, 192);
            label3.Name = "label3";
            label3.Size = new Size(108, 15);
            label3.TabIndex = 6;
            label3.Text = "Account Approvals";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.Navy;
            label7.Location = new Point(11, 248);
            label7.Name = "label7";
            label7.Size = new Size(117, 15);
            label7.TabIndex = 8;
            label7.Text = "Filesystem Accessors";
            // 
            // ApprovalsLabel
            // 
            ApprovalsLabel.AutoSize = true;
            ApprovalsLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            ApprovalsLabel.Location = new Point(11, 207);
            ApprovalsLabel.Name = "ApprovalsLabel";
            ApprovalsLabel.Size = new Size(25, 32);
            ApprovalsLabel.TabIndex = 7;
            ApprovalsLabel.Text = "?";
            // 
            // panel2
            // 
            panel2.Controls.Add(groupBox4);
            panel2.Controls.Add(groupBox3);
            panel2.Controls.Add(groupBox2);
            panel2.Controls.Add(LoggedInAsLabel);
            panel2.Controls.Add(ProfilePictureBox);
            panel2.Controls.Add(GreetingBox);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(25);
            panel2.Size = new Size(634, 546);
            panel2.TabIndex = 1;
            // 
            // LoggedInAsLabel
            // 
            LoggedInAsLabel.AutoSize = true;
            LoggedInAsLabel.Location = new Point(28, 57);
            LoggedInAsLabel.Name = "LoggedInAsLabel";
            LoggedInAsLabel.Size = new Size(173, 15);
            LoggedInAsLabel.TabIndex = 2;
            LoggedInAsLabel.Text = "Logged in as (email) on (server)";
            // 
            // ProfilePictureBox
            // 
            ProfilePictureBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ProfilePictureBox.BackgroundImage = Properties.Resources.user;
            ProfilePictureBox.BackgroundImageLayout = ImageLayout.Zoom;
            ProfilePictureBox.Location = new Point(478, 28);
            ProfilePictureBox.Name = "ProfilePictureBox";
            ProfilePictureBox.Size = new Size(128, 128);
            ProfilePictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            ProfilePictureBox.TabIndex = 1;
            ProfilePictureBox.TabStop = false;
            // 
            // GreetingBox
            // 
            GreetingBox.AutoSize = true;
            GreetingBox.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            GreetingBox.Location = new Point(28, 25);
            GreetingBox.Name = "GreetingBox";
            GreetingBox.Size = new Size(247, 25);
            GreetingBox.TabIndex = 0;
            GreetingBox.Text = "Good afternoon, username!";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button3);
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(button1);
            groupBox2.Location = new Point(28, 89);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(10);
            groupBox2.Size = new Size(129, 146);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Users && Security";
            // 
            // button1
            // 
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.Image = Properties.Resources.users16;
            button1.ImageAlign = ContentAlignment.TopLeft;
            button1.Location = new Point(13, 24);
            button1.Name = "button1";
            button1.Padding = new Padding(0, 0, 10, 0);
            button1.Size = new Size(102, 23);
            button1.TabIndex = 4;
            button1.Text = "Users";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.BackgroundImageLayout = ImageLayout.Zoom;
            button2.Image = Properties.Resources.keys16;
            button2.ImageAlign = ContentAlignment.TopLeft;
            button2.Location = new Point(13, 53);
            button2.Name = "button2";
            button2.Padding = new Padding(0, 0, 10, 0);
            button2.Size = new Size(102, 23);
            button2.TabIndex = 5;
            button2.Text = "Tokens";
            button2.TextAlign = ContentAlignment.MiddleRight;
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.BackgroundImageLayout = ImageLayout.Zoom;
            button3.Image = Properties.Resources.flag16;
            button3.ImageAlign = ContentAlignment.TopLeft;
            button3.Location = new Point(13, 80);
            button3.Name = "button3";
            button3.Padding = new Padding(0, 0, 10, 0);
            button3.Size = new Size(102, 23);
            button3.TabIndex = 6;
            button3.Text = "Activities";
            button3.TextAlign = ContentAlignment.MiddleRight;
            button3.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(button4);
            groupBox3.Controls.Add(button5);
            groupBox3.Controls.Add(button6);
            groupBox3.Location = new Point(163, 89);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(10);
            groupBox3.Size = new Size(142, 146);
            groupBox3.TabIndex = 7;
            groupBox3.TabStop = false;
            groupBox3.Text = "Content";
            // 
            // button4
            // 
            button4.BackgroundImageLayout = ImageLayout.Zoom;
            button4.Image = Properties.Resources.installer16;
            button4.ImageAlign = ContentAlignment.TopLeft;
            button4.Location = new Point(13, 80);
            button4.Name = "button4";
            button4.Padding = new Padding(0, 0, 10, 0);
            button4.Size = new Size(116, 23);
            button4.TabIndex = 6;
            button4.Text = "App Store";
            button4.TextAlign = ContentAlignment.MiddleRight;
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.BackgroundImageLayout = ImageLayout.Zoom;
            button5.Image = Properties.Resources.share16;
            button5.ImageAlign = ContentAlignment.TopLeft;
            button5.Location = new Point(13, 53);
            button5.Name = "button5";
            button5.Padding = new Padding(0, 0, 10, 0);
            button5.Size = new Size(116, 23);
            button5.TabIndex = 5;
            button5.Text = "Shares";
            button5.TextAlign = ContentAlignment.MiddleRight;
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.BackgroundImageLayout = ImageLayout.Zoom;
            button6.Image = Properties.Resources.keyfs16;
            button6.ImageAlign = ContentAlignment.TopLeft;
            button6.Location = new Point(13, 24);
            button6.Name = "button6";
            button6.Padding = new Padding(0, 0, 10, 0);
            button6.Size = new Size(116, 23);
            button6.TabIndex = 4;
            button6.Text = "Filesystems";
            button6.TextAlign = ContentAlignment.MiddleRight;
            button6.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(button10);
            groupBox4.Controls.Add(button7);
            groupBox4.Controls.Add(button8);
            groupBox4.Controls.Add(button9);
            groupBox4.Location = new Point(311, 89);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(10);
            groupBox4.Size = new Size(142, 146);
            groupBox4.TabIndex = 8;
            groupBox4.TabStop = false;
            groupBox4.Text = "Administration";
            // 
            // button7
            // 
            button7.BackgroundImageLayout = ImageLayout.Zoom;
            button7.Image = Properties.Resources.cabinet1;
            button7.ImageAlign = ContentAlignment.TopLeft;
            button7.Location = new Point(13, 80);
            button7.Name = "button7";
            button7.Padding = new Padding(0, 0, 10, 0);
            button7.Size = new Size(116, 23);
            button7.TabIndex = 6;
            button7.Text = "Audit Log";
            button7.TextAlign = ContentAlignment.MiddleRight;
            button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.BackgroundImageLayout = ImageLayout.Zoom;
            button8.Image = Properties.Resources.elevate16;
            button8.ImageAlign = ContentAlignment.TopLeft;
            button8.Location = new Point(13, 53);
            button8.Name = "button8";
            button8.Padding = new Padding(0, 0, 10, 0);
            button8.Size = new Size(116, 23);
            button8.TabIndex = 5;
            button8.Text = "Scopes";
            button8.TextAlign = ContentAlignment.MiddleRight;
            button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.BackgroundImageLayout = ImageLayout.Zoom;
            button9.Image = Properties.Resources.crash16;
            button9.ImageAlign = ContentAlignment.TopLeft;
            button9.Location = new Point(13, 24);
            button9.Name = "button9";
            button9.Padding = new Padding(0, 0, 10, 0);
            button9.Size = new Size(116, 23);
            button9.TabIndex = 4;
            button9.Text = "Bug Reports";
            button9.TextAlign = ContentAlignment.MiddleRight;
            button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            button10.BackgroundImageLayout = ImageLayout.Zoom;
            button10.Image = Properties.Resources.event16;
            button10.ImageAlign = ContentAlignment.TopLeft;
            button10.Location = new Point(13, 109);
            button10.Name = "button10";
            button10.Padding = new Padding(0, 0, 10, 0);
            button10.Size = new Size(116, 23);
            button10.TabIndex = 7;
            button10.Text = "Logs";
            button10.TextAlign = ContentAlignment.MiddleRight;
            button10.UseVisualStyleBackColor = true;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "Home";
            Size = new Size(884, 546);
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ProfilePictureBox).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label TokensLabel;
        private Label UsersLabel;
        private Label label4;
        private Label IndexesLabel;
        private Label label6;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Label ActivitiesLabel;
        private Label label13;
        private Label AuditLogLabel;
        private Label label11;
        private Label BugReportsLabel;
        private Label label9;
        private Label AccessorsLabel;
        private Label label7;
        private Label ApprovalsLabel;
        private Label label3;
        private GroupBox groupBox1;
        private Panel panel2;
        private Label LoggedInAsLabel;
        private PictureBox ProfilePictureBox;
        private Label GreetingBox;
        private GroupBox groupBox2;
        private Button button3;
        private Button button2;
        private Button button1;
        private GroupBox groupBox3;
        private Button button4;
        private Button button5;
        private Button button6;
        private GroupBox groupBox4;
        private Button button10;
        private Button button7;
        private Button button8;
        private Button button9;
    }
}
