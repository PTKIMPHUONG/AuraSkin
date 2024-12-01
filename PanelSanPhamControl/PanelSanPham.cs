using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PanelSanPhamControl
{
    public partial class PanelSanPham: UserControl
    {
        public PanelSanPham()
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

        private void PanelSanPham_Load(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }
    }
}
