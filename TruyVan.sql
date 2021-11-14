go
use ADB1_N13_DATH#01
go
DECLARE @StartTime datetime
DECLARE @EndTime datetime
-- a. Cho danh sach hoa don lap trong nam 2020
SELECT @StartTime=GETDATE() 
select *
from HOADON hd
where year(hd.NgayLap) = 2020
SELECT @EndTime=GETDATE()
SELECT DATEDIFF(MS,@StartTime,@EndTime) AS [Thoi gian thuc thi cau a]
-- b. Cho danh sach khach hang o TPHCM
SELECT @StartTime=GETDATE() 
select *
from KHACHHANG kh
where kh.Tpho = N'TPHCM'
SELECT @EndTime=GETDATE()
SELECT DATEDIFF(MS,@StartTime,@EndTime) AS [Thoi gian thuc thi cau b]
-- c. Cho danh sach cac san pham co gia trong mot khoang tu ... den ...
SELECT @StartTime=GETDATE() 
select *
from SANPHAM sp
where sp.Gia > 100000 and sp.Gia < 500000
SELECT @EndTime=GETDATE()
SELECT DATEDIFF(MS,@StartTime,@EndTime) AS [Thoi gian thuc thi cau c]
-- d. Cho danh sach cac san pham co so luong ton < 100
SELECT @StartTime=GETDATE() 
select * 
from SANPHAM sp
where sp.SoLuongTon < 100
SELECT @EndTime=GETDATE()
SELECT DATEDIFF(MS,@StartTime,@EndTime) AS [Thoi gian thuc thi cau d]
-- e. Cho danh sach cac san pham ban chay nhat (so luong ban nhieu nhat)
SELECT @StartTime=GETDATE() 
SELECT sp.MaSP, sp.TenSP, sp.Mota, sp.SoLuongTon, sp.Gia FROM SANPHAM sp
WHERE SP.MaSP IN (SELECT TOP(10) C.MASP FROM CTHoaDon C INNER JOIN HOADON H 
			ON C.maHD = H.maHD GROUP BY C.MaSP ORDER BY SUM(C.SoLuong) DESC)
SELECT @EndTime=GETDATE()
SELECT DATEDIFF(MS,@StartTime,@EndTime) AS [Thoi gian thuc thi cau e]
-- f. cho danh sach cac san pham co doanh thu cao nhat
SELECT @StartTime=GETDATE() 
select sp.MaSP, sp.TenSP, sp.Mota, sp.SoLuongTon, sp.Gia--, MAX(sp.DoanhThu) as DoanhThu
FROM SANPHAM sp
WHERE SP.MaSP IN (SELECT TOP(10) C.MASP FROM CTHoaDon C INNER JOIN HOADON H 
			ON C.maHD = H.maHD GROUP BY C.MaSP ORDER BY SUM(C.ThanhTien) DESC)
SELECT @EndTime=GETDATE()
--This will return execution time of your query
SELECT DATEDIFF(MS,@StartTime,@EndTime) AS [Thoi gian thuc thi cau f]
--a. Select * from A join B join C on.... Và Select * from A,B,C where A.x = B.x....
SELECT @StartTime=GETDATE() 
Select * from SANPHAM s join cthoadon ct on s.MASP = CT.MASP join HOADON h on CT.MaHD = H.MAHD 
SELECT @EndTime=GETDATE()
--This will return execution time of your query
SELECT DATEDIFF(MS,@StartTime,@EndTime) AS [Thoi gian thuc thi cau 5a1]
--------------------------
SELECT @StartTime=GETDATE() 
Select * from SANPHAM s, cthoadon ct, HOADON h where s.masp = ct.MaSP and ct.MaHD = H.MAHD 
SELECT @EndTime=GETDATE()
--This will return execution time of your query
SELECT DATEDIFF(MS,@StartTime,@EndTime) AS [Thoi gian thuc thi cau 5a2]
--b. Select * from A jọin B (A có số dòng nhỏ, B rất lớn) và Select * from B join A
SELECT @StartTime=GETDATE() 
Select * from SANPHAM s join cthoadon ct on s.MASP = CT.MASP
SELECT @EndTime=GETDATE()
--This will return execution time of your query
SELECT DATEDIFF(MS,@StartTime,@EndTime) AS [Thoi gian thuc thi cau 5b1]
--------------------------------
SELECT @StartTime=GETDATE() 
Select * from cthoadon ct join sanpham s on ct.MASP = s.MASP 
SELECT @EndTime=GETDATE()
--This will return execution time of your query
SELECT DATEDIFF(MS,@StartTime,@EndTime) AS [Thoi gian thuc thi cau 5b2]
