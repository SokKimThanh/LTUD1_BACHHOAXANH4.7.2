-- Create Procedure sp_khuyenmai_update.sql
-- Danh mục update
-- Author:		Sok Kim Thanh
-- Create date: <07/11/2023>
drop procedure if exists sp_khuyenmai_update
go
CREATE PROCEDURE sp_khuyenmai_update
	@makm char(11) = '', 
	@ngaybd date,
	@ngaykt date,
	@maht char(11)
AS
BEGIN
	update khuyenmai set ngaybd = @ngaybd, ngaykt = @ngaykt, maht=@maht where makm = @makm -- chuẩn sql
END
GO
