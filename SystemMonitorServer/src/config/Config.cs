using System;

namespace SystemMonitorServer.src.config
{
    class Config
    {
        public String Host { get; set; }
        public int Port { get; set; }

        public string GetUrl()
        {
            return $"http://{Host}:{Port}/";
        }
    }
}
