using ReArc.ApiHandler;
using ReArc.Gui.Common;
using ReArc.Shared;
using ReArc.Shared.Records.Configuration;

namespace ReArc.Gui
{
    public partial class SelectServerForm : Form
    {
        private List<ServerOption> _servers = new List<ServerOption>();
        private ServerOption? _selectedServer;

        public SelectServerForm()
        {
            InitializeComponent();
        }

        private void SelectServerForm_Load(object sender, EventArgs e)
        {
            UpdateServerList();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void ServerListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ServerListBox.SelectedIndex >= 0 && ServerListBox.SelectedIndex < _servers.Count)
                _selectedServer = _servers[ServerListBox.SelectedIndex];
            UpdateDisabledState();
        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            _ = DoConnect();
        }

        private void UpdateDisabledState()
        {
            ConnectButton.Enabled = _selectedServer != null;
            DeleteButton.Enabled = _selectedServer != null;
            EditButton.Enabled = _selectedServer != null;
        }

        private void UpdateServerList()
        {
            _servers = Configuration.Settings?.Servers ?? new List<ServerOption>();

            ServerListBox.Items.Clear();

            foreach (var server in _servers)
            {
                ServerListBox.Items.Add(server.Url + " " + (server.AuthCode != null ? "(Protected)" : "(Public)"));
            }
        }


        private async Task DoConnect()
        {
            if (_selectedServer == null) return;

            var loading = new LoadingDialog($"Connecting to {_selectedServer.Url}");
            BeginInvoke(() => loading.ShowDialog(this));

            Client.Dispose();
            var result = await Client.Initialize(_selectedServer);

            await loading.Stop();

            // TODO: this should probably be handled in a separate method for clarity
            if (!result.Success)
            {
                DialogResult dialogResult = MessageBox.Show(this, $"Unable to connect to the requested server. It might be offline or the provided authorization code is incorrect.\n\nDetails: {result.ErrorMessage}", "Connection failed", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                if (dialogResult == DialogResult.Retry)
                {
                    await DoConnect();
                    return;
                }
            }
            else
            {
                // TEMPORARY
                MessageBox.Show(this, $"Connection established to {_selectedServer.Url}", "Connected!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
