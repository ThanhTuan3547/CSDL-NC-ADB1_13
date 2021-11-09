﻿create database ADB_DA1
go
use ADB_DA1
go
--drop database ADB_DA1
-- use master
-- Khach hang
create table KHACHHANG
(
	MaKH char(10) NOT NULL primary key,
	Ho nvarchar(10) NOT NULL,
	Ten nvarchar(10) NOT NULL,
	NgSinh date NOT NULL,
	SoNha char(10) NOT NULL,
	Duong nvarchar(30) NOT NULL,
	Phuong nvarchar(30) NOT NULL,
	Quan nvarchar(30) NOT NULL,
	Tpho nvarchar(30) NOT NULL,
	DienThoai char(10) NOT NULL,
)
go
-- San pham
create table SANPHAM
(
	MaSP char(10) NOT NULL primary key,
	TenSP nvarchar(50) NOT NULL,
	SoLuongTon int NOT NULL,
	Mota nvarchar(100) NULL,
	Gia money NOT NULL
)
go
-- Hoa don
create table HOADON
(
	MaHD char(10) NOT NULL primary key,
	MaKH char(10) NOT NULL,
	NgayLap date NOT NULL,
	TongTien money default 0,
	constraint chk_NgayLap CHECK(NgayLap >= '2020-05-01' AND NgayLap <= '2021-06-30'),
	foreign key (MaKH) references KHACHHANG (MaKH)
)
go
-- Chi tiet hoa don
create table CTHOADON
(
	MaHD char(10) NOT NULL,
	MaSP char(10) NOT NULL,
	foreign key (MaHD) references HOADON (MaHD),
	foreign key (MaSP) references SANPHAM (MaSP),
	constraint PK_CTHOADON primary key (MaHD, MaSP),
	SoLuong int,
	GiaBan money NOT NULL,
	GiaGiam money NOT NULL,
	ThanhTien money NOT NULL,
)	

--go
--UPDATE HOADON
--SET HOADON.TongTien = CTHOADON.ThanhTien 
--from HOADON inner join CTHOADON on (HOADON.MaHD = CTHOADON.MaHD);

-- trigger 

-- a: thành tiền CTHD = Số lượng * (Giá bán - giá giảm) 
go
create trigger ThanhTien_CT_HoaDon on CTHoaDon
for update, insert 
as 
if update(giaban) or update (giagiam) or update (soluong)
begin update cthoadon 
	set ThanhTien = i.SoLuong * (i.GiaBan - i.GiaGiam)
	from inserted I --join CTHOADON ct on I.MaHD = ct.MaHD and I.MaSP = ct.MaSP
	where cthoadon.MaHD = i.MaHD and CTHOADON.MaSP = i.MaSP
end 
go 

-- b: tổng tiền(mahd) = sum(ThanhTien)cthd(mahd)
go
create trigger TongTien_HoaDon on CTHOADON 
for insert, update 
as  
if update(giaban) or update(giagiam) or update (soluong) 
begin 
	UPDATE HOADON
	SET TongTien = (SELECT SUM(CT.ThanhTien)
				FROM CTHOADON CT
				WHERE CT.MaHD = HOADON.MaHD)
	WHERE MaHD in (select inserted.mahd from inserted) 
END
go
-- trigger cho delete tren CTHOADON 
create trigger TongTien_DonHang_delete on CTHOADON
for delete 
as 
	UPDATE HOADON
	SET TongTien = (SELECT SUM(CT.ThanhTien) 
				FROM CTHOADON CT
				WHERE CT.MaHD = HOADON.MaHD)
	WHERE MaHD in (select deleted.mahd from deleted)

go
