namespace ReArc.Shared.Records.Database.User
{
    public record class UserPreferences(
        AccountInfo Account
    );

    public record class AccountInfo(
        string? LoginBackground,
        string? DisplayName
    );
}
