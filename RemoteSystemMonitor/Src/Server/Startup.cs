using Microsoft.Owin;
using Owin;
using System.Web.Http;
using RemoteSystemMonitor.Src.Server.Configuration;

[assembly: OwinStartup(typeof(RemoteSystemMonitor.Src.Server.Startup))]

namespace RemoteSystemMonitor.Src.Server
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
