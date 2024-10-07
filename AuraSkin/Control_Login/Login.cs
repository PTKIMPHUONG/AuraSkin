using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Control_Login
{
    public partial class Login: UserControl
    {
        // Định nghĩa delegate phục vụ cho event
        public delegate void SubmitClickedHandler(object sender, EventArgs e);

        // Định nghĩa event SubmitClicked cho control
        public event SubmitClickedHandler SubmitClicked;

        // Định nghĩa hàm xử lý sự kiện SubmitClicked
        protected virtual void OnSubmitClicked(object sender, EventArgs e)
        {
            // Kiểm tra xem có hàm xử lý sự kiện SubmitClicked? nếu có thì gọi
            if (SubmitClicked != null)
            {
                SubmitClicked(sender, e); // Notify Subcribers
            }
        }

        public delegate void DangKyClickedhandler(object sender, EventArgs e);
        public event DangKyClickedhandler DangKyClicked;
        protected virtual void OnDangKyClicked(object sender, EventArgs e)
        {
            if(DangKyClicked != null)
            {
                DangKyClicked(sender, e);
            }    
        }
        public Login()
        {
            InitializeComponent();
            
        }
        public string UserName
        {
            get { return txtUsername.Text; }
            set { txtUsername.Text = value; }
        }
        public string Password
        {
            get { return txtPassword.Text; }
            set { txtPassword.Text = value; }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OnDangKyClicked(sender, e);
        }

        private void rdoHienThiMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoHienThiMatKhau.Checked)
                txtPassword.PasswordChar = (char)0;
            else
                txtPassword.PasswordChar = '*';
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            // Kiểm tra đã nhập user name chưa
            if (txtUsername.Text.Length == 0)
            {
                MessageBox.Show("Hãy nhập tên đăng nhập!"); return;
            }
            // Kiểm tra đã nhập password chưa
            if (txtPassword.Text.Length == 0)
            {
                MessageBox.Show("Hãy nhập Password!"); return;
            }

            /* Tạo sự kiện Click để gọi hàm xử lý sự kiện Click do người dùng nhập trình ứng dụng viết*/
            OnSubmitClicked(sender, e);
        }
    }
}
