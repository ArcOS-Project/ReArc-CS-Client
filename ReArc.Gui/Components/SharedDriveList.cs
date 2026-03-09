using ReArc.Shared.Helpers;
using ReArc.Shared.Records.Database;
using ReArc.Shared.Records.Responses;
using System.Data;

namespace ReArc.Gui.Components;

public partial class SharedDriveList : UserControl
{
    public List<SharedDrive> Shares = [];
    public List<ArcUser> Users = [];
    public MainForm? MainForm;
    private string _filter { get => FilterBox.Text; }
    private string _query { get => SearchBox.Text; }
    private List<SharedDrive> _filteredShares = [];

    public SharedDriveList()
    {
        InitializeComponent();

        FilterBox.SelectedIndex = 0;
    }


    public void FilterReports()
    {
        var comparison = StringComparison.InvariantCultureIgnoreCase;

        if (_filter == string.Empty && _query == string.Empty)
        {
            _filteredShares = Shares;
            return;
        }

        _filteredShares = [.. Shares.Where(
                (u) => _query == string.Empty ||
                       (u.Description?.Contains(_query, comparison) ?? false) ||
                       (u.ShareName?.Contains(_query, comparison) ?? false) ||
                       u._id == _query)];

        _filteredShares = [.. _filteredShares.Where(
                (u) => _filter switch {
                        "All" => true,
                        "Not locked" => u.Locked != true,
                        "Locked" => u.Locked == true,
                        "Abnormal size" => u.MaxSize != (1024 ^ 3) / 2,
                        "Normal size" => u.MaxSize == (1024 ^ 3) / 2,
                        "No members" => u.Accessors.Length == 0,
                        "Has members" => u.Accessors.Length > 0,
                        _ => true})];
    }

    public void PopulateList()
    {
        GridView.Rows.Clear();

        foreach (var report in _filteredShares)
        {
            var author = Users.Find((u) => u._id == report.UserId)?.Username ?? "Stranger";

            GridView.Rows.Add([Properties.Resources.share16, report.ShareName, author, ByteHelpers.FormatBytes(report.MaxSize), report.Locked]);
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

    public static void Create(MainForm MainForm, Control target, List<ArcUser> users, List<SharedDrive> shares)
    {
        MainForm.BeginInvoke(() =>
        {
            var sharesList = new SharedDriveList()
            {
                Dock = DockStyle.Fill,
                Users = users,
                MainForm = MainForm,
                Shares = shares
            };

            target.Controls.Add(sharesList);
            sharesList.FilterReports();
            sharesList.PopulateList();
        });

    }
}
