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
DROP PROCEDURE IF EXISTS sp_chitiethoadon_delete
GO
CREATE PROCEDURE sp_chitiethoadon_delete
	-- Add the parameters for the stored procedure here
	@mahd char(11) ,
	@masp char(11)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	Update sp set sp.SLTONKHO = sp.SLTONKHO + ct.SLMUA 
	from SANPHAM sp,CHITIETHD ct
	where sp.MASP = @masp and ct.MASP = sp.MASP

    -- Delete statements for procedure here
	DELETE FROM CHITIETHD WHERE MAHD = @mahd and MASP = @masp
END
GO
