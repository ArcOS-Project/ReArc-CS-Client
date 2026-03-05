namespace ReArc.Shared.Records.Responses.User;

public record class UserInfo(
    string UpdatedAt,
    string CreatedAt,
    bool? HasTotp,
    bool Restricted,
    string Username,
    object Preferences,
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