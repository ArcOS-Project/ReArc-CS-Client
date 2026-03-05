using ReArc.Shared.Records.Configuration;
using System.Diagnostics;
using System.Text.Json;

namespace ReArc.Shared
{
    public static class Configuration
    {
        private static readonly string ConfigPath = Path.Join(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "ReArcClient.json");
        public static ConfigurationSettings? Settings
        {
            get; private set
            {
                if (value != null) _ = WriteConfiguration(value);

                field = value;
            }
        }

        public static async Task<CommandResult<ConfigurationSettings>> ReadConfiguration()
        {
            try
            {
                var contents = await File.ReadAllTextAsync(ConfigPath);
                var settings = JsonSerializer.Deserialize<ConfigurationSettings>(contents) ?? throw new Exception();
                Settings = settings;

                return CommandResult<ConfigurationSettings>.Ok(settings);
            }
            catch (Exception)
            {
                var result = await WriteConfiguration(DefaultConfiguration());
                Settings = result.Result!;

                return result;
            }
        }

        private static async Task<CommandResult<ConfigurationSettings>> WriteConfiguration(ConfigurationSettings settings)
        {
            try
            {
                await File.WriteAllTextAsync(ConfigPath, JsonSerializer.Serialize(settings));

                return CommandResult<ConfigurationSettings>.Ok(settings);
            }
            catch (Exception e)
            {
                return CommandResult<ConfigurationSettings>.Error("Failed to save configuration: " + e.Message);
            }
        }

        private static ConfigurationSettings DefaultConfiguration()
        {
            return new ConfigurationSettings()
            {
                Servers = [],
                LastServer = null
            };
        }

        public static void DeleteServer(Predicate<ServerOption> predicate)
        {
            var idx = Settings?.Servers.FindIndex(predicate) ?? -1;
            if (idx < 0) return;

            Settings?.Servers.RemoveAt(idx);
        }

        public static void AddServer(string url, string? authCode, string? username, string? token)
        {
            var server = Settings?.Servers.Find((s) => s.Url == url);
            if (server != null) return;

            Settings?.Servers.Add(new ServerOption()
            {
                Url = url,
                AuthCode = authCode,
                Username = username,
                Token = token
            });
        }

        public static void UpdateServer(Predicate<ServerOption> predicate, ServerOption update)
        {
            var idx = Settings?.Servers.FindIndex(predicate) ?? -1;
            if (idx < 0) return;

            Settings?.Servers[idx] = update;
        }

        public static void SetLastServer(string url)
        {
            if (Settings == null) return;

            Settings.LastServer = url;
        }
    }
}
