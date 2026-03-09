using MimeKit;
using ReArc.Shared;
using ReArc.Shared.Records.Responses;
using ReArc.Shared.Records.Responses.User;

namespace ReArc.ApiHandler.Controllers
{
    public static class UserController
    {
        public static UserInfo? UserInfo { get; private set => field = value; }
        public static string? ProfilePicture { get; private set => field = value; }
        public static string? Token { get; private set => field = value; }
        public static bool Restricted { get; private set => field = value; }
        public static string? DisplayName { get => UserInfo?.Preferences.Account.DisplayName ?? UserInfo?.Username; }

        public static async Task<CommandResult<UserInfo>> GetUserInfoForToken(string token)
        {
            var response = await Client.CurrentClient.GetJson<UserInfo>("/user/self", token);
            if (!response.Success) return CommandResult<UserInfo>.Error(response.ErrorMessage);

            return response;
        }

        public static async Task<CommandResult<UserInfo>> LoginUser(string identity, string password)
        {
            var loginResult = await Client.CurrentClient.PostForJson<LoginResponse>("/login", new Dictionary<string, string>()
            {
                { "identity", identity },
                { "password", password },
            });

            if (!loginResult.Success) return CommandResult<UserInfo>.Error(loginResult.ErrorMessage);

            return await LoginUserWithToken(loginResult.Result!.Token!);
        }

        public static async Task<CommandResult<UserInfo>> LoginUserWithToken(string token)
        {
            if (UserInfo != null)
            {
                return CommandResult<UserInfo>.Error("Already authenticated as " + UserInfo.Username);
            }

            var userInfoResult = await GetUserInfoForToken(token);

            if (!userInfoResult.Success) return CommandResult<UserInfo>.Error(userInfoResult.ErrorMessage);
            if (!userInfoResult.Result!.Admin) return CommandResult<UserInfo>.Error("You have to be an administrator to access this resource.");

            Token = token;
            UserInfo = userInfoResult.Result!;
            Restricted = (UserInfo.HasTotp ?? false) && (UserInfo.Restricted ?? false);

            var profilePictureResult = await DownloadProfilePicture(UserInfo._id);
            if (profilePictureResult.Success) ProfilePicture = profilePictureResult.Result!;

            return CommandResult<UserInfo>.Ok(userInfoResult.Result!);
        }

        public static async Task<CommandResult<bool>> UnlockTotp(string totpCode)
        {
            if (Token == null) return CommandResult<bool>.Error("Not logged in.");

            var response = await Client.CurrentClient.Post("/totp/unlock", new Dictionary<string, string>()
            {
                { "code", totpCode }
            });

            if (!response.Success) return CommandResult<bool>.Error(response.ErrorMessage);

            Restricted = false;

            return CommandResult<bool>.Ok(true);
        }

        public static async Task<CommandResult<bool>> DiscontinueToken(string token)
        {
            var response = await Client.CurrentClient.Post("/logout", token);
            if (!response.Success) return CommandResult<bool>.Error(response.ErrorMessage);

            return CommandResult<bool>.Ok(true);
        }

        public static async Task<CommandResult<bool>> Logout()
        {
            if (Token == null) return CommandResult<bool>.Error("Not logged in.");

            var discontinuationResult = await DiscontinueToken(Token);
            if (discontinuationResult.Success)
            {
                UserInfo = null;
                Token = null;
                Restricted = false;
                ProfilePicture = null;
            }

            return discontinuationResult;
        }

        public static void Reset()
        {
            UserInfo = null;
            Token = null;
            Restricted = false;
            ProfilePicture = null;
        }

        public static void SetToken(string token)
        {
            Token = token;
        }

        public static async Task<CommandResult<string>> DownloadProfilePicture(string userId)
        {
            var uri = new UriBuilder(Client.CurrentClient.ServerOption.Url)
            {
                Path = $"/user/pfp/{userId}",
                Query = $"authcode={Client.CurrentClient.ServerOption.AuthCode ?? ""}"
            };
            var url = uri.ToString();
            var client = new HttpClient();

            try
            {
                var response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();

                MimeTypes.TryGetExtension(response.Content.Headers.ContentType?.MediaType ?? "image/png", out var extension);
                var path = Path.Join(Configuration.Temp.FullName, Guid.NewGuid().ToString() + extension);

                var stream = await response.Content.ReadAsStreamAsync();
                var fileStream = new FileStream(path, FileMode.Create);
                await stream.CopyToAsync(fileStream);

                fileStream.Close();

                return CommandResult<string>.Ok(path);
            }
            catch (Exception e)
            {
                return CommandResult<string>.Error(e.Message);
            }
        }
    }
}
