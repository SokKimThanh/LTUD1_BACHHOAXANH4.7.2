-- Create Procedure sp_PhongBan_select_all.sql
-- phongban phongban all
-- Author:		vo tu
-- Create date: <10/11/2023>
-- Description:	<vo tu select all>
drop procedure if exists sp_cbb_chinhanh_select
go
CREATE PROCEDURE sp_cbb_chinhanh_select
AS
BEGIN
	SELECT * from CHINHANH
END
GO
exec sp_cbb_chinhanh_select
