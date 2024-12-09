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
using aura_skin.BUS;
using Syncfusion.WinForms.DataGrid;
using aura_skin.DAO;
using Syncfusion.WinForms.DataGrid.Events;
using Syncfusion.WinForms.ListView;
using System.IO;
using PanelThongKeControl;
using Syncfusion.WinForms.Input;

namespace aura_skin
{
    public partial class frm_Main : RoundedBorderForm
    {
        public string Username;
        //string[] getSt = { "Bán hàng", "Khuyến mãi", "Sản phẩm" };
        string[] getSt1 = { "Bán hàng", "Khuyến mãi", "Sản phẩm", "Hóa đơn", "Khách hàng", "Nhà cung cấp","Thống kê" };
        string[] getSt2 = { "Nhân viên", "Khách hàng", "Nhà cung cấp", "Thống kê" };
        string[] getStLogOut = { "Đăng xuất" };


        #region Khai Báo Các Panel Main
        private PanelBanHang pnlBanHang;
        private PanelSanPham pnlSanPham;
        private PanelNhanVien pnlNhanVien;
        private PanelCustomer pnlCustomer;
        private PanelSale pnlSale;
        private PanelSupplier pnlSupplier;
        private PanelThongKe pnlThongKe;
        #endregion

        ProductBUS productBUS = new ProductBUS();
        CategoriesBUS categoriesBUS = new CategoriesBUS();
        SuppliersBUS suppliersBUS = new SuppliersBUS();
        UsersBUS usersBUS = new UsersBUS();
        SalesBUS salesBUS = new SalesBUS();
        RolesBUS rolesBUS = new RolesBUS();
        OrderBUS ordersBUS = new OrderBUS();
        CustomerInfoBUS customerInfoBUS = new CustomerInfoBUS();

        List<Category> categories = new List<Category>();
        List<Supplier> suppliers = new List<Supplier>();
        List<Product> products = new List<Product>();
        List<Order> orders = new List<Order>();
        List<User> users = new List<User>();
        List<Sale> sales= new List<Sale>();
        List<Role> roles = new List<Role>();
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
            products = productBUS.products;
            categories = categoriesBUS.categories;
            suppliers = suppliersBUS.suppliers;
            users = usersBUS.users;
            sales = salesBUS.sales;
            roles = rolesBUS.roles;

            inits();
            users= usersBUS.users;
            orders = ordersBUS.orders;

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

            #region Check Phân Quyền
            string[] allItems = { };
            User userloginNow = usersBUS.GetUserByUsername(Username); 
            foreach (Role item in roles)
            {
                if (userloginNow.id_role == item.id_role)
                {
                    if (item.role_name == "Admin")
                    {
                        allItems = getSt1.Concat(getSt2).Concat(getStLogOut).Distinct().ToArray();
                    }
                    else if (item.role_name == "Nhân viên bán hàng")
                    {
                        allItems = getSt1.Concat(getStLogOut).Distinct().ToArray();
                    }
                }
            }
            #endregion

