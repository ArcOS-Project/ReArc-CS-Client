namespace ReArc.Gui
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectServerForm));
            label1 = new Label();
            ServerListBox = new ListBox();
            ConnectButton = new Button();
            ExitButton = new Button();
            DeleteButton = new Button();
            AddButton = new Button();
            EditButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(256, 15);
            label1.TabIndex = 0;
            label1.Text = "Select the server to which you want to connect:";
            // 
            // ServerListBox
            // 
            ServerListBox.FormattingEnabled = true;
            ServerListBox.Location = new Point(12, 34);
            ServerListBox.Name = "ServerListBox";
            ServerListBox.Size = new Size(404, 169);
            ServerListBox.TabIndex = 1;
            ServerListBox.SelectedIndexChanged += ServerListBox_SelectedIndexChanged;
            // 
            // ConnectButton
            // 
            ConnectButton.Enabled = false;
            ConnectButton.Location = new Point(341, 209);
            ConnectButton.Name = "ConnectButton";
            ConnectButton.Size = new Size(75, 23);
            ConnectButton.TabIndex = 2;
            ConnectButton.Text = "Connect";
            ConnectButton.UseVisualStyleBackColor = true;
            ConnectButton.Click += ConnectButton_Click;
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(260, 209);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(75, 23);
            ExitButton.TabIndex = 3;
            ExitButton.Text = "Cancel";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += CancelButton_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.Enabled = false;
            DeleteButton.Location = new Point(69, 209);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(52, 23);
            DeleteButton.TabIndex = 4;
            DeleteButton.Text = "Delete";
            DeleteButton.UseVisualStyleBackColor = true;
            // 
            // AddButton
            // 
            AddButton.Location = new Point(12, 209);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(51, 23);
            AddButton.TabIndex = 5;
            AddButton.Text = "Add...";
            AddButton.UseVisualStyleBackColor = true;
            // 
            // EditButton
            // 
            EditButton.Enabled = false;
            EditButton.Location = new Point(127, 209);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(42, 23);
            EditButton.TabIndex = 6;
            EditButton.Text = "Edit";
            EditButton.UseVisualStyleBackColor = true;
            // 
            // SelectServerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(428, 244);
            Controls.Add(EditButton);
            Controls.Add(AddButton);
            Controls.Add(DeleteButton);
            Controls.Add(ExitButton);
            Controls.Add(ConnectButton);
            Controls.Add(ServerListBox);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SelectServerForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Choose Server";
            Load += SelectServerForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox ServerListBox;
        private Button ConnectButton;
        private Button ExitButton;
        private Button DeleteButton;
        private Button AddButton;
        private Button EditButton;
    }
}
