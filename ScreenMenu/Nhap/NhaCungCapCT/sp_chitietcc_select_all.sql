-- Create Procedure sp_chitietcc_select_all.sql
-- Tài kho?n select all
-- Author:		Sok Kim Thanh
-- Create date: <14/12/2023>
drop procedure if exists sp_chitietcc_select_all
go
CREATE PROCEDURE sp_chitietcc_select_all
AS
BEGIN
	select ncc.MANCC, ncc.TENNCC as N'Nhà cung cấp' ,sp.TENSP as N'Tên sản phẩm', sp.DONGIA as N'Giá sản phẩm',  ct.SLCUNGCCAP as N'Số lượng', sp.DONVI as N'Đơn vị tính'
	from chitietcc ct, nhacungcap ncc, sanpham sp
	where ct.MANCC = ncc.MANCC and ct.MASP = sp.MASP
END;
GO
execute sp_chitietcc_select_all
select * from CHITIETCC
