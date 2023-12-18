-- Create Procedure sp_taikhoan_select_all.sql
-- Tài kho?n select all
-- Author:		Sok Kim Thanh
-- Create date: <16/11/2023>
drop procedure if exists sp_taikhoan_select_all
go
CREATE PROCEDURE sp_taikhoan_select_all
AS
BEGIN
SELECT * from TAIKHOAN
END
GO
