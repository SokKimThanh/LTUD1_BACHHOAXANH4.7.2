-- Author:		Sok Kim Thanh
-- Create date: <06/12/2023 10:57 CH>
-- update date: <12/12/2023 10:57 ch>
-- Description:	<Hiển thị report nhân viên theo chi nhánh theo phòng ban>
go
drop procedure if exists sp_nhanvien_danhsach_theophongban_chinhanh
go
CREATE PROCEDURE sp_nhanvien_danhsach_theophongban_chinhanh
		@MaChiNhanh CHAR(11), 
		@MaPhongBan CHAR(11)
AS
BEGIN 
	SELECT cn.TENCN as N'Tên Chi Nhánh', pb.TENPHG as N'Phòng ban', STUFF((SELECT ', ' + nv.HOTENNV 
	FROM nhanvien nv 
	WHERE pb.MAPB = nv.MAPB AND cn.MACN = pb.MACN FOR XML PATH('')), 1, 2, '') as N'Danh sách nhân viên' 
	FROM PHONGBAN pb, CHINHANH cn 
	WHERE cn.MACN  =  @MaChiNhanh or  pb.MAPB = @MaPhongBan  
	--GROUP BY pb.TENPHG, cn.TENCN, pb.MAPB, cn.MACN, pb.MACN;
END;
go
--select * from chinhanh
--select * from phongban 
--select * from nhanvien
--exec sp_nhanvien_danhsach_theophongban_chinhanh 'cn01','pb01'
