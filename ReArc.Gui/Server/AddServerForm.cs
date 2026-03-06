using ReArc.ApiHandler;
using ReArc.Gui.Common;
using ReArc.Gui.Helpers;
using ReArc.Shared;
using ReArc.Shared.Records.Configuration;

namespace ReArc.Gui.Server;

public partial class AddServerForm : Form
{
    public SelectServerForm? SelectServerForm;
    private int? Port
    {
        get
        {
            var val = PortBox.Value;
            if (val < 80 || val >= 65535) return null;

            return (int)val;
        }
    }

    private bool IsValid
    {
        get => Port != null && HostnameBox.Text != string.Empty;
    }

    public AddServerForm()
    {
        InitializeComponent();
        AddButton.Enabled = IsValid;
    }

    private void HostnameBox_TextChanged(object sender, EventArgs e)
    {
        AddButton.Enabled = IsValid;
    }

    private void PortBox_ValueChanged(object sender, EventArgs e)
    {
        AddButton.Enabled = IsValid;
    }

    private void AbortButton_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void AddButton_Click(object sender, EventArgs e)
    {
        _ = DoAdd();
    }

    private async Task DoAdd()
    {
        if (!IsValid) return;

        ServerOption option = Client.CreateServerOption(HostnameBox.Text, Port!.Value, AuthCodeBox.Text);
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

        Configuration.AddServer(option.Url, option.AuthCode, null, null);
        SelectServerForm?.UpdateServerList();
        Close();
    }

    private void AddServerForm_Load(object sender, EventArgs e)
    {
        Focus();
    }
}
