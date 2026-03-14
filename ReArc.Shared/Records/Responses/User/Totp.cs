namespace ReArc.Shared.Records.Responses.User
{
    public record class Totp(
        bool Activated,
        string Secret,
        string Url,
        string UserId,
        string _id);
}
