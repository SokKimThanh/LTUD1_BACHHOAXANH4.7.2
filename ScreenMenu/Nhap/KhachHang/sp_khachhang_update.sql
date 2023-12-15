-- Create Procedure sp_khachhang_update.sql
-- Nhà cung cấp update
-- Author:		Vo Tu
-- Create date: <13/11/2023>
drop procedure if exists sp_khachhang_update
go
CREATE PROCEDURE sp_khachhang_update
	@maKH char(11) = '', 
	@tenKH nvarchar(30) = N'',
	@sdtKH int = 0,
	@diemTL int = 0
AS
BEGIN
	update KHACHHANG set HOTENKH = @tenKH,SDTKH = @sdtKH, DIEMTL = @diemTL where MAKH = @maKH -- chuẩn sql
END
GO
