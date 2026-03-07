namespace ReArc.Gui.Views
{
    partial class ViewUser
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
            groupBox1 = new GroupBox();
            ProfilePictureBox = new PictureBox();
            UsernameLabel = new Label();
            EmailLabel = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ProfilePictureBox).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(EmailLabel);
            groupBox1.Controls.Add(UsernameLabel);
            groupBox1.Controls.Add(ProfilePictureBox);
            groupBox1.Location = new Point(13, 13);
            groupBox1.Margin = new Padding(0);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(8);
            groupBox1.Size = new Size(318, 130);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "User Information";
            // 
            // ProfilePictureBox
            // 
            ProfilePictureBox.ErrorImage = Properties.Resources.error;
            ProfilePictureBox.InitialImage = Properties.Resources.user;
            ProfilePictureBox.Location = new Point(11, 27);
            ProfilePictureBox.Name = "ProfilePictureBox";
            ProfilePictureBox.Size = new Size(64, 64);
            ProfilePictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            ProfilePictureBox.TabIndex = 0;
            ProfilePictureBox.TabStop = false;
            // 
            // UsernameLabel
            // 
            UsernameLabel.AutoSize = true;
            UsernameLabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            UsernameLabel.Location = new Point(81, 27);
            UsernameLabel.Name = "UsernameLabel";
            UsernameLabel.Size = new Size(78, 20);
            UsernameLabel.TabIndex = 1;
            UsernameLabel.Text = "username";
            // 
            // EmailLabel
            // 
            EmailLabel.AutoSize = true;
            EmailLabel.Location = new Point(81, 47);
            EmailLabel.Name = "EmailLabel";
            EmailLabel.Size = new Size(36, 15);
            EmailLabel.TabIndex = 2;
            EmailLabel.Text = "email";
            // 
            // ViewUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox1);
            Name = "ViewUser";
            Padding = new Padding(10);
            Size = new Size(643, 282);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ProfilePictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private PictureBox ProfilePictureBox;
        private Label UsernameLabel;
        private Label EmailLabel;
    }
}
