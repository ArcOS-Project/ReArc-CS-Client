using ReArc.ApiHandler.Controllers;
using ReArc.Gui.Common;
using ReArc.Gui.Components;
using ReArc.Shared;
using ReArc.Shared.Records.Database;
using ReArc.Shared.Records.Responses;

namespace ReArc.Gui.Views
{
    public partial class BugReports : Page
    {
        private List<BugReport> _reports = [];
        private List<ArcUser> _users = [];
        private ReportStatistics? _stats;

        public BugReports()
        {
            InitializeComponent();
        }

        public override async Task<CommandResult<bool>> LoadData(Dictionary<string, object>? props = null)
        {
            LoadingDialog.ChangeCaption("Retrieving bug reports");
            var reportsResult = await AdminController.GetAllBugReports();
            if (!reportsResult.Success) return CommandResult<bool>.Error(reportsResult.ErrorMessage);

            LoadingDialog.ChangeCaption("Retrieving report statistics");
            var statsResult = await AdminController.GetBugHuntStatistics();
            if (!statsResult.Success) return CommandResult<bool>.Error(statsResult.ErrorMessage);

            LoadingDialog.ChangeCaption("Retrieving user list");
            var usersResult = await AdminController.GetAllUsers();
            if (!usersResult.Success) return CommandResult<bool>.Error(usersResult.ErrorMessage);

            _reports = reportsResult.Result!;
            _stats = statsResult.Result!;
            _users = usersResult.Result!;

            return CommandResult<bool>.Ok(true);
        }

        public override void Render()
        {
            OpenedLabel.Text = _stats!.Opened.ToString();
            ClosedLabel.Text = _stats!.Closed.ToString();
            TotalLabel.Text = _stats!.Total.ToString();
            ApisLabel.Text = _stats!.Apis.ToString();

            BugReportList.Create(MainForm!, ReportsListPanel, _users!, _reports!);
        }
    }
}
