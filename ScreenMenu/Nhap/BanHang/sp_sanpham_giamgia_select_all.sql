-- Create Procedure sp_sanpham_select_all.SQL
-- S?n ph?m gi?m gi�
-- Author:		<Sok Kim Thanh>
-- Create date: <17/12/2023>
-- Description:	<S?n ph?m gi?m gi�>
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
	--select @TT as 'T?ng th�nh ti?n'
	Update HOADON
	set TONGTHANHTIEN = @TT
	where MAHD = @mahd; 
	select hd.MAHD,hd.NGAYHOADON,hd.MANV, sp.masp,sp.tensp,cthd.SLMUA 
	,sp.dongia N'Gi� G?c'
	, sp.donvi N'�on v? t�nh'
	,km.phantramgiamgia N'Ph?n tram gi?m gi�'
	,sp.dongia * (100-km.phantramgiamgia)/100 N'Gi� sau gi?m gi�'
	,sp.sltonkho N'T?n kho',
	cthd.SLMUA
	,sp.dongia * (100-km.phantramgiamgia)/100 * cthd.SLMUA N'Th�nh ti?n'
	,hd.TONGTHANHTIEN N'T?ng th�nh ti?n'
	from SanPham sp,KHUYENMAI km, HOADON hd, CHITIETHD cthd
	where sp.MAKM = km.MAKM and hd.MAHD = @MAHD and cthd.MAHD = hd.MAHD and cthd.MASP = sp.MASP
	select TONGTHANHTIEN  from HoaDon where HOADON.MAHD =@MAHD
END;
GO
--select * from SANPHAM
exec sp_sanpham_giamgia_select_all 'HD01'
