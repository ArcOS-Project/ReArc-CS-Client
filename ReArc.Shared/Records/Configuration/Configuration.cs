namespace ReArc.Shared.Records.Configuration;

public record ConfigurationSettings
{
    public List<ServerOption> Servers = [];
    public string? Token = null;
    public string? Username = null;
}
