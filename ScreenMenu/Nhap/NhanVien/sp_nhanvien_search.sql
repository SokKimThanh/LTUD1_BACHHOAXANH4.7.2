
-- Author:		Sok Kim Thanh
-- Create date: <10/12/2023 9:33 SA>

drop procedure if exists sp_nhanvien_search
go
CREATE PROCEDURE sp_nhanvien_search
	-- Add the parameters for the stored procedure here
	@keyword nvarchar(100)
	 
AS
BEGIN 
    -- Insert statements for procedure here
	SELECT * from nhanvien where HOTENNV like '%' + @keyword + '%'--like chính xác mã 100%
END;
go

--select * from nhanvien
--exec sp_nhanvien_search 'b' --test ok