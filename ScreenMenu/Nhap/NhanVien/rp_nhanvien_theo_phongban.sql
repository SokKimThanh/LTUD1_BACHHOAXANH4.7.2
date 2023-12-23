-- Author:		Sok Kim Thanh
-- Create date: <06/12/2023 10:57 CH>
go
drop procedure if exists rp_nhanvien_theo_phongban
go
CREATE PROCEDURE rp_nhanvien_theo_phongban
	@tennhanvien nvarchar(255)= N'a'
AS
BEGIN
    SELECT count( pb.MAPB ) as N'số lượng nhân viên',   nv.HOTENNV as N'Họ và tên', pb.TENPHG as N'Tên phòng ban'
	FROM NHANVIEN nv, PHONGBAN pb
    where nv.MAPB = PB.MAPB and nv.hotennv like N'%' + isnull(@tennhanvien,nv.hotennv) + '%'
	group by pb.MAPB, nv.HOTENNV, pb.TENPHG , nv.CREATED_DATE_NV
	order by nv.created_date_nv desc 
END;
go
exec rp_nhanvien_theo_phongban null
