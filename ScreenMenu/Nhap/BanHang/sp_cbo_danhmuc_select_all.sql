
-- Create Procedure sp_danhmuc_select_all.sql
-- Danh mục select all
-- Author:		Sok Kim Thanh
-- Create date: <07/11/2023>


drop procedure if exists sp_cbo_danhmuc_select_all
go
CREATE PROCEDURE sp_cbo_danhmuc_select_all
	
	
AS
BEGIN
	SELECT maloai, tenloai from LOAISP
END;
GO
execute sp_cbo_danhmuc_select_all