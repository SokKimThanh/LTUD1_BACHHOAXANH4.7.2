set dateformat dmy

-- Create Procedure sp_diadiem_select_all.sql
-- hoadon select all


GO

GO

-- Author:		Vo Tu
-- Create date: <13/11/2023>
-- Description:	<dia diem select all>

drop procedure if exists sp_diadiem_select_all
go
CREATE PROCEDURE sp_diadiem_select_all
	
AS
BEGIN
	
	
	 

    
	SELECT * from CHINHANH
END
GO
exec sp_diadiem_select_all
