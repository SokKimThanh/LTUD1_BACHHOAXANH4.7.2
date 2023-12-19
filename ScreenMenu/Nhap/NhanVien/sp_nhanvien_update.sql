-- Author:		Sok Kim Thanh
-- Create date: <06/12/2023 9:39 CH>
go
drop procedure if exists sp_nhanvien_update
go
CREATE PROCEDURE sp_nhanvien_update
	@manv char(11),
	@hotennv NVARCHAR(255),
	@diachinv nvarchar(100),
	@luong float,
	@sdtnv int,
	@ngaysinh date,
	@mapb char(4),
	@gioitinh nvarchar(10)
AS
BEGIN 
	update nhanvien set hotennv = @hotennv, diachinv = @diachinv,luong=@luong,sdtnv=@sdtnv ,ngaysinh=@ngaysinh, mapb = @mapb, gioitinh = @gioitinh where manv = @manv-- chu?n sql
END;
go
