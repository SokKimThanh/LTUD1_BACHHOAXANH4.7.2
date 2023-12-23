-- Author:		Vo Tu
-- Create date: <13/11/2023>
-- Create Procedure sp_nhacungcap_select_one.sql
-- nhacungcap select one
-- Lấy thông tin chi tiết của một hóa đơn: Stored procedure này sẽ trả về thông tin chi tiết của một hóa đơn cụ thể dựa trên mã hóa đơn (MAHD)
drop procedure if exists sp_hoadon_select_one
go
CREATE PROCEDURE sp_hoadon_select_one
	@maHD char(11) = ''
AS
BEGIN
	SELECT * from HOADON where MAHD  = @maHD --like chính xác mã 100%
END
GO
exec sp_hoadon_select_one '12'
