-- ================================================
-- Create Procedure sp_khuyenmai_delete.sql
-- Danh mục delete
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Sok Kim Thanh
-- Create date: <07/11/2023>
-- Description:	<Mô tả>
-- =============================================
DROP PROCEDURE IF EXISTS sp_khuyenmai_delete
GO
CREATE PROCEDURE sp_khuyenmai_delete
	-- Add the parameters for the stored procedure here
	@makm char(11) = '', 
	@ngaybd date,
	@ngaykt date,
	@masp char(11) = N''
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Delete statements for procedure here
	DELETE FROM khuyenmai WHERE makm = @makm
END
GO
