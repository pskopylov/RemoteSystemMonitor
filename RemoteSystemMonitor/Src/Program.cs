#define DEBUG
using RemoteSystemMonitor.Src.AppConfig;
using RemoteSystemMonitor.Src.Server;
using RemoteSystemMonitor.Src.Start;

namespace RemoteSystemMonitor
{
    class Program
    {
        static void Main(string[] args)
        {
            var config = ConfigManager.GetConfig();
            var startType = StartManager.DefineStartType(args);
            Server.Start(config, startType);
        }
    }
}
