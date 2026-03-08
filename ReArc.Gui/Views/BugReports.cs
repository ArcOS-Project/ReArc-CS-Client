using ReArc.ApiHandler.Controllers;
using ReArc.Gui.Common;
using ReArc.Shared;
using ReArc.Shared.Records.Database;
using ReArc.Shared.Records.Responses;

namespace ReArc.Gui.Views
{
    public partial class BugReports : Page
    {
        private List<BugReport> _reports = [];
        private List<BugReport> _filteredReports = [];
        private List<ArcUser> _users = [];
        private ReportStatistics? _stats;
        private string _filter { get => FilterDropdown.Text; }
        private string _query { get => SearchBox.Text; }
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

        private void FilterReports()
        {
            var comparison = StringComparison.InvariantCultureIgnoreCase;

            if (_filter == string.Empty && _query == string.Empty)
            {
                _filteredReports = _reports;
                return;
            }

            _filteredReports = [.. _reports.Where(
                (u) => _query == string.Empty ||
                       (u.Body?.Contains(_query, comparison) ?? false) ||
                       (u.Title?.Contains(_query, comparison) ?? false) ||
                       u._id == _query)];

            _filteredReports = [.. _filteredReports.Where(
                (u) => _filter switch {
                        "All" => true,
                        "System" => u.IsAppReport != true,
                        "Apps" => u.IsAppReport == true,
                        "Closed" => u.Closed,
                        "Opened" => !u.Closed,
                        _ => true})];
        }

        private void PopulateList()
        {
            ReportListView.Rows.Clear();


            foreach (var report in _filteredReports)
            {
                var createdDate = DateTime.Parse(report.CreatedAt).ToString("dd-MM-yyyy, HH:mm:ss");
                var author = _users.Find((u) => u._id == report.AuthorId)?.Username ?? "Stranger";

                ReportListView.Rows.Add([Properties.Resources.crash16, createdDate, report.Title, author]);
            }

            ReportListView.AutoResizeColumns();
        }

        public override void Render()
        {
            OpenedLabel.Text = _stats!.Opened.ToString();
            ClosedLabel.Text = _stats!.Closed.ToString();
            TotalLabel.Text = _stats!.Total.ToString();
            ApisLabel.Text = _stats!.Apis.ToString();

            FilterDropdown.SelectedIndex = 0;
            FilterReports();
            PopulateList();
        }

        private void SearchBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                FilterReports();
                PopulateList();
            }
        }

        private void FilterDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterReports();
            PopulateList();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            FilterReports();
            PopulateList();
        }
    }
}
