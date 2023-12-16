
-- Create Procedure sp_nhacungcap_select_one.sql
-- Nhà cung cấp select one


GO

GO

-- Author:		Vo Tu
-- Create date: <13/11/2023>


drop procedure if exists sp_hoadon_select_one
go
CREATE PROCEDURE sp_hoadon_select_one
	
	@maHD char(11) = ''
AS
BEGIN
	SELECT * from HOADON where MAHD  = @maHD --like chính xác mã 100%
END
GO
exec sp_hoadon_select_one '12'