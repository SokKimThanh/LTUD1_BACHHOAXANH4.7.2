-- Author:		Sok Kim Thanh
-- Create date: <06/12/2023 9:39 CH>
go
drop procedure if exists sp_phongban_select_one
go
CREATE PROCEDURE sp_phongban_select_one
	@mapb char(11)
AS
BEGIN 
	SELECT * from phongban where mapb = @mapb --like chính xác mã 100%
END;
go
--execute sp_phongban_select_one 'pb01'
