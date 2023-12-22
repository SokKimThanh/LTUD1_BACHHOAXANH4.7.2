-- Create Procedure sp_sanpham_update.sql
-- Sản phẩm update
-- Author:		Sok Kim Thanh
-- Create date: <07/11/2023>
drop procedure if exists sp_sanpham_update
go
CREATE PROCEDURE sp_sanpham_update
	@MASP CHAR(11),
	@TENSP NVARCHAR(255) ,
	@DONVI NVARCHAR(255),
	@NSX DATE ,
	@HSD DATE ,
	@DONGIA INT ,
	@SLTONKHO INT, 
	@MALOAI CHAR(11), 
	@MANCC CHAR(11), 
	@MAKM char(11)
AS
BEGIN
	update sanpham set TENSP = @TENSP, DONVI = @DONVI, NSX = @NSX,HSD = @HSD,DONGIA = @DONGIA,SLTONKHO = @SLTONKHO,MALOAI = @MALOAI,MANCC = @MANCC,MAKM = @MAKM where MASP = @MASP -- chuẩn sql
END
GO
select * from LOAISP
--execute sp_sanpham_update 
