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

    protected override bool QueryFilterCallback(string query, ArcUser item)
    {
        var comparison = StringComparison.InvariantCultureIgnoreCase;

        return query == string.Empty ||
               item.Username.Contains(query, comparison) ||
               item.Email.Contains(query, comparison) ||
               (item.Preferences?.Account.DisplayName?.Contains(query, comparison) ?? false) ||
               item._id == query;
    }

    protected override bool FilterCallback(string filter, ArcUser item)
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

    protected override object[] GetGridRow(ArcUser item)
    {
        var createdDate = DateTime.Parse(item.CreatedAt).ToString("dd-MM-yyyy, HH:mm:ss");

        return [Properties.Resources.user16, item.Username, item.Email, createdDate, item.Approved, item.Admin];
    }

    protected override void OnCellClicked(string columnName, ArcUser item, int row, int column)
    {
        switch (columnName)
        {
            case "View":
            case "Username":
                _ = MainForm!.SwitchView(new ViewUser(),
                                         $"View {item.Username}",
                                         new Dictionary<string, object>() { { "User", item } });
                break;

            case "Email":
                CopyDialog.ShowCopyDialog(MainForm!, item.Email);
                break;

            case "Copy":
                CopyDialog.ShowCopyDialog(MainForm!, item._id);
                break;
        }
    }

    protected override void HandleSingleItemResult(ArcUser item, string query, string filter)
    {
        _ = MainForm!.SwitchView(new ViewUser(),
                         $"View {item.Username}",
                         new Dictionary<string, object>() { { "User", item } });
    }
}
