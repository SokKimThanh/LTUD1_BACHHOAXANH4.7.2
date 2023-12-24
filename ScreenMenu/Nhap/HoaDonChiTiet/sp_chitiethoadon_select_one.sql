-- Author:		Quy Ngo
-- Create date: <10/12/2023
-- Create Procedure sp_chitiethoadon_select_one.sql
-- Danh mục select one
drop procedure if exists sp_chitiethoadon_select_one
go
CREATE PROCEDURE sp_chitiethoadon_select_one
	@mahd char(11),
	@masp char(11)
AS
BEGIN
	SELECT * from CHITIETHD where mahd = @mahd and masp=@masp --like chính xác mã 100%
END
GO
--exec sp_chitiethoadon_select_one 'hd03'
