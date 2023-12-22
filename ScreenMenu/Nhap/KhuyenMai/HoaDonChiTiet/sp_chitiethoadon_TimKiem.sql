-- Author:		Vo Tu
-- Create date: <13/11/2023>
DROP PROCEDURE IF EXISTS sp_chitiethoadon_TimKiem
GO
CREATE PROCEDURE sp_chitiethoadon_TimKiem
	@ma nvarchar(50),
	@tensp nvarchar(50)
AS
BEGIN
	Select cthd.MAHD,sp.TENSP,cthd.SLMUA,sp.DONGIA*cthd.SLMUA as N'Thành tiền'
	from CHITIETHD cthd
	INNER Join SANPHAM sp on sp.MASP = cthd.MASP
	where cthd.MAHD = @ma and sp.TENSP like N'%'+@tensp+'%'
END
GO
exec sp_chitiethoadon_TimKiem 'HD01','B'
