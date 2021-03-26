using Microsoft.Owin.Hosting;
using System;
using SystemMonitorServer.src.server.config;

namespace SystemMonitorServer.src.server
{
    class Server
    {

        public static void Start()
        {
            //var config = new HttpSelfHostConfiguration(GetUrl());

            //config.Formatters.Remove(config.Formatters.XmlFormatter);
            //config.Routes.MapHttpRoute(
            //    "DefaultApiGet",
            //    "monitor/{controller}/{action}",
            //    new { action = "Get" });

            //using (HttpSelfHostServer server = new HttpSelfHostServer(config))
            //{
            //    server.OpenAsync().Wait();
            //    Console.WriteLine("Press Enter to quit.");
            //    Console.ReadLine();
            //}
            using (WebApp.Start<Startup>(url : UrlConfiguration.GetUrl()))
            {
                Console.WriteLine("Server started");
                Console.ReadLine();
            }
        }

    }
}
