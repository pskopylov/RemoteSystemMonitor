using System.Windows.Forms;

namespace SystemMonitorServer.src.window
{
    class WindowStarter
    {

        public static void Start()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new InsaneHardwareMonitorWindow());
        }

    }
}
