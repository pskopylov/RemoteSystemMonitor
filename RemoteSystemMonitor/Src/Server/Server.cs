using Microsoft.Owin.Hosting;
using RemoteSystemMonitor.Src.Window;
using RemoteSystemMonitor.Src.AppConfig;
using RemoteSystemMonitor.Src.Firewall;
using RemoteSystemMonitor.Src.Start;

namespace RemoteSystemMonitor.Src.Server
{
    class Server
    {

        public static void Start(StartType startType)
        {
            var config = ConfigManager.LoadConfig();
            FirewallRule.Create(config);
            using (WebApp.Start<Startup>(url : config.GetUrl()))
            {
                WindowStarter.Start(startType);
            }
        }

    }
}
