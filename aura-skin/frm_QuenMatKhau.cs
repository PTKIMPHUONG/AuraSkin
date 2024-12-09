using aura_skin.BUS;
using PanelSupplierControl;
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
    public partial class frm_QuenMatKhau : Form
    {
        UsersBUS usersBUS=new UsersBUS();
        public frm_QuenMatKhau()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            quenMatKhauPanel1.ControlsDictionary["btnResetPassword"].Click += btnRessetPasswrod_Click;
        }

        private void btnRessetPasswrod_Click(object sender, EventArgs e)
        {
            var btnReset= sender as Button;
            string uesrname = quenMatKhauPanel1.ControlsDictionary["txtUsername"].Text.Trim();
            string email = quenMatKhauPanel1.ControlsDictionary["txtEmail"].Text.Trim();
            var user = usersBUS.GetUserByUsernameAndEmail(uesrname, email);
            if (user != null)
            {
                if (usersBUS.ResetPassword(user.id_user))
                    MessageBox.Show("Đã đổi reset mật khẩu thành công");
                else
                    MessageBox.Show("Reset mật khẩu thất bại");
            }
            else
                MessageBox.Show("Không tìm thấy username hoặc email hợp lệ");

            this.Close();
        }
    }
}
