-- Create Procedure sp_quyentruycap_update.sql
-- quyentruycap update
-- Author:		Sok Kim Thanh
-- Create date: <14/12/2023>
go
drop procedure if exists sp_quyentruycap_update
go
CREATE PROCEDURE sp_quyentruycap_update
	@TENQTC CHAR(30),
	@MAQTC char (11)
AS
BEGIN
	update quyentruycap set TENQTC= @TENQTC where MAQTC = @MAQTC  -- chuẩn sql
END
GO
