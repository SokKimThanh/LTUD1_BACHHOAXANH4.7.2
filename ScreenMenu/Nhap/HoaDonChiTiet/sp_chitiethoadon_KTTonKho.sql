-- Create Procedure sp_chitiethoadon_delete.sql
-- Danh m?c delete
GO
GO
-- Author:		Quy Ngo
-- Create date: <10/12/2023>
DROP PROCEDURE IF EXISTS sp_chitiethoadon_Kiemtratonkho
GO
CREATE PROCEDURE sp_chitiethoadon_Kiemtratonkho
	@makm char(11),
	@slmua int
AS
BEGIN
	Select  sp.SLTONKHO - @slmua as N'Tồn kho'
	from SANPHAM sp,HOADON hd
	 where  sp.MaSP = @makm 
END
GO
exec sp_chitiethoadon_Kiemtratonkho 'SP33', 36
select *
from SANPHAM
