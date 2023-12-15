
-- Create Procedure sp_hinhthuckm_select_one.sql
-- Danh mục select one
-- Author:		Sok Kim Thanh
-- Create date: <07/11/2023>

drop procedure if exists sp_hinhthuckm_select_one
go
CREATE PROCEDURE sp_hinhthuckm_select_one
	@makm char(11) = '', 
	@hinhthuc nvarchar(50) = N'',
	@ghichu nvarchar(100) = N''
AS
BEGIN
	SELECT * from hinhthuckm where MAHT = @makm --like chính xác mã 100%
END
GO
