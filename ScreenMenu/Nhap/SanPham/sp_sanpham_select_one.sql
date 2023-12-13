-- Create Procedure sp_sanpham_select_one.sql
-- Sản phẩm select one
-- Author:		Sok Kim Thanh
-- Create date: <07/11/2023>

drop procedure if exists sp_sanpham_select_one
go
CREATE PROCEDURE sp_sanpham_select_one
	@MASP CHAR(11)
AS
BEGIN
	SELECT * from sanpham where MASP like @MASP --like chính xác mã 100%
END
GO
