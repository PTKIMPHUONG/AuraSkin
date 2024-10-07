using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UCButtonMenu;
using PanelBanHang;
using PanelKhuyenMai;
using PanelNhanVien;
using PanelKhachHang;

namespace AuraSkinGUI
{
    public partial class MainForm : Form
    {
        public string Username;
        string[] getSt = { "Bán hàng", "Khuyến mãi", "Sản phẩm","Nhân viên","Khách hàng","Nhà cung cấp"};

        // Khai báo UserControl cho các chức năng
        private BanHang ucBanHang;
        private KhuyenMai ucKhuyenMai;
        private NhanVien ucNhanVien;
        private KhachHang ucKhachHang;
        public MainForm()
        {
            InitializeComponent();
            
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeUserControls();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            inits();
        }
        private void inits()
        {
            Label lblUsername=new Label();
            lblUsername.Text ="Xin chào "+ Username;
            lblUsername.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
            lblUsername.ForeColor = Color.Black;
            //lblUsername.Size = new Size(this.Width, 50); // Set fixed size for Label
            lblUsername.TextAlign = ContentAlignment.MiddleCenter;
            lblUsername.AutoSize = false; // Disable AutoSize to manually control size
            lblUsername.Location = new Point(
                (pnInfoUser.Width-lblUsername.Width)/2, // Center horizontally
                (pnInfoUser.Height - lblUsername.Height) / 2 // Center vertically
            );
            this.Controls.Add(lblUsername);
            pnInfoUser.Controls.Add(lblUsername);



            int startBtnMenu = pnInfoUser.Height + pnInfoUser.Location.Y + 6;
            for (int i = 0; i < getSt.Length; i++)
            {
                ButtonMenu btnMenu = new ButtonMenu();
                btnMenu.Content = getSt[i];
                btnMenu.Width = pnInfoUser.Width;
                btnMenu.Height = 84;

                // Set vị trí nút
                btnMenu.Location = new Point(pnInfoUser.Location.X, startBtnMenu);

                // Tăng giá trị Y để nút tiếp theo nằm dưới nút trước
                startBtnMenu += btnMenu.Height + 6;
                btnMenu.ButtonMenuClicked += BtnMenu_ButtonMenuClicked;
                this.Controls.Add(btnMenu);
            }

        }
        private void InitializeUserControls()
        {
            // Khởi tạo các UserControl
            ucBanHang = new BanHang();
            ucKhuyenMai = new KhuyenMai();
            ucNhanVien = new NhanVien();
            ucKhachHang = new KhachHang();
        }

        private void BtnMenu_ButtonMenuClicked(object sender, EventArgs e)
        {
            ButtonMenu clickedButton = sender as ButtonMenu;

            pnContent.Controls.Clear();

            // Hiển thị panel tương ứng với nội dung nút
            switch (clickedButton.Content)
            {
                case "Bán hàng":
                    pnContent.Controls.Add(ucBanHang);
                    break;
                case "Khuyến mãi":
                    pnContent.Controls.Add(ucKhuyenMai);
                    break;
                case "Nhân viên":
                    pnContent.Controls.Add(ucNhanVien);
                    break;
                case "Khách hàng":
                    pnContent.Controls.Add(ucKhachHang);
                    break;
                default:
                    break;
            }
        }

        private void panelKhachHang_Load(object sender, EventArgs e)
        {

        }
    }
}
