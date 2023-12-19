-- Author:		Vo Tu
-- Create date: <13/11/2023>
DROP PROCEDURE IF EXISTS sp_diadiem_delete
GO
CREATE PROCEDURE sp_diadiem_delete
	@maCN char(4) = ''
AS
BEGIN
	DELETE FROM CHINHANH WHERE MACN = @maCN
END
GO
