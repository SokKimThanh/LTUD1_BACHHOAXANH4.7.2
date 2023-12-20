-- Author:		Sok Kim Thanh
-- Create date: <14/12/2023>
-- Description:	<Tài kho?n delete>
DROP PROCEDURE IF EXISTS sp_quyentruycap_delete
GO
CREATE PROCEDURE sp_quyentruycap_delete
	@maQTC CHAR(11) 
AS
BEGIN
	DELETE FROM quyentruycap WHERE MAQTC = @maQTC
END
GO
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
-- Create Procedure sp_quyentruycap_select_all.sql
-- Tài kho?n select all
-- Author:		Sok Kim Thanh
-- Create date: <14/12/2023>
drop procedure if exists sp_quyentruycap_select_all
go
CREATE PROCEDURE sp_quyentruycap_select_all
AS
BEGIN
	SELECT qtc.maqtc, qtc.TENQTC FROM quyentruycap qtc
END
GO
-- Create Procedure sp_quyentruycap_select_one.sql
-- Tài kho?n select one
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
