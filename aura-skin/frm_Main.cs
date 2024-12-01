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
using Syncfusion.Windows.Forms.Tools;
using PanelNhanVienControl;
using PanelSaleControl;
using PanelSupplierControl;
using PanelBanHangControl;
using PanelSanPhamControl;
using PanelCustomerControl;


namespace aura_skin
{
    public partial class frm_Main : RoundedBorderForm
    {
        public string Username;
        //string[] getSt = { "Bán hàng", "Khuyến mãi", "Sản phẩm" };
        string[] getSt = { "Bán hàng", "Khuyến mãi", "Sản phẩm", "Hóa đơn", "Nhân viên", "Khách hàng", "Nhà cung cấp", "Phiếu nhập", "Thống kê", "Đăng xuất" };
        string[] getSt1 = { "Nhân viên", "Khách hàng", "Nhà cung cấp", "Thống kê" };
        string[] getStLogOut = { "Đăng xuất" };


        #region Khai Báo Các Panel Main
        private PanelBanHang pnlBanHang;
        private PanelSanPham pnlSanPham;
        private PanelNhanVien pnlNhanVien;
        private PanelCustomer pnlCustomer;
        private PanelSale pnlSale;
        private PanelSupplier pnlSupplier;
        
        #endregion

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
            InitializeMainPanels();
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


            #region Thêm các button menu
            int startBtnMenu = pnl_UserInfo.Height + pnl_UserInfo.Location.Y - 0;
            for (int i = 0; i < getSt.Length; i++)
            {
                GradientRadiusButton btnMenu = new GradientRadiusButton();
                btnMenu.Text = getSt[i];
                btnMenu.Width = 317;
                btnMenu.Height = 65;
                btnMenu.Cursor = Cursors.Hand;

                // Set vị trí nút
                btnMenu.Location = new Point(11, startBtnMenu);


                btnMenu.Font = new System.Drawing.Font("Segoe UI Semibold", 14F);
                btnMenu.CornerRadius = 10;
                btnMenu.ForeColor = System.Drawing.Color.LemonChiffon;
                btnMenu.BorderColor = System.Drawing.Color.Transparent;
                btnMenu.GradientColor1 = System.Drawing.Color.RoyalBlue;
                btnMenu.GradientColor2 = System.Drawing.Color.Violet;
                btnMenu.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;

                //Thêm sự kiện hover vào button menu
                btnMenu.MouseEnter += BtnMenu_MouseEnter;
                btnMenu.MouseLeave += BtnMenu_MouseLeave;

                // Tăng giá trị Y để nút tiếp theo nằm dưới nút trước
                startBtnMenu += btnMenu.Height + 7;
                if (btnMenu.Text == "Đăng xuất")
                    btnMenu.Click += buttonMenuLogOut_Click;
                else
                    btnMenu.Click += BtnMenu_ButtonMenuClicked;
                pnl_sidebar.Controls.Add(btnMenu);
            }
            #endregion
        }

        private void BtnMenu_MouseLeave(object sender, EventArgs e)
        {
            if (sender is GradientRadiusButton button)
            {
                button.ForeColor = System.Drawing.Color.LemonChiffon;
                button.GradientColor1 = System.Drawing.Color.RoyalBlue;
                button.GradientColor2 = System.Drawing.Color.Violet;
            }
        }

        private void BtnMenu_MouseEnter(object sender, EventArgs e)
        {
            if (sender is GradientRadiusButton button)
            {
                button.ForeColor = System.Drawing.Color.MidnightBlue;
                button.GradientColor1 = System.Drawing.Color.HotPink;
                button.GradientColor2 = System.Drawing.Color.Yellow;
            }
        }

        private void setupBtnTitle()
        {
            btn_Exit.BackColor = System.Drawing.Color.White;
            btn_Minize.BackColor = System.Drawing.Color.White;
            btn_Exit.BringToFront();
            btn_Minize.BringToFront();
        }

        private void InitializeMainPanels()
        {
            pnlBanHang = new PanelBanHang();
            pnlSale = new PanelSale();
            pnlSanPham = new PanelSanPham();
            pnlNhanVien = new PanelNhanVien();
            pnlCustomer = new PanelCustomer();
            pnlSupplier = new PanelSupplier();
        }
        private void ClearPanelButKeepSpecificControls(Panel panel)
        {
            // Tạo danh sách các control cần giữ lại
            var controlsToKeep = new List<Control> { btn_Exit, btn_Minize };

            // Lặp qua danh sách control và xóa các control không có trong danh sách
            for (int i = panel.Controls.Count - 1; i >= 0; i--)
            {
                Control control = panel.Controls[i];
                if (!controlsToKeep.Contains(control))
                {
                    panel.Controls.Remove(control);
                }
            }
        }

