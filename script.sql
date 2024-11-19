CREATE DATABASE QUANLYBENXEKHACH
USE QUANLYBENXEKHACH

CREATE TABLE NGUOIDUNG (
    MaNguoiDung INT IDENTITY PRIMARY KEY, 
    TenDangNhap VARCHAR(50) UNIQUE NOT NULL,
    MatKhau VARCHAR(255) NOT NULL,
    Email VARCHAR(100) UNIQUE NOT NULL,
    VaiTro VARCHAR(255) DEFAULT 'user',
    NgayTao DATE DEFAULT GETDATE(),
    NgayCapNhat DATE DEFAULT GETDATE(),
    TrangThai INT DEFAULT 1 
);

CREATE TABLE XACMINHTAIKHOAN (
    MaXacMinh INT IDENTITY PRIMARY KEY, 
    MaNguoiDung INT NOT NULL,
    MaToken VARCHAR(6) NOT NULL,
    LoaiXacMinh VARCHAR(255) NOT NULL,
    NgayTao DATE DEFAULT GETDATE(),
    FOREIGN KEY (MaNguoiDung) REFERENCES NGUOIDUNG(MaNguoiDung) ON DELETE CASCADE ON UPDATE CASCADE
);


CREATE TABLE XEKHACH (
    MaXe INT IDENTITY PRIMARY KEY,
    BienSo VARCHAR(20) UNIQUE NOT NULL,
    LoaiXe VARCHAR(50) NOT NULL,
    SoChoNgoi INT NOT NULL,
	TenNhaXe NVARCHAR(100) NOT NULL,
    TrangThai NVARCHAR(100) DEFAULT N'Hoạt Động'  NOT NULL,
    NgayTao DATE DEFAULT GETDATE()
);

CREATE TABLE VEXE (
    MaVe INT IDENTITY PRIMARY KEY,
    MaNguoiDung INT,
    MaXe INT,
	GiaVe DECIMAL(10, 2),
    NgayDatVe DATETIME DEFAULT GETDATE(),
    TrangThaiVe VARCHAR(10) CHECK (TrangThaiVe IN ('DaDat', 'DaHuy')) NOT NULL,
    FOREIGN KEY (MaNguoiDung) REFERENCES NguoiDung(MaNguoiDung)
        ON DELETE SET NULL,
    FOREIGN KEY (MaXe) REFERENCES XeKhach(MaXe)
        ON DELETE CASCADE
);


CREATE TABLE BAOCAO (
    MaBaoCao INT IDENTITY PRIMARY KEY,
    MaNguoiDung INT,
    TenBaoCao NVARCHAR(255),
    GhiChu TEXT, 
    ThoiGianLap DATETIME DEFAULT GETDATE(),
    SoVeBanDuoc INT DEFAULT 0,  
    TongDoanhThu DECIMAL(15, 2) DEFAULT 0.00,  
    FOREIGN KEY (MaNguoiDung) REFERENCES NguoiDung(MaNguoiDung)
        ON DELETE SET NULL
);


CREATE TABLE LICHTRINH (
    MaLichTrinh INT IDENTITY PRIMARY KEY,
    MaXe INT,
    TuyenDuong VARCHAR(255) NOT NULL,
    NgayKhoiHanh DATE NOT NULL,
    GioKhoiHanh TIME NOT NULL,
    TrangThai VARCHAR(10) CHECK (TrangThai IN ('HoatDong', 'Huy')) NOT NULL,
    FOREIGN KEY (MaXe) REFERENCES XeKhach(MaXe)
        ON DELETE CASCADE
);

CREATE TABLE DOANHTHU (
    MaDoanhThu INT IDENTITY PRIMARY KEY, 
    MaXe INT NOT NULL,
    Ngay DATE NOT NULL, 
    TongDoanhThu DECIMAL(15, 2) NOT NULL,
    NgayTao DATETIME DEFAULT GETDATE(),
    FOREIGN KEY (MaXe) REFERENCES XeKhach(MaXe)
        ON DELETE CASCADE
        ON UPDATE CASCADE
);

-- DỮ LIỆU MẪU

