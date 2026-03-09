using ReArc.Gui.Helpers;
using ReArc.Shared.Records.Database;
using ReArc.Shared.Records.Responses;

namespace ReArc.Gui.Components
{
    public partial class BugReportList : BaseList<BugReport>
    {
        public List<ArcUser> Users = [];
        protected override List<string> FilterOptions() => ["All", "System", "Apps", "Opened", "Closed", "With user data", "No user data"];
        protected override List<DataGridViewColumn> Columns()
        {
            return [
                TableHelpers.ImageColumn(Properties.Resources.user, "Icon"),
                TableHelpers.TextColumn("Timestamp", "Timestamp"),
                TableHelpers.TextColumn("Title", "Title", DataGridViewAutoSizeColumnMode.Fill),
                TableHelpers.TextColumn("Author", "Author"),
                TableHelpers.CheckboxColumn("Opened", "Opened"),
                TableHelpers.CheckboxColumn("UserData", "User Data?"),
            ];
        }

        public override bool QueryFilterCallback(string query, BugReport item)
        {
            var comparison = StringComparison.InvariantCultureIgnoreCase;

            return query == string.Empty ||
                   (item.Body?.Contains(query, comparison) ?? false) ||
                   (item.Title?.Contains(query, comparison) ?? false) ||
                   (item.UserAgent?.Contains(query, comparison) ?? false) ||
                   item._id == query;
        }

        public override bool FilterCallback(string filter, BugReport item)
        {
            return filter switch
            {
                "All" => true,
                "System" => item.IsAppReport != true,
                "Apps" => item.IsAppReport == true,
                "Closed" => item.Closed,
                "Opened" => !item.Closed,
                "With user data" => item.UserData != null,
                "No user data" => item.UserData == null,
                _ => true
            };
        }

        public override object[] GetGridRow(BugReport item)
        {
            var createdDate = DateTime.Parse(item.CreatedAt).ToString("dd-MM-yyyy, HH:mm:ss");
            var author = Users.Find((u) => u._id == item.AuthorId)?.Username ?? "Stranger";

            return [Properties.Resources.crash16, createdDate, item.Title, author, !item.Closed, item.UserData != null];
        }

        public override void OnCellClicked(object sender, DataGridViewCellEventArgs e)
        { }

        public static void Create(MainForm MainForm, Control target, List<ArcUser> users, List<BugReport> reports)
        {
            MainForm.BeginInvoke(() =>
            {
                var reportsList = new BugReportList()
                {
                    Dock = DockStyle.Fill,
                    Users = users,
                    MainForm = MainForm,
                    Items = reports
                };

                target.Controls.Add(reportsList);
                reportsList.FilterItems();
                reportsList.PopulateList();
            });
        }
    }
}
