use ADB1_N13_DATH#02

drop index tentaikhoan_taikhoan on TAIKHOAN

exec DangNhap 'taikhoan34', 12345 

create index tentaikhoan_taikhoan on TAIKHOAN(username)

exec DangNhap 'taikhoan34', 12345 

select top 100 * from TAIKHOAN 