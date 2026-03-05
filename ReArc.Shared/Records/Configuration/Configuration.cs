using System.Text.Json.Serialization;

namespace ReArc.Shared.Records.Configuration;

public record ConfigurationSettings
{
    [JsonInclude]
    public List<ServerOption> Servers = [];
    [JsonInclude]
    public string? LastServer = null;
}
