-- Create Procedure sp_taikhoan_select_all.sql
-- Tài khoản select all
-- Author:		Sok Kim Thanh
-- Create date: <16/11/2023>

drop procedure if exists sp_taikhoan_select_all
go
CREATE PROCEDURE sp_taikhoan_select_all
AS
BEGIN
	SELECT tk.TENTK as ID, tk.TENTK, qtc.TENQTC FROM TAIKHOAN tk, QUYENTRUYCAP qtc where tk.MAQTC = qtc.MAQTC
END
GO
 