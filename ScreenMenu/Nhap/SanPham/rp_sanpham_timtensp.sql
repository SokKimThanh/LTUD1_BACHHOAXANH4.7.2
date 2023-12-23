-- Create Procedure sp_sanpham_select_one.sql
-- Sản phẩm select one
-- Author:		Ngô Công Quý
-- Create date: <07/11/2023>
drop procedure if exists rp_sanpham_timtensp
go
CREATE PROCEDURE rp_sanpham_timtensp
	@TenSP nvarchar(50)
AS
BEGIN
	SELECT * from sanpham sp,NHACUNGCAP ncc,LOAISP lsp where sp.TENSP like N'%'+ @TenSP+'%' and sp.MANCC = ncc.MANCC and lsp.MALOAI=sp.MALOAI--like chính xác mã 100%
END
GO
select * from sanpham
exec rp_sanpham_timtensp N'CÁ'
