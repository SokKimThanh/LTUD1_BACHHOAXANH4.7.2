-- Author:		Vo Tu
-- Create date: <13/11/2023>
DROP PROCEDURE IF EXISTS sp_khachhang_TimKiem
GO
CREATE PROCEDURE sp_khachhang_TimKiem
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
exec sp_khachhang_TimKiem 'Lê'
