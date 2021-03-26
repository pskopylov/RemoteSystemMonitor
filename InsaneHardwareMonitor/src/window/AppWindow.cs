using System;
using System.Windows.Forms;

namespace InsaneHardwareMonitor.src.window
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
                CloseApplication(e);
            } 
        }

        private void InsaneHardwareMonitorWindow_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                Hide();
                notifyIcon.Visible = true;
                notifyIcon.ShowBalloonTip(500);
            }
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
            notifyIcon.Visible = false;
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseApplication();
        }

        private void CloseApplication()
        {
            if (CloseConfirmation())
            {
                Application.Exit();
            }
        }

        private void CloseApplication(FormClosingEventArgs e)
        {
            if (CloseConfirmation())
            {
                Application.Exit();
            } else
            {
                e.Cancel = true;
            }
            
        }

        public bool CloseConfirmation()
        {
            const string message = "Are you sure you want to close Insane Hardware Monitor?";
            const string caption = "Insane Hardware Monitor";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            return result == DialogResult.Yes;
        }

    }
}
