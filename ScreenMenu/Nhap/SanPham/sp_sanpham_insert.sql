-- ================================================
-- Create Procedure sp_sanpham_insert.sql
-- Sản phẩm insert
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
drop procedure if exists sp_sanpham_insert
go
CREATE PROCEDURE sp_sanpham_insert
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
	INSERT INTO sanpham (MASP,TENSP,DONVI ,NSX  ,HSD  ,DONGIA  ,SLTONKHO , MALOAI , MANCC, MAKM ) 
	VALUES (@MASP,@TENSP,@DONVI ,@NSX  ,@HSD  ,@DONGIA  ,@SLTONKHO , @MALOAI , @MANCC, @MAKM )
END
GO
