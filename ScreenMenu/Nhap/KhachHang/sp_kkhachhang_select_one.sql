-- ================================================
-- Author:		Vo Tu
-- Create date: <13/11/2023>
-- Create Procedure sp_khachhang_select_one.sql
-- Nhà cung cấp select one
-- ================================================

drop procedure if exists sp_khachhang_select_one
go
CREATE PROCEDURE sp_khachhang_select_one
	-- Add the parameters for the stored procedure here
	@maKH char(11)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
    -- Insert statements for procedure here
	SELECT * from KHACHHANG where  MAKH = @maKH --like chính xác mã 100%
END
GO
