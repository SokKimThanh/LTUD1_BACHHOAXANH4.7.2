-- Author:		Vo Tu
-- Create date: <13/11/2023>
DROP PROCEDURE IF EXISTS sp_chinhanh_delete
GO
CREATE PROCEDURE sp_chinhanh_delete
	@maCN CHAR(11) = ''
AS
BEGIN
	DELETE FROM CHINHANH WHERE MACN = @maCN
END
GO
