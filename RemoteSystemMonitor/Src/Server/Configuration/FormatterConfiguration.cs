using System.Web.Http;

namespace RemoteSystemMonitor.Src.Server.Configuration
{
    class FormatterConfiguration
    {
        public static void Register(HttpConfiguration config)
        {
            config.Formatters.Remove(config.Formatters.XmlFormatter);
        }
    }
}
