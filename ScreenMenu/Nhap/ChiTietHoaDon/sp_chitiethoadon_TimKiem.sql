
-- =============================================
-- Author:		Vo Tu
-- Create date: <13/11/2023>

-- =============================================
DROP PROCEDURE IF EXISTS sp_chitiethoadon_TimKiem
GO
CREATE PROCEDURE sp_chitiethoadon_TimKiem
	-- Add the parameters for the stored procedure here
	@ma nvarchar(50),
	@tensp nvarchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Delete statements for procedure here
	Select cthd.MAHD,sp.TENSP,cthd.SLMUA,sp.DONGIA*cthd.SLMUA as 'Thành tiền'
	from CHITIETHD cthd
	INNER Join SANPHAM sp on sp.MASP = cthd.MASP
	where cthd.MAHD = @ma and sp.TENSP like N'%'+@tensp+'%'
	 
END
GO
exec sp_chitiethoadon_TimKiem 'HD01','B'