-- Insert 5 records for NGUOIDUNG
INSERT INTO NGUOIDUNG (TenDangNhap, MatKhau, Email, VaiTro, NgayTao, NgayCapNhat, TrangThai)
VALUES
('user1', 'password1', 'user1@example.com', 'user', '2024-11-18', '2024-11-18', 1),
('admin1', 'password2', 'admin1@example.com', 'admin', '2024-11-18', '2024-11-18', 1),
('manager1', 'password3', 'manager1@example.com', 'staff', '2024-11-18', '2024-11-18', 1),
('user2', 'password4', 'user2@example.com', 'user', '2024-11-18', '2024-11-18', 1),
('user3', 'password5', 'user3@example.com', 'user', '2024-11-18', '2024-11-18', 1);

-- Insert 25 records for XEKHACH
INSERT INTO XEKHACH (BienSo, LoaiXe, SoChoNgoi, TenNhaXe, TrangThai, NgayTao)
VALUES
('29A-12345', 'Bus', 40, 'Nha Xe 1', 'Hoạt Động', '2024-11-18'),
('29B-23456', 'Limousine', 12, 'Nha Xe 2', 'Hoạt Động', '2024-11-18'),
('29C-34567', 'Van', 20, 'Nha Xe 3', 'Hoạt Động', '2024-11-18'),
('29D-45678', 'Bus', 50, 'Nha Xe 4', 'Hoạt Động', '2024-11-18'),
('29E-56789', 'Van', 18, 'Nha Xe 5', 'Hoạt Động', '2024-11-18'),
('29F-67890', 'Limousine', 10, 'Nha Xe 6', 'Hoạt Động', '2024-11-18'),
('29G-78901', 'Bus', 45, 'Nha Xe 7', 'Hoạt Động', '2024-11-18'),
('29H-89012', 'Van', 22, 'Nha Xe 8', 'Hoạt Động', '2024-11-18'),
('29I-90123', 'Limousine', 8, 'Nha Xe 9', 'Hoạt Động', '2024-11-18'),
('29J-01234', 'Bus', 40, 'Nha Xe 10', 'Hoạt Động', '2024-11-18'),
('29K-12345', 'Van', 24, 'Nha Xe 11', 'Hoạt Động', '2024-11-18'),
('29L-23456', 'Limousine', 12, 'Nha Xe 12', 'Hoạt Động', '2024-11-18'),
('29M-34567', 'Bus', 35, 'Nha Xe 13', 'Hoạt Động', '2024-11-18'),
('29N-45678', 'Van', 18, 'Nha Xe 14', 'Hoạt Động', '2024-11-18'),
('29O-56789', 'Limousine', 10, 'Nha Xe 15', 'Hoạt Động', '2024-11-18'),
('29P-67890', 'Bus', 45, 'Nha Xe 16', 'Hoạt Động', '2024-11-18'),
('29Q-78901', 'Van', 22, 'Nha Xe 17', 'Hoạt Động', '2024-11-18'),
('29R-89012', 'Limousine', 8, 'Nha Xe 18', 'Hoạt Động', '2024-11-18'),
('29S-90123', 'Bus', 40, 'Nha Xe 19', 'Hoạt Động', '2024-11-18'),
('29T-01234', 'Van', 24, 'Nha Xe 20', 'Hoạt Động', '2024-11-18'),
('29U-12345', 'Limousine', 12, 'Nha Xe 21', 'Hoạt Động', '2024-11-18'),
('29V-23456', 'Bus', 50, 'Nha Xe 22', 'Hoạt Động', '2024-11-18'),
('29W-34567', 'Van', 18, 'Nha Xe 23', 'Hoạt Động', '2024-11-18'),
('29X-45678', 'Limousine', 10, 'Nha Xe 24', 'Hoạt Động', '2024-11-18'),
('29Y-56789', 'Bus', 45, 'Nha Xe 25', 'Hoạt Động', '2024-11-18');

