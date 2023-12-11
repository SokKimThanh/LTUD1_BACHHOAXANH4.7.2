-- ================================================
-- Create Procedure sp_khuyenmai_update.sql
-- Danh mục update
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
drop procedure if exists sp_cbo_hinhthuckm
go
CREATE PROCEDURE sp_cbo_hinhthuckm
	-- Add the parameters for the stored procedure here
	--@makm char(11) = '', 
	--@hinhthuc nvarchar(50) = N'',
	--@ghichu nvarchar(100) = N''
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT MAHT from hinhthuckm-- chuẩn sql
END
GO
