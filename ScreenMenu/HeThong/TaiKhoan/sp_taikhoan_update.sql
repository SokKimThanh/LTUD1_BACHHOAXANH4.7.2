-- Create Procedure sp_taikhoan_update.sql
-- Tài khoản update
-- Author:		Sok Kim Thanh
-- Create date: <16/11/2023>

go
drop procedure if exists sp_taikhoan_update
go
CREATE PROCEDURE sp_taikhoan_update
	@TENTK CHAR(30), 
	@MATKHAU char(16),
	@MANV char(11),
	@MAQTC char (11)
AS
BEGIN
	update taikhoan set matkhau = @MATKHAU, manv = @MANV, MAQTC = @MAQTC where tentk= @TENTK -- chuẩn sql
END
GO
