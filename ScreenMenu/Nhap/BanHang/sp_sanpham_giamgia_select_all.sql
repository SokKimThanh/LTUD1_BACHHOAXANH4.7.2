-- Create Procedure sp_sanpham_select_all.SQL
-- Sản phẩm giảm giá
-- Author:		<Sok Kim Thanh>
-- Create date: <17/12/2023>
-- Description:	<Sản phẩm giảm giá>
drop procedure if exists sp_sanpham_giamgia_select_all
go
CREATE PROCEDURE sp_sanpham_giamgia_select_all
AS
BEGIN
	select masp,tensp 
	,dongia N'Giá Gốc'
	, donvi N'Đơn vị tính'
	,phantramgiam N'Phần trăm giảm giá'
	,dongia * (100-phantramgiamgia)/100 N'Giá sau giảm giá'
	,sltonkho N'Tồn kho' 
	from SanPham
END
GO

exec sp_sanpham_giamgia_select_all
