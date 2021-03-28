using System.Web.Http;

namespace RemoteHardwareMonitor.Src.Server.Configuration
{
    class FormatterConfiguration
    {
        public static void Register(HttpConfiguration config)
        {
            config.Formatters.Remove(config.Formatters.XmlFormatter);
        }
    }
}
