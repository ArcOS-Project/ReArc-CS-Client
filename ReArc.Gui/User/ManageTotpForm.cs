using ReArc.ApiHandler.Controllers;
using ReArc.Shared.Records.Responses.User;

namespace ReArc.Gui.User
{
    public partial class ManageTotpForm : Form
    {
        private Totp _totp;
        private string _username;

        public ManageTotpForm(string username, Totp totp)
        {
            _totp = totp;
            _username = username;
            InitializeComponent();

        }

        private void UpdateStuff()
        {
            Text = $"Manage 2FA of {_username}";
            SecretBox.Text = _totp.Secret;
            UrlBox.Text = _totp.Url;
            DisableButton.Enabled = _totp.Activated;

            if (_totp.Activated)
            {
                StatusLabel.Text = "Enforced";
                StatusLabel.ForeColor = Color.LimeGreen;
            }
            else
            {
                StatusLabel.Text = "Not active";
                StatusLabel.ForeColor = Color.Red;
            }
        }

        private void ManageTotpForm_Load(object sender, EventArgs e)
        {
            UpdateStuff();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void RevealButton_Click(object sender, EventArgs e)
        {
            if (SecretBox.UseSystemPasswordChar)
            {
                SecretBox.UseSystemPasswordChar = false;
                UrlBox.UseSystemPasswordChar = false;
                RevealButton.Text = "Hide";
            }
            else
            {
                SecretBox.UseSystemPasswordChar = true;
                UrlBox.UseSystemPasswordChar = true;
                RevealButton.Text = "Reveal";
            }
        }

        private void DisableButton_Click(object sender, EventArgs e)
        {
            _ = DoDisable();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            _ = DoDelete();
        }

        private async Task DoDisable()
        {
            DialogResult confirm = MessageBox.Show("Are you sure you want to deactivate the 2FA of this user? They will have to set up their 2FA again in order to enforce the security of their account.",
                                                 "Deactivate 2FA",
                                                 MessageBoxButtons.YesNo,
                                                 MessageBoxIcon.Warning);

            if (confirm != DialogResult.Yes) return;

            var result = await AdminController.DeactivateTotpOf(_username);
            if (!result.Success)
            {
                MessageBox.Show($"An error occurred while trying to deactivate the 2FA of this user. {result.ErrorMessage}",
                                                 "Error",
                                                 MessageBoxButtons.OK,
                                                 MessageBoxIcon.Error);

                return;
            }

            _totp = new Totp(false, _totp.Secret, _totp.Url, _totp.UserId, _totp._id);
            UpdateStuff();
            await ((MainForm)Owner!).RefreshView();
        }

        private async Task DoDelete()
        {
            DialogResult confirm = MessageBox.Show("Are you sure you want to delete the 2FA record of this user? They will have to set up their 2FA again in order to enforce the security of their account.",
                                                  "Delete 2FA",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Warning);

            if (confirm != DialogResult.Yes) return;

            var result = await AdminController.DeleteTotpOf(_username);
            if (!result.Success)
            {
                MessageBox.Show($"An error occurred while trying to delete the 2FA of this user. {result.ErrorMessage}",
                                                 "Error",
                                                 MessageBoxButtons.OK,
                                                 MessageBoxIcon.Error);

                return;
            }

            await ((MainForm)Owner!).RefreshView();
            Close();
        }
    }
}
