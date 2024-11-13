using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using Syncfusion.WinForms.Controls;

namespace GradientButtonRadiusControl
{
    public partial class GradientRadiusButton : SfButton
    {
        // Các thuộc tính công khai để thiết lập từ form khác
        private int _cornerRadius = 5;
        public int CornerRadius
        {
            get { return _cornerRadius; }
            set
            {
                _cornerRadius = value;
                this.Invalidate(); // Gọi lại Paint để cập nhật UI khi giá trị thay đổi
            }
        }

        private Color _gradientColor1 = Color.Green;
        public Color GradientColor1
        {
            get { return _gradientColor1; }
            set
            {
                _gradientColor1 = value;
                this.Invalidate();
            }
        }

        private Color _gradientColor2 = Color.Yellow;
        public Color GradientColor2
        {
            get { return _gradientColor2; }
            set
            {
                _gradientColor2 = value;
                this.Invalidate();
            }
        }

        private LinearGradientMode _gradientMode = LinearGradientMode.ForwardDiagonal;
        public LinearGradientMode GradientMode
        {
            get { return _gradientMode; }
            set
            {
                _gradientMode = value;
                this.Invalidate();
            }
        }

        // Thêm thuộc tính BorderColor để tùy chỉnh màu viền
        private Color _borderColor = Color.Red;
        public Color BorderColor
        {
            get { return _borderColor; }
            set
            {
                _borderColor = value;
                this.Invalidate();
            }
        }

        public GradientRadiusButton()
        {
            InitializeComponent();
            this.Paint += sfButton1_Paint;
        }

        private void sfButton1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            // Thiết lập hình chữ nhật với góc bo tròn
            Rectangle rect = new Rectangle(this.ClientRectangle.X + 1,
                                           this.ClientRectangle.Y + 1,
                                           this.ClientRectangle.Width - 2,
                                           this.ClientRectangle.Height - 2);
            this.Region = new Region(GetRoundedRect(rect, _cornerRadius));

            // Vẽ nền gradient với các giá trị từ thuộc tính
            using (LinearGradientBrush brush = new LinearGradientBrush(rect, _gradientColor1, _gradientColor2, _gradientMode))
            {
                e.Graphics.FillRectangle(brush, rect);
            }

            // Vẽ viền ngoài với màu và góc bo tròn tùy chỉnh
            using (Pen borderPen = new Pen(_borderColor))
            {
                e.Graphics.DrawPath(borderPen, GetRoundedRect(rect, _cornerRadius));
            }

            // Vẽ văn bản của nút
            using (SolidBrush textBrush = new SolidBrush(this.ForeColor))
            {
                StringFormat stringFormat = new StringFormat
                {
                    Alignment = StringAlignment.Center,
                    LineAlignment = StringAlignment.Center
                };
                e.Graphics.DrawString(this.Text, this.Font, textBrush, rect, stringFormat);
            }
        }

        private GraphicsPath GetRoundedRect(Rectangle bounds, int radius)
        {
            int diameter = radius * 2;
            Size size = new Size(diameter, diameter);
            Rectangle arc = new Rectangle(bounds.Location, size);
            GraphicsPath path = new GraphicsPath();

            if (radius == 0)
            {
                path.AddRectangle(bounds);
                return path;
            }

            // top left arc  
            path.AddArc(arc, 180, 90);
            // top right arc  
            arc.X = bounds.Right - diameter;
            path.AddArc(arc, 270, 90);
            // bottom right arc  
            arc.Y = bounds.Bottom - diameter;
            path.AddArc(arc, 0, 90);
            // bottom left arc 
            arc.X = bounds.Left;
            path.AddArc(arc, 90, 90);
            path.CloseFigure();
            return path;
        }
    }
}
