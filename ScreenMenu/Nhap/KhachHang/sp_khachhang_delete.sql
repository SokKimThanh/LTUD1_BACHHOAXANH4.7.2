-- ================================================
-- Author:		Vo Tu
-- Create date: <13/11/2023>
-- Create Procedure sp_khachhang_delete.sql
-- Nhà cung cấp delete
-- ================================================
DROP PROCEDURE IF EXISTS sp_khachhang_delete
GO
CREATE PROCEDURE sp_khachhang_delete
	-- Add the parameters for the stored procedure here
	@maKH char(11)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Delete statements for procedure here
	DELETE FROM KHACHHANG WHERE MAKH = @maKH
END
GO
