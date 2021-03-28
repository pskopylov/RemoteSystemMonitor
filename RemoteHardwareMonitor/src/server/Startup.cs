using Microsoft.Owin;
using Owin;
using System.Web.Http;
using RemoteHardwareMonitor.Src.Server.Configuration;

[assembly: OwinStartup(typeof(RemoteHardwareMonitor.Src.Server.Startup))]

namespace RemoteHardwareMonitor.Src.Server
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
