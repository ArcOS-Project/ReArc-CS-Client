namespace ReArc.Gui.Server;

partial class AddServerForm
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
        label1 = new Label();
        label2 = new Label();
        label3 = new Label();
        label4 = new Label();
        HostnameBox = new TextBox();
        AuthCodeBox = new TextBox();
        PortBox = new NumericUpDown();
        groupBox1 = new GroupBox();
        AddButton = new Button();
        AbortButton = new Button();
        ((System.ComponentModel.ISupportInitialize)PortBox).BeginInit();
        groupBox1.SuspendLayout();
        SuspendLayout();
        // 
        // label1
        // 
        label1.Location = new Point(12, 9);
        label1.Name = "label1";
        label1.Size = new Size(360, 33);
        label1.TabIndex = 0;
        label1.Text = "Please enter the information of the server to which you want to connect. The server has to be online before it can be added.";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(10, 25);
        label2.Name = "label2";
        label2.Size = new Size(62, 15);
        label2.TabIndex = 1;
        label2.Text = "Hostname";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(10, 54);
        label3.Name = "label3";
        label3.Size = new Size(29, 15);
        label3.TabIndex = 2;
        label3.Text = "Port";
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(10, 83);
        label4.Name = "label4";
        label4.Size = new Size(117, 15);
        label4.TabIndex = 3;
        label4.Text = "Authentication Code";
        // 
        // HostnameBox
        // 
        HostnameBox.Location = new Point(199, 22);
        HostnameBox.Name = "HostnameBox";
        HostnameBox.Size = new Size(150, 23);
        HostnameBox.TabIndex = 1;
        HostnameBox.TextChanged += HostnameBox_TextChanged;
        // 
        // AuthCodeBox
        // 
        AuthCodeBox.Location = new Point(199, 80);
        AuthCodeBox.Name = "AuthCodeBox";
        AuthCodeBox.Size = new Size(150, 23);
        AuthCodeBox.TabIndex = 3;
        AuthCodeBox.UseSystemPasswordChar = true;
        // 
        // PortBox
        // 
        PortBox.Location = new Point(199, 52);
        PortBox.Maximum = new decimal(new int[] { 65535, 0, 0, 0 });
        PortBox.Minimum = new decimal(new int[] { 80, 0, 0, 0 });
        PortBox.Name = "PortBox";
        PortBox.Size = new Size(150, 23);
        PortBox.TabIndex = 2;
        PortBox.Value = new decimal(new int[] { 443, 0, 0, 0 });
        PortBox.ValueChanged += PortBox_ValueChanged;
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(AuthCodeBox);
        groupBox1.Controls.Add(PortBox);
        groupBox1.Controls.Add(HostnameBox);
        groupBox1.Controls.Add(label2);
        groupBox1.Controls.Add(label3);
        groupBox1.Controls.Add(label4);
        groupBox1.Location = new Point(12, 45);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new Size(360, 114);
        groupBox1.TabIndex = 8;
        groupBox1.TabStop = false;
        groupBox1.Text = "Server Information";
        // 
        // AddButton
        // 
        AddButton.Location = new Point(313, 165);
        AddButton.Name = "AddButton";
        AddButton.Size = new Size(59, 23);
        AddButton.TabIndex = 5;
        AddButton.Text = "Add";
        AddButton.UseVisualStyleBackColor = true;
        AddButton.Click += AddButton_Click;
        // 
        // AbortButton
        // 
        AbortButton.Location = new Point(232, 165);
        AbortButton.Name = "AbortButton";
        AbortButton.Size = new Size(75, 23);
        AbortButton.TabIndex = 4;
        AbortButton.Text = "Cancel";
        AbortButton.UseVisualStyleBackColor = true;
        AbortButton.Click += AbortButton_Click;
        // 
        // AddServerForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(384, 202);
        Controls.Add(AbortButton);
        Controls.Add(AddButton);
        Controls.Add(groupBox1);
        Controls.Add(label1);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "AddServerForm";
        StartPosition = FormStartPosition.CenterParent;
        Text = "Add Server";
        Load += AddServerForm_Load;
        ((System.ComponentModel.ISupportInitialize)PortBox).EndInit();
        groupBox1.ResumeLayout(false);
        groupBox1.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private Label label1;
    private Label label2;
    private Label label3;
    private Label label4;
    private TextBox HostnameBox;
    private TextBox AuthCodeBox;
    private NumericUpDown PortBox;
    private GroupBox groupBox1;
    private Button AddButton;
    private Button AbortButton;
}