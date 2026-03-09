using ReArc.Gui.Common;
using ReArc.Gui.Helpers;
using ReArc.Gui.Views;
using ReArc.Shared.Records.Database;
namespace ReArc.Gui.Components;

public partial class UserList : BaseList<ArcUser>
{
    protected override List<string> FilterOptions() => ["All", "Regular", "Admins", "Approved", "Disapproved"];

    protected override List<DataGridViewColumn> Columns()
    {
        return [
            TableHelpers.ImageColumn(Properties.Resources.user16,"ProfilePicture"),
            TableHelpers.TextColumn("Username","Username"),
            TableHelpers.TextColumn("Email","Email address"),
            TableHelpers.TextColumn("Created","Created"),
            TableHelpers.CheckboxColumn("Approved", "Approved"),
            TableHelpers.CheckboxColumn("Admin", "Admin"),
            TableHelpers.ImageColumn(Properties.Resources.id16, "View", "View User"),
            TableHelpers.ImageColumn(Properties.Resources.copy16, "Copy", "Copy..."),
        ];
    }

    public override bool QueryFilterCallback(string query, ArcUser item)
    {
        var comparison = StringComparison.InvariantCultureIgnoreCase;

        return query == string.Empty ||
               item.Username.Contains(query, comparison) ||
               item.Email.Contains(query, comparison) ||
               (item.Preferences?.Account.DisplayName?.Contains(query, comparison) ?? false) ||
               item._id == query;
    }

    public override bool FilterCallback(string filter, ArcUser item)
    {
        return filter switch
        {
            "All" => true,
            "Regular" => !item.Admin,
            "Admins" => item.Admin,
            "Approved" => item.Approved,
            "Disapproved" => !item.Approved,
            _ => true
        };
    }

    public override object[] GetGridRow(ArcUser item)
    {
        var createdDate = DateTime.Parse(item.CreatedAt).ToString("dd-MM-yyyy, HH:mm:ss");

        return [Properties.Resources.user16, item.Username, item.Email, createdDate, item.Approved, item.Admin];
    }

    public override void OnCellClicked(object sender, DataGridViewCellEventArgs e)
    {
        var columnName = ((DataGridView)sender).Columns[e.ColumnIndex].Name;
        var user = _filteredItems[e.RowIndex];

        switch (columnName)
        {
            case "View":
                _ = MainForm!.SwitchView(new ViewUser(), $"View {user.Username}", new Dictionary<string, object>() {
                        { "User", user! }
                    });
                break;

            case "Copy":
                CopyDialog.ShowCopyDialog(MainForm!, user._id);
                break;
        }
    }
}
