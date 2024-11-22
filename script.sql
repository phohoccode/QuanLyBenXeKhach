CREATE DATABASE QUANLYBENXEKHACH
USE QUANLYBENXEKHACH

CREATE TABLE NGUOIDUNG (
    MaNguoiDung INT IDENTITY PRIMARY KEY, 
    TenDangNhap NVARCHAR(50) UNIQUE NOT NULL,
    MatKhau VARCHAR(255) NOT NULL,  
    Email VARCHAR(100) UNIQUE NOT NULL,
    VaiTro VARCHAR(50) DEFAULT 'user', 
    NgayTao DATETIME DEFAULT GETDATE(),
    NgayCapNhat DATETIME DEFAULT GETDATE(),
    TrangThai BIT DEFAULT 1 
);


CREATE TABLE XACMINHTAIKHOAN (
    MaXacMinh INT IDENTITY PRIMARY KEY, 
    MaNguoiDung INT NOT NULL,
    MaToken CHAR(6) NOT NULL,
    LoaiXacMinh VARCHAR(50) NOT NULL CHECK (LoaiXacMinh IN ('KichHoat', 'QuenMatKhau')),
    NgayTao DATETIME DEFAULT GETDATE(),
    FOREIGN KEY (MaNguoiDung) REFERENCES NGUOIDUNG(MaNguoiDung) 
        ON DELETE CASCADE ON UPDATE CASCADE
);


CREATE TABLE XEKHACH (
    MaXe INT IDENTITY PRIMARY KEY,
    BienSo NVARCHAR(20) UNIQUE NOT NULL,
    LoaiXe NVARCHAR(50) NOT NULL,
    SoChoNgoi INT NOT NULL CHECK (SoChoNgoi > 0), 
    TenNhaXe NVARCHAR(100) NOT NULL,
    TrangThai NVARCHAR(20) DEFAULT N'Hoạt Động' CHECK (TrangThai IN (N'Hoạt Động', N'Ngừng Hoạt Động', N'Bảo Trì')),
    NgayTao DATETIME DEFAULT GETDATE()
);

CREATE TABLE LOAIVE (
    LoaiVe NVARCHAR(50) PRIMARY KEY, 
    GiaVe DECIMAL(10, 2) NOT NULL CHECK (GiaVe >= 0)
);


CREATE TABLE VEXE (
    MaVe INT IDENTITY PRIMARY KEY,
    MaNguoiDung INT NULL, -- Cho phép NULL nếu khách không có tài khoản
    MaXe INT NOT NULL,
    LoaiVe NVARCHAR(50) NOT NULL, -- Loại vé
    NgayDatVe DATETIME DEFAULT GETDATE(),
    TrangThaiVe NVARCHAR(10) NOT NULL CHECK (TrangThaiVe IN (N'Đã Đặt', N'Đã Hủy')), -- Trạng thái vé có dấu
    FOREIGN KEY (MaNguoiDung) REFERENCES NGUOIDUNG(MaNguoiDung)
        ON DELETE SET NULL,
    FOREIGN KEY (MaXe) REFERENCES XEKHACH(MaXe)
        ON DELETE CASCADE,
    FOREIGN KEY (LoaiVe) REFERENCES LOAIVE(LoaiVe) -- Tham chiếu đến bảng LOAIVE
);


CREATE TABLE LICHTRINH (
    MaLichTrinh INT IDENTITY PRIMARY KEY,
    MaXe INT,
    TuyenDuong NVARCHAR(255) NOT NULL,
    NgayKhoiHanh DATE NOT NULL,
    GioKhoiHanh TIME NOT NULL,
    TrangThai NVARCHAR(50) DEFAULT N'Hoạt động' CHECK (TrangThai IN (N'Hoạt động', N'Huỷ')) NOT NULL,
    FOREIGN KEY (MaXe) REFERENCES XeKhach(MaXe)
        ON DELETE CASCADE
);




