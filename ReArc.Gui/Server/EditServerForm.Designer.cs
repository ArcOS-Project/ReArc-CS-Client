namespace ReArc.Gui.Server;

partial class EditServerForm
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
        AbortButton = new Button();
        UpdateButton = new Button();
        groupBox1 = new GroupBox();
        TokenBox = new TextBox();
        label5 = new Label();
        UsernameBox = new TextBox();
        label3 = new Label();
        UrlBox = new TextBox();
        label2 = new Label();
        AuthCodeBox = new TextBox();
        label4 = new Label();
        label1 = new Label();
        groupBox1.SuspendLayout();
        SuspendLayout();
        // 
        // AbortButton
        // 
        AbortButton.Location = new Point(232, 199);
        AbortButton.Name = "AbortButton";
        AbortButton.Size = new Size(75, 23);
        AbortButton.TabIndex = 5;
        AbortButton.Text = "Cancel";
        AbortButton.UseVisualStyleBackColor = true;
        AbortButton.Click += AbortButton_Click;
        // 
        // UpdateButton
        // 
        UpdateButton.Location = new Point(313, 199);
        UpdateButton.Name = "UpdateButton";
        UpdateButton.Size = new Size(59, 23);
        UpdateButton.TabIndex = 6;
        UpdateButton.Text = "Update";
        UpdateButton.UseVisualStyleBackColor = true;
        UpdateButton.Click += UpdateButton_Click;
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(TokenBox);
        groupBox1.Controls.Add(label5);
        groupBox1.Controls.Add(UsernameBox);
        groupBox1.Controls.Add(label3);
        groupBox1.Controls.Add(UrlBox);
        groupBox1.Controls.Add(label2);
        groupBox1.Controls.Add(AuthCodeBox);
        groupBox1.Controls.Add(label4);
        groupBox1.Location = new Point(12, 45);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new Size(360, 148);
        groupBox1.TabIndex = 12;
        groupBox1.TabStop = false;
        groupBox1.Text = "Server Information";
        // 
        // TokenBox
        // 
        TokenBox.Enabled = false;
        TokenBox.Location = new Point(147, 109);
        TokenBox.Name = "TokenBox";
        TokenBox.ReadOnly = true;
        TokenBox.Size = new Size(202, 23);
        TokenBox.TabIndex = 4;
        TokenBox.UseSystemPasswordChar = true;
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Location = new Point(10, 112);
        label5.Name = "label5";
        label5.Size = new Size(39, 15);
        label5.TabIndex = 9;
        label5.Text = "Token";
        // 
        // UsernameBox
        // 
        UsernameBox.Enabled = false;
        UsernameBox.Location = new Point(147, 80);
        UsernameBox.Name = "UsernameBox";
        UsernameBox.ReadOnly = true;
        UsernameBox.Size = new Size(202, 23);
        UsernameBox.TabIndex = 3;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(10, 83);
        label3.Name = "label3";
        label3.Size = new Size(60, 15);
        label3.TabIndex = 7;
        label3.Text = "Username";
        // 
        // UrlBox
        // 
        UrlBox.Location = new Point(147, 22);
        UrlBox.Name = "UrlBox";
        UrlBox.Size = new Size(202, 23);
        UrlBox.TabIndex = 1;
        UrlBox.TextChanged += UrlBox_TextChanged;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(10, 25);
        label2.Name = "label2";
        label2.Size = new Size(28, 15);
        label2.TabIndex = 1;
        label2.Text = "URL";
        // 
        // AuthCodeBox
        // 
        AuthCodeBox.Location = new Point(147, 51);
        AuthCodeBox.Name = "AuthCodeBox";
        AuthCodeBox.Size = new Size(202, 23);
        AuthCodeBox.TabIndex = 2;
        AuthCodeBox.UseSystemPasswordChar = true;
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(10, 54);
        label4.Name = "label4";
        label4.Size = new Size(117, 15);
        label4.TabIndex = 3;
        label4.Text = "Authentication Code";
        // 
        // label1
        // 
        label1.Location = new Point(12, 9);
        label1.Name = "label1";
        label1.Size = new Size(360, 33);
        label1.TabIndex = 11;
        label1.Text = "Change the values you want to update, then click \"Save\" to apply the changes.";
        // 
        // EditServerForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(384, 236);
        Controls.Add(AbortButton);
        Controls.Add(UpdateButton);
        Controls.Add(groupBox1);
        Controls.Add(label1);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "EditServerForm";
        ShowIcon = false;
        StartPosition = FormStartPosition.CenterParent;
        Text = "Edit Server";
        Load += EditServerForm_Load;
        groupBox1.ResumeLayout(false);
        groupBox1.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private Button AbortButton;
    private Button UpdateButton;
    private GroupBox groupBox1;
    private TextBox UrlBox;
    private Label label2;
    private TextBox AuthCodeBox;
    private Label label4;
    private Label label1;
    private TextBox TokenBox;
    private Label label5;
    private TextBox UsernameBox;
    private Label label3;
}