using Microsoft.Owin.Hosting;
using InsaneHardwareMonitor.src.server.config;
using InsaneHardwareMonitor.src.window;

namespace InsaneHardwareMonitor.src.server
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
