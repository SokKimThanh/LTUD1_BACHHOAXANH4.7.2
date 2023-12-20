-- Create Procedure sp_nhacungcap_select_all.sql
-- Nhà cung c?p select all
-- Author:		Vo Tu
-- Create date: <13/11/2023>
-- Description:	<Nhà cung c?p select all>
drop procedure if exists sp_cbb_khachhang_select_all
go
CREATE PROCEDURE sp_cbb_khachhang_select_all
AS
BEGIN
	SELECT kh.MAKH, kh.HOTENKH from KHACHHANG kh
END
GO
exec sp_cbb_khachhang_select_all
-- Create Procedure sp_nhacungcap_update.sql
-- Nhà cung c?p update
-- Author:		Vo Tu
-- Create date: <13/11/2023>
drop procedure if exists sp_khachhang_update
go
CREATE PROCEDURE sp_khachhang_update
	@maKH char(11) = '', 
	@tenKH NVARCHAR(255) = N'',
	@sdtKH int = 0,
	@diemTL int = 0
AS
BEGIN
	update KHACHHANG set HOTENKH = @tenKH,SDTKH = @sdtKH, DIEMTL = @diemTL where MAKH = @maKH -- chuẩn sql
END
GO
-- Create Procedure sp_nhacungcap_insert.sql
-- Nhà cung c?p insert
-- Author:		Vo Tu
-- Create date: <13/11/2023>
drop procedure if exists sp_nhacungcap_insert
go
CREATE PROCEDURE sp_khachhang_insert
	@maKH char(11) = '', 
	@tenKH NVARCHAR(255) = N'',
	@sdtKH int = 0,
	@diemTL int = 0
AS
BEGIN
	INSERT INTO KHACHHANG VALUES (@maKH, @tenKH, @sdtKH,@diemTL)
END
GO
-- Create Procedure sp_nhacungcap_delete.sql
-- Nhà cung c?p delete
-- Author:		Vo Tu
-- Create date: <13/11/2023>
DROP PROCEDURE IF EXISTS sp_khachhang_delete
GO
CREATE PROCEDURE sp_khachhang_delete
	@maKH char(11) = ''
AS
BEGIN
	DELETE FROM KHACHHANG WHERE MAKH = @maKH
END
GO
