namespace ReArc.Shared.Records.Responses
{
    public record class BugReport(
        string? AuthorId,
        string Title,
        string Body,
        bool Closed,
        string Version,
        object Location,
        object? UserData,
        string? UserAgent,
        string? Api,
        string Frontend,
        object Meta,
        object Env,
        string? _id,
        string CreatedAt,
        string Mode,
        string Build,
        bool Public,
        bool? IsAppReport,
        string? ReportAppId,
        string? ReportAppPkgId);

    public record class LogItem(
        string Source,
        string Message,
        int Timestamp,
        LogLevel Level,
        int KernelTime);

    public record class ReportStatistics(
        int Opened,
        int Closed,
        int Total,
        int Apis);

    public enum LogLevel
    {
        Info,
        Warning,
        Error,
        Critical
    }
}