-- Insert 25 records for VEXE
INSERT INTO VEXE (MaNguoiDung, MaXe, NgayDatVe, TrangThaiVe, GiaVe)
VALUES
(1, 1, '2024-11-18 08:00:00', 'DaDat', 100000),
(2, 2, '2024-11-18 09:00:00', 'DaHuy', 120000),
(3, 3, '2024-11-18 10:00:00', 'DaDat', 110000),
(4, 4, '2024-11-18 11:00:00', 'DaHuy', 130000),
(5, 5, '2024-11-18 12:00:00', 'DaDat', 100000),
(1, 6, '2024-11-18 13:00:00', 'DaHuy', 125000),
(2, 7, '2024-11-18 14:00:00', 'DaDat', 115000),
(3, 8, '2024-11-18 15:00:00', 'DaHuy', 135000),
(4, 9, '2024-11-18 16:00:00', 'DaDat', 110000),
(5, 10, '2024-11-18 17:00:00', 'DaHuy', 120000),
(1, 11, '2024-11-18 18:00:00', 'DaDat', 105000),
(2, 12, '2024-11-18 19:00:00', 'DaHuy', 130000),
(3, 13, '2024-11-18 20:00:00', 'DaDat', 100000),
(4, 14, '2024-11-18 21:00:00', 'DaHuy', 115000),
(5, 15, '2024-11-18 22:00:00', 'DaDat', 120000),
(1, 16, '2024-11-18 23:00:00', 'DaHuy', 125000),
(2, 17, '2024-11-19 00:00:00', 'DaDat', 110000),
(3, 18, '2024-11-19 01:00:00', 'DaHuy', 135000),
(4, 19, '2024-11-19 02:00:00', 'DaDat', 100000),
(5, 20, '2024-11-19 03:00:00', 'DaHuy', 125000),
(1, 21, '2024-11-19 04:00:00', 'DaDat', 115000),
(2, 22, '2024-11-19 05:00:00', 'DaHuy', 130000),
(3, 23, '2024-11-19 06:00:00', 'DaDat', 100000),
(4, 24, '2024-11-19 07:00:00', 'DaHuy', 120000),
(5, 25, '2024-11-19 08:00:00', 'DaDat', 105000);

INSERT INTO BAOCAO (NguoiLapBaoCao, TenBaoCao, GhiChu, ThoiGianLap, SoVeBanDuoc, TongDoanhThu)
VALUES
(1, 'Bao Cao 1', 'Ghi chu 1', '2024-11-18 08:00:00', 100, 5000.00),
(2, 'Bao Cao 2', 'Ghi chu 2', '2024-11-18 09:00:00', 150, 7500.00),
(3, 'Bao Cao 3', 'Ghi chu 3', '2024-11-18 10:00:00', 200, 10000.00),
(4, 'Bao Cao 4', 'Ghi chu 4', '2024-11-18 11:00:00', 120, 6000.00),
(5, 'Bao Cao 5', 'Ghi chu 5', '2024-11-18 12:00:00', 130, 6500.00),
(1, 'Bao Cao 6', 'Ghi chu 6', '2024-11-18 13:00:00', 110, 5500.00),
(2, 'Bao Cao 7', 'Ghi chu 7', '2024-11-18 14:00:00', 140, 7000.00),
(3, 'Bao Cao 8', 'Ghi chu 8', '2024-11-18 15:00:00', 160, 8000.00),
(4, 'Bao Cao 9', 'Ghi chu 9', '2024-11-18 16:00:00', 170, 8500.00),
(5, 'Bao Cao 10', 'Ghi chu 10', '2024-11-18 17:00:00', 180, 9000.00),
(1, 'Bao Cao 11', 'Ghi chu 11', '2024-11-18 18:00:00', 190, 9500.00),
(2, 'Bao Cao 12', 'Ghi chu 12', '2024-11-18 19:00:00', 150, 7500.00),
(3, 'Bao Cao 13', 'Ghi chu 13', '2024-11-18 20:00:00', 200, 10000.00),
(4, 'Bao Cao 14', 'Ghi chu 14', '2024-11-18 21:00:00', 120, 6000.00),
(5, 'Bao Cao 15', 'Ghi chu 15', '2024-11-18 22:00:00', 130, 6500.00),
(1, 'Bao Cao 16', 'Ghi chu 16', '2024-11-18 23:00:00', 110, 5500.00),
(2, 'Bao Cao 17', 'Ghi chu 17', '2024-11-19 00:00:00', 140, 7000.00),
(3, 'Bao Cao 18', 'Ghi chu 18', '2024-11-19 01:00:00', 160, 8000.00),
(4, 'Bao Cao 19', 'Ghi chu 19', '2024-11-19 02:00:00', 170, 8500.00),
(5, 'Bao Cao 20', 'Ghi chu 20', '2024-11-19 03:00:00', 180, 9000.00),
(1, 'Bao Cao 21', 'Ghi chu 21', '2024-11-19 04:00:00', 190, 9500.00),
(2, 'Bao Cao 22', 'Ghi chu 22', '2024-11-19 05:00:00', 150, 7500.00),
(3, 'Bao Cao 23', 'Ghi chu 23', '2024-11-19 06:00:00', 200, 10000.00),
(4, 'Bao Cao 24', 'Ghi chu 24', '2024-11-19 07:00:00', 120, 6000.00),
(5, 'Bao Cao 25', 'Ghi chu 25', '2024-11-19 08:00:00', 130, 6500.00);


