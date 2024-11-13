using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;

namespace RoundedBorderControl
{
    public partial class RoundedBorderForm: Form
    {
        private int borderRadius = 20;
        private int borderSize = 2;
        private Color borderColor = Color.FromArgb(128, 128, 255);
        private Color gradientColor1 = Color.LightBlue;
        private Color gradientColor2 = Color.MediumPurple;
        private LinearGradientMode gradientMode = LinearGradientMode.Vertical;

        public RoundedBorderForm()
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.Padding = new Padding(borderSize);

            // Bật việc vẽ tùy chỉnh và double buffering
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.DoubleBuffer | ControlStyles.UserPaint, true);
            this.UpdateStyles();

            // Thiết lập màu nền cho form là màu Fuchsia (một màu không hiển thị)
            //this.BackColor = Color.Fuchsia; // Fuchsia thường được sử dụng vì đây là màu không hiển thị
            //this.TransparencyKey = Color.Fuchsia; // Thiết lập TransparencyKey cho màu tương ứng với BackColor
        }

        // Thuộc tính công khai để có thể thiết lập từ bên ngoài
        public int BorderRadius
        {
            get => borderRadius;
            set { borderRadius = value; this.Invalidate(); }
        }

        public int BorderSize
        {
            get => borderSize;
            set { borderSize = value; this.Padding = new Padding(borderSize); this.Invalidate(); }
        }

        public Color BorderColor
        {
            get => borderColor;
            set { borderColor = value; this.Invalidate(); }
        }

        public Color GradientColor1
        {
            get => gradientColor1;
            set { gradientColor1 = value; this.Invalidate(); }
        }

        public Color GradientColor2
        {
            get => gradientColor2;
            set { gradientColor2 = value; this.Invalidate(); }
        }

        public LinearGradientMode GradientMode
        {
            get => gradientMode;
            set { gradientMode = value; this.Invalidate(); }
        }

        // API để kéo form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            // Tạo gradient background
            using (LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle, gradientColor1, gradientColor2, gradientMode))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }

            // Vẽ bo góc và border
            FormRegionAndBorder(this, borderRadius, e.Graphics, borderColor, borderSize);
        }

        private GraphicsPath GetRoundedPath(Rectangle rect, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            float curveSize = radius * 2F;
            path.StartFigure();
            path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
            path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
            path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
            path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
            path.CloseFigure();
            return path;
        }

        private void FormRegionAndBorder(Form form, float radius, Graphics graph, Color borderColor, float borderSize)
        {
            if (this.WindowState != FormWindowState.Minimized)
            {
                using (GraphicsPath roundPath = GetRoundedPath(form.ClientRectangle, radius))
                using (Pen penBorder = new Pen(borderColor, borderSize))
                {
                    graph.SmoothingMode = SmoothingMode.AntiAlias;
                    form.Region = new Region(roundPath);
                    if (borderSize >= 1)
                    {
                        Rectangle rect = form.ClientRectangle;
                        float scaleX = 1.0F - ((borderSize + 1) / rect.Width);
                        float scaleY = 1.0F - ((borderSize + 1) / rect.Height);
                        graph.Transform = new Matrix(scaleX, 0, 0, scaleY, borderSize / 1.6F, borderSize / 1.6F);
                        graph.DrawPath(penBorder, roundPath);
                    }
                }
            }
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
