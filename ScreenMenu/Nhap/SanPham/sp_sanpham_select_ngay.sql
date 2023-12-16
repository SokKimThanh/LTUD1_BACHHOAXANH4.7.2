-- Create Procedure sp_sanpham_select_one.sql
-- Sản phẩm select one
-- Author:		Ngô Công Quý
-- Create date: <07/11/2023>
set dateformat ymd
drop procedure if exists sp_sanpham_select_ngay
go
CREATE PROCEDURE sp_sanpham_select_ngay
	@NgayHT date
AS
BEGIN
	SELECT * from sanpham sp,NHACUNGCAP ncc,LOAISP lsp where sp.HSD = @NgayHT  and sp.MANCC = ncc.MANCC and lsp.MALOAI=sp.MALOAI--like chính xác mã 100%
	
END
GO
exec sp_sanpham_select_ngay '2023-04-03'