        private void BtnMenu_ButtonMenuClicked(object sender, EventArgs e)
        {
            GradientRadiusButton clickedButton = sender as GradientRadiusButton;

            //Clear các panel trước khi thêm panel mới
            //pnl_main.Controls.Clear();
            ClearPanelButKeepSpecificControls(pnl_main);

            // Hiển thị panel tương ứng với nội dung nút
            switch (clickedButton.Text)
            {
                case "Bán hàng":
                    {
                        pnlBanHang.BackColor = System.Drawing.Color.White;
                        pnlBanHang.ForeColor = System.Drawing.Color.Black;
                        pnlBanHang.Location = new System.Drawing.Point(-1, 3);
                        pnlBanHang.Name = "pnlBanHang";
                        pnlBanHang.Size = new System.Drawing.Size(1572, 850);
                        pnlBanHang.TabIndex = 6;
                        pnl_main.Controls.Add(pnlBanHang);
                        setupBtnTitle();
                    }
                    break;
                case "Khuyến mãi":
                    {
                        pnlSale.BackColor = System.Drawing.Color.White;
                        pnlSale.ForeColor = System.Drawing.Color.Black;
                        pnlSale.Location = new System.Drawing.Point(-1, 3);
                        pnlSale.Name = "pnlSale";
                        pnlSale.Size = new System.Drawing.Size(1572, 850);
                        pnlSale.TabIndex = 6;
                        pnl_main.Controls.Add(pnlSale);
                        setupBtnTitle();
                    }
                    break;
                case "Sản phẩm":
                    {
                        pnlSanPham.BackColor = System.Drawing.Color.White;
                        pnlSanPham.ForeColor = System.Drawing.Color.Black;
                        pnlSanPham.Location = new System.Drawing.Point(-1, 3);
                        pnlSanPham.Name = "pnlSanPham";
                        pnlSanPham.Size = new System.Drawing.Size(1572, 850);
                        pnlSanPham.TabIndex = 6;
                        pnl_main.Controls.Add(pnlSanPham);
                        setupBtnTitle();
                    }
                    break;
                case "Hóa đơn":
                    {

                    }
                    break;
                case "Nhân viên":
                    {
                        pnlCustomer.BackColor = System.Drawing.Color.White;
                        pnlNhanVien.ForeColor = System.Drawing.Color.Black;
                        pnlNhanVien.Location = new System.Drawing.Point(-1, 3);
                        pnlNhanVien.Name = "pnlNhanVien";
                        pnlNhanVien.Size = new System.Drawing.Size(1572, 850);
                        pnlNhanVien.TabIndex = 6;
                        pnl_main.Controls.Add(pnlNhanVien);
                        setupBtnTitle();
                    }
                    break;
                case "Khách hàng":
                    {
                        pnlCustomer.BackColor = System.Drawing.Color.White;
                        pnlCustomer.ForeColor = System.Drawing.Color.Black;
                        pnlCustomer.Location = new System.Drawing.Point(-1, 3);
                        pnlCustomer.Name = "pnlCustomer";
                        pnlCustomer.Size = new System.Drawing.Size(1572, 850);
                        pnlCustomer.TabIndex = 6;
                        pnl_main.Controls.Add(pnlCustomer);
                        setupBtnTitle();
                    }
                    break;
                case "Nhà cung cấp":
                    {
                        pnlSupplier.BackColor = System.Drawing.Color.White;
                        pnlSupplier.ForeColor = System.Drawing.Color.Black;
                        pnlSupplier.Location = new System.Drawing.Point(-1, 3);
                        pnlSupplier.Name = "pnlSupplier";
                        pnlSupplier.Size = new System.Drawing.Size(1572, 850);
                        pnlSupplier.TabIndex = 6;
                        pnl_main.Controls.Add(pnlSupplier);
                        setupBtnTitle();
                    }
                    break;
                case "Phiếu nhập":
                    {

                    }
                    break;
                case "Thống kê":
                    {

                    }
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

        private void lblMinize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


    }
}
