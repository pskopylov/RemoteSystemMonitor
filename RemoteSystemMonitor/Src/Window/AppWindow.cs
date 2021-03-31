using RemoteSystemMonitor.Src.Start;
using RemoteSystemMonitor.Src.Window.QRCode;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace RemoteSystemMonitor.Src.Window
{
    public partial class RemoteSystemMonitorForm : Form
    {

        private readonly Color buttonHoverColor = Color.FromArgb(209, 209, 209);
        private readonly Color buttonBaseColor = Color.Transparent;
        private readonly string NotifyMessage = "Are you sure you want to close Remote System Monitor?";
        private readonly string NotifyCaption = "Remote System Monitor";

        Point offset;
        bool isTopPanelDragged = false;
        private readonly StartType startType;

        public RemoteSystemMonitorForm(StartType startType)
        {
            this.startType = startType;
            InitializeComponent();
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

        public bool CloseConfirmation()
        {
            var result = MessageBox.Show(NotifyMessage, NotifyCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            return result == DialogResult.Yes;
        }

        private void RemoteSystemMonitorForm_Load(object sender, EventArgs e)
        {
            Bitmap qrCode = QRCodeManager.Create();
            QRCodeBox.Image = qrCode;
            if (startType == StartType.Auto)
            {
                HideOnStart();
            }
            
        }

        private void HideOnStart()
        {
            NotifyIcon.Visible = true;
            ShowInTaskbar = false;
            Hide();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            CloseApplication();
        }

        private void CloseButton_MouseEnter(object sender, EventArgs e)
        {
            CloseButton.BackColor = buttonHoverColor;
        }

        private void CloseButton_MouseLeave(object sender, EventArgs e)
        {
            CloseButton.BackColor = buttonBaseColor;
        }

        private void TrayButton_Click(object sender, EventArgs e)
        {
            Hide();
            NotifyIcon.Visible = true;
            NotifyIcon.ShowBalloonTip(500);
        }

        private void TrayButton_MouseEnter(object sender, EventArgs e)
        {
            TrayButton.BackColor = buttonHoverColor;
        }

        private void TrayButton_MouseLeave(object sender, EventArgs e)
        {
            TrayButton.BackColor = buttonBaseColor;
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
    }
}
