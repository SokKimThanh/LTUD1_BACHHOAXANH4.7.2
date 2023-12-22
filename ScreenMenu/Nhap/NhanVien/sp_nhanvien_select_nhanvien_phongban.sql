-- Author:		Sok Kim Thanh
-- Create date: <06/12/2023 10:57 CH>
go
drop procedure if exists sp_nhanvien_select_nhanvien_phongban
go
CREATE PROCEDURE sp_nhanvien_select_nhanvien_phongban
	@tennhanvien nvarchar(255)
AS
BEGIN
    SELECT nv.MANV as NhanVienID, pb.MAPB as PhongBanID, nv.HOTENNV as N'Họ và tên', pb.TENPHG as N'Tên phòng ban'
	FROM NHANVIEN nv, PHONGBAN pb
    where nv.MAPB = PB.MAPB and nv.hotennv like N'%' + @tennhanvien + '%'
	order by nv.created_date_nv desc 
END;
go
exec sp_nhanvien_select_nhanvien_phongban null
