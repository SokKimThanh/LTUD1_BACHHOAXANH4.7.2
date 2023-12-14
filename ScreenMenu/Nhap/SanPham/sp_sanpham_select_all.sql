-- Create Procedure sp_sanpham_select_all.SQL
-- Sản phẩm select all
-- Author:		<Sok Kim Thanh>
-- Create date: <07/11/2023>
-- update date: <14/12/2023> 3:34 CH
-- Description:	<Sản phẩm select all>
drop procedure if exists sp_sanpham_select_all
go
CREATE PROCEDURE sp_sanpham_select_all
AS
BEGIN
	select masp, tensp 'Tên sản phẩm', donvi 'Đơn vị', nsx 'Ngày sản xuất', hsd'Hạn sử dụng', dongia'Đơn giá',sltonkho'Tồn kho' 
	from SanPham
END
GO
exec sp_sanpham_select_all
