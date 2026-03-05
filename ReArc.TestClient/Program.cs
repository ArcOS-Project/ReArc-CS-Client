using ReArc.ApiHandler;
using ReArc.ApiHandler.Controllers;
using ReArc.Shared.Helpers;
using ReArc.Shared.Records.Configuration;

namespace ReArc.TestClient;

internal class Program
{
    private static async Task Main(string[] args)
    {
        try
        {
            var client = await Client.Initialize(new ServerOption() { Url = "https://arcapi.nl" });
            string? identity = ConsoleHelpers.Prompt("Identity: ");
            string? password = ConsoleHelpers.Prompt("Password: ", true);

            if (identity is null || password is null)
            {
                throw new Exception("Missing identity or password");
            }

            var userInfoResult = await UserController.LoginUser(identity, password);

            if (!userInfoResult.Success)
            {
                throw new Exception(userInfoResult.ErrorMessage);
            }

            if (!(UserController.UserInfo?.Admin ?? false))
            {
                throw new Exception("You must be an administrator to access this resource.");
            }

            if (UserController.Restricted)
            {
                string? totpCode = ConsoleHelpers.Prompt("2FA code: ") ?? throw new Exception("You didn't enter a 2FA code");
                var result = await UserController.UnlockTotp(totpCode);

                if (!result.Success)
                {
                    throw new Exception(result.ErrorMessage);
                }
            }

            Console.WriteLine($"{userInfoResult.Result!.Email} ({userInfoResult.Result._id})");
        }
        catch (Exception e)
        {
            Console.WriteLine("An error occurred: " + e.Message);
        }
    }
}