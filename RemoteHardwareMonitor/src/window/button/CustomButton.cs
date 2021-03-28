using System;
using System.Drawing;
using System.Windows.Forms;

namespace InsaneHardwareMonitor.src.window.button
{
    class CustomButton : Button
    {
        private Color color = Color.FromArgb(249, 249, 249);
        private Color baseColor = Color.FromArgb(249, 249, 249);
        private Color hovercolor = Color.FromArgb(209, 209, 209);
        private int textX = 0;
        private int textY = 0;
        private string text = "\u2715";

        public string DisplayText
        {
            get { return text; }
            set { text = value; Invalidate(); }
        }
        public Color CustomBackColor
        {
            get { return color; }
            set { color = value; Invalidate(); }
        }

        public Color MouseHoverColor
        {
            get { return hovercolor; }
            set { hovercolor = value; Invalidate(); }
        }

        public int TextLocationX
        {
            get { return textX; }
            set { textX = value; Invalidate(); }
        }

        public int TextLocationY
        {
            get { return textY; }
            set { textY = value; Invalidate(); }
        }

        public CustomButton()
        {
            Size = new Size(30, 30);
            ForeColor = Color.FromArgb(50, 50, 50);
            FlatStyle = FlatStyle.Flat;
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            color = hovercolor;
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            color = baseColor;
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);

            Point p = new Point(textX, textY);
            pe.Graphics.FillRectangle(new SolidBrush(color), ClientRectangle);
            pe.Graphics.DrawString(text, Font, new SolidBrush(ForeColor), p);
        }

    }
}
