
-- Create Procedure sp_quyentruycap_select_one.sql
-- Tài khoản select one
-- Author:		Sok Kim Thanh
-- Create date: <14/12/2023>

go
drop procedure if exists sp_quyentruycap_select_one
go
CREATE PROCEDURE sp_quyentruycap_select_one
	
	@MAQTC CHAR(30)
AS
BEGIN
	SELECT * from quyentruycap where MAQTC = @MAQTC --  chính xác mã 100%
END
GO
