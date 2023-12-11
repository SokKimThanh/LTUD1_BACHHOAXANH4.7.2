-- Author:		Sok Kim Thanh
-- Create date: <06/12/2023 10:57 CH>
drop procedure if exists sp_nhanvien_select_all_all
go
CREATE PROCEDURE sp_nhanvien_select_all_all
AS
BEGIN
    SELECT 
       
        NV.MANV AS NhanVienID,
        PB.MAPB AS PhongBanID,
        NV.HOTENNV AS 'Họ và tên',
        PB.TENPHG AS 'Tên phòng ban'
        
    FROM 
        NHANVIEN NV,
		PHONGBAN PB
    where NV.MAPB = PB.MAPB
	order by nv.created_date_nv desc;
END;
go

 
