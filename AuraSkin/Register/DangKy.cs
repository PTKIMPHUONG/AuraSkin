using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Register
{
    public partial class DangKy: UserControl
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


        public delegate void DangNhapClickedhandler(object sender, EventArgs e);
        public event DangNhapClickedhandler DangNhapClicked;
        protected virtual void OnDangNhapClicked(object sender, EventArgs e)
        {
            if (DangNhapClicked != null)
            {
                DangNhapClicked(sender, e);
            }
        }
        public string UserName
        {
            get { return txtUsername.Text; }
            set { txtUsername.Text = value; }
        }
        public string Email
        {
            get { return txtEmail.Text; }
            set { txtEmail.Text = value; }
        }
        public string Password
        {
            get { return txtPassword.Text; }
            set { txtPassword.Text = value; }
        }
        public DangKy()
        {
            InitializeComponent();
        }

        private void lblPassword_Click(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            // Kiểm tra đã nhập user name chưa
            if (txtUsername.Text.Length == 0)
            {
                MessageBox.Show("Hãy nhập tên đăng nhập!"); return;
            }
            if (txtEmail.Text.Length == 0)
            {
                MessageBox.Show("Hãy nhập email!"); return;
            }
            // Kiểm tra đã nhập password chưa
            if (txtPassword.Text.Length == 0)
            {
                MessageBox.Show("Hãy nhập Password!"); return;
            }

            /* Tạo sự kiện Click để gọi hàm xử lý sự kiện Click do người dùng nhập trình ứng dụng viết*/
            OnSubmitClicked(sender, e);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            OnDangNhapClicked(sender, e);
        }
    }
}
