namespace RemoteSystemMonitor.Src.AppConfig
{
    public class Config
    {
        public string Port { get => port; set => port = value; }

        private string port = "57308";


        public string GetUrl()
        {
            return $"http://*:{Port}/";
        }
    }
}
