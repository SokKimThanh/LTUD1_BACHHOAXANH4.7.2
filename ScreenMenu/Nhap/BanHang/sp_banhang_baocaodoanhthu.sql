-- Create sp_banhang_baocaodoanhthu
-- Author:		Sok Kim Thanh
-- Create date: <07/11/2023>
drop procedure if exists sp_banhang_baocaodoanhthu
go
CREATE PROCEDURE sp_banhang_baocaodoanhthu
	@thang int = 12,
	@nam int = 2023
AS
BEGIN
	 select sum(hd.TONGTHANHTIEN) N'Doanh thu theo tháng', nv.HOTENNV N'Người lập hóa đơn'
	 from   HOADON hd,  NHANVIEN nv
	 where nv.MANV = hd.MANV 
	 and MONTH(hd.NGAYHOADON) = @thang and YEAR(hd.ngayhoadon) = @nam
	 group by nv.HOTENNV
END
GO
select * from hoadon
execute sp_banhang_baocaodoanhthu 1, 2022
