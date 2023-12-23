-- Create Procedure sp_sanpham_select_one.sql
-- Sản phẩm select one
-- Author:		Ngô Công Quý
-- Create date: <07/11/2023>
set dateformat ymd
drop procedure if exists rp_sanpham_thongke_theongay
go
CREATE PROCEDURE rp_sanpham_thongke_theongay
	@NgayHT date = null
AS
BEGIN
	SELECT * from sanpham sp,NHACUNGCAP ncc,LOAISP lsp where sp.HSD = isnull(@NgayHT,sp.hsd)--like chính xác mã 100%
END
GO
select * From SANPHAM
exec rp_sanpham_thongke_theongay
