-- Create Procedure sp_hinhthuckm_select_all.sql
-- Danh mục select all
-- Author:		Sok Kim Thanh
-- Create date: <07/11/2023>
drop procedure if exists sp_hinhthuckm_select_all
go
CREATE PROCEDURE sp_hinhthuckm_select_all
AS
BEGIN
	SELECT * from hinhthuckm
END
GO
