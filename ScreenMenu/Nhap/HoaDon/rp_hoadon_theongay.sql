-- Author:		Vo Tu
-- Create date: <13/11/2023>
set dateformat dmy
DROP PROCEDURE IF EXISTS rp_hoadon_theongay
GO
CREATE PROCEDURE rp_hoadon_theongay
	@ngay date
AS
BEGIN
	Select hd.MAHD,hd.NGAYHOADON,hd.TONGTHANHTIEN,nv.HOTENNV,kh.HOTENKH
	from HOADON hd
	INNER Join NHANVIEN nv on hd.MANV = nv.MANV
	INNER Join KHACHHANG kh on hd.MAKH = kh.MAKH
	where hd.NGAYHOADON = @ngay
END
GO
exec rp_hoadon_theongay '1-01-2022'
select * from HOADON
