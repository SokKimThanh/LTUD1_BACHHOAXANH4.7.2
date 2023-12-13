
-- Author:		Vo Tu
-- Create date: <13/11/2023>


DROP PROCEDURE IF EXISTS sp_hoadon_delete
GO
CREATE PROCEDURE sp_hoadon_delete
	
	@maHD char(11) = ''
AS
BEGIN
	
	
	
    
	DELETE FROM HOADON WHERE MAHD = @maHD
	DELETE FROM CHITIETHD WHERE MAHD = @maHD
end
