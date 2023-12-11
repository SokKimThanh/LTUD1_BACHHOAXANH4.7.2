
-- =============================================
-- Author:		Vo Tu
-- Create date: <13/11/2023>
-- Description:	<Mô tả>
-- =============================================
DROP PROCEDURE IF EXISTS sp_khachhang_TimKiem
GO
CREATE PROCEDURE sp_khachhang_TimKiem
	-- Add the parameters for the stored procedure here
	@ma nvarchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Delete statements for procedure here
	Select hd.MAHD,hd.NGAYHOADON,hd.TONGTHANHTIEN,nv.HOTENNV,kh.HOTENKH
	from HOADON hd
	INNER Join NHANVIEN nv on hd.MANV = nv.MANV
	INNER Join KHACHHANG kh on hd.MAKH = kh.MAKH
	where hd.MAHD like N'%'+@ma+'%' or kh.HOTENKH like N'%'+@ma+'%' or nv.HOTENNV like N'%'+@ma+'%'
	 
END
GO
exec sp_khachhang_TimKiem HD01
