-- =============================================
-- Author:		Vo Tu
-- Create date: <13/11/2023>
-- Description:	<Mô tả>
-- =============================================
drop procedure if exists sp_diaiem_update
go
CREATE PROCEDURE sp_diadiem_update
	-- Add the parameters for the stored procedure here
@maCN char(4) = '',
	@tenCN nvarchar(30),
	@diaChi nvarchar(100)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	update CHINHANH set TENCN = @tenCN, DIACHICN = @diaChi  where MACN = @maCN -- chuẩn sql
END
GO
--exec sp_diadiem_update 'CN05', N'Chi nhánh Bình Phước', N'Số 3 Nguyễn Văn Linh, Hải Châu, Đà Nẵng';
select * from CHINHANH