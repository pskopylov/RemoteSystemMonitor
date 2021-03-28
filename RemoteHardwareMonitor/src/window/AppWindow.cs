using RemoteHardwareMonitor.Src.AppConfig;
using RemoteHardwareMonitor.Src.Server;
using System;
using System.Drawing;
using System.Windows.Forms;
using ZXing;
using ZXing.QrCode;

namespace RemoteHardwareMonitor.Src.window
{
    public partial class RemoteHardwareMonitorWindow : Form
    {

        private Color hoverColor = Color.FromArgb(209, 209, 209);

        Point offset;
        bool isTopPanelDragged = false; 

        public RemoteHardwareMonitorWindow()
        {
            InitializeComponent();
        }

        private void RemoteHardwareMonitorWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                CloseApplication(e);
            } 
        }

        private void RemoteHardwareMonitorWindow_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                Hide();
                NotifyIcon.Visible = true;
                NotifyIcon.ShowBalloonTip(500);
            }
        }

        private void NotifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
            NotifyIcon.Visible = false;
        }

        private void CloseToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void RemoteHardwareMonitorWindow_Load(object sender, EventArgs e)
        {
            string ip = IPAdressManager.GetLocalIPAddress();
            string port = ConfigLoader.LoadConfig().Port;

            var writer = new BarcodeWriter
            {
                Format = BarcodeFormat.QR_CODE,
                Options = new QrCodeEncodingOptions
                {
                    Width = 120,
                    Height = 120,
                    Margin = 0
                }
            };

            Bitmap qrCode = writer.Write($"http://{ip}:{port}/");
            QRCodeBox.Image = qrCode;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            CloseApplication();
        }

        private void TrayButton_Click(object sender, EventArgs e)
        {
            Hide();
            NotifyIcon.Visible = true;
            NotifyIcon.ShowBalloonTip(500);
        }

        private void TrayButton_MouseHover(object sender, EventArgs e)
        {
            TrayButton.BackColor = hoverColor;
        }

        private void TrayButton_MouseLeave(object sender, EventArgs e)
        {
            TrayButton.BackColor = Color.Transparent;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TrayButton.BackColor = hoverColor;
        }

        private void TopPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isTopPanelDragged = true;
                Point pointStartPosition = this.PointToScreen(new Point(e.X, e.Y));
                offset = new Point
                {
                    X = Location.X - pointStartPosition.X,
                    Y = Location.Y - pointStartPosition.Y
                };
            }
            else
            {
                isTopPanelDragged = false;
            }
        }

        private void TopPanel_MouseUp(object sender, MouseEventArgs e)
        {
            isTopPanelDragged = false;
        }

        private void TopPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (isTopPanelDragged)
            {
                Point newPoint = TopPanel.PointToScreen(new Point(e.X, e.Y));
                newPoint.Offset(offset);
                this.Location = newPoint;
            }
        }

        private void TrayButton_MouseEnter(object sender, EventArgs e)
        {
            TrayButton.BackColor = hoverColor;
        }
    }
}
