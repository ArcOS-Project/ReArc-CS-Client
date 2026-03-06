using ReArc.ApiHandler;
using ReArc.Gui.Common;
using ReArc.Gui.Helpers;
using ReArc.Shared;
using ReArc.Shared.Records.Configuration;

namespace ReArc.Gui.Server;

public partial class EditServerForm : Form
{
    public ServerOption? ServerOption;
    public SelectServerForm? SelectServerForm;

    private bool IsValid
    {
        get => !string.IsNullOrEmpty(UrlBox.Text);
    }

    public EditServerForm()
    {
        InitializeComponent();
    }

    private void AbortButton_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void UpdateButton_Click(object sender, EventArgs e)
    {
        _ = DoUpdate();
    }

    private void EditServerForm_Load(object sender, EventArgs e)
    {
        if (ServerOption == null)
        {
            MessageBox.Show("The edit dialog wasn't invoked properly. Please contact Izaak.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Close();
            return;
        }

        UrlBox.Text = ServerOption.Url;
        AuthCodeBox.Text = ServerOption.AuthCode ?? "";
        UsernameBox.Text = ServerOption.Username ?? "";
        TokenBox.Text = ServerOption.Token ?? "";
        Focus();
    }

    private void UrlBox_TextChanged(object sender, EventArgs e)
    {
        UpdateButton.Enabled = IsValid;
    }

    private async Task DoUpdate()
    {
        var option = new ServerOption()
        {
            Url = UrlBox.Text,
            AuthCode = string.IsNullOrEmpty(AuthCodeBox.Text) ? null : AuthCodeBox.Text,
            Username = ServerOption!.Username,
            Token = ServerOption!.Token
        };

        BeginInvoke(() => LoadingDialog.ShowLoading(this, $"Connecting to {option.Url}"));
        await Task.Delay(100);

        Client.Dispose();
        var result = await Client.Initialize(option);

        await LoadingDialog.Stop();

        if (!result.Success)
        {
            MessageBoxHelper.ServerConnectFailed(this, result);
            return;
        }

        Configuration.UpdateServer((s) => s.Url == ServerOption!.Url, option);
        SelectServerForm?.UpdateServerList();
        Close();
    }
}
