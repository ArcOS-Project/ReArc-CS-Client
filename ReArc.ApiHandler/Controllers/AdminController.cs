using Org.BouncyCastle.Asn1.X509;
using ReArc.Shared;
using ReArc.Shared.Records.Database;
using ReArc.Shared.Records.Responses;
using ReArc.Shared.Records.Responses.Admin;
using ReArc.Shared.Records.Responses.User;
using System.Runtime.InteropServices;

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

        public static async Task<CommandResult<List<BugReport>>> GetAllBugReports()
        {
            var response = await Client.CurrentClient.GetJson<List<BugReport>>("/admin/bughunt/list", UserController.Token);
            if (!response.Success) return CommandResult<List<BugReport>>.Error(response.ErrorMessage);

            return CommandResult<List<BugReport>>.Ok(response.Result!);
        }

        public static async Task<CommandResult<ReportStatistics>> GetBugHuntStatistics()
        {
            var response = await Client.CurrentClient.GetJson<ReportStatistics>("/admin/bughunt/stats", UserController.Token);
            if (!response.Success) return CommandResult<ReportStatistics>.Error(response.ErrorMessage);

            return CommandResult<ReportStatistics>.Ok(response.Result!);
        }

        public static async Task<CommandResult<UserQuota>> GetQuotaOf(string username)
        {
            var response = await Client.CurrentClient.GetJson<UserQuota>($"/admin/fs/quota/{username}", UserController.Token);
            if (!response.Success) return CommandResult<UserQuota>.Error(response.ErrorMessage);

            return CommandResult<UserQuota>.Ok(response.Result!);
        }

        public static async Task<CommandResult<UserStatistics>> GetStatisticsOf(string userId)
        {
            var response = await Client.CurrentClient.GetJson<UserStatistics>($"/admin/users/stats/{userId}", UserController.Token);
            if (!response.Success) return CommandResult<UserStatistics>.Error(response.ErrorMessage);

            return CommandResult<UserStatistics>.Ok(response.Result!);
        }

        public static async Task<CommandResult<bool>> ApproveUser(string username)
        {
            var response = await Client.CurrentClient.Post("/admin/users/approve", new Dictionary<string, string>() {
                {"target", username }
            });

            if (!response.Success) return CommandResult<bool>.Error(response.ErrorMessage);
            return CommandResult<bool>.Ok(true);
        }

        public static async Task<CommandResult<bool>> DisapproveUser(string username)
        {
            var response = await Client.CurrentClient.Post("/admin/users/disapprove", new Dictionary<string, string>() {
                {"target", username }
            });

            if (!response.Success) return CommandResult<bool>.Error(response.ErrorMessage);
            return CommandResult<bool>.Ok(true);
        }
        public static async Task<CommandResult<bool>> GrantAdmin(string username)
        {
            var response = await Client.CurrentClient.Post("/admin/grant", new Dictionary<string, string>() {
                {"target", username }
            });

            if (!response.Success) return CommandResult<bool>.Error(response.ErrorMessage);
            return CommandResult<bool>.Ok(true);
        }
        public static async Task<CommandResult<bool>> RevokeAdmin(string username)
        {
            var response = await Client.CurrentClient.Post("/admin/revoke", new Dictionary<string, string>() {
                {"target", username }
            });

            if (!response.Success) return CommandResult<bool>.Error(response.ErrorMessage);
            return CommandResult<bool>.Ok(true);
        }

        public static async Task<CommandResult<List<SharedDrive>>> GetAllShares()
        {
            var response = await Client.CurrentClient.GetJson<List<SharedDrive>>($"/admin/share/list", UserController.Token);
            if (!response.Success) return CommandResult<List<SharedDrive>>.Error(response.ErrorMessage);

            return CommandResult<List<SharedDrive>>.Ok(response.Result!);
        }

        public static async Task<CommandResult<List<SharedDrive>>> GetSharesOf(string userId)
        {
            var response = await Client.CurrentClient.GetJson<List<SharedDrive>>($"/admin/share/list/{userId}", UserController.Token);
            if (!response.Success) return CommandResult<List<SharedDrive>>.Error(response.ErrorMessage);

            return CommandResult<List<SharedDrive>>.Ok(response.Result!);
        }

        public static async Task<CommandResult<byte[]>> ReadFile(string username, string path)
        {
            var response = await Client.CurrentClient.Get($"/admin/fs/{username}/{path}", UserController.Token!);
            if (!response.Success) return CommandResult<byte[]>.Error(response.ErrorMessage);

            var data = await response.Result!.Content!.ReadAsByteArrayAsync();
            if (data == null) return CommandResult<byte[]>.Error("Failed to read");

            return CommandResult<byte[]>.Ok(data);
        }

        public static async Task<CommandResult<bool>> DeleteUser(string username)
        {
            var response = await Client.CurrentClient.Delete($"/admin/users/delete/{username}", UserController.Token!);
            if (!response.Success) return CommandResult<bool>.Error(response.ErrorMessage);

            return CommandResult<bool>.Ok(true);
        }
    }
}
