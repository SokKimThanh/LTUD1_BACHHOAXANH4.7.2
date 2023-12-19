-- Create Procedure sp_quyentruycap_insert.sql
-- Tài kho?n insert
-- Author:		Sok Kim Thanh
-- Create date: <14/12/2023>
drop procedure if exists sp_quyentruycap_insert
go
CREATE PROCEDURE sp_quyentruycap_insert
	@MAQTC char(11),
	@TENQTC  CHAR(30)  	
AS
BEGIN
	INSERT INTO quyentruycap VALUES (@MAQTC, @TENQTC)
END
GO
