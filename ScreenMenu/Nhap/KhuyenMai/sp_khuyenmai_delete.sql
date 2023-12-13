-- Create Procedure sp_khuyenmai_delete.sql
-- Danh mục delete
-- Author:		Sok Kim Thanh
-- Create date: <07/11/2023>


DROP PROCEDURE IF EXISTS sp_khuyenmai_delete
GO
CREATE PROCEDURE sp_khuyenmai_delete
	
	@makm char(11) = '', 
	@ngaybd date,
	@ngaykt date,
	@masp char(11) = N''
AS
BEGIN
	
	
	

    
	DELETE FROM khuyenmai WHERE makm = @makm
END
GO
