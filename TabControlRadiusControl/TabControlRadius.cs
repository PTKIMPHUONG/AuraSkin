using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using System.Drawing.Drawing2D;

namespace TabControlRadiusControl
{
    public partial class TabControlRadius: TabControlAdv
    {
        private int cornerRadius = 15;
        private Color borderColor = Color.Gray;

        [Category("Appearance")]
        [Description("Sets the radius for the rounded corners.")]
        public int CornerRadius
        {
            get { return cornerRadius; }
            set
            {
                cornerRadius = value;
                this.Invalidate(); // Redraw when the corner radius changes
            }
        }

        [Category("Appearance")]
        [Description("Sets the border color for the tab control.")]
        public Color BorderColor
        {
            get { return borderColor; }
            set
            {
                borderColor = value;
                this.Invalidate(); // Redraw when the border color changes
            }
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            // Vẽ nền với bo góc cho toàn bộ TabControlAdv
            GraphicsPath path = new GraphicsPath();
            Rectangle rect = this.ClientRectangle;

            path.AddArc(rect.X, rect.Y, cornerRadius, cornerRadius, 180, 90);
            path.AddArc(rect.Right - cornerRadius, rect.Y, cornerRadius, cornerRadius, 270, 90);
            path.AddArc(rect.Right - cornerRadius, rect.Bottom - cornerRadius, cornerRadius, cornerRadius, 0, 90);
            path.AddArc(rect.X, rect.Bottom - cornerRadius, cornerRadius, cornerRadius, 90, 90);
            path.CloseFigure();

            // Vẽ nền cho TabControlAdv
            using (Brush brush = new SolidBrush(this.BackColor))
            {
                e.Graphics.FillPath(brush, path);
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // Vẽ viền bo góc cho TabControl
            using (GraphicsPath path = new GraphicsPath())
            {
                Rectangle rect = this.ClientRectangle;

                path.AddArc(rect.X, rect.Y, cornerRadius, cornerRadius, 180, 90);
                path.AddArc(rect.Right - cornerRadius, rect.Y, cornerRadius, cornerRadius, 270, 90);
                path.AddArc(rect.Right - cornerRadius, rect.Bottom - cornerRadius, cornerRadius, cornerRadius, 0, 90);
                path.AddArc(rect.X, rect.Bottom - cornerRadius, cornerRadius, cornerRadius, 90, 90);
                path.CloseFigure();

                using (Pen pen = new Pen(borderColor, 2))
                {
                    e.Graphics.DrawPath(pen, path);
                }
            }
        }
    }
}
