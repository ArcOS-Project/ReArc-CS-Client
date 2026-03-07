namespace ReArc.Shared.Records.Responses.Admin
{
    public record class Statistics(
        StatisticsCounts Counts,
        int Endpoints
    );

    public record class StatisticsCounts(
        int Tokens,
        int Users,
        int Indexes,
        int Approvals,
        int Accessors,
        int Bugreps,
        int Audits,
        int Activities
    );
}
