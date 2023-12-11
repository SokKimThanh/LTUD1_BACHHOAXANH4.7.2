-- ================================================
-- Create Procedure sp_chitiethoadon_delete.sql
-- Danh mục delete
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Quy Ngo
-- Create date: <10/12/2023>

-- =============================================
DROP PROCEDURE IF EXISTS sp_chitiethoadon_Kiemtratonkho
GO
CREATE PROCEDURE sp_chitiethoadon_Kiemtratonkho
	-- Add the parameters for the stored procedure here
	@makm char(11),
	@slmua int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Delete statements for procedure here
	Select  sp.SLTONKHO - @slmua as 'Tồn kho'
	from SANPHAM sp,HOADON hd
	 where  sp.MaSP = @makm 
END
GO
exec sp_chitiethoadon_Kiemtratonkho 'SP33', 36
select *
from SANPHAM