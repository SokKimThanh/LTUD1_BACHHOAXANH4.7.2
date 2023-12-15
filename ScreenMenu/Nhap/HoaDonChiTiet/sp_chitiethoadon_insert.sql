
-- Create Procedure sp_chitiethoadon_insert.sql
-- Danh mục insert


GO

GO

-- Author:		Quy Ngo
-- Create date: <10/12/2023>


drop procedure if exists sp_chitiethoadon_insert
go
CREATE PROCEDURE sp_chitiethoadon_insert
	
	@mahd char(11) = '', 
    @masp char(11) = '',
	@sl int
AS
BEGIN
	
	
	

    
	INSERT INTO CHITIETHD(mahd, masp, slmua) VALUES (@mahd, @masp, @sl)

	Update SANPHAM set SLTONKHO = SLTONKHO - @sl where MASP = @masp;
END
GO
select count (*) from chitiethd;
exec sp_chitiethoadon_insert 'hd03', 'sp02', 40
exec sp_chitiethoadon_select_one 'hd03'
select count (*) from chitiethd;
