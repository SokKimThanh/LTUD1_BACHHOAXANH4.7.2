-- ================================================
-- Create Procedure sp_nhanvien_insert.sql
-- Nhân viên insert
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Sok Kim Thanh
-- Create date: <10/11/2023>
-- Description:	<Mô tả>
-- =============================================
drop procedure if exists sp_phongban_insert
go
CREATE PROCEDURE sp_PhongBan_insert
	-- Add the parameters for the stored procedure here
	@maPB char(11),
	@tenPB nvarchar(30),
	@maCN nvarchar(100)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
    -- Insert statements for procedure here
	INSERT INTO PHONGBAN VALUES (@maPB, @tenPB, @maCN)
END
GO
