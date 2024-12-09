using aura_skin.BUS;
using QuenMatKhauControl;
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
    public partial class frm_DoiMatKhau : Form
    {
        UsersBUS usersBUS = new UsersBUS();
        public frm_DoiMatKhau()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            doiMatKhauPanel1.ControlsDictionary["btnDoiMatKhau"].Click += btnDoiMatKhau_Click;
        }
        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            var btnReset = sender as Button;
            string uesrname = doiMatKhauPanel1.ControlsDictionary["txtUsername"].Text.Trim();
            string oldPass = doiMatKhauPanel1.ControlsDictionary["txtOldPass"].Text;
            string newPass = doiMatKhauPanel1.ControlsDictionary["txtNewPass"].Text;
            var user = usersBUS.GetUserByUsername(uesrname);
            if (user != null)
            {
                if (user.password == oldPass)
                {
                    if (usersBUS.UpdatePassword(user.id_user,newPass))
                        MessageBox.Show("Đã cập nhật mật khẩu thành công");
                    else
                        MessageBox.Show("Cập nhật mật khẩu thất bại!");
                }
                else
                    MessageBox.Show("Mật khẩu không chính xác");
            }
            else
                MessageBox.Show("Username không tồn tại");

            this.Close();
        }
    }
    
}
