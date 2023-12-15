
-- Create Procedure sp_hinhthuckm_insert.sql
-- Danh mục insert
-- Author:		Sok Kim Thanh
-- Create date: <07/11/2023>

drop procedure if exists sp_hinhthuckm_insert
go
CREATE PROCEDURE sp_hinhthuckm_insert
	
	@makm char(11) = '', 
	@hinhthuc nvarchar(50) = N'',
	@ghichu nvarchar(100) = N''
AS
BEGIN 
	INSERT INTO hinhthuckm VALUES (@makm, @hinhthuc, @ghichu)
END
GO
