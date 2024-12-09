using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RoundedBorderControl;
using System.Runtime.InteropServices;
using Syncfusion.Drawing;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using aura_skin.BUS;
using aura_skin.DAO;
using System.Diagnostics.Eventing.Reader;

namespace aura_skin
{
    public partial class frm_Login : RoundedBorderForm
    {
        public frm_Login()
        {
            InitializeComponent();

            // Thiết lập các thuộc tính bo góc, viền, và màu gradient theo ý muốn
            //this.BorderRadius = 30;
            //this.BorderSize = 3;
            //this.BorderColor = Color.DarkSlateBlue;
            //this.GradientColor1 = Color.Coral;
            //this.GradientColor2 = Color.CadetBlue;
            //this.GradientMode = LinearGradientMode.Horizontal;

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
            frm_Register registerForm= new frm_Register();
            registerForm.ShowDialog();
            this.Close();            
        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            if(CheckUsernameAndPass(txt_tenDangNhap.Text.Trim(), txt_password.Text))
            {
                this.Hide();
                frm_Main mainForm = new frm_Main();
                mainForm.Username = txt_tenDangNhap.Text.Trim();
                mainForm.ShowDialog();
                this.Close();
            }
        }
        
        private bool CheckUsernameAndPass(string username, string password)
        {
            UsersBUS usersBUS = new UsersBUS();
            foreach (User item in usersBUS.users)
            {
                if (item.username == username && item.password == password)
                    return true;
            }
            return false;
        }

        private void lblQuenMatKhau_Click(object sender, EventArgs e)
        {
            frm_QuenMatKhau frmQuenMatKhau=new frm_QuenMatKhau();
            frmQuenMatKhau.ShowDialog();
        }

        private void lblDoiMatKhau_Click(object sender, EventArgs e)
        {
            frm_DoiMatKhau frmDoiMatKhau = new frm_DoiMatKhau();
            frmDoiMatKhau.ShowDialog();
        }
    }
}
