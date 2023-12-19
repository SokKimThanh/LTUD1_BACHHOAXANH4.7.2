-- Create Procedure sp_diadiem_insert.sql
-- Nh� cung c?p insert
-- Author:		Vo Tu
-- Create date: <13/11/2023>
set dateformat dmy
drop procedure if exists sp_diadiem_insert
go
CREATE PROCEDURE sp_diadiem_insert
	@maCN char(4) = '',
	@tenCN NVARCHAR(255),
	@diaChi nvarchar(100)
AS
BEGIN
	INSERT INTO CHINHANH VALUES (@maCN,@tenCN,@diaChi)
END
GO
exec sp_diadiem_insert 'CN05', N'Chi nh�nh �� N?ng', N'S? 3 Nguy?n Van Linh, H?i Ch�u, �� N?ng';
select * from CHINHANH
