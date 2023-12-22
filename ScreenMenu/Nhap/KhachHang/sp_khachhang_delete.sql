-- Author:		Vo Tu
-- Create date: <13/11/2023>
-- Create Procedure sp_khachhang_delete.sql
-- nhacungcap delete
DROP PROCEDURE IF EXISTS sp_khachhang_delete
GO
CREATE PROCEDURE sp_khachhang_delete
	@maKH char(11)
AS
BEGIN
	DELETE FROM KHACHHANG WHERE MAKH = @maKH
END
GO
