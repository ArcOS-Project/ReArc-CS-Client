using ReArc.ApiHandler.Controllers;
using ReArc.Gui.Components;
using ReArc.Gui.Logic;
using ReArc.Shared;
using ReArc.Shared.Records.Database;
using ReArc.Shared.Records.Responses.User;

namespace ReArc.Gui.Views
{

    public partial class Filesystems : Page
    {
        private List<ArcUser> _users = [];
        private Dictionary<string, UserQuota>? _quotaOverview;
        public Filesystems()
        {
            InitializeComponent();
        }

        public override async Task<CommandResult<bool>> LoadData(Dictionary<string, object>? props = null)
        {
            var usersResult = await AdminController.GetAllUsers();
            if (!usersResult.Success) return CommandResult<bool>.Error(usersResult.ErrorMessage);

            var overviewResult = await AdminLogic.GetFilesystemOverview(MainForm!, usersResult.Result!);
            if (!overviewResult.Success)
            {
                MessageBox.Show($"One or more errors occurred while obtaining the filesystem overview:\n\n{overviewResult.ErrorMessage}", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            _users = usersResult.Result!;
            _quotaOverview = overviewResult.Result!;

            return CommandResult<bool>.Ok(true);
        }

        public override void Render()
        {
            FilesystemsList.Create(MainForm!, this, _users!, _quotaOverview!);
        }
    }
}
