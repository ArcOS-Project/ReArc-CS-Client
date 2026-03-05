namespace ReArc.Gui.Common
{
    partial class LoadingDialog
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
            StatusLabel = new Label();
            progressBar1 = new ProgressBar();
            SuspendLayout();
            // 
            // StatusLabel
            // 
            StatusLabel.AutoSize = true;
            StatusLabel.Location = new Point(12, 9);
            StatusLabel.Name = "StatusLabel";
            StatusLabel.Size = new Size(189, 15);
            StatusLabel.TabIndex = 0;
            StatusLabel.Text = "Doing something very important...";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(12, 37);
            progressBar1.MarqueeAnimationSpeed = 20;
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(420, 23);
            progressBar1.Style = ProgressBarStyle.Marquee;
            progressBar1.TabIndex = 1;
            // 
            // LoadingDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(440, 69);
            ControlBox = false;
            Controls.Add(progressBar1);
            Controls.Add(StatusLabel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LoadingDialog";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = " ";
            TopMost = true;
            FormClosing += LoadingDialog_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label StatusLabel;
        private ProgressBar progressBar1;
    }
}