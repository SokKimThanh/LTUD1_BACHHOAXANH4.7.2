-- Author:		Vo Tu
-- Create date: <13/11/2023>
-- Create Procedure sp_nhacungcap_select_all.sql
-- Description:	<Nhà cung c?p select all>
drop procedure if exists sp_khachhang_select_all
go
CREATE PROCEDURE sp_khachhang_select_all
AS
BEGIN
	SELECT * from KHACHHANG
END
GO
exec sp_khachhang_select_all
