-- Author:		Sok Kim Thanh
-- Create date: <06/12/2023 9:39 CH>
go
drop procedure if exists sp_nhanvien_insert
go
CREATE PROCEDURE sp_nhanvien_insert
	@manv char(11),
	@hotennv nvarchar(30),
	@diachinv nvarchar(100),
	@luong float,
	@sdtnv int,
	@ngaysinh date,
	@mapb char(4),
	@gioitinh char(4)
AS
BEGIN 
	-- Ð?i 50 milliseconds
	WAITFOR DELAY '00:00:00.050';
	INSERT INTO nhanvien(manv, hotennv, diachinv, luong, sdtnv, ngaysinh,mapb, gioitinh) 
	VALUES (@manv, @hotennv, @diachinv, @luong, @sdtnv, @ngaysinh,@mapb, @gioitinh);
END;
go
--exec sp_nhanvien_insert 'nv', 'hoang van dung', '222 dia chi ma', 3214232, 123123,'09-09-2000','pb01', 'nam'
--Select * from nhanvien order by created_date asc where gioitinh = 'nam';
