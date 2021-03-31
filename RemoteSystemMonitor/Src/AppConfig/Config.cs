namespace RemoteSystemMonitor.Src.AppConfig
{
    class Config
    {
        public string Port { get; set; }
        public bool Autorun { get => autorun; set => autorun = value; }
        public bool RuleCreated { get => ruleCreated; set => ruleCreated = value; }

        private bool ruleCreated = false;

        private bool autorun = false;

        public string GetUrl()
        {
            return $"http://*:{Port}/";
        }
    }
}
