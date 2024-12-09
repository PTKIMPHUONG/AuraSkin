using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PanelThongKeControl
{
    public partial class PanelThongKe: UserControl
    {
        public PanelThongKe()
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

        private void gradientPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gradientPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gradientPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gradientPanel3_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void PanelThongKe_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dtgDsSP_Click(object sender, EventArgs e)
        {

        }
    }
}