-- dữ liệu bảng người dùng
INSERT INTO NGUOIDUNG (TenDangNhap, MatKhau, Email, VaiTro, NgayTao, NgayCapNhat, TrangThai)
VALUES
(N'Nguyễn Văn Anh', '123456', 'nguyen.anh@example.com', 'user', '2024-11-18', '2024-11-18', 1),
(N'Lê Thị Bích', 'admin123', 'le.bich@example.com', 'staff', '2024-11-18', '2024-11-18', 1),
(N'Trần Hồng Dương', 'manager456', 'duong.hong@example.com', 'staff', '2024-11-18', '2024-11-18', 1),
(N'Phạm Quốc Hiếu', 'password789', 'hieu.quoc@example.com', 'user', '2024-11-18', '2024-11-18', 1),
(N'Quản trị viên', 'admin123', 'admin@example.com', 'admin', '2024-11-18', '2024-11-18', 1),
(N'Hoàng Thị Sao', 'sao123', 'hoang.sao@example.com', 'user', '2024-11-18', '2024-11-18', 1),
(N'Vũ Minh Quang', 'quang123', 'minh.quang@example.com', 'user', '2024-11-18', '2024-11-18', 1),
(N'Đào Thiên Kim', 'kim123', 'thien.kim@example.com', 'staff', '2024-11-18', '2024-11-18', 1),
(N'Ngô Duy Hòa', 'hoa456', 'duy.hoa@example.com', 'user', '2024-11-18', '2024-11-18', 1),
(N'Bùi Thị Lan', 'lan789', 'lan.bui@example.com', 'user', '2024-11-18', '2024-11-18', 1),
(N'Lý Hải Nam', 'nam123', 'hai.nam@example.com', 'admin', '2024-11-18', '2024-11-18', 1),
(N'Đặng Minh Quý', 'minh123', 'quy.dang@example.com', 'staff', '2024-11-18', '2024-11-18', 1),
(N'Cao Thị Lan', 'lan123', 'cao.lan@example.com', 'user', '2024-11-18', '2024-11-18', 1),
(N'Trương Quỳnh Anh', 'anh456', 'quynh.anh@example.com', 'staff', '2024-11-18', '2024-11-18', 1),
(N'Phan Tiến Thành', 'thanh123', 'tien.thanh@example.com', 'user', '2024-11-18', '2024-11-18', 1),
(N'Dương Hoàng Sơn', 'son123', 'hoang.son@example.com', 'user', '2024-11-18', '2024-11-18', 1);



-- dữ liệu bảng xe khách
INSERT INTO XEKHACH (BienSo, LoaiXe, SoChoNgoi, TenNhaXe, NgayTao)
VALUES
('29A-12345', 'Bus', 40, N'Nhà Xe An Bình', '2024-11-18'),
('29B-23456', 'Limousine', 12, N'Nhà Xe Thành Công', '2024-11-18'),
('29C-34567', 'Van', 20, N'Nhà Xe Minh Tuấn', '2024-11-18'),
('29D-45678', 'Bus', 50, N'Nhà Xe Hoàng Sơn', '2024-11-18'),
('29E-56789', 'Van', 18, N'Nhà Xe Hòa Bình', '2024-11-18'),
('29F-67890', 'Limousine', 10, N'Nhà Xe Vạn Tường', '2024-11-18'),
('29G-78901', 'Bus', 45, N'Nhà Xe Long Hải', '2024-11-18'),
('29H-89012', 'Van', 22, N'Nhà Xe Duy Minh', '2024-11-18'),
('29I-90123', 'Limousine', 8, N'Nhà Xe Bảo Anh', '2024-11-18'),
('29J-01234', 'Bus', 40, N'Nhà Xe Đại Phát', '2024-11-18'),
('29K-12345', 'Van', 24, N'Nhà Xe Tân Cảng', '2024-11-18'),
('29L-23456', 'Limousine', 12, N'Nhà Xe Cát Tường', '2024-11-18'),
('29M-34567', 'Bus', 35, N'Nhà Xe Quang Duy', '2024-11-18'),
('29N-45678', 'Van', 18, N'Nhà Xe Ngọc Lan', '2024-11-18'),
('29O-56789', 'Limousine', 10, N'Nhà Xe Quốc Anh', '2024-11-18'),
('29P-67890', 'Bus', 45, N'Nhà Xe Minh Kiên', '2024-11-18'),
('29Q-78901', 'Van', 22, N'Nhà Xe Lộc An', '2024-11-18'),
('29R-89012', 'Limousine', 8, N'Nhà Xe Thành Đạt', '2024-11-18'),
('29S-90123', 'Bus', 40, N'Nhà Xe Việt Lâm', '2024-11-18'),
('29T-01234', 'Van', 24, N'Nhà Xe Hữu Hạnh', '2024-11-18'),
('29U-12345', 'Limousine', 12, N'Nhà Xe Sơn Tùng', '2024-11-18'),
('29V-23456', 'Bus', 50, N'Nhà Xe Đoàn Kết', '2024-11-18'),
('29W-34567', 'Van', 18, N'Nhà Xe Hải Đăng', '2024-11-18'),
('29X-45678', 'Limousine', 10, N'Nhà Xe Hoàng Gia', '2024-11-18'),
('29Y-56789', 'Bus', 45, N'Nhà Xe Minh Đức', '2024-11-18');


-- dữ liệu bảng loại vé
INSERT INTO LOAIVE (LoaiVe, GiaVe) VALUES
(N'Vé Thường', 100000),
(N'Vé Vip', 200000),
(N'Vé Giường Nằm', 300000),
(N'Vé Giảm Giá', 80000),
(N'Vé Khuyến Mại', 60000),
(N'Vé Một Chiều', 120000),
(N'Vé Hai Chiều', 220000),
(N'Vé Đoàn', 180000),
(N'Vé Gói Combo', 250000);

