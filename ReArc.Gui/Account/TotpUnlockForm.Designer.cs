namespace ReArc.Gui.Account;

partial class TotpUnlockForm
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
        tableLayoutPanel1 = new TableLayoutPanel();
        pictureBox1 = new PictureBox();
        panel1 = new Panel();
        LogoutButton = new Button();
        UnlockButton = new Button();
        TotpCodeBox = new TextBox();
        label2 = new Label();
        GreetingLabel = new Label();
        tableLayoutPanel1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        panel1.SuspendLayout();
        SuspendLayout();
        // 
        // tableLayoutPanel1
        // 
        tableLayoutPanel1.ColumnCount = 1;
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
        tableLayoutPanel1.Controls.Add(pictureBox1, 0, 0);
        tableLayoutPanel1.Controls.Add(panel1, 0, 1);
        tableLayoutPanel1.Dock = DockStyle.Fill;
        tableLayoutPanel1.Location = new Point(0, 0);
        tableLayoutPanel1.Name = "tableLayoutPanel1";
        tableLayoutPanel1.RowCount = 2;
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle());
        tableLayoutPanel1.Size = new Size(400, 216);
        tableLayoutPanel1.TabIndex = 0;
        // 
        // pictureBox1
        // 
        pictureBox1.Dock = DockStyle.Fill;
        pictureBox1.Image = Properties.Resources.banner;
        pictureBox1.Location = new Point(0, 0);
        pictureBox1.Margin = new Padding(0);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new Size(400, 70);
        pictureBox1.TabIndex = 0;
        pictureBox1.TabStop = false;
        // 
        // panel1
        // 
        panel1.Controls.Add(LogoutButton);
        panel1.Controls.Add(UnlockButton);
        panel1.Controls.Add(TotpCodeBox);
        panel1.Controls.Add(label2);
        panel1.Controls.Add(GreetingLabel);
        panel1.Dock = DockStyle.Fill;
        panel1.Location = new Point(0, 70);
        panel1.Margin = new Padding(0);
        panel1.Name = "panel1";
        panel1.Padding = new Padding(20);
        panel1.Size = new Size(400, 146);
        panel1.TabIndex = 1;
        // 
        // LogoutButton
        // 
        LogoutButton.Location = new Point(302, 100);
        LogoutButton.Name = "LogoutButton";
        LogoutButton.Size = new Size(75, 23);
        LogoutButton.TabIndex = 4;
        LogoutButton.Text = "Log out";
        LogoutButton.UseVisualStyleBackColor = true;
        LogoutButton.Click += LogoutButton_Click;
        // 
        // UnlockButton
        // 
        UnlockButton.Location = new Point(221, 100);
        UnlockButton.Name = "UnlockButton";
        UnlockButton.Size = new Size(75, 23);
        UnlockButton.TabIndex = 3;
        UnlockButton.Text = "Unlock";
        UnlockButton.UseVisualStyleBackColor = true;
        UnlockButton.Click += UnlockButton_Click;
        // 
        // TotpCodeBox
        // 
        TotpCodeBox.Location = new Point(23, 100);
        TotpCodeBox.Name = "TotpCodeBox";
        TotpCodeBox.Size = new Size(192, 23);
        TotpCodeBox.TabIndex = 2;
        TotpCodeBox.TextChanged += TotpCodeBox_TextChanged;
        // 
        // label2
        // 
        label2.Location = new Point(23, 50);
        label2.Name = "label2";
        label2.Size = new Size(354, 31);
        label2.TabIndex = 1;
        label2.Text = "Please enter the 2FA code from your authenticator app to continue to the Administrative Toolbox:";
        // 
        // GreetingLabel
        // 
        GreetingLabel.AutoSize = true;
        GreetingLabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        GreetingLabel.Location = new Point(23, 20);
        GreetingLabel.Name = "GreetingLabel";
        GreetingLabel.Size = new Size(106, 20);
        GreetingLabel.TabIndex = 0;
        GreetingLabel.Text = "Hi, username!";
        // 
        // TotpUnlockForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(400, 216);
        Controls.Add(tableLayoutPanel1);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "TotpUnlockForm";
        ShowIcon = false;
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Enter 2FA code";
        Load += TotpUnlockForm_Load;
        tableLayoutPanel1.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        panel1.ResumeLayout(false);
        panel1.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private TableLayoutPanel tableLayoutPanel1;
    private PictureBox pictureBox1;
    private Panel panel1;
    private Button LogoutButton;
    private Button UnlockButton;
    private TextBox TotpCodeBox;
    private Label label2;
    private Label GreetingLabel;
}