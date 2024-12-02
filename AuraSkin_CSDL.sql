use master
go
create database AuraSkin
go
use AuraSkin
go

-- Bảng Users (Người dùng)
CREATE TABLE Users (
    id_user VARCHAR(10) PRIMARY KEY,
    username VARCHAR(50) UNIQUE NOT NULL,
    password VARCHAR(50),
    full_name NVARCHAR(255),
    gender NVARCHAR(10) CHECK (gender IN (N'Nam', N'Nữ')),
    phone_number NVARCHAR(20),
    email NVARCHAR(255),
    address NVARCHAR(MAX)
);

-- Bảng Categories (Danh mục sản phẩm)
CREATE TABLE Categories (
    id_category VARCHAR(10) PRIMARY KEY,
    category_name NVARCHAR(255) UNIQUE NOT NULL,
    is_active BIT NOT NULL DEFAULT 1
);

-- Bảng Supplier (Nhà cung cấp)
CREATE TABLE Supplier (
    id_supplier VARCHAR(10) PRIMARY KEY,
    supplier_name NVARCHAR(255) UNIQUE NOT NULL,
    email NVARCHAR(255),
    phone_number NVARCHAR(20),
    address NVARCHAR(MAX)
);

-- Bảng Sale (Khuyến mãi)
CREATE TABLE Sale (
    id_sale VARCHAR(10) PRIMARY KEY,
    id_user VARCHAR(10) FOREIGN KEY REFERENCES Users(id_user),
    description NVARCHAR(MAX),
    start_date DATE NOT NULL,
    end_date DATE NOT NULL,
    percent_sale DECIMAL(5, 2) NOT NULL CHECK (percent_sale BETWEEN 0 AND 100),
    is_active BIT NOT NULL DEFAULT 1
);

-- Bảng Products (Sản phẩm)
CREATE TABLE Products (
    id_product VARCHAR(10) PRIMARY KEY,
    id_category VARCHAR(10) FOREIGN KEY REFERENCES Categories(id_category),
    id_supplier VARCHAR(10) FOREIGN KEY REFERENCES Supplier(id_supplier),
    id_sale VARCHAR(10) FOREIGN KEY REFERENCES Sale(id_sale),
    product_name NVARCHAR(255) UNIQUE NOT NULL,
    default_price DECIMAL(18, 2) NOT NULL,
    description NVARCHAR(MAX),
    default_image NVARCHAR(MAX),
    stock_quantity INT NOT NULL CHECK (stock_quantity >= 0), -- Quản lý số lượng tồn kho trực tiếp
    is_active BIT NOT NULL DEFAULT 1
);

-- Bảng Status Order (Trạng thái đơn hàng)
CREATE TABLE StatusOrder (
    id_status VARCHAR(10) PRIMARY KEY,
    status_name NVARCHAR(50) UNIQUE NOT NULL,
    is_active BIT NOT NULL DEFAULT 1
);

-- Bảng Customer Info (Thông tin khách hàng)
CREATE TABLE CustomerInfo (
    id_customer_info VARCHAR(10) PRIMARY KEY,
    customer_name NVARCHAR(255),
    gender NVARCHAR(10) CHECK (gender IN (N'Nam', N'Nữ')),
    contact_number NVARCHAR(20),
    address_line NVARCHAR(255),
    ward NVARCHAR(255),
    district NVARCHAR(255),
    province NVARCHAR(255),
    country NVARCHAR(255)
);

-- Bảng Orders (Đơn hàng)
CREATE TABLE Orders (
    id_order VARCHAR(10) PRIMARY KEY,
    id_user VARCHAR(10) FOREIGN KEY REFERENCES Users(id_user),
    id_status VARCHAR(10) FOREIGN KEY REFERENCES StatusOrder(id_status),
    create_at DATETIME NOT NULL DEFAULT GETDATE(),
    delivery_fee DECIMAL(18, 2) DEFAULT 0,
    total_amount DECIMAL(18, 2) NOT NULL,
    customer_info VARCHAR(10) FOREIGN KEY REFERENCES CustomerInfo (id_customer_info)
);

-- Bảng Order Items (Chi tiết đơn hàng)
CREATE TABLE OrderItems (
    id_order VARCHAR(10) FOREIGN KEY REFERENCES Orders(id_order),
    id_product VARCHAR(10) FOREIGN KEY REFERENCES Products(id_product),
    quantity INT NOT NULL CHECK (quantity > 0),
    PRIMARY KEY (id_order, id_product)
);

-- Tạo các chỉ mục
CREATE INDEX idx_product_name ON Products (product_name);
CREATE INDEX idx_order_user ON Orders (id_user);



INSERT INTO Users (id_user, username, password, full_name, gender, phone_number, email, address)
VALUES
('USR001', 'admin', '123', N'Nguyễn Minh Hoàng', N'Nam', '0901234567', 'a@example.com', 'Hồ Chí Minh'),
('USR002', 'nguyenthb', 'abcdef', N'Nguyễn Thị B', N'Nữ', '0907654321', 'b@example.com', 'Hà Nội'),
('USR003', 'levanc', '123abc', N'Lê Văn C', N'Nam', '0912345678', 'c@example.com', 'Đà Nẵng'),
('USR004', 'tranthid', 'pass123', N'Trần Thị D', N'Nữ', '0934567890', 'd@example.com', 'Cần Thơ'),
('USR005', 'hoangvane', 'qwerty', N'Hoàng Văn E', N'Nam', '0923456789', 'e@example.com', 'Huế');


