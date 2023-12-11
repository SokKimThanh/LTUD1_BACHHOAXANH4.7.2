-- =============================================
-- Author:		Vo Tu
-- Create date: <13/11/2023>
-- Description:	<Mô tả>
-- =============================================
DROP PROCEDURE IF EXISTS sp_diadiem_delete
GO
CREATE PROCEDURE sp_diadiem_delete
	-- Add the parameters for the stored procedure here
	@maCN char(4) = ''
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Delete statements for procedure here
	DELETE FROM CHINHANH WHERE MACN = @maCN
END
GO
