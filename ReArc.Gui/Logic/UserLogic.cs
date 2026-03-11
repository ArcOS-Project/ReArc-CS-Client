using ReArc.ApiHandler;
using ReArc.ApiHandler.Controllers;
using ReArc.Gui.Account;
using ReArc.Gui.Common;
using ReArc.Shared;
using ReArc.Shared.Records.Configuration;

namespace ReArc.Gui.Logic;

public static class UserLogic
{
    public static async Task LoginExisting(Form form, ServerOption serverOption)
    {
        form.BeginInvoke(() => LoadingDialog.ShowLoading(form, $"Welcome back, {serverOption.Username}"));
        await Task.Delay(100);

        var loginResult = await UserController.LoginUserWithToken(serverOption.Token!);

        await LoadingDialog.Stop();

        if (!loginResult.Success)
        {
            MessageBox.Show($"The saved token for user {serverOption.Username} on {serverOption.Url} is invalid. Please log in again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            Configuration.RemoveTokenFrom((s) => s.Url == serverOption.Url);

            Program.SetNextForm(new LoginForm());
            form.Close();
            return;
        }

        await Task.Delay(100);

        if (UserController.Restricted)
        {
            Program.SetNextForm(new TotpUnlockForm());
            form.Close();
            return;
        }

        Program.SetNextForm(new MainForm());
        form.Close();
        return;

    }

    public static async Task UnlockCurrentUser(Form form, string totpCode)
    {
        form.BeginInvoke(() => LoadingDialog.ShowLoading(form, $"Unlocking your session..."));
        await Task.Delay(100);

        var result = await UserController.UnlockTotp(totpCode);

        await LoadingDialog.Stop();

        if (!result.Success)
        {
            MessageBox.Show($"Failed to unlock. {result.ErrorMessage ?? "An unknown error occurred."}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        Program.SetNextForm(new MainForm());
        form.Close();
    }

    public static async Task LogoutCurrentUser(Form form)
    {
        form.BeginInvoke(() => LoadingDialog.ShowLoading(form, $"Logging you out..."));
        await Task.Delay(100);

        var result = await UserController.Logout();

        await LoadingDialog.Stop();

        if (!result.Success)
        {
            MessageBox.Show($"Failed to log you out. {result.ErrorMessage ?? "An unknown error occurred."}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        Configuration.RemoveTokenFrom((s) => s.Url == Client.CurrentClient.ServerOption.Url);

        Program.SetNextForm(new LoginForm());
        form.Close();
        return;
    }

    public static async Task LoginUser(Form form, string identity, string password)
    {
        form.BeginInvoke(() => LoadingDialog.ShowLoading(form, $"Logging in as {identity}"));
        await Task.Delay(100);

        var result = await UserController.LoginUser(identity, password);

        await LoadingDialog.Stop();

        if (!result.Success)
        {
            MessageBox.Show($"Failed to log you in. {result.ErrorMessage ?? "An unknown error occurred."}", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        Configuration.SetUserOf((s) => s.Url == Client.CurrentClient.ServerOption.Url, UserController.UserInfo!.Username, UserController.Token!);

        if (UserController.Restricted)
        {
            Program.SetNextForm(new TotpUnlockForm());
            form.Close();
            return;
        }

        Program.SetNextForm(new MainForm());
        form.Close();
    }
}
