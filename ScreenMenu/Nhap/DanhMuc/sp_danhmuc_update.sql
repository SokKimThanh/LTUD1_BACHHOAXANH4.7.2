-- ================================================
-- Create Procedure sp_danhmuc_update.sql
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
drop procedure if exists sp_danhmuc_update
go
CREATE PROCEDURE sp_danhmuc_update
	-- Add the parameters for the stored procedure here
	@MALOAI CHAR(11),
	@TENLOAI NVARCHAR(30),
	@GHICHU NVARCHAR(100)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	update LOAISP set TENLOAI = @TENLOAI, GHICHU = @GHICHU where MALOAI = @MALOAI -- chuẩn sql
END
GO
