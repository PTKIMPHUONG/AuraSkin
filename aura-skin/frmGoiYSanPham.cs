using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aura_skin
{
    public partial class frmGoiYSanPham : Form
    {
        public frmGoiYSanPham()
        {
            InitializeComponent();
            this.StartPosition=FormStartPosition.CenterScreen;
        }

        private void btnChonKhachHang_Click(object sender, EventArgs e)
        {
            frm_Customer frmCustomer=new frm_Customer();
            frmCustomer.Show();
        }
    }
}
