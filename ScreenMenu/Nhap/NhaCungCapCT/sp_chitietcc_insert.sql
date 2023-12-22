-- Create Procedure sp_chitietcc_insert.sql
-- chitietcc insert
-- Author:		Sok Kim Thanh
-- Create date: <14/12/2023>
drop procedure if exists sp_chitietcc_insert
go
CREATE PROCEDURE sp_chitietcc_insert
	@MANCC char(11),
	@MASP char(11),
	@SLCUNGCCAP int
AS
BEGIN
	INSERT INTO chitietcc(MANCC,MASP,SLCUNGCCAP)
	Values(@MANCC,@MASP,@SLCUNGCCAP)
	Update SanPham set SLTONKHO += SLTONKHO + @SLCungCCap;
END
GO
--select count(*) from CHITIETCC
--execute sp_chitietcc_insert 'ncc01', 'sp02', 123 
--select count(*) from CHITIETCC
