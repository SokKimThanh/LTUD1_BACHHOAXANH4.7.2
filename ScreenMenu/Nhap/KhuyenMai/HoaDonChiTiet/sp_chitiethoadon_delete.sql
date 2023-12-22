-- Create Procedure sp_chitiethoadon_delete.sql
-- Danh mục delete
GO
GO
-- Author:		Quy Ngo
-- Create date: <10/12/2023>
DROP PROCEDURE IF EXISTS sp_chitiethoadon_delete
GO
CREATE PROCEDURE sp_chitiethoadon_delete
	@mahd char(11) ,
	@masp char(11)
AS
BEGIN
	Update sp set sp.SLTONKHO = sp.SLTONKHO + ct.SLMUA 
	from SANPHAM sp,CHITIETHD ct
	where sp.MASP = @masp and ct.MASP = sp.MASP
	DELETE FROM CHITIETHD WHERE MAHD = @mahd and MASP = @masp
END
GO
Select count (*) from CHITIETHD 
Exec sp_chitiethoadon_delete 'HD01','SP01'
Select count (*) from CHITIETHD 
