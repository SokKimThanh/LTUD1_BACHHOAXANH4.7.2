-- Create Procedure sp_danhmuc_select_all.sql
-- Danh m?c select all
-- Author:		Sok Kim Thanh
-- Create date: <07/11/2023>
drop procedure if exists sp_danhmuc_select_all
go
CREATE PROCEDURE sp_danhmuc_select_all
AS
BEGIN
	SELECT * from LOAISP
END
GO
