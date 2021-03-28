using System.Windows.Forms;

namespace InsaneHardwareMonitor.src.window
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