            #region Thêm các button menu
            int startBtnMenu = pnl_UserInfo.Height + pnl_UserInfo.Location.Y - 0;
            for (int i = 0; i < allItems.Length; i++)
            {
                GradientRadiusButton btnMenu = new GradientRadiusButton();
                btnMenu.Text = allItems[i];
                btnMenu.Width = 317;
                btnMenu.Height = 75;
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
            pnlThongKe = new PanelThongKe();

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
            InitializeMainPanels();

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
                        addControlsToBanHangPanel();
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
                        addControlsToSalesPanel();
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
                        addControlsToProductsPanel();
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
                        addControlToNhanVienPanel();
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
                        addControlsToSuppliersPanel();
                    }
                    break;
                case "Thống kê":
                    {
                        pnlThongKe.BackColor = System.Drawing.Color.White;
                        pnlThongKe.ForeColor = System.Drawing.Color.Black;
                        pnlThongKe.Location = new System.Drawing.Point(-1, 3);
                        pnlThongKe.Name = "pnlThongKe";
                        pnlThongKe.Size = new System.Drawing.Size(1572, 850);
                        pnlThongKe.TabIndex = 6;
                        pnl_main.Controls.Add(pnlThongKe);
                        setupBtnTitle();
                        addControlsToThongKePanel();
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
        private void addControlsToBanHangPanel()
        {
            pnlBanHang.ControlsDictionary["btnGoiYSanPham"].Click += btnGoiYSanPham_Click;
            pnlBanHang.ControlsDictionary["btnTimKiem"].Click += btnTimKiemSP_Cart_Click;
            pnlBanHang.ControlsDictionary["btnThemVaoGio"].Click += btnAddProductToCart_Click;
            #region Load dữ liệu vào combobox categories
            // Gán dữ liệu vào ComboBox
            var cboLoaiSP = pnlBanHang.ControlsDictionary["cboLoaiSP"] as SfComboBox;
            cboLoaiSP.DataSource = categories;
            cboLoaiSP.DisplayMember = "category_name"; // Hiển thị tên trong ComboBox
            cboLoaiSP.ValueMember = "id_category"; // Gán giá trị của Id vào ComboBox

            //Gán giá trị mặc định là chưa select
            cboLoaiSP.SelectedIndex = -1;
            #endregion


        }

        private void btnAddProductToCart_Click(object sender, EventArgs e)
        {
            //Lấy mã sp ra
            string maSP = pnlBanHang.ControlsDictionary["txtMaSP"].Text.Trim();
            Product product = productBUS.GetProductByID(maSP);


            var sfDataGrid = sender as SfDataGrid;
            if (sfDataGrid != null)
            {

            }
        }

        private void btnTimKiemSP_Cart_Click(object sender, EventArgs e)
        {
            Product product = productBUS.GetProductByID(pnlBanHang.ControlsDictionary["txtMaSP"].Text.Trim().ToString());
            pnlBanHang.ControlsDictionary["txtTenSP"].Text=product.product_name;
            pnlBanHang.ControlsDictionary["txtPrice"].Text = product.default_price.ToString();
            pnlBanHang.ControlsDictionary["txtDescription"].Text = product.description;
            var numericQuantity = pnlBanHang.ControlsDictionary["numericQuantity"] as NumericUpDownExt;
            numericQuantity.Maximum=product.stock_quantity;


            if (product.default_image != null && product.default_image != "")
            {
                #region Thêm hình ảnh vào panel
                // Tạo PictureBox và thêm vào Panel
                PictureBox pictureBox = new PictureBox();
                pictureBox.Dock = DockStyle.Fill;
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

                // Tải hình ảnh vào PictureBox
                pictureBox.Image = Image.FromFile("../../../image/Product/" + product.default_image);

                // Thêm PictureBox vào Panel
                pnlBanHang.ControlsDictionary["pnlImageSP"].Controls.Add(pictureBox);
                #endregion
            }
            else
            {
                //pnlSanPham.ControlsDictionary["pnlImageSP"].Refresh();
            }
        }

        private void addControlToNhanVienPanel()
        {
            #region Load dữ liệu vào table Products
            // Lấy SfDataGrid từ ControlsDictionary
            var dtgDsNhanVien = pnlNhanVien.ControlsDictionary["dtgDsNhanVien"] as SfDataGrid;
            if (dtgDsNhanVien != null)
            {
                dtgDsNhanVien.AutoGenerateColumns = false;
                // Gán DataSource
                dtgDsNhanVien.DataSource = users;
            }
            else
            {
                MessageBox.Show("Không thể load dữ liệu Products");
            }
            #endregion

            #region Load dữ liệu vào combobox giới tính
            // Tạo danh sách giới tính
            var genders = new List<object>
            {
                new { Value = "Nam" },
                new { Value = "Nữ" }
            };

            // Lấy ComboBox từ ControlsDictionary
            var cboGender = pnlNhanVien.ControlsDictionary["cboGioiTinh"] as SfComboBox;

            // Gán dữ liệu vào ComboBox
            cboGender.DataSource = genders;
            cboGender.DisplayMember = "Value";
            cboGender.ValueMember = "Value";

            // Gán giá trị mặc định là chưa chọn
            cboGender.SelectedIndex = -1;
            #endregion

            dtgDsNhanVien.CurrentCellActivated += dtgNhanVien_CurrentCellActivated;
        }
        private void addControlsToSuppliersPanel()
        {
            #region Load dữ liệu vào table Products
            // Lấy SfDataGrid từ ControlsDictionary
            var dtgDsSuppliers = pnlSupplier.ControlsDictionary["dtgDsSuppliers"] as SfDataGrid;
            if (dtgDsSuppliers != null)
            {
                dtgDsSuppliers.AutoGenerateColumns = false;
                // Gán DataSource
                dtgDsSuppliers.DataSource = suppliers;
            }
            else
            {
                MessageBox.Show("Không thể load dữ liệu Products");
            }
            #endregion
            dtgDsSuppliers.CurrentCellActivated += dtgSuppliers_CurrentCellActivated;
        }

        private void addControlsToProductsPanel()
        {
            #region Load dữ liệu vào table Products
            // Lấy SfDataGrid từ ControlsDictionary
            var dtgProducts = pnlSanPham.ControlsDictionary["dtgDsSP"] as SfDataGrid;
           if (dtgProducts!=null)
            {
                dtgProducts.AutoGenerateColumns = false;
                // Gán DataSource
                dtgProducts.DataSource = products;
            }
            else
            {
                MessageBox.Show("Không thể load dữ liệu Products");
            }
            #endregion

            #region Load dữ liệu vào combobox categories
            // Gán dữ liệu vào ComboBox
            var cboLoaiSP = pnlSanPham.ControlsDictionary["cboLoaiSP"] as SfComboBox;
            cboLoaiSP.DataSource = categories;
            cboLoaiSP.DisplayMember = "category_name"; // Hiển thị tên trong ComboBox
            cboLoaiSP.ValueMember = "id_category"; // Gán giá trị của Id vào ComboBox

            //Gán giá trị mặc định là chưa select
            cboLoaiSP.SelectedIndex = -1;
            #endregion

            #region Load dữ liệu vào combobox suppliers
            // Gán dữ liệu vào ComboBox
            var cboSuppler = pnlSanPham.ControlsDictionary["cboSupplier"] as SfComboBox;
            cboSuppler.DataSource = suppliers;
            cboSuppler.DisplayMember = "supplier_name"; // Hiển thị tên trong ComboBox
            cboSuppler.ValueMember = "id_supplier"; // Gán giá trị của Id vào ComboBox

            //Gán giá trị mặc định là chưa select
            cboSuppler.SelectedIndex = -1;
            #endregion

            pnlSanPham.ControlsDictionary["btnAddImage"].Click += btnSelectImageProduct_Click;

            dtgProducts.CurrentCellActivated += dtgProducts_CurrentCellActivated;
        }
        private void addControlsToSalesPanel()
        {
            #region Load dữ liệu vào table Sales
            // Lấy SfDataGrid từ ControlsDictionary
            var dtgSales = pnlSale.ControlsDictionary["dtgDsSales"] as SfDataGrid;
            if (dtgSales != null)
            {
                dtgSales.AutoGenerateColumns = false;
                // Gán DataSource
                dtgSales.DataSource = sales;
            }
            else
            {
                MessageBox.Show("Không thể load dữ liệu Sales");
            }
            #endregion

            #region Load dữ liệu vào combobox tênSP
            // Gán dữ liệu vào ComboBox
            var cboTenSP = pnlSale.ControlsDictionary["cboTenSP"] as SfComboBox;
            cboTenSP.DataSource = products;
            cboTenSP.DisplayMember = "product_name"; // Hiển thị tên trong ComboBox
            cboTenSP.ValueMember = "id_product"; // Gán giá trị của Id vào ComboBox

            //Gán giá trị mặc định là chưa select
            cboTenSP.SelectedIndex = -1;
            #endregion

            dtgSales.CurrentCellActivated += dtgSales_CurrentCellActivated;

        }
        private void dtgSales_CurrentCellActivated(object sender, CurrentCellActivatedEventArgs e)
        {
            var sfDataGrid = sender as SfDataGrid;
            if (sfDataGrid != null && sfDataGrid.CurrentItem != null)
            {
                // Lấy đối tượng của hàng hiện tại
                var selectedRow = sfDataGrid.CurrentItem;

                // Lấy giá trị của cột đầu tiên (mã)
                var firstCellValue = selectedRow.GetType().GetProperty(sfDataGrid.Columns[0].MappingName)?.GetValue(selectedRow, null);

                if (firstCellValue != null)
                {
                    //Sale sale = new Sale();
                    //sale = salesBUS.GetSaleByID(firstCellValue.ToString());
                    //pnlSale.ControlsDictionary["txtSupplierID"].Text = sale.id_sale;
                    //pnlSale.ControlsDictionary["txtSupplierName"].Text = sale.supplier_name;
                    //pnlSale.ControlsDictionary["txtEmail"].Text = sale.email;
                    //pnlSale.ControlsDictionary["txtPhoneNumber"].Text = sale.phone_number;
                    //pnlSale.ControlsDictionary["txtAddress"].Text = sale.address;
                }
            }
        }
        private void addControlsToThongKePanel()
        {
            #region Load dữ liệu vào table thống kê
            // Lấy SfDataGrid từ ControlsDictionary
            var dtgOrders = pnlThongKe.ControlsDictionary["sfDataGridOrders"] as SfDataGrid;
            if (dtgOrders != null)
            {
                dtgOrders.AutoGenerateColumns = false;
                // Gán DataSource
                dtgOrders.DataSource = orders;
            }
            else
            {
                MessageBox.Show("Không thể load dữ liệu Orders");
            }
            #endregion

            #region Load dữ liệu form panelThongKe
            var subPanelDonHang = pnlThongKe.Controls["PanelDonHang"] as Panel;
            var subPanelKhachHang = pnlThongKe.Controls["PanelKhachHang"] as Panel;
            var subPanelDoanhThu = pnlThongKe.Controls["PanelDoanhThu"] as Panel;
            var lblTodayOrdersControl = subPanelDonHang?.Controls["LabelNewOrders"] as Label;
            var lblTodayCustomerControl = subPanelKhachHang?.Controls["LabelNewOrders"] as Label;
            var lblTotalOrderControl = subPanelDonHang?.Controls["LabelTotalOrders"] as Label;
            var lblTotalCustomerControl = subPanelKhachHang?.Controls["LabelTotalCustomers"] as Label;
            var lblTotalSalesTodayControl = subPanelDoanhThu?.Controls["LabelSalesToday"] as Label;
            var lblTotalSalesControl = subPanelDoanhThu?.Controls["LabelTotalDoanhThu"] as Label;

            if (lblTodayOrdersControl != null && lblTotalOrderControl != null)
            {
                try
                {
                    // Lấy dữ liệu từ BUS
                    int todayOrderCount = ordersBUS.GetTodayOrderCount();
                    int totalOrder = ordersBUS.GetTotalOrder();
                    int totalCustomer = customerInfoBUS.GetTotalCustomer();
                    int totalSales = ordersBUS.GetTotalOrderAmountByStatus();
                    int totalSalesToday = ordersBUS.GetTotalOrderAmountForTodayByStatus();




                    // Hiển thị dữ liệu lên giao diện
                    lblTodayOrdersControl.Text = $"{todayOrderCount}";
                    lblTotalOrderControl.Text = $"{totalOrder}";
                    lblTotalCustomerControl.Text = $"{totalCustomer}";
                    lblTotalSalesControl.Text = $"{totalSales}";
                    lblTotalSalesTodayControl.Text = $"{totalSalesToday}";

                }
                catch (Exception ex)
                {
                    lblTodayOrdersControl.Text = "Dữ liệu không khả dụng";
                    lblTotalOrderControl.Text = "Dữ liệu không khả dụng";
                    lblTotalCustomerControl.Text = "Dữ liệu không khả dụng";
                    lblTotalSalesControl.Text = "Dữ liệu không khả dụng";
                    lblTotalSalesTodayControl.Text = $"Dữ liệu không khả dụng";


                    // Hiển thị thông báo lỗi
                    MessageBox.Show($"Không thể load dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy các Label trên panelThongKe", "Lỗi giao diện", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            #endregion

            #region Lọc danh sách thống kê
            var startDateEdit = pnlThongKe.ControlsDictionary["sfDateTimeEditStart"] as SfDateTimeEdit;
            var endDateEdit = pnlThongKe.ControlsDictionary["sfDateTimeEditEnd"] as SfDateTimeEdit;
            var filterButton = pnlThongKe.ControlsDictionary["btnFilter"] as GradientRadiusButton;
            if (startDateEdit != null && endDateEdit != null && filterButton != null)
            {
                // Xử lý sự kiện ValueChanged của endDateEdit
                endDateEdit.ValueChanged += (s, e) =>
                {
                    if (endDateEdit.Value < startDateEdit.Value)
                    {
                        MessageBox.Show("Ngày kết thúc không được nhỏ hơn ngày bắt đầu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        endDateEdit.Value = startDateEdit.Value; // Đặt lại giá trị endDateEdit
                    }
                };

                // Xử lý sự kiện click của filterButton
                filterButton.Click += (s, e) =>
                {
                    try
                    {
                        // Lấy giá trị từ SfDateTimeEdit
                        DateTime startDate = startDateEdit.Value ?? DateTime.MinValue;
                        DateTime endDate = endDateEdit.Value ?? DateTime.MaxValue;

                        // Kiểm tra ràng buộc: endDate không được nhỏ hơn startDate
                        if (endDate < startDate)
                        {
                            MessageBox.Show("Ngày kết thúc không được nhỏ hơn ngày bắt đầu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        // Lọc danh sách đơn hàng
                        var filteredOrders = ordersBUS.GetOrdersByDateRange(startDate, endDate);

                        // Gán danh sách đã lọc vào DataGrid
                   
                        if (dtgOrders != null)
                        {
                            dtgOrders.DataSource = filteredOrders;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Lỗi khi lọc đơn hàng: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                };
            }
            else
            {
                MessageBox.Show("Không thể tìm thấy các điều khiển để thực hiện lọc.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            #endregion
        }
        private void dtgNhanVien_CurrentCellActivated(object sender, CurrentCellActivatedEventArgs e)
        {
            var sfDataGrid = sender as SfDataGrid;
            if (sfDataGrid != null && sfDataGrid.CurrentItem != null)
            {
                // Lấy đối tượng của hàng hiện tại
                var selectedRow = sfDataGrid.CurrentItem;

                // Lấy giá trị của cột đầu tiên (MappingName phải khớp)
                var firstCellValue = selectedRow.GetType().GetProperty(sfDataGrid.Columns[0].MappingName)?.GetValue(selectedRow, null);

                if (firstCellValue != null)
                {
                    User user = new User();
                    user = usersBUS.GetUserByID(firstCellValue.ToString());
                    pnlNhanVien.ControlsDictionary["txtUserID"].Text = user.id_user;
                    pnlNhanVien.ControlsDictionary["txtUsername"].Text = user.username;
                    pnlNhanVien.ControlsDictionary["txtFullName"].Text = user.full_name;

                    // Tìm Category có Id tương ứng 
                    var cboGioiTinh = pnlNhanVien.ControlsDictionary["cboGioiTinh"] as SfComboBox;
                    cboGioiTinh.SelectedValue = user.gender;

                    pnlNhanVien.ControlsDictionary["txtEmail"].Text = user.email;
                    pnlNhanVien.ControlsDictionary["txtSDT"].Text = user.phone_number;
                    pnlNhanVien.ControlsDictionary["txtAddress"].Text = user.address;

                    if (user.image_user != null && user.image_user!= "")
                    {
                        #region Thêm hình ảnh vào panel
                        // Tạo PictureBox và thêm vào Panel
                        PictureBox pictureBox = new PictureBox();
                        pictureBox.Dock = DockStyle.Fill; 
                        pictureBox.SizeMode = PictureBoxSizeMode.StretchImage; 

                        // Tải hình ảnh vào PictureBox
                        pictureBox.Image = Image.FromFile("../../../image/User/" + user.image_user);

                        // Thêm PictureBox vào Panel
                        pnlNhanVien.ControlsDictionary["pnlImageUser"].Controls.Add(pictureBox);
                        #endregion
                    }
                    else
                    {
                        //pnlSanPham.ControlsDictionary["pnlImageUser"].Refresh();
                    }
                }
                else
                {
                    MessageBox.Show("Không thể lấy giá trị ô đầu tiên.");
                }
            }
        }
        private void dtgSuppliers_CurrentCellActivated(object sender, CurrentCellActivatedEventArgs e)
        {
            var sfDataGrid = sender as SfDataGrid;
            if (sfDataGrid != null && sfDataGrid.CurrentItem != null)
            {
                // Lấy đối tượng của hàng hiện tại
                var selectedRow = sfDataGrid.CurrentItem;

                // Lấy giá trị của cột đầu tiên (mã)
                var firstCellValue = selectedRow.GetType().GetProperty(sfDataGrid.Columns[0].MappingName)?.GetValue(selectedRow, null);

                if (firstCellValue != null)
                {
                    Supplier supplier = new Supplier();
                    supplier = suppliersBUS.GetSupplierByID(firstCellValue.ToString());
                    pnlSupplier.ControlsDictionary["txtSupplierID"].Text = supplier.id_supplier;
                    pnlSupplier.ControlsDictionary["txtSupplierName"].Text = supplier.supplier_name;
                    pnlSupplier.ControlsDictionary["txtEmail"].Text = supplier.email;
                    pnlSupplier.ControlsDictionary["txtPhoneNumber"].Text = supplier.phone_number;
                    pnlSupplier.ControlsDictionary["txtAddress"].Text = supplier.address;
                }
            }
        }
        private void dtgProducts_CurrentCellActivated(object sender, CurrentCellActivatedEventArgs e)
        {
            var sfDataGrid = sender as SfDataGrid;
            if (sfDataGrid != null && sfDataGrid.CurrentItem != null)
            {
                // Lấy đối tượng của hàng hiện tại
                var selectedRow = sfDataGrid.CurrentItem;

                // Lấy giá trị của cột đầu tiên
                var firstCellValue = selectedRow.GetType().GetProperty(sfDataGrid.Columns[0].MappingName)?.GetValue(selectedRow, null);

                if (firstCellValue != null)
                {
                    Product product = new Product();
                    product=productBUS.GetProductByID(firstCellValue.ToString());
                    pnlSanPham.ControlsDictionary["txtMaSP"].Text = product.id_product;
                    pnlSanPham.ControlsDictionary["txtTenSP"].Text = product.product_name;

                    // Tìm Category có Id tương ứng 
                    var cboLoaiSP = pnlSanPham.ControlsDictionary["cboLoaiSP"] as SfComboBox;
                    cboLoaiSP.SelectedValue = product.id_category;

                    // Tìm Supplier có Id tương ứng 
                    var cboSupplier = pnlSanPham.ControlsDictionary["cboSupplier"] as SfComboBox;
                    cboSupplier.SelectedValue = product.id_supplier;

                    pnlSanPham.ControlsDictionary["txtTrangThai"].Text = product.is_active.ToString();
                    pnlSanPham.ControlsDictionary["txtDonGia"].Text = product.default_price.ToString();

                    if(product.default_image!= null&&product.default_image!="")
                    {
                        #region Thêm hình ảnh vào panel
                        // Tạo PictureBox và thêm vào Panel
                        PictureBox pictureBox = new PictureBox();
                        pictureBox.Dock = DockStyle.Fill; 
                        pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;  

                        // Tải hình ảnh vào PictureBox
                        pictureBox.Image = Image.FromFile("../../../image/Product/" + product.default_image); 

                        // Thêm PictureBox vào Panel
                        pnlSanPham.ControlsDictionary["pnlImageSP"].Controls.Add(pictureBox);
                        #endregion
                    }
                    else
                    {
                        //pnlSanPham.ControlsDictionary["pnlImageSP"].Refresh();
                    }    
                }
                else
                {
                    MessageBox.Show("Không thể lấy giá trị ô đầu tiên.");
                }
            }
        }

        private void btnSelectImageProduct_Click(object sender, EventArgs e)
        {
            // Khởi tạo OpenFileDialog
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            openFileDialog.Title = "Chọn ảnh";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFile = openFileDialog.FileName;

                // Xác định đường dẫn lưu ảnh trong thư mục Images trong dự án
                string targetDirectory = Path.Combine(Application.StartupPath, "../../../image/Product");

                // Nếu thư mục chưa tồn tại, tạo mới
                if (!Directory.Exists(targetDirectory))
                {
                    Directory.CreateDirectory(targetDirectory);
                }

                // Lấy tên file và đường dẫn mới
                string fileName = Path.GetFileName(selectedFile); // Lấy tên file (không bao gồm đường dẫn)
                // Lấy tên file và đường dẫn mới
                string targetFilePath = Path.Combine(targetDirectory, fileName);

                bool check = File.Exists("../../../image/Product/" + fileName);
                if (selectedFile.Contains("AuraSkin\\image\\Product\\") && File.Exists("../../../image/Product/" + fileName))
                {
                    // Hiển thị thông báo lỗi hoặc sử dụng ảnh mặc định
                    MessageBox.Show("Đường dẫn này có thể gây lỗi!");
                    return;
                }
                else
                {
                    // Sao chép file vào thư mục trong dự án
                    File.Copy(selectedFile, targetFilePath, true);
                }

                // Hiển thị đường dẫn hoặc làm gì đó với file ảnh
                MessageBox.Show("Ảnh đã được lưu thành công!");

                //Load ảnh vào pnlImageProduct
                PictureBox pictureBox = new PictureBox();
                // Tải hình ảnh vào PictureBox
                pictureBox.Image = Image.FromFile(targetFilePath);
                // Thêm PictureBox vào Panel
                pnlSanPham.ControlsDictionary["pnlImageSP"].Controls.Add(pictureBox);

                //Lưu vào BUS
                string id = pnlSanPham.ControlsDictionary["txtMaSP"].Text;
                productBUS.UpdateImageProduct(id, fileName);
            }
        }
        private void btnGoiYSanPham_Click(object sender, EventArgs e) 
        {
            var btnGoiY=sender as Button;
            frmGoiYSanPham frm_goiYSP=new frmGoiYSanPham();
            frm_goiYSP.Show();
        }

    }
}
