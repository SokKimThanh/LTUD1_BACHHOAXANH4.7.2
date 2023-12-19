-- Create Procedure sp_nhanvien_update.sql
-- Nhân viên update
-- Author:		Sok Kim Thanh
-- Create date: <10/11/2023>
drop procedure if exists sp_phongban_update
go
CREATE PROCEDURE sp_phongban_update
	@maPB char(11),
	@tenPB NVARCHAR(255),
	@maCN nvarchar(100)
AS
BEGIN
	update PHONGBAN set TENPHG = @tenPB, MACN = @maCN where MACN = @maCN -- chu?n sql
END
GO
