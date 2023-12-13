
-- Create Procedure sp_taikhoan_insert.sql
-- Tài khoản insert
-- Author:		Sok Kim Thanh
-- Create date: <16/11/2023>


drop procedure if exists sp_taikhoan_insert
go
CREATE PROCEDURE sp_taikhoan_insert
	 
	@tentk  CHAR(30), 
	@matkhau char(30),
	@manv char(11),
	@maqtc char(11)
AS
BEGIN
	INSERT INTO taikhoan VALUES (@tentk, @matkhau, @manv, @maqtc)
END
GO
