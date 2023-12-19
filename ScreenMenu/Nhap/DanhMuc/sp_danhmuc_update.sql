-- Create Procedure sp_danhmuc_update.sql
-- Danh m?c update
-- Author:		Sok Kim Thanh
-- Create date: <07/11/2023>
drop procedure if exists sp_danhmuc_update
go
CREATE PROCEDURE sp_danhmuc_update
	@MALOAI CHAR(11),
	@TENLOAI NVARCHAR(255),
	@GHICHU NVARCHAR(100)
AS
BEGIN
	update LOAISP set TENLOAI = @TENLOAI, GHICHU = @GHICHU where MALOAI = @MALOAI -- chu?n sql
END
GO
