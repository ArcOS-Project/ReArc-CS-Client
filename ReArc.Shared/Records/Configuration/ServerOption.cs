namespace ReArc.Shared.Records.Configuration;

public record ServerOption
{
    public required string Url;
    public string? AuthCode = null;
}
