using ReArc.ApiHandler;
using ReArc.ApiHandler.Controllers;
using ReArc.Gui.Logic;
using ReArc.Gui.Server;
using ReArc.Shared.Records.Configuration;

namespace ReArc.Gui.Account;

public partial class LoginForm : Form
{
    private bool _isLoggedIn = false;
    private ServerOption? _serverOption;
    public LoginForm()
    {
        InitializeComponent();
    }

    private void AbortButton_click(object sender, EventArgs e)
    {
        Close();
    }

    private void SwitchServerButton_Click(object sender, EventArgs e)
    {
        Program.SetNextForm(new SelectServerForm());
        Close();
    }

    private void LoginForm_Load(object sender, EventArgs e)
    {
        if (!Client.ClientIsConnected)
        {
            MessageBox.Show(this, "You have to be connected to the server before you can log in to the Administrative Toolbox.", "Not connected", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Program.SetNextForm(new SelectServerForm());
            Close();
            return;
        }

        _serverOption = Client.CurrentClient.ServerOption;
        ServerBox.Text = _serverOption!.Url;
        UsernameBox.Text = _serverOption!.Username ?? string.Empty;

        UpdateEnablement();

        if (_serverOption!.Username != null && _serverOption!.Token != null)
        {
            UserIsLoggedIn();
        }

        Focus();
    }

    private void UsernameBox_TextChanged(object sender, EventArgs e)
    {
        UpdateEnablement();
    }

    private void PasswordBox_TextChanged(object sender, EventArgs e)
    {
        UpdateEnablement();
    }

    private void LoginButton_Click(object sender, EventArgs e)
    {
        _ = DoLogin();
    }

    private void UpdateEnablement()
    {
        LoginButton.Enabled = ServerBox.Text != string.Empty && UsernameBox.Text != string.Empty && PasswordBox.Text != string.Empty;
    }

    private async Task DoLogin()
    {

        if (_isLoggedIn)
        {
            await UserLogic.LoginExisting(this, _serverOption!);
            return;
        }

        var identity = UsernameBox.Text;
        var password = PasswordBox.Text;

        await UserLogic.LoginUser(this, identity, password);
    }

    private async Task DoLogout()
    {
        UserController.SetToken(_serverOption!.Token!);
        await UserLogic.LogoutCurrentUser(this);
    }

    private void UserIsLoggedIn()
    {
        _isLoggedIn = true;
        StatusLabel.Text = $"Click Continue to log in as {_serverOption!.Username}.";
        LoginButton.Text = "Continue";
        UsernameBox.Enabled = false;
        PasswordBox.Enabled = false;
        LogoutButton.Enabled = true;
        LoginButton.Enabled = true;
    }

    private void LogoutButton_Click(object sender, EventArgs e)
    {
        _ = DoLogout();
    }
}
