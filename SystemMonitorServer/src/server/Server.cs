using Microsoft.Owin.Hosting;
using System;
using SystemMonitorServer.src.server.config;

namespace SystemMonitorServer.src.server
{
    class Server
    {

        public static void Start()
        {
            using (WebApp.Start<Startup>(url : UrlConfiguration.GetUrl()))
            {
                Console.WriteLine("Server started");
                Console.ReadLine();
            }
        }

    }
}
