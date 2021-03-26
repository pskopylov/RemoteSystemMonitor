using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemMonitorServer.src.window
{
    public partial class InsaneHardwareMonitorWindow : Form
    {
        public InsaneHardwareMonitorWindow()
        {
            InitializeComponent();
        }

        private void InsaneHardwareMonitorWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                FastClose();
            } 
        }

        private void InsaneHardwareMonitorWindow_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                Hide();
                notifyIcon.Visible = true;
                notifyIcon.ShowBalloonTip(1500);
            }
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            notifyIcon.Visible = false;
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FastClose();
        }

        private void FastClose()
        {
            Application.Exit();
        }
    }
}
