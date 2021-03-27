using Microsoft.Owin.Hosting;
using InsaneHardwareMonitor.src.window;
using InsaneHardwareMonitor.src.config;
using InsaneHardwareMonitor.src.firewall;
using System;
using System.Diagnostics;

namespace InsaneHardwareMonitor.src.server
{
    class Server
    {

        public static void Start()
        {
            Config config = ConfigLoader.LoadConfig();
            FirewallRule.Create(config);
            using (WebApp.Start<Startup>(url : config.GetUrl()))
            {
                WindowStarter.Start();
            }
        }

    }
}
