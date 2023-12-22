--In tất cả nhân viên:
drop procedure if exists sp_select_all_nhanvien 
go
CREATE PROCEDURE sp_select_all_nhanvien
AS
BEGIN
    SELECT * FROM NHANVIEN;
END;
go
execute sp_select_all_nhanvien
go
--In nhân viên theo tên:
drop procedure if exists sp_select_nhanvien_by_name 
go
CREATE PROCEDURE sp_select_nhanvien_by_name
@HOTENNV NVARCHAR(255) = N''
AS
BEGIN
    SELECT * FROM NHANVIEN WHERE HOTENNV like N'%' +isnull(@HOTENNV,hotennv) + '%';
END;
go
execute sp_select_nhanvien_by_name 'alan'
go
--In nhân viên theo phòng ban:
drop procedure if exists sp_select_nhanvien_by_phongban 
go
CREATE PROCEDURE sp_select_nhanvien_by_phongban
@MAPB CHAR(11) = N''
AS
BEGIN
    SELECT * FROM NHANVIEN WHERE MAPB = isnull(@MAPB,MAPB);
END;
go
execute sp_select_nhanvien_by_phongban 'pb01'
go
--In ra số lượng nhân viên theo chi nhánh:
drop procedure if exists sp_count_nhanvien_by_chinhanh 
go
CREATE PROCEDURE sp_count_nhanvien_by_chinhanh
@MACN CHAR(11) = N''
AS
BEGIN
    SELECT COUNT(*) as SLNV FROM NHANVIEN 
    INNER JOIN PHONGBAN ON NHANVIEN.MAPB = PHONGBAN.MAPB
    WHERE PHONGBAN.MACN = isnull(@MACN, PHONGBAN.MACN);
END;
go
execute sp_count_nhanvien_by_chinhanh 'cn01'
go