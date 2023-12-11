-- Author:		Sok Kim Thanh
-- Create date: <06/12/2023>
drop procedure if exists sp_cbo_phongban
go
CREATE PROCEDURE sp_cbo_phongban
	-- Add the parameters for the stored procedure here
	 
AS
BEGIN 
    -- Delete statements for procedure here
	Select MAPB, TENPHG FROM PHONGBAN
END;
go
