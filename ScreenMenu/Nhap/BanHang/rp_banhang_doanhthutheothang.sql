-- Author:		Sok Kim Thanh
-- Create date: <16/12/2023>
-- Create Procedure rp_banhang_doanhthutheothang
drop procedure if exists rp_banhang_doanhthutheothang
go
CREATE PROCEDURE rp_banhang_doanhthutheothang
@thang int = 12,
@nam int = 2023
AS
BEGIN
	select sum(hd.TONGTHANHTIEN) N'Doanh Thu Theo Thang', nv. HOTENNV N'Nguoi Lập Hóa ĐƠn'
	from HOADON hd, NHANVIEN nv
	where nv.MANV = hd.MANV
	and MONTH(hd.NGAYHOADON)  = @thang and YEAR(hd.NGAYHOADON) = @nam
	group by nv.HOTENNV
END;
GO
 select * from HOADON
execute rp_banhang_doanhthutheothang 1,2022
