-- Create Procedure sp_sanpham_select_all.SQL
-- Sản phẩm giảm giá
-- Author:		<Sok Kim Thanh>
-- Create date: <17/12/2023>
-- Description:	<Sản phẩm giảm giá>
drop procedure if exists sp_sanpham_giamgia_select_all
go
CREATE PROCEDURE sp_sanpham_giamgia_select_all
@MAHD CHAR(11)
AS
BEGIN
	Declare  @TT int = 0;
	select   @TT   +=  sp.dongia * (100-km.phantramgiamgia)/100 * ct.SLMUA
	from CHITIETHD ct,HOADON hd,SANPHAM sp,KHUYENMAI km
	where ct.MAHD = hd.MAHD and sp.MASP = ct.MASP and ct.MAHD = @mahd and sp.MAKM = km.MAKM

	--select @TT as 'Tổng thành tiền'
	Update HOADON
	set TONGTHANHTIEN = @TT
	where MAHD = @mahd; 

	select hd.MAHD,hd.NGAYHOADON,hd.MANV, sp.masp,sp.tensp,cthd.SLMUA 
	,sp.dongia N'Giá Gốc'
	, sp.donvi N'Đơn vị tính'
	,km.phantramgiamgia N'Phần trăm giảm giá'
	,sp.dongia * (100-km.phantramgiamgia)/100 N'Giá sau giảm giá'
	,sp.sltonkho N'Tồn kho',
	cthd.SLMUA
	,sp.dongia * (100-km.phantramgiamgia)/100 * cthd.SLMUA N'Thành tiền'
	,hd.TONGTHANHTIEN N'Tổng thành tiền'
	from SanPham sp,KHUYENMAI km, HOADON hd, CHITIETHD cthd
	where sp.MAKM = km.MAKM and hd.MAHD = @MAHD and cthd.MAHD = hd.MAHD and cthd.MASP = sp.MASP

	

	select TONGTHANHTIEN  from HoaDon where HOADON.MAHD =@MAHD
END;
GO
--select * from SANPHAM
exec sp_sanpham_giamgia_select_all 'HD01'

