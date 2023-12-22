set dateformat dmy
-- Create Procedure sp_nhacungcap_insert.sql
-- Nhà cung c?p insert 
-- Author:		Vo Tu
-- Create date: <13/11/2023>
drop procedure if exists sp_hoadon_insert
go
CREATE PROCEDURE sp_hoadon_insert
	@maHD char(11) = '', 
	@ngayHD date,
	@tongTien decimal,
	@maNV char(11),
	@maKH char(11)
AS
BEGIN 
	INSERT INTO HOADON VALUES (@maHD, @ngayHD, @tongTien,@maNV,@maKH)
END
GO
exec sp_hoadon_insert 'HD03', '15/01/2022', 90000,'NV02', 'KH02'
select * from NHANVIEN
