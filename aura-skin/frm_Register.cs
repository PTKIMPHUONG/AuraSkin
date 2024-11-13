using RoundedBorderControl;
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
    public partial class frm_Register : RoundedBorderForm
    {
        public frm_Register()
        {
            InitializeComponent();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void chk_HienThiPass_CheckStateChanged(object sender, EventArgs e)
        {
            if (chk_HienThiPass.Checked)
            {
                txt_password.PasswordChar = '\0'; // Hiển thị mật khẩu
            }
            else
            {
                txt_password.PasswordChar = '*'; // Ẩn mật khẩu
            }
        }

        private void lbl_DangKyForm_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_Login loginForm = new frm_Login();
            loginForm.ShowDialog();
            this.Close();
        }
    }
}
