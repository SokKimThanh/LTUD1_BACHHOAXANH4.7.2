-- Create Procedure sp_quyentruycap_select_all.sql
-- account select all
-- Author:		Sok Kim Thanh
-- Create date: <14/12/2023>
drop procedure if exists sp_cbo_quyentruycap_select_all
go
CREATE PROCEDURE sp_cbo_quyentruycap_select_all
AS
BEGIN
	SELECT qtc.maqtc, qtc.TENQTC FROM quyentruycap qtc
END
GO
-- Create Procedure sp_cbo_taikhoan.sql
-- account select all
-- Author:		Sok Kim Thanh
-- Create date: <24/12/2023>
drop procedure if exists sp_cbo_taikhoan
go
CREATE PROCEDURE sp_cbo_taikhoan
AS
BEGIN
	SELECT tentk as MATK, tentk as TENTK FROM TAIKHOAN  
END
GO
exec sp_cbo_taikhoan