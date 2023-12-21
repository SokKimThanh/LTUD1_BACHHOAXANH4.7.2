-- Create Procedure sp_khuyenmai_select_all.sql
-- Danh mục select all
-- Author:		NgoQuy
-- Create date: <07/11/2023>
drop procedure if exists sp_khuyenmai_select_all
go
CREATE PROCEDURE sp_khuyenmai_select_all
AS
BEGIN
	SELECT km.*,ht.TENHINHTHUC from KHUYENMAI km , HINHTHUCKM ht
	where km.MAHT = ht.MAHT 
END
GO
exec sp_khuyenmai_select_all
exec sp_sanpham_select_all
