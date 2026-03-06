using ReArc.ApiHandler;
using ReArc.Shared;

namespace ReArc.Gui.Helpers;

public static class MessageBoxHelper
{
    public static DialogResult ServerConnectFailed(Form form, CommandResult<Client> result, bool retry = false)
    {
        return MessageBox.Show(form, $"Unable to connect to the requested server. It might be offline or the provided authorization code is incorrect.\n\nDetails: {result.ErrorMessage}", "Connection failed", retry ? MessageBoxButtons.RetryCancel : MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
}
