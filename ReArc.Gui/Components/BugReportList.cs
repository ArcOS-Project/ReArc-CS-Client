using ReArc.Shared.Records.Database;
using ReArc.Shared.Records.Responses;
using System.Data;

namespace ReArc.Gui.Components;

public partial class BugReportList : UserControl
{
    public List<BugReport> Reports = [];
    public List<ArcUser> Users = [];
    public MainForm? MainForm;
    private string _filter { get => FilterBox.Text; }
    private string _query { get => SearchBox.Text; }
    private List<BugReport> _filteredReports = [];
    
    public BugReportList()
    {
        InitializeComponent();

        FilterBox.SelectedIndex = 0;
    }


    public void FilterReports()
    {
        var comparison = StringComparison.InvariantCultureIgnoreCase;

        if (_filter == string.Empty && _query == string.Empty)
        {
            _filteredReports = Reports;
            return;
        }

        _filteredReports = [.. Reports.Where(
                (u) => _query == string.Empty ||
                       (u.Body?.Contains(_query, comparison) ?? false) ||
                       (u.Title?.Contains(_query, comparison) ?? false) ||
                       (u.UserAgent?.Contains(_query, comparison) ?? false) ||
                       u._id == _query)];

        _filteredReports = [.. _filteredReports.Where(
                (u) => _filter switch {
                        "All" => true,
                        "System" => u.IsAppReport != true,
                        "Apps" => u.IsAppReport == true,
                        "Closed" => u.Closed,
                        "Opened" => !u.Closed,
                        "With user data" => u.UserData != null,
                        "No user data" => u.UserData == null,
                        _ => true})];
    }

    public void PopulateList()
    {
        GridView.Rows.Clear();

        foreach (var report in _filteredReports)
        {
            var createdDate = DateTime.Parse(report.CreatedAt).ToString("dd-MM-yyyy, HH:mm:ss");
            var author = Users.Find((u) => u._id == report.AuthorId)?.Username ?? "Stranger";

            GridView.Rows.Add([Properties.Resources.crash16, createdDate, report.Title, author, !report.Closed, report.UserData != null]);
        }

        GridView.AutoResizeColumns();
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

    public static void Create(MainForm MainForm, Control target, List<ArcUser> users, List<BugReport> reports)
    {
        MainForm.BeginInvoke(() =>
        {
            var reportsList = new BugReportList()
            {
                Dock = DockStyle.Fill,
                Users = users,
                MainForm = MainForm,
                Reports = reports
            };

            target.Controls.Add(reportsList);
            reportsList.FilterReports();
            reportsList.PopulateList();
        });

    }
}
