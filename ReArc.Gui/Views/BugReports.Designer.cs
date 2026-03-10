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
            ReportsListPanel = new Panel();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 250F));
            tableLayoutPanel1.Controls.Add(panel1, 1, 0);
            tableLayoutPanel1.Controls.Add(ReportsListPanel, 0, 0);
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
            panel1.BackgroundImage = Properties.Resources.dashboardstatbg;
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
            // ReportsListPanel
            // 
            ReportsListPanel.Dock = DockStyle.Fill;
            ReportsListPanel.Location = new Point(0, 0);
            ReportsListPanel.Margin = new Padding(0);
            ReportsListPanel.Name = "ReportsListPanel";
            ReportsListPanel.Size = new Size(634, 546);
            ReportsListPanel.TabIndex = 1;
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
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private GroupBox groupBox1;
        private Label label1;
        private Label ClosedLabel;
        private Label label4;
        private Label OpenedLabel;
        private Label ApisLabel;
        private Label label3;
        private Label label7;
        private Label TotalLabel;
        private Panel ReportsListPanel;
    }
}
