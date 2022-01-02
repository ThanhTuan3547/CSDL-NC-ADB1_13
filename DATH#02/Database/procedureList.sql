﻿--1: Đăng nhập 
use ADB1_N13_DATH#02
go
create proc DangNhap
(	
	@TK varchar(20),
	@MK varchar(30)
	
)
 
as
begin tran 	

	if exists(select * from TaiKhoan
						where TaiKhoan.USERNAME = @TK and TaiKhoan.PASSWORDTK = @MK) 
		
		begin
			print (N'Đăng nhập thành công')

			declare @Loai char(2),
					@MaNguoiDung int, 
					@idTaiKhoan varchar(20) 
			set @MaNguoiDung = -1
			select @Loai = LOAITK
			from TaiKhoan
			where TaiKhoan.USERNAME = @TK
			
			select @idTaiKhoan = TAIKHOANID
			from TAIKHOAN 
			where TaiKhoan.USERNAME = @TK

			if @Loai  = 'NV'
			begin 
				select @MaNguoiDung = MaNV	 
				from NHANVIEN 
				where NHANVIEN.IDTAIKHOAN = @idTaiKhoan	
			end
			else if @Loai = 'KH' 
			begin  
				select @MaNguoiDung = MaKH 
				from KHACHHANG 
				where IDTAIKHOAN = @idTaiKhoan 
			end 
			else
			begin  
				select @MaNguoiDung = MAQT 
				from QUANTRI 
				where IDTAIKHOAN = @idTaiKhoan 
			end 
			select @Loai as LoaiTK, @MaNguoiDung as MaSoNguoiDung
		end

	else 
		begin 
			raiserror(N'Tài khoản hoặc mật khẩu không đúng',16,1);
		end
 IF @@TRANCOUNT > 0 COMMIT TRAN
go 



go  
--2 thêm đơn hàng online 

create proc ThemDonHangOnline (
	@MAHOADON INT ,
	@MAKH INT  ,
	@SDT VARCHAR(10)  ,
	@NGAYLAP DATE  ,
	@DIACHIGIAOHANG NVARCHAR(100)  ,
	@HINHTHUCTHANHTOAN NVARCHAR(30)  ,
	@DONVIVANCHUYEN NVARCHAR(30)  ,
	@PHIVANCHUYEN MONEY,
	@TONGTIEN MONEY  
)
as 
begin tran
	insert into HOADONONLINE values (@MAHOADON, @MAKH, @SDT, Cast(@NGAYLAP as datetime),@DIACHIGIAOHANG, @HINHTHUCTHANHTOAN,@DONVIVANCHUYEN,@PHIVANCHUYEN, @TONGTIEN)
	commit tran
go 


--3 tạo mã hóa đơn online: 

create proc TaoMaHoaDonMoi(
	@maHoaDon int
)
as 
begin tran 
	set @maHoaDon = (select  top 1 MAHOADON 
	from HOADONONLINE
	 order by (MAHOADON) desc) + 1
	 select @maHoaDon
	 commit tran  

go

--4: thêm chi tiết đơn hàng online 

create proc ThemCTDHOnline (
	@MAHOADON INT  ,
	@MASP INT  ,
	@SOLUONG INT  ,
	@GIATIEN MONEY  ,
	@THANHTIEN MONEY 
)
as  
begin tran 
	insert into CTHOADONONLINE values (@MAHOADON, @MASP, @SOLUONG, @GIATIEN, @THANHTIEN)	
	commit tran
go 

--5: xem lịch sử mua hàng 

create proc XemLichSuMuaHang (
	@MaKH int
)
as
begin tran 

	select sp.TENSP, cthd.MASP,cthd.GIATIEN, cthd.MAHOADON, cthd.NGAYLAP, cthd.THANHTIEN, cthd.SOLUONG
	from 
	(select hd.MAHOADON, hd.NGAYLAP, ct.MASP, ct.GIATIEN, ct.THANHTIEN, ct.SOLUONG
	from 
			(select hd.MAHOADON, hd.NGAYLAP
			from HOADONONLINE hd 
			where hd.MAKH = @MaKH) hd join CTHOADONONLINE ct on hd.MAHOADON = ct.MAHOADON) cthd join sanpham sp on cthd.MASP = sp.MASP
	commit tran 
	
	
--6: xem tất cả sản phẩm trong cửa hàng: 

--10: Điểm danh
create proc DiemDanh(@username varchar(20))
as 
begin
	UPDATE NHANVIEN 
	SET DIEMDANH = DIEMDANH + 1
	FROM NHANVIEN nv, TAIKHOAN tk
	WHERE nv.IDTAIKHOAN = tk.TAIKHOANID AND tk.USERNAME = @username
end
go
--