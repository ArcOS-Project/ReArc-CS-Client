using ReArc.ApiHandler.Controllers;
using ReArc.Gui.Common;
using ReArc.Gui.Components;
using ReArc.Shared;
using ReArc.Shared.Records.Database;
using ReArc.Shared.Records.Responses;

namespace ReArc.Gui.Views;

public partial class Shares : Page
{
    private List<ArcUser> _users = [];
    private List<SharedDrive> _shares = [];

    public Shares()
    {
        InitializeComponent();
    }

    public override async Task<CommandResult<bool>> LoadData(Dictionary<string, object>? props = null)
    {
        LoadingDialog.ChangeCaption("Retrieving shared drives");
        var sharesResult = await AdminController.GetAllShares();
        if (!sharesResult.Success) return CommandResult<bool>.Error(sharesResult.ErrorMessage);

        LoadingDialog.ChangeCaption("Retrieving user list");
        var usersResult = await AdminController.GetAllUsers();
        if (!usersResult.Success) return CommandResult<bool>.Error(usersResult.ErrorMessage);

        _shares = sharesResult.Result!;
        _users = usersResult.Result!;
        return CommandResult<bool>.Ok(true);
    }

    public override void Render()
    {
        ShareList.Create(MainForm!, this, _users!, _shares!);
    }
}
