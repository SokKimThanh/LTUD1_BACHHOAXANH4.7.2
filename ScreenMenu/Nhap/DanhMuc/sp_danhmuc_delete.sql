-- Create Procedure sp_danhmuc_delete.sql
-- Danh m?c delete
-- Author:		Sok Kim Thanh
-- Create date: <07/11/2023>
DROP PROCEDURE IF EXISTS sp_danhmuc_delete
GO
CREATE PROCEDURE sp_danhmuc_delete
	@MALOAI CHAR(11) 
AS
BEGIN
	DELETE FROM LOAISP WHERE MALOAI = @MALOAI
END
GO
