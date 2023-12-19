-- Create Procedure sp_hinhthuckm_delete.sql
-- Danh m?c delete
-- Author:		Sok Kim Thanh
-- Create date: <07/11/2023>
DROP PROCEDURE IF EXISTS sp_hinhthuckm_delete
GO
CREATE PROCEDURE sp_hinhthuckm_delete
	@makm char(11) 
AS
BEGIN
	DELETE FROM hinhthuckm WHERE MAHT = @makm
END
GO
