-- Create Procedure sp_khuyenmai_update.sql
-- Danh m?c update
-- Author:		Sok Kim Thanh
-- Create date: <07/11/2023>
drop procedure if exists sp_khuyenmai_update
go
CREATE PROCEDURE sp_khuyenmai_update
	@makm char(11) = '', 
	@ngaybd date,
	@ngaykt date,
	@maht char(11),
	@phantramgiamgia int
AS
BEGIN
	update khuyenmai set ngaybd = @ngaybd, ngaykt = @ngaykt, maht=@maht, 
	phantramgiamgia = isnull(@phantramgiamgia, phantramgiamgia) where makm = @makm -- chuẩn sql
END
GO
