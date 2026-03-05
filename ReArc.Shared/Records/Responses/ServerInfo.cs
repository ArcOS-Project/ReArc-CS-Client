namespace ReArc.Shared.Records.Responses;

public record class ServerInfo(
    string Validation,
    string Status,
    bool LoginWallpaper = false,
    string LoginBottomText = "",
    string LoginNotice = "",
    bool DisableRegistration = false,
    bool FreshBackend = false,
    bool RejectTargetedAuthorization = false,
    bool NoEmailVerify = false
);