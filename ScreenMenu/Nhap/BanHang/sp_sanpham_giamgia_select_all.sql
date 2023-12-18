-- Create Procedure sp_sanpham_select_all.SQL
-- S?n ph?m gi?m giá
-- Author:		<Sok Kim Thanh>
-- Create date: <17/12/2023>
-- Description:	<S?n ph?m gi?m giá>
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
	--select @TT as 'T?ng thành ti?n'
	Update HOADON
	set TONGTHANHTIEN = @TT
	where MAHD = @mahd; 
	select hd.MAHD,hd.NGAYHOADON,hd.MANV, sp.masp,sp.tensp,cthd.SLMUA 
	,sp.dongia N'Giá G?c'
	, sp.donvi N'Ðon v? tính'
	,km.phantramgiamgia N'Ph?n tram gi?m giá'
	,sp.dongia * (100-km.phantramgiamgia)/100 N'Giá sau gi?m giá'
	,sp.sltonkho N'T?n kho',
	cthd.SLMUA
	,sp.dongia * (100-km.phantramgiamgia)/100 * cthd.SLMUA N'Thành ti?n'
	,hd.TONGTHANHTIEN N'T?ng thành ti?n'
	from SanPham sp,KHUYENMAI km, HOADON hd, CHITIETHD cthd
	where sp.MAKM = km.MAKM and hd.MAHD = @MAHD and cthd.MAHD = hd.MAHD and cthd.MASP = sp.MASP
	select TONGTHANHTIEN  from HoaDon where HOADON.MAHD =@MAHD
END;
GO
--select * from SANPHAM
exec sp_sanpham_giamgia_select_all 'HD01'
