using InsaneHardwareMonitor.src.config;

namespace InsaneHardwareMonitor.src.server.config
{
    class UrlConfiguration
    {
        public static string GetUrl()
        {
            Config config = ConfigLoader.LoadConfig();
            return config.GetUrl();
        }
    }
}
