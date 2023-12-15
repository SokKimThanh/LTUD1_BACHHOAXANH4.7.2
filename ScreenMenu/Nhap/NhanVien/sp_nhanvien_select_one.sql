-- Author:		Sok Kim Thanh
-- Create date: <06/12/2023 9:39 CH>
go
drop procedure if exists sp_nhanvien_select_one
go
CREATE PROCEDURE sp_nhanvien_select_one
	
	@manv char(11)
	 
AS
BEGIN 
    
	SELECT * from nhanvien where MANV = @manv --like chính xác mã 100%
END;
go

