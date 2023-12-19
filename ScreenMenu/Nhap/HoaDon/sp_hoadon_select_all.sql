-- Create Procedure sp_hoadon_select_all.sql
-- hoadon select all 
-- Author:		Vo Tu
-- Create date: <13/11/2023>
-- Description:	<Hóa don select all>
set dateformat dmy
drop procedure if exists sp_hoadon_select_all
go
CREATE PROCEDURE sp_hoadon_select_all
AS
BEGIN 
	SELECT hd.MAHD, hd.NGAYHOADON, hd.TONGTHANHTIEN , nv.HOTENNV, kh.HOTENKH from HOADON hd, NHANVIEN nv, KHACHHANG kh
	where hd.MANV = nv.MANV and hd.MAKH = kh.MAKH
END
GO
exec sp_hoadon_select_all
