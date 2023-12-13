-- Author:		Sok Kim Thanh
-- Create date: <06/12/2023 9:39 CH>
go
drop procedure if exists sp_nhanvien_delete
go
CREATE PROCEDURE sp_nhanvien_delete
	
	@manv char(11) 
AS
BEGIN 
    
	DELETE FROM nhanvien WHERE manv = @manv
END;
go 
