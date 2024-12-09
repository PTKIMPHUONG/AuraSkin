namespace PanelBanHangControl
{
    partial class PanelBanHang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn1 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn2 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn3 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn4 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn5 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn6 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn7 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            this.cboLoaiSP = new Syncfusion.WinForms.ListView.SfComboBox();
            this.pnlImageSP = new System.Windows.Forms.Panel();
            this.txtDescription = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.dtgDsSP = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.lblTitle = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.lblLoai = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.lblTenSP = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.lblDonGia = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.lblSoLuong = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.lblDescription = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.lbl_MaSP = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.txtTenSP = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.txtPrice = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.txtMaSP = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.numericQuantity = new Syncfusion.Windows.Forms.Tools.NumericUpDownExt();
            this.btnGoiYSanPham = new GradientButtonRadiusControl.GradientRadiusButton();
            this.btnAddImage = new GradientButtonRadiusControl.GradientRadiusButton();
            this.btnTimKiem = new GradientButtonRadiusControl.GradientRadiusButton();
            this.btnThanhToan = new GradientButtonRadiusControl.GradientRadiusButton();
            this.btnXoaKhoiGio = new GradientButtonRadiusControl.GradientRadiusButton();
            this.btnThemVaoGio = new GradientButtonRadiusControl.GradientRadiusButton();
            ((System.ComponentModel.ISupportInitialize)(this.cboLoaiSP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDsSP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenSP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaSP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // cboLoaiSP
            // 
            this.cboLoaiSP.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.cboLoaiSP.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cboLoaiSP.Location = new System.Drawing.Point(273, 237);
            this.cboLoaiSP.Name = "cboLoaiSP";
            this.cboLoaiSP.Size = new System.Drawing.Size(270, 31);
            this.cboLoaiSP.Style.DropDownStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cboLoaiSP.Style.EditorStyle.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cboLoaiSP.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cboLoaiSP.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboLoaiSP.Style.TokenStyle.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cboLoaiSP.TabIndex = 62;
            this.cboLoaiSP.TabStop = false;
            // 
            // pnlImageSP
            // 
            this.pnlImageSP.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlImageSP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlImageSP.Location = new System.Drawing.Point(1299, 106);
            this.pnlImageSP.Name = "pnlImageSP";
            this.pnlImageSP.Size = new System.Drawing.Size(250, 250);
            this.pnlImageSP.TabIndex = 61;
            // 
            // txtDescription
            // 
            this.txtDescription.BeforeTouchSize = new System.Drawing.Size(371, 28);
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescription.CornerRadius = 2;
            this.txtDescription.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.txtDescription.Location = new System.Drawing.Point(273, 338);
            this.txtDescription.MinimumSize = new System.Drawing.Size(14, 10);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ReadOnly = true;
            this.txtDescription.Size = new System.Drawing.Size(270, 30);
            this.txtDescription.TabIndex = 60;
            // 
            // dtgDsSP
            // 
            this.dtgDsSP.AccessibleName = "Table";
            this.dtgDsSP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgDsSP.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.Fill;
            gridTextColumn1.HeaderStyle.FilterIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            gridTextColumn1.HeaderText = "Mã SP";
            gridTextColumn1.MappingName = "id_product";
            gridTextColumn2.HeaderStyle.FilterIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            gridTextColumn2.HeaderText = "Tên SP";
            gridTextColumn2.MappingName = "product_name";
            gridTextColumn3.HeaderStyle.FilterIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            gridTextColumn3.HeaderText = "Loại SP";
            gridTextColumn3.MappingName = "id_category";
            gridTextColumn4.HeaderStyle.FilterIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            gridTextColumn4.HeaderText = "Đơn giá";
            gridTextColumn4.MappingName = "default_price";
            gridTextColumn5.HeaderStyle.FilterIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            gridTextColumn5.HeaderText = "Số lượng";
            gridTextColumn5.MappingName = "quantiy";
            gridTextColumn6.HeaderStyle.FilterIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            gridTextColumn6.HeaderText = "Mô tả";
            gridTextColumn6.MappingName = "description";
            gridTextColumn7.HeaderStyle.FilterIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            gridTextColumn7.HeaderText = "Ảnh";
            gridTextColumn7.MappingName = "default_image";
            this.dtgDsSP.Columns.Add(gridTextColumn1);
            this.dtgDsSP.Columns.Add(gridTextColumn2);
            this.dtgDsSP.Columns.Add(gridTextColumn3);
            this.dtgDsSP.Columns.Add(gridTextColumn4);
            this.dtgDsSP.Columns.Add(gridTextColumn5);
            this.dtgDsSP.Columns.Add(gridTextColumn6);
            this.dtgDsSP.Columns.Add(gridTextColumn7);
            this.dtgDsSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.dtgDsSP.Location = new System.Drawing.Point(3, 382);
            this.dtgDsSP.Name = "dtgDsSP";
            this.dtgDsSP.PreviewRowHeight = 35;
            this.dtgDsSP.Size = new System.Drawing.Size(1041, 465);
            this.dtgDsSP.Style.HeaderStyle.BackColor = System.Drawing.Color.LightSkyBlue;
            this.dtgDsSP.Style.HeaderStyle.FilterIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.dtgDsSP.TabIndex = 58;
            this.dtgDsSP.Text = "sfDataGrid1";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = false;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblTitle.Location = new System.Drawing.Point(595, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(387, 44);
            this.lblTitle.TabIndex = 56;
            this.lblTitle.Text = "Quản Lý Bán Hàng";
            // 
            // lblLoai
            // 
            this.lblLoai.AutoSize = false;
            this.lblLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblLoai.Location = new System.Drawing.Point(160, 240);
            this.lblLoai.Name = "lblLoai";
            this.lblLoai.Size = new System.Drawing.Size(145, 23);
            this.lblLoai.TabIndex = 55;
            this.lblLoai.Text = "Loại";
            // 
            // lblTenSP
            // 
            this.lblTenSP.AutoSize = false;
            this.lblTenSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblTenSP.Location = new System.Drawing.Point(726, 135);
            this.lblTenSP.Name = "lblTenSP";
            this.lblTenSP.Size = new System.Drawing.Size(130, 23);
            this.lblTenSP.TabIndex = 54;
            this.lblTenSP.Text = "Tên SP";
            // 
            // lblDonGia
            // 
            this.lblDonGia.AutoSize = false;
            this.lblDonGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblDonGia.Location = new System.Drawing.Point(726, 341);
            this.lblDonGia.Name = "lblDonGia";
            this.lblDonGia.Size = new System.Drawing.Size(130, 27);
            this.lblDonGia.TabIndex = 53;
            this.lblDonGia.Text = "Đơn giá";
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.AutoSize = false;
            this.lblSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblSoLuong.Location = new System.Drawing.Point(726, 241);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(130, 27);
            this.lblSoLuong.TabIndex = 52;
            this.lblSoLuong.Text = "Số lượng";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = false;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblDescription.Location = new System.Drawing.Point(160, 341);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(145, 23);
            this.lblDescription.TabIndex = 51;
            this.lblDescription.Text = "Mô tả";
            // 
            // lbl_MaSP
            // 
            this.lbl_MaSP.AutoSize = false;
            this.lbl_MaSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lbl_MaSP.Location = new System.Drawing.Point(160, 135);
            this.lbl_MaSP.Name = "lbl_MaSP";
            this.lbl_MaSP.Size = new System.Drawing.Size(145, 23);
            this.lbl_MaSP.TabIndex = 50;
            this.lbl_MaSP.Text = "Mã SP";
            // 
            // txtTenSP
            // 
            this.txtTenSP.BeforeTouchSize = new System.Drawing.Size(371, 28);
            this.txtTenSP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTenSP.CornerRadius = 2;
            this.txtTenSP.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtTenSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.txtTenSP.Location = new System.Drawing.Point(862, 128);
            this.txtTenSP.MinimumSize = new System.Drawing.Size(14, 10);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.ReadOnly = true;
            this.txtTenSP.Size = new System.Drawing.Size(270, 30);
            this.txtTenSP.TabIndex = 69;
            // 
            // txtPrice
            // 
            this.txtPrice.BeforeTouchSize = new System.Drawing.Size(371, 28);
            this.txtPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrice.CornerRadius = 2;
            this.txtPrice.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.txtPrice.Location = new System.Drawing.Point(862, 338);
            this.txtPrice.MinimumSize = new System.Drawing.Size(14, 10);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(270, 30);
            this.txtPrice.TabIndex = 71;
            // 
            // txtMaSP
            // 
            this.txtMaSP.BeforeTouchSize = new System.Drawing.Size(371, 28);
            this.txtMaSP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaSP.CornerRadius = 2;
            this.txtMaSP.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtMaSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.txtMaSP.Location = new System.Drawing.Point(273, 128);
            this.txtMaSP.MinimumSize = new System.Drawing.Size(14, 10);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(270, 30);
            this.txtMaSP.TabIndex = 72;
            // 
            // numericQuantity
            // 
            this.numericQuantity.BeforeTouchSize = new System.Drawing.Size(270, 30);
            this.numericQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.numericQuantity.Location = new System.Drawing.Point(862, 238);
            this.numericQuantity.Name = "numericQuantity";
            this.numericQuantity.Size = new System.Drawing.Size(270, 30);
            this.numericQuantity.TabIndex = 73;
            // 
            // btnGoiYSanPham
            // 
            this.btnGoiYSanPham.BorderColor = System.Drawing.Color.Transparent;
            this.btnGoiYSanPham.CornerRadius = 10;
            this.btnGoiYSanPham.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGoiYSanPham.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnGoiYSanPham.ForeColor = System.Drawing.Color.SlateBlue;
            this.btnGoiYSanPham.GradientColor1 = System.Drawing.Color.LightPink;
            this.btnGoiYSanPham.GradientColor2 = System.Drawing.Color.LightSkyBlue;
            this.btnGoiYSanPham.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.btnGoiYSanPham.Location = new System.Drawing.Point(1214, 464);
            this.btnGoiYSanPham.Name = "btnGoiYSanPham";
            this.btnGoiYSanPham.Size = new System.Drawing.Size(239, 71);
            this.btnGoiYSanPham.Style.ForeColor = System.Drawing.Color.SlateBlue;
            this.btnGoiYSanPham.TabIndex = 74;
            this.btnGoiYSanPham.Text = "Gợi ý sản phẩm";
            // 
            // btnAddImage
            // 
            this.btnAddImage.BorderColor = System.Drawing.Color.Transparent;
            this.btnAddImage.CornerRadius = 10;
            this.btnAddImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddImage.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.btnAddImage.GradientColor1 = System.Drawing.Color.DarkTurquoise;
            this.btnAddImage.GradientColor2 = System.Drawing.Color.DeepSkyBlue;
            this.btnAddImage.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnAddImage.Location = new System.Drawing.Point(1342, 382);
            this.btnAddImage.Name = "btnAddImage";
            this.btnAddImage.Size = new System.Drawing.Size(174, 59);
            this.btnAddImage.TabIndex = 68;
            this.btnAddImage.Text = "Thêm Ảnh";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BorderColor = System.Drawing.Color.Transparent;
            this.btnTimKiem.CornerRadius = 10;
            this.btnTimKiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimKiem.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnTimKiem.ForeColor = System.Drawing.Color.SlateBlue;
            this.btnTimKiem.GradientColor1 = System.Drawing.Color.LightPink;
            this.btnTimKiem.GradientColor2 = System.Drawing.Color.LightSkyBlue;
            this.btnTimKiem.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.btnTimKiem.Location = new System.Drawing.Point(943, 464);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(239, 71);
            this.btnTimKiem.Style.ForeColor = System.Drawing.Color.SlateBlue;
            this.btnTimKiem.TabIndex = 66;
            this.btnTimKiem.Text = "Tìm Kiếm";
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.BorderColor = System.Drawing.Color.Transparent;
            this.btnThanhToan.CornerRadius = 10;
            this.btnThanhToan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThanhToan.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnThanhToan.ForeColor = System.Drawing.Color.SlateBlue;
            this.btnThanhToan.GradientColor1 = System.Drawing.Color.LightPink;
            this.btnThanhToan.GradientColor2 = System.Drawing.Color.LightSkyBlue;
            this.btnThanhToan.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.btnThanhToan.Location = new System.Drawing.Point(675, 464);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(239, 71);
            this.btnThanhToan.Style.ForeColor = System.Drawing.Color.SlateBlue;
            this.btnThanhToan.TabIndex = 65;
            this.btnThanhToan.Text = "Thanh toán";
            // 
            // btnXoaKhoiGio
            // 
            this.btnXoaKhoiGio.BorderColor = System.Drawing.Color.Transparent;
            this.btnXoaKhoiGio.CornerRadius = 10;
            this.btnXoaKhoiGio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoaKhoiGio.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnXoaKhoiGio.ForeColor = System.Drawing.Color.SlateBlue;
            this.btnXoaKhoiGio.GradientColor1 = System.Drawing.Color.LightPink;
            this.btnXoaKhoiGio.GradientColor2 = System.Drawing.Color.LightSkyBlue;
            this.btnXoaKhoiGio.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.btnXoaKhoiGio.Location = new System.Drawing.Point(409, 464);
            this.btnXoaKhoiGio.Name = "btnXoaKhoiGio";
            this.btnXoaKhoiGio.Size = new System.Drawing.Size(239, 71);
            this.btnXoaKhoiGio.Style.ForeColor = System.Drawing.Color.SlateBlue;
            this.btnXoaKhoiGio.TabIndex = 64;
            this.btnXoaKhoiGio.Text = "Xóa khỏi giỏ";
            // 
            // btnThemVaoGio
            // 
            this.btnThemVaoGio.BorderColor = System.Drawing.Color.Transparent;
            this.btnThemVaoGio.CornerRadius = 10;
            this.btnThemVaoGio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThemVaoGio.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnThemVaoGio.ForeColor = System.Drawing.Color.SlateBlue;
            this.btnThemVaoGio.GradientColor1 = System.Drawing.Color.LightPink;
            this.btnThemVaoGio.GradientColor2 = System.Drawing.Color.LightSkyBlue;
            this.btnThemVaoGio.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.btnThemVaoGio.Location = new System.Drawing.Point(129, 464);
            this.btnThemVaoGio.Name = "btnThemVaoGio";
            this.btnThemVaoGio.Size = new System.Drawing.Size(239, 71);
            this.btnThemVaoGio.Style.ForeColor = System.Drawing.Color.SlateBlue;
            this.btnThemVaoGio.TabIndex = 63;
            this.btnThemVaoGio.Text = "Thêm vào giỏ";
            // 
            // PanelBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnGoiYSanPham);
            this.Controls.Add(this.numericQuantity);
            this.Controls.Add(this.txtMaSP);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtTenSP);
            this.Controls.Add(this.btnAddImage);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.btnXoaKhoiGio);
            this.Controls.Add(this.btnThemVaoGio);
            this.Controls.Add(this.cboLoaiSP);
            this.Controls.Add(this.pnlImageSP);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.dtgDsSP);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblLoai);
            this.Controls.Add(this.lblTenSP);
            this.Controls.Add(this.lblDonGia);
            this.Controls.Add(this.lblSoLuong);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lbl_MaSP);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "PanelBanHang";
            this.Size = new System.Drawing.Size(1572, 850);
            ((System.ComponentModel.ISupportInitialize)(this.cboLoaiSP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDsSP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenSP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaSP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GradientButtonRadiusControl.GradientRadiusButton btnAddImage;
        private GradientButtonRadiusControl.GradientRadiusButton btnTimKiem;
        private GradientButtonRadiusControl.GradientRadiusButton btnThanhToan;
        private GradientButtonRadiusControl.GradientRadiusButton btnXoaKhoiGio;
        private GradientButtonRadiusControl.GradientRadiusButton btnThemVaoGio;
        private Syncfusion.WinForms.ListView.SfComboBox cboLoaiSP;
        private System.Windows.Forms.Panel pnlImageSP;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtDescription;
        private Syncfusion.WinForms.DataGrid.SfDataGrid dtgDsSP;
        private Syncfusion.Windows.Forms.Tools.AutoLabel lblTitle;
        private Syncfusion.Windows.Forms.Tools.AutoLabel lblLoai;
        private Syncfusion.Windows.Forms.Tools.AutoLabel lblTenSP;
        private Syncfusion.Windows.Forms.Tools.AutoLabel lblDonGia;
        private Syncfusion.Windows.Forms.Tools.AutoLabel lblSoLuong;
        private Syncfusion.Windows.Forms.Tools.AutoLabel lblDescription;
        private Syncfusion.Windows.Forms.Tools.AutoLabel lbl_MaSP;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtTenSP;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtPrice;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtMaSP;
        private Syncfusion.Windows.Forms.Tools.NumericUpDownExt numericQuantity;
        private GradientButtonRadiusControl.GradientRadiusButton btnGoiYSanPham;
    }
}
