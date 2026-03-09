using Org.BouncyCastle.Asn1.X509;
using ReArc.ApiHandler.Controllers;
using ReArc.Gui.Components;
using ReArc.Shared;
using ReArc.Shared.Records.Database;

namespace ReArc.Gui.Views
{
    public partial class Users : Page
    {
        private List<ArcUser> _users = [];

        public Users()
        {
            InitializeComponent();
        }

        public override async Task<CommandResult<bool>> LoadData(Dictionary<string, object>? props = null)
        {
            var response = await AdminController.GetAllUsers();
            if (!response.Success) return CommandResult<bool>.Error(response.ErrorMessage);

            _users = response.Result!;
            return CommandResult<bool>.Ok(true);
        }

        public override void Render()
        {
            MainForm!.BeginInvoke(() =>
            {
                var reportsList = new UserList()
                {
                    Dock = DockStyle.Fill,
                    Items = _users,
                    MainForm = MainForm
                };

                Controls.Add(reportsList);
                reportsList.FilterItems();
                reportsList.PopulateList();
            });
        }
    }
}
