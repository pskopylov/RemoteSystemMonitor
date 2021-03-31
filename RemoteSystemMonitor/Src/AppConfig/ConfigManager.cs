using Newtonsoft.Json;
using System.IO;

namespace RemoteSystemMonitor.Src.AppConfig
{
    class ConfigManager
    {
        private const string CONFIG_PATH = "Config/config.json";
        public static Config LoadConfig()
        {
            return JsonConvert.DeserializeObject<Config>(File.ReadAllText(CONFIG_PATH));
        }

        public static void SaveConfig(Config config)
        {
            string cfg = JsonConvert.SerializeObject(config);
            File.WriteAllText(CONFIG_PATH, cfg);
        }

    }
}
