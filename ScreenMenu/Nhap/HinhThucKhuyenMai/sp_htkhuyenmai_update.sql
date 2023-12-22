-- Create Procedure sp_hinhthuckm_update.sql
-- Danh mục update
-- Author:		Sok Kim Thanh
-- Create date: <07/11/2023>
drop procedure if exists sp_hinhthuckm_update
go
CREATE PROCEDURE sp_hinhthuckm_update
	@makm char(11) = '', 
	@hinhthuc nvarchar(50) = N'',
	@ghichu nvarchar(100) = N''
AS
BEGIN
	update hinhthuckm set TENHINHTHUC = @hinhthuc, ghichu = @ghichu  where MAHT = @makm -- chuẩn sql
END
GO
