using System.Text.Json.Serialization;

namespace ReArc.Shared.Records.Configuration;

public record ServerOption
{
    [JsonInclude]
    public required string Url;
    [JsonInclude]
    public string? AuthCode = null;
    [JsonInclude]
    public string? Username = null;
    [JsonInclude]
    public string? Token = null;
}
