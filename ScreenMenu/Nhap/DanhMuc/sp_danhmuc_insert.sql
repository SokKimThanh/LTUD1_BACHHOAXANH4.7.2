
-- Create Procedure sp_danhmuc_insert.sql
-- Danh mục insert
-- Author:		Sok Kim Thanh
-- Create date: <07/11/2023>


drop procedure if exists sp_danhmuc_insert
go
CREATE PROCEDURE sp_danhmuc_insert
	
	@MALOAI CHAR(11) ,
	@TENLOAI NVARCHAR(30),
	@GHICHU NVARCHAR(100)
AS
BEGIN
	
	
	

    
	INSERT INTO LOAISP VALUES (@MALOAI, @TENLOAI, @GHICHU)
END
GO