-- dữ liệu bảng vé xe
DECLARE @NgayHienTai DATETIME = GETDATE();

INSERT INTO VEXE (MaNguoiDung, MaXe, NgayDatVe, TrangThaiVe, LoaiVe)
VALUES
(1, 1, @NgayHienTai, N'Đã Đặt', N'Vé Thường'),
(2, 2, @NgayHienTai, N'Đã Hủy', N'Vé Vip'),
(3, 3, @NgayHienTai, N'Đã Đặt', N'Vé Giường Nằm'),
(4, 4, @NgayHienTai, N'Đã Hủy', N'Vé Giảm Giá'),
(5, 5, @NgayHienTai, N'Đã Đặt', N'Vé Khuyến Mại'),
(6, 6, @NgayHienTai, N'Đã Đặt', N'Vé Một Chiều'),
(7, 7, @NgayHienTai, N'Đã Hủy', N'Vé Hai Chiều'),
(8, 8, @NgayHienTai, N'Đã Đặt', N'Vé Đoàn'),
(9, 9, @NgayHienTai, N'Đã Hủy', N'Vé Gói Combo'),
(1, 10, @NgayHienTai, N'Đã Đặt', N'Vé Thường'),
(2, 1, @NgayHienTai, N'Đã Đặt', N'Vé Vip'),
(3, 2, @NgayHienTai, N'Đã Hủy', N'Vé Giường Nằm'),
(4, 3, @NgayHienTai, N'Đã Đặt', N'Vé Giảm Giá'),
(5, 4, @NgayHienTai, N'Đã Hủy', N'Vé Khuyến Mại'),
(6, 5, @NgayHienTai, N'Đã Đặt', N'Vé Một Chiều'),
(7, 6, @NgayHienTai, N'Đã Đặt', N'Vé Hai Chiều'),
(7, 7, DATEADD(DAY, 1, @NgayHienTai), N'Đã Hủy', N'Vé Đoàn'),
(9, 8, DATEADD(DAY, 1, @NgayHienTai), N'Đã Đặt', N'Vé Gói Combo'),
(10, 9, DATEADD(DAY, 1, @NgayHienTai), N'Đã Hủy', N'Vé Thường');


-- Dữ liệu bảng lịch trình

INSERT INTO LICHTRINH (MaXe, TuyenDuong, NgayKhoiHanh, GioKhoiHanh)
VALUES
(1, N'Ha Noi - Quang Ninh', '2024-11-18', '08:00:00'),
(2, N'TP. Hồ Chí Minh - Vũng Tàu', '2024-11-18', '09:00:00'),
(3, N'Đà Nẵng - Hội An', '2024-11-18', '10:00:00'),
(4, N'Hà Nội - Hải Phòng', '2024-11-18', '11:00:00'),
(5, N'TP. Hồ Chí Minh - Tây Ninh', '2024-11-18', '12:00:00'),
(6, N'Hải Phòng - Quảng Ninh', '2024-11-18', '13:00:00'),
(7, N'Đà Nẵng - Huế', '2024-11-18', '14:00:00'),
(8, N'TP. Hồ Chí Minh - Đồng Nai', '2024-11-18', '15:00:00'),
(9, N'Hà Nội - Vĩnh Phúc', '2024-11-18', '16:00:00'),
(10, N'Hà Nội - Bắc Giang', '2024-11-18', '17:00:00'),
(11, N'TP. Hồ Chí Minh - Bình Dương', '2024-11-18', '18:00:00'),
(12, N'Đà Nẵng - Quảng Nam', '2024-11-18', '19:00:00'),
(13, N'Hà Nội - Lào Cai', '2024-11-18', '20:00:00'),
(14, N'TP. Hồ Chí Minh - Bình Thuận', '2024-11-18', '21:00:00'),
(15, N'Hà Nội - Sơn La', '2024-11-18', '22:00:00'),
(16, N'Hà Nội - Nam Định', '2024-11-18', '23:00:00'),
(17, N'TP. Hồ Chí Minh - Long An', '2024-11-19', '00:00:00'),
(18, N'Hà Nội - Thái Nguyên', '2024-11-19', '01:00:00'),
(19, N'Đà Nẵng - Quảng Trị', '2024-11-19', '02:00:00'),
(20, N'TP. Hồ Chí Minh - Tiền Giang', '2024-11-19', '03:00:00'),
(21, N'Hà Nội - Thanh Hóa', '2024-11-19', '04:00:00'),
(22, N'TP. Hồ Chí Minh - Bà Rịa', '2024-11-19', '05:00:00'),
(23, N'Đà Nẵng - Phú Yên', '2024-11-19', '06:00:00'),
(24, N'Hà Nội - Nghệ An', '2024-11-19', '07:00:00'),
(25, N'TP. Hồ Chí Minh - Vĩnh Long', '2024-11-19', '08:00:00');
