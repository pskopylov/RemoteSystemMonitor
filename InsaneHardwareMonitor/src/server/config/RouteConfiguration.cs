using System.Web.Http;

namespace InsaneHardwareMonitor.src.server.config
{
    class RouteConfiguration
    {
        public static void Register(HttpConfiguration config)
        {
            config.Routes.MapHttpRoute(
                "Hardware Monitor API",
                "Hardware/{controller}/{action}",
                new { controller = "System", action = "Get" });
        }
    }
}
