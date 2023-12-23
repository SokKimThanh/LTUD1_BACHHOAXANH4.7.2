-- Author:		Sok Kim Thanh
-- Create date: <23/12/2023>
go
drop procedure if exists sp_cbo_nhanvien
go
CREATE PROCEDURE sp_cbo_nhanvien
AS
BEGIN 
	Select manv, hotennv FROM nhanvien
END;
go

execute sp_cbo_nhanvien