-- Create Procedure sp_nhanvien_insert.sql
-- phongban insert
-- Author:		Sok Kim Thanh
-- Create date: <10/11/2023>
drop procedure if exists sp_phongban_insert
go
CREATE PROCEDURE sp_PhongBan_insert
 @maPB char(11),
	@tenPB NVARCHAR(255),
	@maCN nvarchar(100)
AS
BEGIN
	INSERT INTO PHONGBAN VALUES (@maPB, @tenPB, @maCN)
END
GO
