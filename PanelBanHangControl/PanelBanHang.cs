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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PanelBanHangControl
{
    public partial class PanelBanHang: UserControl
    {
            //        this.textBoxExt1.BeforeTouchSize = new System.Drawing.Size(100, 22);
            //this.textBoxExt1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            //this.textBoxExt1.CornerRadius = 5;
            //this.textBoxExt1.Location = new System.Drawing.Point(417, 251);
            //this.textBoxExt1.MinimumSize = new System.Drawing.Size(14, 10);
            //this.textBoxExt1.Name = "textBoxExt1";
            //this.textBoxExt1.Size = new System.Drawing.Size(100, 22);
            //this.textBoxExt1.TabIndex = 6;
            //this.textBoxExt1.Text = "textBoxExt1";



        public PanelBanHang()
        {
            InitializeComponent();
            InitializeControlsDictionary();
        }

        public Dictionary<string, Control> ControlsDictionary { get; private set; }
        private void InitializeControlsDictionary()
        {
            ControlsDictionary = new Dictionary<string, Control>();
            foreach (Control control in this.Controls)
            {
                ControlsDictionary[control.Name] = control;
            }
        }
        private void addControlToBanHangTab()
        {

            //Label lblUsername = new Label();
            //lblUsername.Text = "Xin chào " + Username;
            //lblUsername.Font = new Font("Microsoft Sans Serif", 15, FontStyle.Regular);
            //lblUsername.ForeColor = Color.Black;
            //lblUsername.TextAlign = ContentAlignment.MiddleCenter;

            //// Đảm bảo label lấp đầy panel và văn bản căn giữa
            //lblUsername.AutoSize = false;
            //lblUsername.Dock = DockStyle.Fill;

            ////lblUsername.Location = new Point(
            ////    (pnl_UserInfo.Width - lblUsername.Width) / 2, // Center horizontally
            ////    (pnl_UserInfo.Height - lblUsername.Height) / 2 // Center vertically
            ////);
            //this.Controls.Add(lblUsername);
            //pnl_UserInfo.Controls.Add(lblUsername);
        }
    }
}
