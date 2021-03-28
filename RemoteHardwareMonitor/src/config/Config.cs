using System;

namespace InsaneHardwareMonitor.src.config
{
    class Config
    {
        public string Port { get; set; }

        public string GetUrl()
        {
            return $"http://*:{Port}/";
        }
    }
}
