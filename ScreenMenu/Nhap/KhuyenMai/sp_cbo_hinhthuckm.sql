-- Create Procedure sp_khuyenmai_update.sql
-- Danh m?c update
-- Author:		Sok Kim Thanh
-- Create date: <07/11/2023>
drop procedure if exists sp_cbo_hinhthuckm
go
CREATE PROCEDURE sp_cbo_hinhthuckm
	--@makm char(11) = '', 
	--@hinhthuc nvarchar(50) = N'',
	--@ghichu nvarchar(100) = N''
AS
BEGIN
	SELECT MAHT from hinhthuckm-- chuẩn sql
END
GO
