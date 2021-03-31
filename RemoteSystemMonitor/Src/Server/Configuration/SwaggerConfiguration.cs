using System.Web.Http;
using Swashbuckle.Application;

namespace RemoteSystemMonitor.Src.Server.Configuration
{
    class SwaggerConfiguration
    {
        public static void Register(HttpConfiguration config)
        {
            config.EnableSwagger(c =>
            {
                c.SingleApiVersion("v1", "Hardware Monitor API");
            })
            .EnableSwaggerUi();
        }
    }
}
