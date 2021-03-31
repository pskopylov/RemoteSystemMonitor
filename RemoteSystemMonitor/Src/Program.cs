#define DEBUG
using RemoteSystemMonitor.Src.Autorun;
using RemoteSystemMonitor.Src.Server;
using RemoteSystemMonitor.Src.Start;

namespace RemoteSystemMonitor
{
    class Program
    {
        static void Main(string[] args)
        {
            StartType startType = StartManager.DefineStartType(args);
            #if DEBUG
                startType = StartType.User;
            #endif
            RegisterManager.AddToStartup();
            Server.Start(startType);
        }
    }
}
