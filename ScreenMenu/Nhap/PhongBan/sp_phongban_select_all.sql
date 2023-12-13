-- Create Procedure sp_PhongBan_select_all.sql
-- Nhân viên phongban all
-- Author:		vo tu
-- Create date: <10/11/2023>
-- Description:	<vo tu select all>
drop procedure if exists sp_phongban_select_all
go
CREATE PROCEDURE sp_phongban_select_all
AS
BEGIN
	SELECT pb.MAPB, pb.TENPHG, cn.TENCN from PHONGBAN pb, CHINHANH cn
END
GO
exec sp_phongban_select_all
