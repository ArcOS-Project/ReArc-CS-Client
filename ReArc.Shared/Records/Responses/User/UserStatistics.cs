namespace ReArc.Shared.Records.Responses.User
{
    public record class UserStatistics(
        int Activities,
        int Approvals,
        int Bughunts,
        int Fsaccesses,
        int Indexings,
        int Messages,
        int Shares,
        int Tokens);
}
