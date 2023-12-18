-- Author:		Vo Tu
-- Create date: <13/11/2023>
-- Create Procedure sp_khachhang_select_one.sql
-- Nh� cung c?p select one
drop procedure if exists sp_khachhang_select_one
go
CREATE PROCEDURE sp_khachhang_select_one
	@maKH char(11)
AS
BEGIN
	SELECT * from KHACHHANG where  MAKH = @maKH --like ch�nh x�c m� 100%
END
GO
