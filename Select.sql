select * from XEKHACH
select * from VEXE
select * from NGUOIDUNG
select * from LICHTRINH
select * from BAOCAO
SELECT * FROM LOAIVE

select count(*) from VEXE where TrangThaiVe=N'Đã Đặt'

select * from VEXE where TrangThaiVe = N'Đã Đặt'




-- báo cáo theo doanh thu
SELECT 
    XK.MaXe,
    XK.BienSo,
    XK.TenNhaXe,
    XK.LoaiXe,
    COUNT(VX.MaVe) AS SoLuongVeBanDuoc,
    SUM(LV.GiaVe) AS TongDoanhThu
FROM XEKHACH XK
LEFT JOIN VEXE VX ON XK.MaXe = VX.MaXe
LEFT JOIN LOAIVE LV ON VX.LoaiVe = LV.LoaiVe
WHERE VX.TrangThaiVe = N'Đã Đặt' -- Chỉ tính vé đã đặt
GROUP BY XK.MaXe, XK.BienSo, XK.TenNhaXe, XK.LoaiXe
ORDER BY TongDoanhThu DESC; -- Sắp xếp theo doanh thu giảm dần

 SELECT 
     CONVERT(DATE, VX.NgayDatVe) AS NgayGiaoDich,
     VX.MaVe,
     VX.LoaiVe,
     COUNT(VX.MaVe) AS SoLuongVeBanDuoc,
     SUM(LV.GiaVe) AS TongDoanhThu
 FROM VEXE VX
 INNER JOIN LOAIVE LV ON VX.LoaiVe = LV.LoaiVe
 WHERE CONVERT(DATE, VX.NgayDatVe) = CONVERT(DATE, GETDATE()) -- Lấy ngày hiện tại
   AND VX.TrangThaiVe = N'Đã Đặt' -- Chỉ tính vé đã đặt thành công
 GROUP BY 
     CONVERT(DATE, VX.NgayDatVe),
     VX.MaVe,
     VX.LoaiVe
 ORDER BY NgayGiaoDich, TongDoanhThu DESC;


-- loại xe
SELECT 
    XK.LoaiXe,
    COUNT(VX.MaVe) AS SoLuongVeBanDuoc,
    SUM(LV.GiaVe) AS TongDoanhThu
FROM XEKHACH XK
LEFT JOIN VEXE VX ON XK.MaXe = VX.MaXe
LEFT JOIN LOAIVE LV ON VX.LoaiVe = LV.LoaiVe
WHERE VX.TrangThaiVe = N'Đã Đặt' -- Chỉ tính vé đã đặt
GROUP BY XK.LoaiXe
ORDER BY TongDoanhThu DESC; -- Sắp xếp theo doanh thu giảm dần

SELECT 
    XK.TenNhaXe,
    COUNT(VX.MaVe) AS SoLuongVeBanDuoc,
    SUM(LV.GiaVe) AS TongDoanhThu
FROM XEKHACH XK
LEFT JOIN VEXE VX ON XK.MaXe = VX.MaXe
LEFT JOIN LOAIVE LV ON VX.LoaiVe = LV.LoaiVe
WHERE VX.TrangThaiVe = N'Đã Đặt' -- Chỉ tính vé đã đặt
GROUP BY XK.TenNhaXe
ORDER BY TongDoanhThu DESC; -- Sắp xếp theo doanh thu giảm dần





SELECT 
    CONVERT(DATE, VX.NgayDatVe) AS N'Ngày giao dịch',
    VX.LoaiVe as N'Loại vé', 
    COUNT(VX.MaVe) AS N'Số lượng vé bán được',  
    SUM(LV.GiaVe) AS N'Tổng doanh thu' 
FROM VEXE VX
INNER JOIN LOAIVE LV ON VX.LoaiVe = LV.LoaiVe
WHERE CONVERT(DATE, VX.NgayDatVe) = CONVERT(DATE, GETDATE())
  AND VX.TrangThaiVe = N'Đã Đặt'
GROUP BY 
    CONVERT(DATE, VX.NgayDatVe),
    VX.LoaiVe
ORDER BY CONVERT(DATE, VX.NgayDatVe) ASC, SUM(LV.GiaVe) DESC; 
