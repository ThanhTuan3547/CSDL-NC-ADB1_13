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