-- Insert 25 records for LICHTRINH
INSERT INTO LICHTRINH (MaXe, TuyenDuong, NgayKhoiHanh, GioKhoiHanh, TrangThai)
VALUES
(1, 'Ha Noi - Quang Ninh', '2024-11-18', '08:00', 'HoatDong'),
(2, 'HCM - Vung Tau', '2024-11-18', '09:00', 'HoatDong'),
(3, 'Da Nang - Hue', '2024-11-18', '10:00', 'HoatDong'),
(4, 'HCM - Bien Hoa', '2024-11-18', '11:00', 'HoatDong'),
(5, 'Ha Noi - Lao Cai', '2024-11-18', '12:00', 'HoatDong'),
(6, 'Ha Noi - Quang Ninh', '2024-11-18', '13:00', 'HoatDong'),
(7, 'HCM - Vung Tau', '2024-11-18', '14:00', 'HoatDong'),
(8, 'Da Nang - Hue', '2024-11-18', '15:00', 'HoatDong'),
(9, 'HCM - Bien Hoa', '2024-11-18', '16:00', 'HoatDong'),
(10, 'Ha Noi - Lao Cai', '2024-11-18', '17:00', 'HoatDong'),
(11, 'Ha Noi - Quang Ninh', '2024-11-18', '18:00', 'HoatDong'),
(12, 'HCM - Vung Tau', '2024-11-18', '19:00', 'HoatDong'),
(13, 'Da Nang - Hue', '2024-11-18', '20:00', 'HoatDong'),
(14, 'HCM - Bien Hoa', '2024-11-18', '21:00', 'HoatDong'),
(15, 'Ha Noi - Lao Cai', '2024-11-18', '22:00', 'HoatDong'),
(16, 'Ha Noi - Quang Ninh', '2024-11-19', '08:00', 'HoatDong'),
(17, 'HCM - Vung Tau', '2024-11-19', '09:00', 'HoatDong'),
(18, 'Da Nang - Hue', '2024-11-19', '10:00', 'HoatDong'),
(19, 'HCM - Bien Hoa', '2024-11-19', '11:00', 'HoatDong'),
(20, 'Ha Noi - Lao Cai', '2024-11-19', '12:00', 'HoatDong'),
(21, 'Ha Noi - Quang Ninh', '2024-11-19', '13:00', 'HoatDong'),
(22, 'HCM - Vung Tau', '2024-11-19', '14:00', 'HoatDong'),
(23, 'Da Nang - Hue', '2024-11-19', '15:00', 'HoatDong'),
(24, 'HCM - Bien Hoa', '2024-11-19', '16:00', 'HoatDong'),
(25, 'Ha Noi - Lao Cai', '2024-11-19', '17:00', 'HoatDong');

-- Insert 25 records for DOANHTHU
INSERT INTO DOANHTHU (MaXe, Ngay, TongDoanhThu)
VALUES
(1, '2024-11-18', 1000000),
(2, '2024-11-18', 1500000),
(3, '2024-11-18', 2000000),
(4, '2024-11-18', 1800000),
(5, '2024-11-18', 1200000),
(6, '2024-11-18', 1300000),
(7, '2024-11-18', 1400000),
(8, '2024-11-18', 1600000),
(9, '2024-11-18', 1700000),
(10, '2024-11-18', 2100000),
(11, '2024-11-18', 2200000),
(12, '2024-11-18', 2300000),
(13, '2024-11-18', 2400000),
(14, '2024-11-18', 2500000),
(15, '2024-11-18', 2600000),
(16, '2024-11-18', 2700000),
(17, '2024-11-18', 2800000),
(18, '2024-11-18', 2900000),
(19, '2024-11-18', 3000000),
(20, '2024-11-18', 3100000),
(21, '2024-11-18', 3200000),
(22, '2024-11-18', 3300000),
(23, '2024-11-18', 3400000),
(24, '2024-11-18', 3500000),
(25, '2024-11-18', 3600000);

