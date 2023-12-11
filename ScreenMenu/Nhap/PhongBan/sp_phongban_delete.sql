-- ================================================
-- Create Procedure sp_phongban_delete.sql
-- Nhân viên delete
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		vo tu
-- Create date: <10/11/2023>
-- Description:	<Mô tả>
-- =============================================
DROP PROCEDURE IF EXISTS sp_phongban_delete
GO
CREATE PROCEDURE sp_phongban_delete
	-- Add the parameters for the stored procedure here
	@maPB char(11)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Delete statements for procedure here
	DELETE FROM PHONGBAN WHERE MAPB = @maPB
END
GO
