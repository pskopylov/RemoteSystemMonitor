using Microsoft.Owin;
using Owin;
using System;
using System.Threading.Tasks;
using System.Web.Http;
using SystemMonitorServer.src.server.config;

[assembly: OwinStartup(typeof(SystemMonitorServer.src.server.Startup))]

namespace SystemMonitorServer.src.server
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
