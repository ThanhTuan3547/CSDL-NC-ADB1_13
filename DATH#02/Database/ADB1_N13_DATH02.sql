﻿create database ADB1_N13_DATH#02
go
use ADB1_N13_DATH#02
go
--go use master drop database ADB1_N13_DATH#02
CREATE TABLE TAIKHOAN
(
	TAIKHOANID VARCHAR(20) NOT NULL PRIMARY KEY,
	USERNAME VARCHAR(20) NOT NULL,
	PASSWORDTK VARCHAR(30) NOT NULL,
	LOAITK CHAR(2) -- Khach hang: KH, Nhan vien: NV, Quan tri: QT, Quan Li: QL
)
GO

CREATE TABLE LOAISANPHAM
(
	MALOAI INT NOT NULL PRIMARY KEY,
	TENLOAI NVARCHAR(30) NOT NULL,
)
GO
CREATE TABLE SANPHAM
(
	MASP INT NOT NULL PRIMARY KEY,
	TENSP NVARCHAR(50) NOT NULL,
	LOAISP INT NOT NULL,
	GIA MONEY NOT NULL,
	DONVITINH NVARCHAR(20),
	MOTA NVARCHAR(200),
	SOLUONGTON INT NOT NULL,
	CONSTRAINT chk_slt CHECK(SOLUONGTON >= 0),
	FOREIGN KEY (LOAISP) REFERENCES LOAISANPHAM(MALOAI),
)
GO
CREATE TABLE NHANVIEN
(
	MANV INT NOT NULL PRIMARY KEY,
	IDTAIKHOAN VARCHAR(20) NOT NULL,
	TENNV NVARCHAR(30) NOT NULL,
	SDT VARCHAR(10),
	DIACHI NVARCHAR(100),
	LOAINV NVARCHAR(30),
	LUONG MONEY,
	THUONG MONEY,
	DOANHSOBANHANG MONEY,
	DIEMDANH INT,
	CMND CHAR(12),
)
GO
 CREATE TABLE KHACHHANG
 (
	MAKH INT NOT NULL PRIMARY KEY,
	IDTAIKHOAN VARCHAR(20) NOT NULL,
	TENKH NVARCHAR(30) NOT NULL,
	SDT VARCHAR(10),
	DIACHI NVARCHAR(100),
	LOAIKH VARCHAR(10),
 )
 GO
 CREATE TABLE CHINHANH
 (
	MACN INT NOT NULL PRIMARY KEY,
	DIACHICN NVARCHAR(100),
	SDTCN VARCHAR(10),
 )
 GO

 CREATE TABLE NHACUNGCAP
 (
	MANCC INT NOT NULL PRIMARY KEY,
	TENNCC NVARCHAR(30) NOT NULL,
	DIACHI NVARCHAR(100),
	SDT VARCHAR(10),
 )
 GO

 CREATE TABLE DATHANG
 (
	MADATHANG INT NOT NULL PRIMARY KEY,
	MANCC INT NOT NULL,
	MACN INT NOT NULL,
	NGAYDAT DATE,
	FOREIGN KEY (MANCC) REFERENCES NHACUNGCAP(MANCC),
	FOREIGN KEY (MACN) REFERENCES CHINHANH(MACN),
 )
