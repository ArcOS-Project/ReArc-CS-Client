using ReArc.ApiHandler;
using ReArc.Gui.Account;
using ReArc.Gui.Common;
using ReArc.Gui.Helpers;
using ReArc.Shared;
using ReArc.Shared.Records.Configuration;

namespace ReArc.Gui.Server
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
            if (!string.IsNullOrEmpty(Configuration.Settings?.LastServer))
            {
                ServerListBox.SelectedIndex = _servers.FindIndex((s) => s.Url == Configuration.Settings.LastServer);
            }
            Focus();
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

        public void UpdateServerList()
        {
            _servers = Configuration.Settings?.Servers ?? [];

            ServerListBox.Items.Clear();
            _selectedServer = null;
            UpdateDisabledState();

            foreach (var server in _servers)
            {
                ServerListBox.Items.Add(server.Url + " " + (server.AuthCode != null ? "(Protected)" : "(Public)"));
            }
        }


        private async Task DoConnect()
        {
            if (_selectedServer == null) return;

            BeginInvoke(() => LoadingDialog.ShowLoading(this, $"Connecting to {_selectedServer.Url}"));
            await Task.Delay(100);

            Client.Dispose();
            var result = await Client.Initialize(_selectedServer);

            await LoadingDialog.Stop();

            if (!result.Success)
            {
                DialogResult dialogResult = MessageBoxHelper.ServerConnectFailed(this, result, true);
                if (dialogResult == DialogResult.Retry)
                {
                    await DoConnect();
                    return;
                }
            }
            else
            {
                Configuration.SetLastServer(_selectedServer.Url);
                Program.SetNextForm(new LoginForm());
                Close();
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddServerForm form = new()
            {
                SelectServerForm = this
            };

            form.ShowDialog(this);
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (_selectedServer == null) return;

            DialogResult confirm = MessageBox.Show(this, "Are you sure you want to delete this server from your list?", $"Delete {_selectedServer.Url}", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm != DialogResult.Yes) return;

            Configuration.DeleteServer((s) => s.Url == _selectedServer.Url);
            UpdateServerList();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (_selectedServer == null) return;

            EditServerForm form = new()
            {
                SelectServerForm = this,
                ServerOption = _selectedServer
            };

            form.ShowDialog(this);
        }
    }
}
