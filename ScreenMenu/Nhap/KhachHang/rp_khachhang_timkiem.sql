-- Author:		Vo Tu
-- Create date: <13/11/2023>
DROP PROCEDURE IF EXISTS rp_khachhang_timkiem
GO
CREATE PROCEDURE rp_khachhang_timkiem
	@ma nvarchar(50)
AS
BEGIN
    -- Delete statements for procedure here
	Select *
	from KHACHHANG
	where MAKH like N'%'+@ma+'%' or HOTENKH like N'%'+@ma+'%' or SDTKH like N'%'+@ma+'%'
END
GO
select * from KHACHHANG
exec rp_khachhang_timkiem 'Lê'
