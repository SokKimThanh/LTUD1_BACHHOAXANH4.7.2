-- Create Procedure sp_sanpham_insert.sql
-- S?n ph?m insert
-- Author:		Sok Kim Thanh
-- Create date: <07/11/2023>
drop procedure if exists sp_sanpham_insert
go
CREATE PROCEDURE sp_sanpham_insert
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
	INSERT INTO sanpham (MASP,TENSP,DONVI ,NSX  ,HSD  ,DONGIA  ,SLTONKHO , MALOAI , MANCC, MAKM ) 
	VALUES (@MASP,@TENSP,@DONVI ,@NSX  ,@HSD  ,@DONGIA  ,@SLTONKHO , @MALOAI , @MANCC, @MAKM )
END
GO
