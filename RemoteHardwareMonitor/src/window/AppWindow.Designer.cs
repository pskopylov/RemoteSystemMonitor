
namespace RemoteHardwareMonitor.Src.window
{
    partial class RemoteHardwareMonitorWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private global::System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new global::System.ComponentModel.Container();
            global::System.ComponentModel.ComponentResourceManager resources = new global::System.ComponentModel.ComponentResourceManager(typeof(RemoteHardwareMonitorWindow));
            this.NotifyIcon = new global::System.Windows.Forms.NotifyIcon(this.components);
            this.TrayMenuStrip = new global::System.Windows.Forms.ContextMenuStrip(this.components);
            this.closeToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
            this.QRCodeBox = new global::System.Windows.Forms.PictureBox();
            this.TopPanel = new global::System.Windows.Forms.Panel();
            this.CloseButton = new RemoteHardwareMonitor.Src.window.button.CustomButton();
            this.TrayButton = new RemoteHardwareMonitor.Src.window.button.CustomButton();
            this.TrayMenuStrip.SuspendLayout();
            ((global::System.ComponentModel.ISupportInitialize)(this.QRCodeBox)).BeginInit();
            this.TopPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // NotifyIcon
            // 
            this.NotifyIcon.BalloonTipText = "You can update system info on your device";
            this.NotifyIcon.BalloonTipTitle = "Insane Hardware Monitor server is running";
            this.NotifyIcon.ContextMenuStrip = this.TrayMenuStrip;
            this.NotifyIcon.Icon = ((global::System.Drawing.Icon)(resources.GetObject("NotifyIcon.Icon")));
            this.NotifyIcon.Text = "Insane Hardware Monitor";
            this.NotifyIcon.MouseDoubleClick += new global::System.Windows.Forms.MouseEventHandler(this.NotifyIcon_MouseDoubleClick);
            // 
            // TrayMenuStrip
            // 
            this.TrayMenuStrip.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem});
            this.TrayMenuStrip.Name = "contextMenuStrip";
            this.TrayMenuStrip.Size = new global::System.Drawing.Size(104, 26);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new global::System.Drawing.Size(103, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new global::System.EventHandler(this.CloseToolStripMenuItem_Click);
            // 
            // QRCodeBox
            // 
            this.QRCodeBox.BackColor = global::System.Drawing.Color.White;
            this.QRCodeBox.Location = new global::System.Drawing.Point(138, 277);
            this.QRCodeBox.Name = "QRCodeBox";
            this.QRCodeBox.Size = new global::System.Drawing.Size(124, 124);
            this.QRCodeBox.TabIndex = 1;
            this.QRCodeBox.TabStop = false;
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = global::System.Drawing.Color.Transparent;
            this.TopPanel.Controls.Add(this.CloseButton);
            this.TopPanel.Controls.Add(this.TrayButton);
            this.TopPanel.Location = new global::System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new global::System.Drawing.Size(400, 30);
            this.TopPanel.TabIndex = 4;
            this.TopPanel.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseDown);
            this.TopPanel.MouseMove += new global::System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseMove);
            this.TopPanel.MouseUp += new global::System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseUp);
            // 
            // CloseButton
            // 
            this.CloseButton.CustomBackColor = global::System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.CloseButton.DisplayText = "✕";
            this.CloseButton.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.CloseButton.ForeColor = global::System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.CloseButton.Location = new global::System.Drawing.Point(370, 0);
            this.CloseButton.MouseHoverColor = global::System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new global::System.Drawing.Size(30, 30);
            this.CloseButton.TabIndex = 5;
            this.CloseButton.Text = "customButton1";
            this.CloseButton.TextLocationX = 2;
            this.CloseButton.TextLocationY = 5;
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new global::System.EventHandler(this.CloseButton_Click);
            // 
            // TrayButton
            // 
            this.TrayButton.CustomBackColor = global::System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.TrayButton.DisplayText = "–";
            this.TrayButton.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
            this.TrayButton.Font = new global::System.Drawing.Font("Roboto Medium", 18F, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TrayButton.ForeColor = global::System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.TrayButton.Location = new global::System.Drawing.Point(340, 0);
            this.TrayButton.MouseHoverColor = global::System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.TrayButton.Name = "TrayButton";
            this.TrayButton.Size = new global::System.Drawing.Size(30, 30);
            this.TrayButton.TabIndex = 6;
            this.TrayButton.Text = "–";
            this.TrayButton.TextLocationX = 3;
            this.TrayButton.TextLocationY = 1;
            this.TrayButton.UseVisualStyleBackColor = true;
            this.TrayButton.Click += new global::System.EventHandler(this.TrayButton_Click);
            // 
            // RemoteHardwareMonitorWindow
            // 
            this.AutoScaleDimensions = new global::System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::System.Drawing.Color.Black;
            this.BackgroundImage = ((global::System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new global::System.Drawing.Size(400, 590);
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.QRCodeBox);
            this.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((global::System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RemoteHardwareMonitorWindow";
            this.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Remote Hardware Monitor";
            this.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.RemoteHardwareMonitorWindow_FormClosing);
            this.Load += new global::System.EventHandler(this.RemoteHardwareMonitorWindow_Load);
            this.Resize += new global::System.EventHandler(this.RemoteHardwareMonitorWindow_Resize);
            this.TrayMenuStrip.ResumeLayout(false);
            ((global::System.ComponentModel.ISupportInitialize)(this.QRCodeBox)).EndInit();
            this.TopPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private global::System.Windows.Forms.NotifyIcon NotifyIcon;
        private global::System.Windows.Forms.ContextMenuStrip TrayMenuStrip;
        private global::System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private global::System.Windows.Forms.PictureBox QRCodeBox;
        private global::System.Windows.Forms.Panel TopPanel;
        private button.CustomButton TrayButton;
        private button.CustomButton CloseButton;
    }
}