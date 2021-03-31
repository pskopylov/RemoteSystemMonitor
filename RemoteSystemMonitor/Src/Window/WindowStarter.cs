using RemoteSystemMonitor.Src.Start;
using System.Windows.Forms;

namespace RemoteSystemMonitor.Src.Window
{
    class WindowStarter
    {

        public static void Start(StartType startType)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new RemoteSystemMonitorWindow(startType));
        }

    }
}
