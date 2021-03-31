using Microsoft.Win32;
using RemoteSystemMonitor.Src.AppConfig;
using System.Reflection;

namespace RemoteSystemMonitor.Src.Autorun
{
    class RegisterManager
    {
        private const string REGISTRY_PATH = "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run";
        private const string APP_NAME = "RemoteSystemMonitor";
        public static void AddToStartup()
        {
            Config config = ConfigManager.LoadConfig();
            if (!config.Autorun)
            {
                RegistryKey key = Registry.CurrentUser.OpenSubKey(REGISTRY_PATH, true);
                key.SetValue(APP_NAME, Assembly.GetEntryAssembly().Location);
                config.Autorun = true;
                ConfigManager.SaveConfig(config);
            }
        }
    }
}
