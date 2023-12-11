-- ================================================
-- Create Procedure sp_hinhthuckm_select_one.sql
-- Danh mục select one
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
drop procedure if exists sp_hinhthuckm_select_one
go
CREATE PROCEDURE sp_hinhthuckm_select_one
	-- Add the parameters for the stored procedure here
	@makm char(11) = '', 
	@hinhthuc nvarchar(50) = N'',
	@ghichu nvarchar(100) = N''
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * from hinhthuckm where MAHT = @makm --like chính xác mã 100%
END
GO
