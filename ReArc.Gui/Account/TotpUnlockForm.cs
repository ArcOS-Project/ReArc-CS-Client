using ReArc.ApiHandler.Controllers;
using ReArc.Gui.Common;
using ReArc.Gui.Logic;

namespace ReArc.Gui.Account;

public partial class TotpUnlockForm : Form
{
    public TotpUnlockForm()
    {
        InitializeComponent();
    }

    private void LogoutButton_Click(object sender, EventArgs e)
    {
        _ = DoLogout();
    }

    private void TotpUnlockForm_Load(object sender, EventArgs e)
    {
        if (UserController.Token == null || !UserController.Restricted)
        {
            MessageBox.Show("Not logged in or not restricted", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Close();
            return;
        }

        GreetingLabel.Text = $"Hi, {UserController.UserInfo!.Username}!";
        Focus();
    }

    private void TotpCodeBox_TextChanged(object sender, EventArgs e)
    {
        UnlockButton.Enabled = TotpCodeBox.Text != string.Empty;
    }

    private void UnlockButton_Click(object sender, EventArgs e)
    {
        _ = DoUnlock();
    }

    private async Task DoUnlock()
    {
        _ = UserLogic.UnlockCurrentUser(this, TotpCodeBox.Text);
    }

    private async Task DoLogout()
    {
        _ = UserLogic.LogoutCurrentUser(this);
    }

}
