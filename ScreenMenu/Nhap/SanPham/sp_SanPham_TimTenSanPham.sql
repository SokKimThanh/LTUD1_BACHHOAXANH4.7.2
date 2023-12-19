-- Create Procedure sp_sanpham_select_one.sql
-- S?n ph?m select one
-- Author:		Ng� C�ng Qu�
-- Create date: <07/11/2023>
drop procedure if exists sp_sanpham_select_ten
go
CREATE PROCEDURE sp_sanpham_select_ten
	@TenSP nvarchar(50)
AS
BEGIN
	SELECT * from sanpham sp,NHACUNGCAP ncc,LOAISP lsp where sp.TENSP like N'%'+ @TenSP+'%' and sp.MANCC = ncc.MANCC and lsp.MALOAI=sp.MALOAI--like ch�nh x�c m� 100%
END
GO
select * from sanpham
exec sp_sanpham_select_ten 'C�'
