-- Create Procedure sp_khuyenmai_select_one.sql
-- Danh m?c select one
-- Author:		Sok Kim Thanh
-- Create date: <07/11/2023>
drop procedure if exists sp_khuyenmai_select_one
go
CREATE PROCEDURE sp_khuyenmai_select_one
	@MAKM CHAR(11) 
AS
BEGIN
	SELECT * from khuyenmai where MAKM = @MAKM --like ch�nh x�c m� 100%
END
GO
