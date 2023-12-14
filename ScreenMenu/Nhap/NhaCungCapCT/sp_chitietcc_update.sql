-- Create Procedure sp_chitietcc_update.sql
-- Tài khoản update
-- Author:		Sok Kim Thanh
-- Create date: <14/12/2023>

go
drop procedure if exists sp_chitietcc_update
go
CREATE PROCEDURE sp_chitietcc_update
	@MANCC char(11),
	@MASP char(11),
	@SLCUNGCCAP int
AS
BEGIN
	update chitietcc set SLCUNGCCAP = @SLCUNGCCAP where MANCC = @MANCC and MASP = @MASP  -- chuẩn sql
END
GO

--execute sp_chitietcc_update 'ncc01', 'sp01', 10
--execute sp_chitietcc_select_one 'ncc01', 'sp01'
--execute sp_chitietcc_update 'ncc01', 'sp01', 100
--execute sp_chitietcc_select_one 'ncc01', 'sp01'
