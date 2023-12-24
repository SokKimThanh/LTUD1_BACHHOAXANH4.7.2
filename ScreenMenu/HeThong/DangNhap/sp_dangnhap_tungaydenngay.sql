set dateformat dmy
-- Author:		Sok Kim Thanh
-- Create date: <16/11/2023>
-- Description:	<quan ly dang nhap tu ngay den ngay>
DROP PROCEDURE IF EXISTS sp_dangnhap_tungaydenngay
GO
CREATE PROCEDURE sp_dangnhap_tungaydenngay
	@tungay datetime,
	@denngay datetime,
	@tentk char(30)
AS
BEGIN
	Select tk.TENTK as N'Tên tài khoản'
		,nv.HOTENNV as N'Nhân viên'
		,format(tc.THOIDIEM,'dd/MM/yyy HH:mm:ss tt') as N'Thời gian đăng nhập'
		--,tc.THOIDIEM as N'Thời gian đăng nhập'
		,tc.KETQUA N'Kết quả'  
	FROM taikhoan tk, nhanvien nv, truycap tc  
	WHERE tk.manv = nv.manv and tk.tentk = tc.tentk
	and tc.THOIDIEM >= isnull(@tungay,getdate()) 
	and tc.THOIDIEM <= isnull(@denngay,getdate()) 
	and tk.TENTK = isnull(@tentk,tk.TENTK)
	ORDER BY tc.THOIDIEM
END;
go

DECLARE @StartDate datetime
DECLARE @EndDate datetime

SET @StartDate = '2023-01-01 08:00:00'
SET @EndDate = '2023-01-02 20:00:00'

SELECT 
    DATEDIFF(hour, @StartDate, @EndDate) as 'Hours',
    DATEDIFF(minute, @StartDate, @EndDate) % 60 as 'Minutes',
    DATEDIFF(second, @StartDate, @EndDate) % 60 as 'Seconds'

	
exec sp_dangnhap_tungaydenngay '2023-24-12','2023-24-12','admin'