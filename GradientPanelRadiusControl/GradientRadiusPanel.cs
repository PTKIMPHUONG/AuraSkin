using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;

namespace GradientPanelRadiusControl
{
    public partial class GradientRadiusPanel : GradientPanel
    {
        private int _radius = 15;

        public GradientRadiusPanel()
        {
            InitializeComponent();
            this.Paint += GradientRadiusPanel_Paint;
            UpdateCornerRadius();
        }

        // Property for corner radius
        [Category("Appearance")]
        [Description("Gets or sets the corner radius of the panel.")]
        public int Radius
        {
            get => _radius;
            set
            {
                _radius = value;
                UpdateCornerRadius();
                this.Invalidate(); // Redraw the control
            }
        }

        // Update the corner radius of the panel
        private void UpdateCornerRadius()
        {
            var path = new GraphicsPath();
            int diameter = _radius * 2;

            path.StartFigure();
            path.AddArc(0, 0, diameter, diameter, 180, 90); // Top-left corner
            path.AddArc(this.Width - diameter, 0, diameter, diameter, 270, 90); // Top-right corner
            path.AddArc(this.Width - diameter, this.Height - diameter, diameter, diameter, 0, 90); // Bottom-right corner
            path.AddArc(0, this.Height - diameter, diameter, diameter, 90, 90); // Bottom-left corner
            path.CloseFigure();

            this.Region = new Region(path);
        }

        // Redraw the corner radius when size changes
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            UpdateCornerRadius();
        }

        private void GradientRadiusPanel_Paint(object sender, PaintEventArgs e)
        {
            UpdateCornerRadius();
        }
    }
}
