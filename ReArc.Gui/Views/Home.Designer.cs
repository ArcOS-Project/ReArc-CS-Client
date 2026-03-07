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
            label1 = new Label();
            TokensLabel = new Label();
            UsersLabel = new Label();
            label4 = new Label();
            IndexesLabel = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 20);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 0;
            label1.Text = "Tokens";
            // 
            // TokensLabel
            // 
            TokensLabel.AutoSize = true;
            TokensLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            TokensLabel.Location = new Point(73, 20);
            TokensLabel.Name = "TokensLabel";
            TokensLabel.Size = new Size(56, 32);
            TokensLabel.TabIndex = 1;
            TokensLabel.Text = "185";
            // 
            // UsersLabel
            // 
            UsersLabel.AutoSize = true;
            UsersLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            UsersLabel.Location = new Point(73, 64);
            UsersLabel.Name = "UsersLabel";
            UsersLabel.Size = new Size(56, 32);
            UsersLabel.TabIndex = 3;
            UsersLabel.Text = "185";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 64);
            label4.Name = "label4";
            label4.Size = new Size(35, 15);
            label4.TabIndex = 2;
            label4.Text = "Users";
            // 
            // IndexesLabel
            // 
            IndexesLabel.AutoSize = true;
            IndexesLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            IndexesLabel.Location = new Point(73, 110);
            IndexesLabel.Name = "IndexesLabel";
            IndexesLabel.Size = new Size(56, 32);
            IndexesLabel.TabIndex = 5;
            IndexesLabel.Text = "185";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(23, 110);
            label6.Name = "label6";
            label6.Size = new Size(46, 15);
            label6.TabIndex = 4;
            label6.Text = "Indexes";
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(IndexesLabel);
            Controls.Add(label6);
            Controls.Add(UsersLabel);
            Controls.Add(label4);
            Controls.Add(TokensLabel);
            Controls.Add(label1);
            Name = "Home";
            Padding = new Padding(20);
            Size = new Size(452, 320);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label TokensLabel;
        private Label UsersLabel;
        private Label label4;
        private Label IndexesLabel;
        private Label label6;
    }
}
