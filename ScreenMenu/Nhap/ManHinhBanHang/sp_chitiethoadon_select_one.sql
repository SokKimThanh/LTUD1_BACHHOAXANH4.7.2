-- ================================================
-- Author:		Quy Ngo
-- Create date: <10/12/2023
-- Create Procedure sp_chitiethoadon_select_one.sql
-- Danh mục select one
-- ================================================
drop procedure if exists sp_chitiethoadon_select_one
go
CREATE PROCEDURE sp_chitiethoadon_select_one
	-- Add the parameters for the stored procedure here
	@mahd char(11) = ''
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * from CHITIETHD where mahd = @mahd --like chính xác mã 100%
END
GO
exec sp_chitiethoadon_select_one 'hd03'