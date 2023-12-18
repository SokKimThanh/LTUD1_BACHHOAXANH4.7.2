-- Author:		Sok Kim Thanh
-- Create date: <06/12/2023 10:57 CH>
-- update date: <12/12/2023 10:57 ch>
-- Description:	<Hi?n th? report nh�n vi�n theo chi nh�nh theo ph�ng ban>
go
drop procedure if exists sp_nhanvien_danhsach_theophongban_chinhanh
go
CREATE PROCEDURE sp_nhanvien_danhsach_theophongban_chinhanh
		@MaChiNhanh char(4), 
		@MaPhongBan char(4)
AS
BEGIN 
	SELECT cn.TENCN as 'T�n Chi Nh�nh', pb.TENPHG as 'Ph�ng ban', STUFF((SELECT ', ' + nv.HOTENNV 
	FROM nhanvien nv 
	WHERE pb.MAPB = nv.MAPB AND cn.MACN = pb.MACN FOR XML PATH('')), 1, 2, '') as 'Danh s�ch nh�n vi�n' 
	FROM PHONGBAN pb, CHINHANH cn 
	WHERE cn.MACN  =  @MaChiNhanh or  pb.MAPB = @MaPhongBan  
	--GROUP BY pb.TENPHG, cn.TENCN, pb.MAPB, cn.MACN, pb.MACN;
END;
go
--select * from chinhanh
--select * from phongban 
--select * from nhanvien
--exec sp_nhanvien_danhsach_theophongban_chinhanh 'cn01','pb01'
