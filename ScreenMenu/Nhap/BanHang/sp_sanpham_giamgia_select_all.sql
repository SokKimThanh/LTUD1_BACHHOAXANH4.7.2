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
	--select @TT as N'Tổng thành tiền'
	Update HOADON
	set TONGTHANHTIEN = @TT
	where MAHD = @mahd; 
	select hd.MAHD,hd.NGAYHOADON, nv.HOTENNV, sp.masp,sp.tensp,cthd.SLMUA 
	,sp.dongia N'Giá Gốc'
	,sp.donvi N'Đơn vị tính'
	,km.phantramgiamgia N'Phần trăm giảm giá'
	,sp.dongia * (100-km.phantramgiamgia)/100 N'Giá sau giảm giá'
	,sp.sltonkho N'Tồn kho',
	cthd.SLMUA
	,sp.dongia * (100-km.phantramgiamgia)/100 * cthd.SLMUA N'Thành tiền'
	,hd.TONGTHANHTIEN N'Tổng thành tiền'
	from SanPham sp,KHUYENMAI km, HOADON hd, CHITIETHD cthd, NHANVIEN nv
	where sp.MAKM = km.MAKM and hd.MAHD = @MAHD and cthd.MAHD = hd.MAHD and cthd.MASP = sp.MASP and hd.MANV = nv.MANV
	--select TONGTHANHTIEN  from HoaDon where HOADON.MAHD =@MAHD
	
END;
GO
--select * from SANPHAM
exec sp_sanpham_giamgia_select_all 'HD01'
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sanpham_giamgia_select_all]') AND type in (N'P', N'PC'))
BEGIN
    PRINT 'Stored procedure exists.'
END
ELSE
BEGIN
    PRINT 'Stored procedure does not exist.'
END
