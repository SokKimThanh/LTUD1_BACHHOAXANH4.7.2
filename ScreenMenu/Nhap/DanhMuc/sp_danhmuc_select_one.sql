
-- Create Procedure sp_danhmuc_select_one.sql
-- Danh mục select one
-- Author:		Sok Kim Thanh
-- Create date: <07/11/2023>


drop procedure if exists sp_danhmuc_select_one
go
CREATE PROCEDURE sp_danhmuc_select_one
	
	@MALOAI CHAR(11) 
AS
BEGIN
	
	
	

    
	SELECT * from LOAISP where MALOAI = @MALOAI --like chính xác mã 100%
END
GO
