-- Create Procedure sp_sanpham_select_all.SQL
-- S?n ph?m select all
-- Author:		<Sok Kim Thanh>
-- Create date: <07/11/2023>
-- update date: <14/12/2023> 3:34 CH
-- Description:	<S?n ph?m select all>
drop procedure if exists sp_sanpham_select_all
go
CREATE PROCEDURE sp_sanpham_select_all
AS
BEGIN
	select masp, tensp , donvi N'Ðon v?', nsx N'Ngày s?n xu?t', hsd N'H?n s? d?ng', dongia N'Ðon giá',sltonkho N'Tồn kho' 
	from SanPham
END
GO
exec sp_sanpham_select_all