INSERT INTO Categories (id_category, category_name, is_active)
VALUES
('CAT001', N'Dược liệu', 1),
('CAT002', N'Thực phẩm chức năng', 1),
('CAT003', N'Mỹ phẩm thiên nhiên', 1),
('CAT004', N'Tinh dầu', 1),
('CAT005', N'Trái cây sấy', 1);


INSERT INTO Supplier (id_supplier, supplier_name, email, phone_number, address)
VALUES
('SUP001', N'Nhà cung cấp A', 'nccA@example.com', '0911222333', N'Hà Nội'),
('SUP002', N'Nhà cung cấp B', 'nccB@example.com', '0922333444', N'Hồ Chí Minh'),
('SUP003', N'Nhà cung cấp C', 'nccC@example.com', '0933444555', N'Đà Nẵng'),
('SUP004', N'Nhà cung cấp D', 'nccD@example.com', '0944555666', N'Cần Thơ'),
('SUP005', N'Nhà cung cấp E', 'nccE@example.com', '0955666777', N'Huế');


INSERT INTO Sale (id_sale, id_user, description, start_date, end_date, percent_sale, is_active)
VALUES
('SAL001', 'USR001', N'Khuyến mãi đầu năm', '2024-01-01', '2024-01-15', 10, 1),
('SAL002', 'USR002', N'Giảm giá mùa hè', '2024-06-01', '2024-06-15', 15, 1),
('SAL003', 'USR003', N'Ưu đãi tháng 8', '2024-08-01', '2024-08-10', 5, 1),
('SAL004', 'USR004', N'Tri ân khách hàng', '2024-12-01', '2024-12-15', 20, 1),
('SAL005', 'USR005', N'Giảm giá cuối năm', '2024-12-20', '2024-12-31', 25, 1);


INSERT INTO Products (id_product, id_category, id_supplier, id_sale, product_name, default_price, description, default_image, stock_quantity, is_active)
VALUES
('PRO001', 'CAT001', 'SUP001', 'SAL001', N'Cây lược vàng', 50000, N'Dùng để chữa bệnh xương khớp', NULL, 100, 1),
('PRO002', 'CAT002', 'SUP002', 'SAL002', N'Nghệ đen', 150000, N'Tăng cường sức đề kháng', NULL, 50, 1),
('PRO003', 'CAT003', 'SUP003', 'SAL003', N'Mặt nạ bơ', 80000, N'Dưỡng da hiệu quả', NULL, 200, 1),
('PRO004', 'CAT004', 'SUP004', NULL, N'Tinh dầu quế', 120000, N'Tăng cường lưu thông khí huyết', NULL, 80, 1),
('PRO005', 'CAT005', 'SUP005', NULL, N'Trái cây sấy thập cẩm', 60000, N'Thực phẩm tiện dụng và bổ dưỡng', NULL, 150, 1);


INSERT INTO StatusOrder (id_status, status_name, is_active)
VALUES
('STA001', N'Chờ xác nhận', 1),
('STA002', N'Đang giao hàng', 1),
('STA003', N'Hoàn thành', 1),
('STA004', N'Đã hủy', 1),
('STA005', N'Hoàn tiền', 1);

INSERT INTO CustomerInfo (id_customer_info, customer_name, gender, contact_number, address_line, ward, district, province, country)
VALUES
('CUS001', N'Nguyễn Văn A', N'Nam', '0901234567', N'123 Đường A', N'Phường 1', N'Quận 1', N'Hồ Chí Minh', N'Việt Nam'),
('CUS002', N'Nguyễn Thị B', N'Nữ', '0907654321', N'456 Đường B', N'Phường 2', N'Quận 2', N'Hà Nội', N'Việt Nam'),
('CUS003', N'Lê Văn C', N'Nam', '0912345678', N'789 Đường C', N'Phường 3', N'Quận 3', N'Đà Nẵng', N'Việt Nam'),
('CUS004', N'Trần Thị D', N'Nữ', '0934567890', N'321 Đường D', N'Phường 4', N'Quận 4', N'Cần Thơ', N'Việt Nam'),
('CUS005', N'Hoàng Văn E', N'Nam', '0923456789', N'654 Đường E', N'Phường 5', N'Quận 5', N'Huế', N'Việt Nam');


INSERT INTO Orders (id_order, id_user, id_status, create_at, delivery_fee, total_amount, customer_info)
VALUES
('ORD001', 'USR001', 'STA001', '2024-01-05', 20000, 70000, 'CUS001'),
('ORD002', 'USR002', 'STA002', '2024-01-06', 15000, 165000, 'CUS002'),
('ORD003', 'USR003', 'STA003', '2024-01-07', 25000, 95000, 'CUS003'),
('ORD004', 'USR004', 'STA004', '2024-01-08', 10000, 130000, 'CUS004'),
('ORD005', 'USR005', 'STA005', '2024-01-09', 0, 50000, 'CUS005');


INSERT INTO OrderItems (id_order, id_product, quantity)
VALUES
('ORD001', 'PRO001', 2),
('ORD002', 'PRO002', 1),
('ORD003', 'PRO003', 3),
('ORD004', 'PRO004', 1),
('ORD005', 'PRO005', 2);

