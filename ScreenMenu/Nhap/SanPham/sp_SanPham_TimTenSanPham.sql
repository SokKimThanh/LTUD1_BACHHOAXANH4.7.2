-- Create Procedure sp_sanpham_select_one.sql
-- Sản phẩm select one
-- Author:		Ngô Công Quý
-- Create date: <07/11/2023>

drop procedure if exists sp_sanpham_select_ten
go
CREATE PROCEDURE sp_sanpham_select_ten
	@TenSP nvarchar(50)
AS
BEGIN
	SELECT * from sanpham sp, NHACUNGCAP ncc, LOAISP lsp 
	WHERE (sp.TENSP like N'%'+ ISNULL(@TenSP, sp.TENSP) +'%' 
		AND sp.MANCC = ncc.MANCC 
		AND lsp.MALOAI=sp.MALOAI)
END
GO
exec sp_sanpham_select_ten N'Sản'
