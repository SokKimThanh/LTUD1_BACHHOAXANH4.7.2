
-- Create Procedure sp_hinhthuckm_update.sql
-- Danh mục update


GO

GO

-- Author:		Quy Ngo
-- Create date: <10/12/2023>


drop procedure if exists sp_chitiethoadon_update
go
CREATE PROCEDURE sp_chitiethoadon_update
	
	@mahd char(11) = '', 
	@masp char(11) = '',
	@sl int
	as
BEGIN
	
	
	
	Update sp set sp.SLTONKHO = sp.SLTONKHO + ct.SLMUA 
	 from SANPHAM sp,CHITIETHD ct
	 where sp.MASP = @masp and ct.MASP = sp.MASP
    
	update CHITIETHD set SLMUA = @sl where MAHD = @mahd and  MASP = @masp -- chuẩn sql

	Update SANPHAM set SLTONKHO = SLTONKHO - @sl where MASP = @masp;
END
GO
exec sp_chitiethoadon_update 'HD01','SP02',50
select *
from CHITIETHD
where MAHD = 'HD01' and MASP = 'SP02'