GO
CREATE TABLE CTDATHANG
(
	MADATHANG INT NOT NULL,
	MASP INT NOT NULL,
	SOLUONGDAT INT NOT NULL,
	CONSTRAINT chk_sld CHECK(SOLUONGDAT >= 0),
	FOREIGN KEY (MADATHANG) REFERENCES DATHANG (MADATHANG),
	FOREIGN KEY (MASP) REFERENCES SANPHAM (MASP),
	CONSTRAINT PK_CTDATHANG PRIMARY KEY (MADATHANG, MASP),
)
GO
 CREATE TABLE NHAPHANG
 (
	MANHAPHANG INT NOT NULL PRIMARY KEY,
	MADATHANG INT NOT NULL,
	MANCC INT NOT NULL,
	MACN INT NOT NULL,
	NGAYNHAP DATE,
	TONGTIENNHAP MONEY NOT NULL,
	FOREIGN KEY (MADATHANG) REFERENCES DATHANG (MADATHANG),
	FOREIGN KEY (MANCC) REFERENCES NHACUNGCAP (MANCC),
	FOREIGN KEY (MACN) REFERENCES CHINHANH (MACN),
 )
 GO
 CREATE TABLE CTNHAPHANG
 (
	MANHAPHANG INT NOT NULL,
	MASP INT NOT NULL,
	SOLUONGNHAP INT NOT NULL,
	CONSTRAINT chk_sln CHECK(SOLUONGNHAP >= 0),
	GIATIEN MONEY NOT NULL,
	THANHTIEN MONEY NOT NULL,
	FOREIGN KEY (MANHAPHANG) REFERENCES NHAPHANG (MANHAPHANG),
	FOREIGN KEY (MASP) REFERENCES SANPHAM (MASP),
	CONSTRAINT PK_CTNHAPHANG PRIMARY KEY (MANHAPHANG, MASP),
 )
 GO
 CREATE TABLE HOADONONLINE
 (
	MAHOADON INT NOT NULL PRIMARY KEY,
	MAKH INT NOT NULL,
	SDT VARCHAR(10) NOT NULL,
	NGAYLAP DATE NOT NULL,
	DIACHIGIAOHANG NVARCHAR(100) NOT NULL,
	HINHTHUCTHANHTOAN NVARCHAR(30) NOT NULL,
	DONVIVANCHUYEN NVARCHAR(30) NOT NULL,
	PHIVANCHUYEN MONEY,
	TONGTIEN MONEY default 0,
	FOREIGN KEY (MAKH) REFERENCES KHACHHANG (MAKH),
 )
 GO
  CREATE TABLE CTHOADONONLINE
 (
	MAHOADON INT NOT NULL,
	MASP INT NOT NULL,
	SOLUONG INT NOT NULL,
	CONSTRAINT chk_slon CHECK(SOLUONG >= 0),
	GIATIEN MONEY NOT NULL,
	THANHTIEN MONEY NOT NULL,
	FOREIGN KEY (MAHOADON) REFERENCES HOADONONLINE(MAHOADON),
	FOREIGN KEY (MASP) REFERENCES SANPHAM(MASP),
	CONSTRAINT PK_CTHOADONONLINE PRIMARY KEY (MAHOADON, MASP),
 )
 GO
 CREATE TABLE HOADONOFFLINE
 (
	MAHOADON INT NOT NULL PRIMARY KEY,
	MAKH INT NOT NULL,
	MACN INT NOT NULL,
	MANV INT NOT NULL,
	NGAYLAP DATE NOT NULL,
	TONGTIEN MONEY default 0,
	FOREIGN KEY (MAKH) REFERENCES KHACHHANG(MAKH),
	FOREIGN KEY (MACN) REFERENCES CHINHANH(MACN),
	FOREIGN KEY (MANV) REFERENCES NHANVIEN(MANV),
 )
 GO
 CREATE TABLE CTHOADONOFFLINE
 (
	MAHOADON INT NOT NULL,
	MASP INT NOT NULL,
	SOLUONG INT NOT NULL,
	CONSTRAINT chk_sloff CHECK(SOLUONG >= 0),
	GIATIEN MONEY NOT NULL,
	THANHTIEN MONEY NOT NULL,
	FOREIGN KEY (MAHOADON) REFERENCES HOADONOFFLINE(MAHOADON),
	FOREIGN KEY (MASP) REFERENCES SANPHAM(MASP),
	CONSTRAINT PK_CTHOADONOFFLINE PRIMARY KEY (MAHOADON, MASP),
 )

 CREATE TABLE QUANTRI
 (
	MAQT INT NOT NULL PRIMARY KEY,
	IDTAIKHOAN VARCHAR(20) NOT NULL,
	TEN nvarchar(30),
	SĐT varchar(10)
 )
GO
ALTER TABLE NHANVIEN
ADD CONSTRAINT FK_TAIKHOAN_NHANVIEN
	FOREIGN KEY (IDTAIKHOAN) REFERENCES TAIKHOAN(TAIKHOANID)
GO
ALTER TABLE KHACHHANG
ADD CONSTRAINT FK_TAIKHOAN_KHACHHANG
	FOREIGN KEY (IDTAIKHOAN) REFERENCES TAIKHOAN(TAIKHOANID)
GO
ALTER TABLE QUANTRI
ADD CONSTRAINT FK_TAIKHOAN_QUANTRI
	FOREIGN KEY (IDTAIKHOAN) REFERENCES TAIKHOAN(TAIKHOANID)
GO
