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
	SELECT * from sanpham sp, NHACUNGCAP ncc, LOAISP lsp 
	WHERE (sp.HSD = ISNULL(@NgayHT, sp.HSD) 
		AND sp.MANCC = ncc.MANCC 
		AND lsp.MALOAI=sp.MALOAI)
END
GO

p_sanpham_select_ngay '2023-04-03'
