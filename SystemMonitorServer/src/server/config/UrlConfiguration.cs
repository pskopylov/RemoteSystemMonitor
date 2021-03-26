using SystemMonitorServer.src.config;

namespace SystemMonitorServer.src.server.config
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
