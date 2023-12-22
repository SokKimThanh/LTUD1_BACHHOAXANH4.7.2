-- Create Procedure sp_chinhanh_select_all.sql
-- hoadon select all
GO
GO
-- Author:		Vo Tu
-- Create date: <13/11/2023>
-- Description:	<dia diem select all>
drop procedure if exists sp_chinhanh_select_all
go
CREATE PROCEDURE sp_chinhanh_select_all
AS
BEGIN
	SELECT MACN,tencn as N'Tên chi nhánh', diachicn as N'Địa chỉ' from CHINHANH
END;
GO
exec sp_chinhanh_select_all
