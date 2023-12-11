-- ================================================
-- Author:		Vo Tu
-- Create date: <13/11/2023>
-- Create Procedure sp_khachhang_insert.sql
-- Nhà cung cấp insert
-- ================================================
drop procedure if exists sp_khachhang_insert
go
CREATE PROCEDURE sp_khachhang_insert
	-- Add the parameters for the stored procedure here
	@maKH char(11),
	@tenKH nvarchar(30),
	@sdtKH int = 0,
	@diemTL int = 0
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO KHACHHANG VALUES (@maKH, @tenKH, @sdtKH,@diemTL)
END
GO
