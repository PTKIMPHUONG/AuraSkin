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



namespace aura_skin
{
    public partial class frm_Main : RoundedBorderForm
    {
        public string Username;
        //string[] getSt = { "Bán hàng", "Khuyến mãi", "Sản phẩm" };
        string[] getSt = { "Bán hàng", "Khuyến mãi", "Sản phẩm", "Hóa đơn", "Nhân viên", "Khách hàng", "Nhà cung cấp", "Thống kê", "Đăng xuất" };
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

        ProductBUS productBUS = new ProductBUS();
        CategoriesBUS categoriesBUS = new CategoriesBUS();
        SuppliersBUS suppliersBUS = new SuppliersBUS();
        UsersBUS usersBUS = new UsersBUS();

        List<Category> categories = new List<Category>();
        List<Supplier> suppliers = new List<Supplier>();
        List<Product> products = new List<Product>();
        List<User> users = new List<User>();
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

            products = productBUS.products;
            categories = categoriesBUS.categories;
            suppliers = suppliersBUS.suppliers;
            users= usersBUS.users;
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
        private void addControlsToBanHangPanel()
        {
            pnlBanHang.ControlsDictionary["btnGoiYSanPham"].Click += btnGoiYSanPham_Click;
            pnlBanHang.ControlsDictionary["btnTimKiem"].Click += btnTimKiemSP_Cart_Click;
        }

        private void btnTimKiemSP_Cart_Click(object sender, EventArgs e)
        {
            Product product = productBUS.GetProductByID(pnlBanHang.ControlsDictionary["txtMaSP"].Text.ToString());
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
