-- Create Procedure sp_khuyenmai_insert.sql
-- Author:		Sok Kim Thanh
-- Create date: <07/11/2023>
drop procedure if exists sp_khuyenmai_insert
go
CREATE PROCEDURE sp_khuyenmai_insert
	@makm char(11) = '', 
	@ngaybd date,
	@ngaykt date,
	@maht char(11) = N''
AS
BEGIN
	INSERT INTO khuyenmai VALUES (@makm, @ngaybd, @ngaykt,@maht)
END
GO
