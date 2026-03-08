namespace ReArc.Shared.Records.Responses.User
{
    public record class UserQuota(
        long Used,
        long Max,
        long Free,
        double Percentage);
}
