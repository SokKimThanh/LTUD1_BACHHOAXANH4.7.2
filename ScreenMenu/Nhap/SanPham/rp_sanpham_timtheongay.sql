--tim san pham het han su dung
-- Author:		Ngô Công Quý
-- Create date: <07/11/2023>
-- update date sok kim thanh 23/12/2023
set dateformat ymd
drop procedure if exists rp_sanpham_timtheongay
go
CREATE PROCEDURE rp_sanpham_timtheongay
	@NgayHT date = null
AS
BEGIN
	IF @NgayHT IS NULL
		SET @NgayHT = CAST(GETDATE() AS date);

	SELECT sp.*, ncc.TENNCC, ncc.SDTNCC  from sanpham sp, NHACUNGCAP ncc, LOAISP lsp where sp.HSD < @NgayHT;
END
GO

select * from SANPHAM
exec rp_sanpham_timtheongay 
