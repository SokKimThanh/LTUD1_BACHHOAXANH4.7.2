-- Author:		Sok Kim Thanh
-- Create date: <06/12/2023>
go
drop procedure if exists sp_cbo_phongban
go
CREATE PROCEDURE sp_cbo_phongban
	
	 
AS
BEGIN 
    
	Select MAPB, TENPHG FROM PHONGBAN
END;
go
