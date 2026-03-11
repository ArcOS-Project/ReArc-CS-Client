using ReArc.ApiHandler.Controllers;
using ReArc.Gui.Common;
using ReArc.Shared;
using ReArc.Shared.Records.Database;
using ReArc.Shared.Records.Responses.User;

namespace ReArc.Gui.Logic
{
    public static class AdminLogic
    {
        public static async Task<CommandResult<Dictionary<string, UserQuota>>> GetFilesystemOverview(MainForm form, List<ArcUser> users)
        {
            form.BeginInvoke(() => LoadingDialog.ShowLoading(form, $"Reading quota for {users.Count} users"));
            await Task.Delay(100);

            var result = new Dictionary<string, UserQuota> { };
            List<string> errors = [];

            for (int i = 0; i < users.Count; i++)
            {
                var user = users[i];
                LoadingDialog.ChangeCaption($"Reading quota for {user.Username}");

                var quotaResult = await AdminController.GetQuotaOf(user.Username);

                if (quotaResult.Success) result.Add(user.Username, quotaResult.Result!);
                else errors.Add($"Could not obtain quota for {user.Username}: {quotaResult.ErrorMessage!}");
                
                LoadingDialog.SetProgress(i + 1, users.Count);
            }

            await LoadingDialog.Stop();

            if (errors.Count > 0)
                return CommandResult<Dictionary<string, UserQuota>>.Error(string.Join(", ", errors), result);

            return CommandResult<Dictionary<string, UserQuota>>.Ok(result);
        }
    }
}
