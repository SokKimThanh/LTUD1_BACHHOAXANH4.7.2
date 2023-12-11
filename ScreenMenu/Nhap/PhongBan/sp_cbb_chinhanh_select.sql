-- ================================================
-- Create Procedure sp_PhongBan_select_all.sql
-- Nhân viên phongban all
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		vo tu
-- Create date: <10/11/2023>
-- Description:	<vo tu select all>
-- =============================================
drop procedure if exists sp_cbb_chinhanh_select
go
CREATE PROCEDURE sp_cbb_chinhanh_select
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * from CHINHANH
END
GO
exec sp_cbb_chinhanh_select
