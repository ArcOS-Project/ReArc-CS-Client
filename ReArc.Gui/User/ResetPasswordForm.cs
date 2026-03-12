using ReArc.ApiHandler.Controllers;
using ReArc.Gui.Common;
using ReArc.Shared.Helpers;
using System.Security.Cryptography;

namespace ReArc.Gui.User
{
    public partial class ResetPasswordForm : Form
    {
        private readonly string _username;

        public ResetPasswordForm(string username)
        {
            _username = username;
            InitializeComponent();

            Text = $"Reset password for {_username}";
            GeneratePassword();
        }

        private void ManualRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            NewPasswordBox.ReadOnly = !ManualRadioButton.Checked;
            RegenerateButton.Enabled = GeneratedRadioButton.Checked;

            if (GeneratedRadioButton.Checked)
            {
                GeneratePassword();
            }
        }

        private void CopyButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(NewPasswordBox.Text)) return;

            CopyDialog.ShowCopyDialog(this, NewPasswordBox.Text);
            ResetButton.Enabled = true;
        }

        private void NewPasswordBox_TextChanged(object sender, EventArgs e)
        {
            CopyButton.Enabled = !string.IsNullOrEmpty(NewPasswordBox.Text);
            ResetButton.Enabled = false;
        }

        private void RegenerateButton_Click(object sender, EventArgs e)
        {
            GeneratePassword();
        }

        private void AbortButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            _ = DoResetPassword();
        }

        private async Task DoResetPassword()
        {
            if (string.IsNullOrEmpty(NewPasswordBox.Text)) return;

            var result = await AdminController.ChangePassword(_username, NewPasswordBox.Text);
            if (!result.Success)
            {
                MessageBox.Show($"An error occurred while trying to change the password of this user. {result.ErrorMessage}",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }

            Close();
        }

        private void GeneratePassword()
        {
            NewPasswordBox.Text = CredentialHelpers.GeneratePassword(16);
        }

    }
}
