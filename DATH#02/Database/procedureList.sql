--1: Đăng nhập 


create proc DangNhap
(	
	@TK varchar(20),
	@MK varchar(20)
	
)
 
as
begin tran 	

	if exists(select * from TaiKhoan
						where TaiKhoan.TenTaiKhoan = @TK and TaiKhoan.MatKhau = @MK) 
		
		begin
			print (N'Đăng nhập thành công')

		if not exists (select * from TaiKhoan 
					where TaiKhoan.TenTaiKhoan = @TK and TaiKhoan.MatKhau = @MK)
			begin 
				
				raiserror(N'Không tìm thấy thông tin tài khoản này',16,1)
				rollback Tran  
			end
		else 
			begin 
				declare @Loai char(2),
						@MaNguoiDung int
				set @MaNguoiDung = -1
				select @Loai = PhanLoai
				from TaiKhoan
				where TaiKhoan.TenTaiKhoan = @TK
					if (@Loai = 'KH')
						begin
							select @MaNguoiDung  = MaKH
							from TaiKhoan tk join KhachHang  kh on tk.TenTaiKhoan = kh.TenTaiKhoan 
						end
					else if (@Loai = 'DT')
						begin
							select @MaNguoiDung = dt.MaDoiTac 
							from TaiKhoan tk join DOITAC dt on tk.TenTaiKhoan = dt.TenTaiKhoan
						end 
					select @MaNguoiDung as MaNguoiDung,
							@Loai as LoaiTaiKhoan
			end
	end
	else 
		begin 
			raiserror(N'Tài khoản hoặc mật khẩu không đúng',16,1);
		end
 IF @@TRANCOUNT > 0 COMMIT TRAN
go 

select * from CTHOADONONLINE

go  
--2 thêm đơn hàng online 

alter proc ThemDonHangOnline (
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
	insert into HOADONONLINE values (@MAHOADON, @MAKH, @SDT, Cast(@NGAYLAP as datetime), @HINHTHUCTHANHTOAN,@DONVIVANCHUYEN,@PHIVANCHUYEN, @TONGTIEN)

go 


--3 tạo mã hóa đơn online: 

alter proc TaoMaHoaDonMoi(
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

alter proc ThemCTDHOnline (
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

