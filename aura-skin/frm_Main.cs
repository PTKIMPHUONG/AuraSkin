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
using Syncfusion.WinForms.Controls;
using GradientButtonRadiusControl;


namespace aura_skin
{
    public partial class frm_Main : RoundedBorderForm
    {
        public string Username;
        string[] getSt = { "Bán hàng", "Khuyến mãi", "Sản phẩm" };
        string[] getSt1 = { "Nhân viên", "Khách hàng", "Nhà cung cấp", "Thống kê" };
        string[] getStLogOut = { "Đăng xuất" };
        public frm_Main()
        {
            InitializeComponent();
            // Thiết lập các thuộc tính bo góc, viền, và màu gradient theo ý muốn
            //this.BorderRadius = 30;
            //this.BorderSize = 3;
            //this.BorderColor = Color.DarkSlateBlue;
            //this.GradientColor1 = Color.Coral;
            //this.GradientColor2 = Color.CadetBlue;
            //this.GradientMode = LinearGradientMode.Horizontal;
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void frm_Main_Load(object sender, EventArgs e)
        {
            inits();
        }

        //Hover chuột ra ngoài sẽ hiển thị màu 64,64,64
        private void Btn_Exit_MouseLeave(object sender, EventArgs e)
        {
            btn_Exit.ForeColor = Color.FromArgb(64, 64, 64);
        }


        //Hover chuột vào sẽ hiển thị màu đen
        private void Btn_Exit_MouseEnter(object sender, EventArgs e)
        {
            btn_Exit.ForeColor = System.Drawing.Color.Black;
        }

        private void adjustSideBar()
        {
            pnl_sidebar.Radius = 20;
            //pnl_sidebar.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.SlateBlue, System.Drawing.Color.DodgerBlue);
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void inits()
        {
            #region Chỉnh hover đối với button Exit
            btn_Exit.MouseEnter += Btn_Exit_MouseEnter;
            btn_Exit.MouseLeave += Btn_Exit_MouseLeave;
            #endregion

            //Cấu hình SideBar
            adjustSideBar();

            #region Info user
            Label lblUsername = new Label();
            lblUsername.Text = "Xin chào " + Username;
            lblUsername.Font = new Font("Microsoft Sans Serif", 15, FontStyle.Regular);
            lblUsername.ForeColor = Color.Black;
            lblUsername.TextAlign = ContentAlignment.MiddleCenter;

            // Đảm bảo label lấp đầy panel và văn bản căn giữa
            lblUsername.AutoSize = false;
            lblUsername.Dock = DockStyle.Fill;

            //lblUsername.Location = new Point(
            //    (pnl_UserInfo.Width - lblUsername.Width) / 2, // Center horizontally
            //    (pnl_UserInfo.Height - lblUsername.Height) / 2 // Center vertically
            //);
            this.Controls.Add(lblUsername);
            pnl_UserInfo.Controls.Add(lblUsername);
            #endregion

            int startBtnMenu = pnl_UserInfo.Height + pnl_UserInfo.Location.Y + 13;
            for (int i = 0; i < getSt.Length; i++)
            {
                GradientRadiusButton btnMenu = new GradientRadiusButton();
                btnMenu.Text = getSt[i];
                btnMenu.Width = 317;
                btnMenu.Height = 95;

                // Set vị trí nút
                btnMenu.Location = new Point(11, startBtnMenu);


                btnMenu.Font = new System.Drawing.Font("Segoe UI Semibold", 14F);
                btnMenu.CornerRadius = 10;
                btnMenu.BorderColor = System.Drawing.Color.Transparent;
                btnMenu.GradientColor1 = System.Drawing.Color.CornflowerBlue;
                btnMenu.GradientColor2 = System.Drawing.Color.RoyalBlue;
                btnMenu.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;

                // Tăng giá trị Y để nút tiếp theo nằm dưới nút trước
                startBtnMenu += btnMenu.Height + 6;
                if (btnMenu.Text == "Đăng xuất")
                    btnMenu.Click += buttonMenuLogOut_Click;
                else
                    btnMenu.Click += BtnMenu_ButtonMenuClicked;
                pnl_sidebar.Controls.Add(btnMenu);
            }
        }

        private void BtnMenu_ButtonMenuClicked(object sender, EventArgs e)
        {
            GradientRadiusButton clickedButton = sender as GradientRadiusButton;

            pnl_main.Controls.Clear();

            // Hiển thị panel tương ứng với nội dung nút
            switch (clickedButton.Text)
            {
                case "Bán hàng":
                    //pnContent.Controls.Add(ucBanHang);
                    break;
                case "Khuyến mãi":
                    //pnContent.Controls.Add(ucKhuyenMai);
                    break;
                case "Sản phẩm":
                    //pnContent.Controls.Add(ucSanPham);
                    break;
                case "Nhân viên":
                    //pnContent.Controls.Add(ucNhanVien);
                    break;
                case "Khách hàng":
                    //pnContent.Controls.Add(ucKhachHang);
                    break;
                case "Nhà cung cấp":
                    //pnContent.Controls.Add(ucNhaCungCap);
                    break;
                case "Thống kê":
                    break;
                case "Đăng xuất":
                    break;
                default:
                    break;
            };
        }

        //LogOut Click
        private void buttonMenuLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_Login loginForm = new frm_Login();
            loginForm.ShowDialog();
            this.Close();
        }

    }
}
