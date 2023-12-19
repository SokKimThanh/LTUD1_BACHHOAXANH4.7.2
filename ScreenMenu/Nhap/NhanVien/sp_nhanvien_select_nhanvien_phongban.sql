-- Author:		Sok Kim Thanh
-- Create date: <06/12/2023 10:57 CH>
go
drop procedure if exists sp_nhanvien_select_nhanvien_phongban
go
CREATE PROCEDURE sp_nhanvien_select_nhanvien_phongban
AS
BEGIN
    SELECT nv.MANV as NhanVienID, pb.MAPB as PhongBanID, nv.HOTENNV as 'H? v� t�n', pb.TENPHG as 'T�n ph�ng ban'
	FROM NHANVIEN nv, PHONGBAN pb
    where nv.MAPB = PB.MAPB
	order by nv.created_date_nv desc
END;
go
--exec sp_nhanvien_select_nhanvien_phongban
