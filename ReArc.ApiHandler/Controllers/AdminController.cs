using ReArc.Shared;
using ReArc.Shared.Records.Database;

namespace ReArc.ApiHandler.Controllers
{
    public static class AdminController
    {
        public static async Task<CommandResult<List<ArcUser>>> GetAllUsers()
        {
            var response = await Client.CurrentClient.GetJson<List<ArcUser>>("/admin/users/list", UserController.Token);
            if (!response.Success) return CommandResult<List<ArcUser>>.Error(response.ErrorMessage);

            return CommandResult<List<ArcUser>>.Ok(response.Result!);
        }
    }
}
