using ReArc.ApiHandler;
using ReArc.ApiHandler.Controllers;
using ReArc.Gui.Logic;
using ReArc.Gui.Server;
using ReArc.Gui.Views;
using System.Reflection;

namespace ReArc.Gui
{
    record ToolboxPage
    {
        public required string Name { get; set; }
        public required Func<Page> Page { get; set; }
        public required Image? Image { get; set; }
    }

    public partial class MainForm : Form
    {
        private readonly List<ToolboxPage> Pages =
        [
            new()
            {
                Name = "Dashboard",
                Image = Properties.Resources.dashboard,
                Page = () => new Home()
            },
            new()
            {
                Name = "Users",
                Image = Properties.Resources.users,
                Page = () => new Users()
            }
        ];

        public MainForm()
        {
            InitializeComponent();
        }

        public async Task SwitchView(Page newView, string name, Dictionary<string, object>? props = null)
        {
            if (PagePanel.Controls.Count > 0 && PagePanel.Controls[0] is Page oldView)
            {
                PagePanel.Controls.Remove(oldView);
                oldView.Dispose();
            }

            newView.Hide();
            PagePanel.Controls.Add(newView);
            newView.Dock = DockStyle.Fill;
            newView.MainForm = this;
            _ = newView.Setup(name, props);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            _ = SwitchView(new Home() { MainForm = this }, "Dashboard");

            PopulateSidebarItems();

            UsernameButton.Text = UserController.DisplayName ?? "Stranger";
            usernameToolStripMenuItem.Text = UserController.UserInfo!.Username;
            emailToolStripMenuItem.Text = UserController.UserInfo!.Email;
            ServerLabel.Text = Client.Hostname!;
            ServerButton.Text = Client.Hostname!;
            ServerUrlItem.Text = Client.CurrentClient.ServerOption.Url!;
            VersionLabel.Text = $"v{Assembly.GetExecutingAssembly().GetName().Version}";

            if (UserController.ProfilePicture != null)
                UsernameButton.Image = Image.FromFile(UserController.ProfilePicture!);
        }

        private void PopulateSidebarItems()
        {
            foreach (var page in Pages)
            {
                ToolStripMenuItem item = new()
                {
                    AutoSize = false,
                    Image = page.Image,
                    ImageAlign = ContentAlignment.MiddleLeft,
                    Name = $"SideMenuItem_{page.Name.Replace(" ", "")}",
                    Padding = new Padding(20),
                    Size = new Size(SideMenuStrip.Size.Width - (SideMenuStrip.Padding.All * 2), 24),
                    Text = page.Name
                };

                item.Click += PageItem_Click;
                SideMenuStrip.Items.Add(item);
            }
        }

        private void PageItem_Click(object? sender, EventArgs e)
        {
            if (sender is not ToolStripMenuItem)
            {
                return;
            }

            var pageName = ((ToolStripMenuItem)sender).Text;
            var page = Pages.Find((p) => p.Name == pageName);

            if (page == null)
            {
                MessageBox.Show($"Unknown toolbox page: {pageName}", "Not found", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            var instance = page.Page();
            instance.MainForm = this;

            _ = SwitchView(instance, page.Name);
        }

        private void LogoutToolbarAction_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Are you sure you want to log out?", "Log out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.No) return;

            _ = UserLogic.LogoutCurrentUser(this);
        }

        private void LogOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Are you sure you want to log out?", "Log out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.No) return;

            _ = UserLogic.LogoutCurrentUser(this);
        }

        private void ExitToolstripAction_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DisconnectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserController.Reset();
            Client.Dispose();
            Program.SetNextForm(new SelectServerForm());
            Close();
        }
    }
}
