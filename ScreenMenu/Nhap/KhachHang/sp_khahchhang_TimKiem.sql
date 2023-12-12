
-- =============================================
-- Author:		Vo Tu
-- Create date: <13/11/2023>
-- Description:	<Mô tả>
-- =============================================
DROP PROCEDURE IF EXISTS sp_khachhang_TimKiem
GO
CREATE PROCEDURE sp_khachhang_TimKiem
	-- Add the parameters for the stored procedure here
	@ma nvarchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Delete statements for procedure here
	Select *
	from KHACHHANG
	where MAKH like N'%'+@ma+'%' or HOTENKH like N'%'+@ma+'%' or SDTKH like N'%'+@ma+'%'
	 
END
GO
select * from KHACHHANG
exec sp_khachhang_TimKiem 'Lê'
