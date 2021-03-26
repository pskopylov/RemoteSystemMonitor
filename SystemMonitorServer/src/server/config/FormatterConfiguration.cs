using System.Web.Http;

namespace SystemMonitorServer.src.server.config
{
    class FormatterConfiguration
    {
        public static void Register(HttpConfiguration config)
        {
            config.Formatters.Remove(config.Formatters.XmlFormatter);
        }
    }
}
