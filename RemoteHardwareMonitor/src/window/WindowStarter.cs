using System.Windows.Forms;

namespace RemoteHardwareMonitor.Src.window
{
    class WindowStarter
    {

        public static void Start()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new RemoteHardwareMonitorWindow());
        }

    }
}
