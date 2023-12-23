-- Author:		Vo Tu
-- Create date: <13/11/2023>
DROP PROCEDURE IF EXISTS rp_hoadon_timkiem
GO
CREATE PROCEDURE rp_hoadon_timkiem
	@ma nvarchar(50)
AS
BEGIN
	Select hd.MAHD,hd.NGAYHOADON,hd.TONGTHANHTIEN,nv.HOTENNV,kh.HOTENKH
	from HOADON hd
	INNER Join NHANVIEN nv on hd.MANV = nv.MANV
	INNER Join KHACHHANG kh on hd.MAKH = kh.MAKH
	where hd.MAHD like N'%'+@ma+'%' 
	or kh.HOTENKH like N'%'+@ma+'%' 
	or nv.HOTENNV like N'%'+@ma+'%'
END
GO
exec rp_hoadon_timkiem 'a'
