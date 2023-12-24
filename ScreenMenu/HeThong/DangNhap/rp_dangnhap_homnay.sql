-- Author:		Sok Kim Thanh
-- Create date: <24/12/2023>
-- Description:	<theo doi dang nhap>
DROP PROCEDURE IF EXISTS rp_dangnhap_homnay
GO
CREATE PROCEDURE rp_dangnhap_homnay
AS
BEGIN
	Select tk.TENTK as N'Tên tài khoản'
		,nv.HOTENNV as N'Nhân viên'
		,tc.THOIDIEM as N'Thời gian đăng nhập'
		,tc.KETQUA N'Kết quả'  
	FROM taikhoan tk, nhanvien nv, truycap tc  
	WHERE tk.manv = nv.manv and tk.tentk = tc.tentk
	and CAST(tc.THOIDIEM AS DATE) = CAST(GETDATE() AS DATE)
	ORDER BY tc.THOIDIEM
END;
go
EXEC rp_dangnhap_homnay;