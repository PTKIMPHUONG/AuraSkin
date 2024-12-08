using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using aura_skin.DAO;
using aura_skin.BUS;

namespace aura_skin
{
    public partial class frmGoiYSanPham : Form
    {
        private RecommendationsBUS recommendationsBUS = new RecommendationsBUS();
        private ProductsDAO productsDAO = new ProductsDAO();
        public frmGoiYSanPham()
        {
            InitializeComponent();
            this.StartPosition=FormStartPosition.CenterScreen;
        }

        private void btnChonKhachHang_Click(object sender, EventArgs e)
        {
            frm_Customer frmCustomer=new frm_Customer();
            frmCustomer.Show();
        }

        private void btnGoiYSanPham_Click(object sender, EventArgs e)
        {
            string customerPhone = txtSDTCustomer.Text.Trim();
            string customerID = GetCustomerIDByPhone(customerPhone);

            if (string.IsNullOrEmpty(customerID))
            {
                MessageBox.Show("Không tìm thấy khách hàng với số điện thoại này.");
                return;
            }

            var recommendedProducts = recommendationsBUS.RecommendProductsByCollaborativeFiltering(customerID);

            dtgDsSP.DataSource = recommendedProducts;
        }

        // Lấy thông tin khách hàng từ số điện thoại
        private string GetCustomerIDByPhone(string phone)
        {
            UsersDAO usersDAO = new UsersDAO();
            var user = usersDAO.GetUsersList().FirstOrDefault(u => u.phone_number == phone);
            return user?.id_user;
        }

        // Hiển thị thông tin sản phẩm khi chọn trong danh sách
        private void dtgDsSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgDsSP.SelectedItem != null)
            {
                var selectedProduct = (Product)dtgDsSP.SelectedItem;

                txtMaSP.Text = selectedProduct.id_product;
                txtTenSP.Text = selectedProduct.product_name;
                cboLoaiSP.Text = selectedProduct.id_category;
                txtDonGia.Text = selectedProduct.default_price.ToString();
                numudSoLuong.Value = selectedProduct.stock_quantity;
                cboTrangThai.Text = selectedProduct.is_active == 1 ? "Đang hoạt động" : "Không hoạt động";

                if (!string.IsNullOrEmpty(selectedProduct.default_image))
                {
                    try
                    {
                        pnlImageSP.BackgroundImage = Image.FromFile(selectedProduct.default_image);
                        pnlImageSP.BackgroundImageLayout = ImageLayout.Zoom;
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Không thể tải ảnh sản phẩm!", "Lỗi ảnh", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    pnlImageSP.BackgroundImage = null;
                }
            }

        }
    }
}
