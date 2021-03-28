using Newtonsoft.Json;
using System.IO;

namespace InsaneHardwareMonitor.src.config
{
    class ConfigLoader
    {
        private static string CONFIG_PATH = "config/config.json";
        public static Config LoadConfig()
        {
            return JsonConvert.DeserializeObject<Config>(File.ReadAllText(CONFIG_PATH));
        }
    }
}
