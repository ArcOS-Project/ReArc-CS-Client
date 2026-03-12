using ReArc.ApiHandler.Controllers;

namespace ReArc.Gui.User
{
    public partial class ChangeEmailForm : Form
    {
        private readonly string _username;
        private readonly string _oldEmail;

        public ChangeEmailForm(string username, string oldEmail)
        {
            _username = username;
            _oldEmail = oldEmail;
            InitializeComponent();

            Text = $"Change email for {username}";
            OldEmailField.Text = _oldEmail;
        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            _ = DoChangeEmail();
        }

        private void NewEmailField_ValueChanged(object sender, EventArgs e)
        {
            ChangeButton.Enabled = !string.IsNullOrEmpty(NewEmailField.Text);
        }

        private void AbortButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async Task DoChangeEmail()
        {
            if (string.IsNullOrEmpty(NewEmailField.Text)) return;

            var result = await AdminController.ChangeEmail(_username, NewEmailField.Text);
            if (!result.Success)
            {
                MessageBox.Show($"An error occurred while trying to change the email of this user. {result.ErrorMessage}",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }

            Close();
        }
    }
}
