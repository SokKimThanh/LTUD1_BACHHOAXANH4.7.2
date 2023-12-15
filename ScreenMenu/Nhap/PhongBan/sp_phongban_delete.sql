-- Create Procedure sp_phongban_delete.sql
-- Nhân viên delete
-- Author:		vo tu
-- Create date: <10/11/2023>


DROP PROCEDURE IF EXISTS sp_phongban_delete
GO
CREATE PROCEDURE sp_phongban_delete
	
	@maPB char(11)
AS
BEGIN
	DELETE FROM PHONGBAN WHERE MAPB = @maPB
END
GO
