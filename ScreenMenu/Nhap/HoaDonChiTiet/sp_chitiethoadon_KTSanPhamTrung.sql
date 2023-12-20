-- Create Procedure sp_chitiethoadon_update.sql
-- Danh m?c update
GO
GO
-- Author:		Quy Ngo
-- Create date: <10/12/2023>
drop procedure if exists sp_chitiethoadon_TimMaSP
go
CREATE PROCEDURE sp_chitiethoadon_TimMaSP
	@masp char(11) = ''
	as
BEGIN
	Select sp.MASP
	from  CHITIETHD sp
	where sp.MASP = @masp
	-- chuẩn sql
END
GO
EXEC sp_chitiethoadon_TimMaSP 'SP03'
