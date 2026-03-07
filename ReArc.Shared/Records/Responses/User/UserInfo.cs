namespace ReArc.Shared.Records.Responses.User;

public record class UserInfo(
    string UpdatedAt,
    string CreatedAt,
    bool? HasTotp,
    bool? Restricted,
    string Username,
    UserPreferences Preferences,
    bool Admin,
    string[] AdminScopes,
    bool Approved,
#pragma warning disable IDE1006
    string _id,
#pragma warning restore IDE1006
    string Email,
    long StorageSize,
    int AccountNumber
);

public record class UserPreferences(
    AccountInfo Account
);

public record class AccountInfo(
    string? LoginBackground,
    string? DisplayName
);