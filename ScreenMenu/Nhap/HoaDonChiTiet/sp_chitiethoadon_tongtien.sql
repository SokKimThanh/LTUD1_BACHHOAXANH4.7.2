-- Create Procedure sp_chitiethoadon_update.sql
-- Danh m?c update
-- Author:		Quy Ngo
-- Create date: <10/12/2023>
drop procedure if exists sp_chitiethoadon_TongTien
go
CREATE PROCEDURE sp_chitiethoadon_TongTien 
	@mahd char(11) = ''
AS
BEGIN 
	Declare  @TT int = 0;
	select   @TT   += ct.SLMUA * sp.DONGIA 
	from CHITIETHD ct,HOADON hd,SANPHAM sp
	where ct.MAHD = hd.MAHD and sp.MASP = ct.MASP and ct.MAHD = @mahd
	--select @TT as 'T?ng thành ti?n'
	Update HOADON
	set TONGTHANHTIEN = @TT
	where MAHD = @mahd;
	select @TT as 'Thanh tien'
END
GO
exec sp_chitiethoadon_TongTien 'HD01'
