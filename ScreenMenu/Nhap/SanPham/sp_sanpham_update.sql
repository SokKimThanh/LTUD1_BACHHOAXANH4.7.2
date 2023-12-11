-- ================================================
-- Create Procedure sp_sanpham_update.sql
-- Sản phẩm update
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
drop procedure if exists sp_sanpham_update
go
CREATE PROCEDURE sp_sanpham_update
	-- Add the parameters for the stored procedure here
	@MASP CHAR(11),
	@TENSP NVARCHAR(30) ,
	@DONVI NVARCHAR(30),
	@NSX DATE ,
	@HSD DATE ,
	@DONGIA INT ,
	@SLTONKHO INT, 
	@MALOAI CHAR(11), 
	@MANCC CHAR(11), 
	@MAKM char(11)
AS

BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	update sanpham set TENSP = @TENSP, DONVI = @DONVI, NSX = @NSX,HSD = @HSD,DONGIA = @DONGIA,SLTONKHO = @SLTONKHO,MALOAI = @MALOAI,MANCC = @MANCC,MAKM = @MAKM where MASP = @MASP -- chuẩn sql
END
GO
