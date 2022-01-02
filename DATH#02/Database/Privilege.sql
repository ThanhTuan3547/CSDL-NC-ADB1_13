GO
USE ADB1_N13_DATH#02
-- Các quyền của khách hàng:
--		select on HOADONONLINE
--		select on CTHOADONONLINE
--		select on HOADONOFFLINE
--		select on CTHOADONOFFLINE
--		select on KHACHHANG
--		select on SANPHAM(MaSP, TENSP, LOAISP, GIA, DONVITINH, MOTA)
--		select on LOAISANPHAM
--      select on TAIKHOAN(TAIKHOANID, USERNAME)
-- add khachhang account
GO
--EXEC sp_addLogin 'khachhang','khachhang'

-- add user_khachhang for login_khachhang account
--CREATE USER user_khachhang FOR LOGIN khachhang

-- add role customer
--EXEC sp_addrole 'khach_hang'

--EXEC sp_addrolemember 'khach_hang',user_khachhang 


-- SELECT ON HOADONONLINE
GRANT SELECT
ON OBJECT::HOADONONLINE
to khach_hang

-- SELECT ON CTHOADONONLINE
GRANT SELECT 
ON OBJECT::CTHOADONONLINE
to khach_hang

-- SELECT ON HOADONOFFLINE
GRANT SELECT
ON OBJECT::HOADONOFFLINE
to khach_hang

-- SELECT ON CTHOADONOFFLINE
GRANT SELECT 
ON OBJECT::CTHOADONOFFLINE
to khach_hang


-- SELECT ON KHACHHANG
GRANT SELECT
ON OBJECT::KHACHHANG
TO khach_hang

--SELECT ON SANPHAM(MaSP, TENSP, LOAISP, GIA, DONVITINH, MOTA)
GRANT SELECT 
ON OBJECT::SANPHAM(MaSP, TENSP, LOAISP, GIA, DONVITINH, MOTA)
TO khach_hang

--SELECT ON LOAISANPHAM
GRANT SELECT 
ON OBJECT::LOAISANPHAM
TO khach_hang

--SELECT ON TAIKHOAN(TAIKHOANID, USERNAME)
GRANT SELECT 
ON OBJECT::TAIKHOAN(TAIKHOANID, USERNAME)
TO khach_hang

-- Dưới đây là các quyền của QUANTRI:
-- Nhân viên permission:
--		select, insert, update, delete on LOAISANPHAM
--		select on CHINHANH
--      select, insert, update, delete on SANPHAM
--		select on NHACUNGCAP
--      select, insert on DATHANG
--		select, insert on CTDATHANG
--		select, insert on NHAPHANG
--      select, insert on CTNHAPHANG
--      select on QUANTRI
-- add login_quantri account
--EXEC sp_addLogin 'quantri','quantri'

-- add user_quantri for login_quantri account
--CREATE USER user_quantri FOR LOGIN quantri

-- add role quan_tri
--EXEC sp_addrole 'quan_tri'

--EXEC sp_addrolemember 'quan_tri',user_quantri 

--select, insert, update, delete on LOAISANPHAM
GRANT SELECT, INSERT, UPDATE, DELETE
ON OBJECT::LOAISANPHAM
TO quan_tri

--select on CHINHANH
GRANT SELECT 
ON OBJECT::CHINHANH
TO quan_tri

--select, insert, update, delete on SANPHAM
GRANT SELECT, INSERT, UPDATE, DELETE 
ON OBJECT::SANPHAM
TO quan_tri

--select on NHACUNGCAP
GRANT SELECT
ON OBJECT::NHACUNGCAP
TO quan_tri

--select, insert, update, delete on DATHANG
GRANT SELECT, INSERT
ON OBJECT::DATHANG
TO quan_tri

--select, insert, update, delete on CTDATHANG
GRANT SELECT, INSERT
ON OBJECT::CTDATHANG
TO quan_tri

--select, insert, update, delete on NHAPHANG
GRANT SELECT, INSERT
ON OBJECT::NHAPHANG
TO quan_tri

-- select, insert, update, delete on CTNHAPHANG
GRANT SELECT, INSERT
ON OBJECT::CTNHAPHANG
TO quan_tri

-- Quan Li
-- them tai khoan doi tac login_quanli
--EXEC sp_addLogin 'login_quanli','login_quanli'
-- them user_doitac cho login_quanli
--CREATE USER user_quanli FOR LOGIN  login_quanli
-- them role quanli
--EXEC sp_addrole 'quanli'
--EXEC sp_addrolemember 'quanli',user_quanli

GRANT SELECT
ON OBJECT::dbo.KiemTraDoanhThuBanHang
TO quanli

GRANT SELECT
ON OBJECT::dbo.QuanLiHangHoaNhap
TO quanli

GRANT SELECT
ON OBJECT::dbo.CacMatHangBanChay
TO quanli

GRANT SELECT
ON OBJECT::dbo.CacMatHangBanCham
TO quanli

GRANT SELECT
ON OBJECT::SANPHAM
TO quanli

-- Nhan Su
-- them tai khoan doi tac login_nhansu
--EXEC sp_addLogin 'login_nhansu','login_nhansu'
-- them user_doitac cho login_nhansu
--CREATE USER user_nhansu FOR LOGIN  login_nhansu
-- them role nhansu
--EXEC sp_addrole 'nhansu'
--EXEC sp_addrolemember 'nhansu',user_nhansu

GRANT SELECT
ON OBJECT::NHANVIEN(MANV, TENNV, SDT, DIACHI, LOAINV, LUONG, THUONG, DOANHSOBANHANG, DIEMDANH, CMND)
TO nhansu

GRANT UPDATE
ON OBJECT::NHANVIEN(THUONG, DIEMDANH)
TO nhansu

GRANT INSERT, DELETE
ON OBJECT::NHANVIEN
TO nhansu