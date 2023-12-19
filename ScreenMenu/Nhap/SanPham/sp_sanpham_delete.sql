-- Create Procedure sp_sanpham_delete.sql
-- S?n ph?m delete
-- Author:		Sok Kim Thanh
-- Create date: <07/11/2023>
DROP PROCEDURE IF EXISTS sp_sanpham_delete
GO
CREATE PROCEDURE sp_sanpham_delete
	@MASP CHAR(11)
AS
BEGIN
	DELETE FROM sanpham WHERE MASP = @MASP
END
GO
