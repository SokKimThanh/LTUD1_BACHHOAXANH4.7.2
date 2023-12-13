-- Author:		Sok Kim Thanh
-- Create date: <10/12/2023 9:33 SA>
go
drop procedure if exists sp_nhanvien_search
go
CREATE PROCEDURE sp_nhanvien_search
	
	@keyword nvarchar(100)
	 
AS
BEGIN 
    
	SELECT * from nhanvien where HOTENNV like '%' + @keyword + '%'--like chính xác mã 100%
END;
go

--select * from nhanvien
--exec sp_nhanvien_search 'b' --test ok