-- Create Procedure sp_PhongBan_select_all.sql
-- phongban phongban all
-- Author:		vo tu
-- Create date: <10/11/2023>
-- Description:	<vo tu select all>
drop procedure if exists sp_phongban_select_all
go
CREATE PROCEDURE sp_phongban_select_all
AS
BEGIN
	SELECT pb.MAPB, pb.TENPHG as N'T�n Ph�ng Ban' , cn.TENCN as N'T�n Chi Nh�nh'  from PHONGBAN pb, CHINHANH cn where pb.MACN = cn.MACN
END;
GO
exec sp_phongban_select_all
