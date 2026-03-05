using ReArc.ApiHandler;
using ReArc.ApiHandler.Controllers;
using ReArc.Shared.Records.Configuration;

namespace ReArc.TestClient;

internal class Program
{
    private static async Task Main(string[] args)
    {
        try
        {
            var client = await Client.Initialize(new ServerOption() { Url = "https://arcapi.nl" });

            Console.Write("Identity: ");
            string? identity = Console.ReadLine();
            Console.Write("Password: ");
            string? password = Console.ReadLine();

            if (identity is null || password is null)
            {
                throw new Exception("Missing identity or password");
            }

            var userInfoResult = await UserController.LoginUser(identity, password);

            if (!userInfoResult.Success)
            {
                throw new Exception(userInfoResult.ErrorMessage);
            }

            Console.WriteLine($"{userInfoResult.Result!.Email} ({userInfoResult.Result._id})");
        }
        catch (Exception e)
        {
            Console.WriteLine("An error occurred: " + e.Message);
        }
    }
}