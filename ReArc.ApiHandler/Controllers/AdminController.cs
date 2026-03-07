using ReArc.Shared;
using ReArc.Shared.Records.Database;
using ReArc.Shared.Records.Responses.Admin;

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

        public static async Task<CommandResult<Statistics>> GetStatistics()
        {
            var response = await Client.CurrentClient.GetJson<Statistics>("/admin/stats", UserController.Token);
            if (!response.Success) return CommandResult<Statistics>.Error(response.ErrorMessage);

            return CommandResult<Statistics>.Ok(response.Result!);
        }
    }
}
