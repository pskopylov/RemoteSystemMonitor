using Newtonsoft.Json;
using System.IO;

namespace RemoteHardwareMonitor.Src.AppConfig
{
    class ConfigLoader
    {
        private const string CONFIG_PATH = "Config/config.json";
        public static Config LoadConfig()
        {
            return JsonConvert.DeserializeObject<Config>(File.ReadAllText(CONFIG_PATH));
        }
    }
}
