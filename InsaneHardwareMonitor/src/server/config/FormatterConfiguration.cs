using System.Web.Http;

namespace InsaneHardwareMonitor.src.server.config
{
    class FormatterConfiguration
    {
        public static void Register(HttpConfiguration config)
        {
            config.Formatters.Remove(config.Formatters.XmlFormatter);
        }
    }
}
