-- ================================================
-- Create Procedure sp_sanpham_select_one.sql
-- Sản phẩm select one
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
drop procedure if exists sp_sanpham_select_one
go
CREATE PROCEDURE sp_sanpham_select_one
	-- Add the parameters for the stored procedure here
	@MASP CHAR(11)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * from sanpham where MASP like @MASP --like chính xác mã 100%
END
GO
