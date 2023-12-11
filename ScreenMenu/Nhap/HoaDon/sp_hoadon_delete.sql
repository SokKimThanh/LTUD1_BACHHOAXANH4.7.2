-- =============================================
-- Author:		Vo Tu
-- Create date: <13/11/2023>
-- Description:	<Mô tả>
-- =============================================
DROP PROCEDURE IF EXISTS sp_hoadon_delete
GO
CREATE PROCEDURE sp_hoadon_delete
	-- Add the parameters for the stored procedure here
	@maHD char(11) = ''
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
    -- Delete statements for procedure here
	DELETE FROM HOADON WHERE MAHD = @maHD
	DELETE FROM CHITIETHD WHERE MAHD = @maHD
end
