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
drop procedure if exists sp_phongban_select_all
go
CREATE PROCEDURE sp_phongban_select_all
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT pb.MAPB, pb.TENPHG, cn.TENCN from PHONGBAN pb, CHINHANH cn
END
GO
exec sp_phongban_select_all
