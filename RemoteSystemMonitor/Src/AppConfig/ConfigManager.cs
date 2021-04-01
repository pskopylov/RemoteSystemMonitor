using Newtonsoft.Json;
using System;
using System.IO;

namespace RemoteSystemMonitor.Src.AppConfig
{
    class ConfigManager
    {
        private const string ConfigPath = "Insane Soft/Config";
        private const string ConfigName = "config.json";
        
        public static Config GetConfig()
        {
            try
            {
                return LoadConfig();
            }
            catch
            {
                return InitConfig();
            }
        }

        private static Config InitConfig()
        {
            Directory.CreateDirectory(GetConfigDir());
            return CreateConfig();
        }
        
        private static Config LoadConfig()
        {
            return JsonConvert.DeserializeObject<Config>(File.ReadAllText(GetConfigPath()));
        }

        private static void SaveConfig(Config config)
        {
            string cfg = JsonConvert.SerializeObject(config, Formatting.Indented);
            File.WriteAllText(GetConfigPath(), cfg);
        }

        private static Config CreateConfig()
        {
            Config config = new Config();
            SaveConfig(config);
            return config;
        }

        private static string GetConfigPath()
        {
            return Path.Combine(GetConfigDir(), ConfigName);
        }

        private static string GetConfigDir()
        {
            return Path.Combine(GetDocumentsDir(), ConfigPath);
        }

        private static string GetDocumentsDir()
        {
            return Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        }

    }
}
