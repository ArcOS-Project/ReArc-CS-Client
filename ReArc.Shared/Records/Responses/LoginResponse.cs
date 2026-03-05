using ReArc.Shared.Records.Database;

namespace ReArc.Shared.Records.Responses;

public record class LoginResponse(
    string Token,
    bool IsAuthenticated,
    ArcUser User
);
