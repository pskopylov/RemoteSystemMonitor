using Microsoft.Owin.Hosting;
using SystemMonitorServer.src.server.config;
using SystemMonitorServer.src.window;

namespace SystemMonitorServer.src.server
{
    class Server
    {

        public static void Start()
        {
            using (WebApp.Start<Startup>(url : UrlConfiguration.GetUrl()))
            {
                WindowStarter.Start();
            }
        }

    }
}
