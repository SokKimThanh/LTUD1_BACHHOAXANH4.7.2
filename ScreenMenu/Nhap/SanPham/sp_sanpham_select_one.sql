-- Create Procedure sp_sanpham_select_one.sql
-- S?n ph?m select one
-- Author:		Sok Kim Thanh
-- Create date: <07/11/2023>
drop procedure if exists sp_sanpham_select_one
go
CREATE PROCEDURE sp_sanpham_select_one
	@MASP CHAR(11)
AS
BEGIN
	SELECT * from sanpham where MASP = @MASP --like ch�nh x�c m� 100%
END
GO
