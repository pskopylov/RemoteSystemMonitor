using Microsoft.Owin;
using Owin;
using System.Web.Http;
using InsaneHardwareMonitor.src.server.config;

[assembly: OwinStartup(typeof(InsaneHardwareMonitor.src.server.Startup))]

namespace InsaneHardwareMonitor.src.server
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var config = new HttpConfiguration();

            FormatterConfiguration.Register(config);
            RouteConfiguration.Register(config);
            SwaggerConfiguration.Register(config);

            app.UseWebApi(config);
        }
    }
}
