using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UCButtonMenu
{
    public partial class ButtonMenu: Panel
    {
        // Định nghĩa delegate phục vụ cho event
        public delegate void ButtonMenuClickedHandler(object sender, EventArgs e);

        // Định nghĩa event buttonMenuClicked cho control
        public event ButtonMenuClickedHandler ButtonMenuClicked;

        // Định nghĩa hàm xử lý sự kiện SubmitClicked
        protected virtual void OnButtonMenuClicked(object sender, EventArgs e)
        {
            // Kiểm tra xem có hàm xử lý sự kiện SubmitClicked? nếu có thì gọi
            if (ButtonMenuClicked != null)
            {
                ButtonMenuClicked(sender, e); // Notify Subcribers
            }
        }

        Label lblContent = new Label();
        public ButtonMenu()
        {
            InitializeComponent();
            this.Size = new Size(200, 70);
            this.BackColor = Color.White; // Màu nền panel để dễ nhận diện
            inits();
            this.Click += new EventHandler(ButtonMenu_Click);
        }

        public string Content
        {
            get { return lblContent.Text; }
            set { lblContent.Text = value; UpdateLabelPosition(); } // Update position when content changes
        }
        private void inits()
        {
            lblContent.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
            lblContent.ForeColor = Color.Black;
            lblContent.Size = new Size(this.Width, 50); // Set fixed size for Label
            lblContent.TextAlign = ContentAlignment.MiddleCenter;
            lblContent.AutoSize = false; // Disable AutoSize to manually control size
            lblContent.Location = new Point(
                0, // Center horizontally
                (this.Height - lblContent.Height) / 2 // Center vertically
            );
            lblContent.Click += new EventHandler(ButtonMenu_Click);
            this.Controls.Add(lblContent);
        }
        // This function re-calculates label's position when content is updated
        private void UpdateLabelPosition()
        {
            lblContent.Location = new Point(
                0, // Center horizontally
                (this.Height - lblContent.Height) / 2 // Center vertically
            );
        }

        private void ButtonMenu_Click(object sender, System.EventArgs e)
        {
            OnButtonMenuClicked(this, e);
        }
    }
}
