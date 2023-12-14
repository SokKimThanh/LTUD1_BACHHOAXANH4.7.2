-- Create Procedure sp_chitietcc_select_all.sql
-- Tài khoản select all
-- Author:		Sok Kim Thanh
-- Create date: <14/12/2023>

drop procedure if exists sp_chitietcc_select_all
go
CREATE PROCEDURE sp_chitietcc_select_all
AS
BEGIN
	select * from chitietcc	
END
GO
 
execute sp_chitietcc_select_all