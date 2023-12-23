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
    WHERE PHONGBAN.MACN = isnull(@MACN, PHONGBAN.MACN)
    
END;
go
execute sp_count_nhanvien_by_chinhanh 'cn01'
go
-- lấy ra tất cả nhân viên của các chi nhánh
drop procedure if exists sp_count_nhanvien_by_chinhanh
go
CREATE PROCEDURE sp_count_nhanvien_by_all_chinhanh
AS
BEGIN
    SELECT CHINHANH.MACN, CHINHANH.TENCN, COUNT(NHANVIEN.MANV) as SLNV
    FROM NHANVIEN 
    INNER JOIN PHONGBAN ON NHANVIEN.MAPB = PHONGBAN.MAPB
    INNER JOIN CHINHANH ON PHONGBAN.MACN = CHINHANH.MACN
    GROUP BY CHINHANH.MACN, CHINHANH.TENCN;
END;
go
execute sp_count_nhanvien_by_all_chinhanh 
go
-- lấy ra danh sách hóa đơn của một nhân viên
drop procedure if exists sp_get_hoadon_by_nhanvien
go
CREATE PROCEDURE sp_get_hoadon_by_nhanvien
@MANV CHAR(11)
AS
BEGIN
    SELECT * FROM HOADON WHERE MANV = @MANV;
END;
go
--Tính tổng thành tiền của tất cả hóa đơn của một nhân viên
drop procedure if exists sp_sum_hoadon_by_nhanvien
go
CREATE PROCEDURE sp_sum_hoadon_by_nhanvien
@MANV CHAR(11)
AS
BEGIN
    SELECT SUM(TONGTHANHTIEN) as Total FROM HOADON WHERE MANV = @MANV;
END;
go
--Lấy danh sách nhân viên theo số lượng hóa đơn
drop procedure if exists sp_count_hoadon_by_nhanvien
go
CREATE PROCEDURE sp_count_hoadon_by_nhanvien
AS
BEGIN
    SELECT MANV, COUNT(MAHD) as SoHoaDon FROM HOADON GROUP BY MANV;
END;
go
execute sp_count_hoadon_by_nhanvien