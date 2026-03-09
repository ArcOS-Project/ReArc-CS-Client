namespace ReArc.Shared.Records.Responses;

public record class SharedDrive(
    string UserId,
    string[] Accessors,
    string ShareName,
    long MaxSize,
    string PasswordHash,
    string? Description,
    bool Locked,
    string _id);
    