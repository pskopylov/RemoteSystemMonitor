namespace RemoteHardwareMonitor.Src.AppConfig
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
