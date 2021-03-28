using Microsoft.Owin.Hosting;
using RemoteHardwareMonitor.Src.window;
using RemoteHardwareMonitor.Src.AppConfig;
using RemoteHardwareMonitor.Src.Firewall;

namespace RemoteHardwareMonitor.Src.Server
{
    class Server
    {

        public static void Start()
        {
            var config = ConfigLoader.LoadConfig();
            FirewallRule.Create(config);
            using (WebApp.Start<Startup>(url : config.GetUrl()))
            {
                WindowStarter.Start();
            }
        }

    }
}
