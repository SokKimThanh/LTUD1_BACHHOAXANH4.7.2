-- ================================================
-- Create Procedure sp_hinhthuckm_update.sql
-- Danh mục update
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Quy Ngo
-- Create date: <10/12/2023>

-- =============================================
drop procedure if exists sp_chitiethoadon_update
go
CREATE PROCEDURE sp_chitiethoadon_update
	-- Add the parameters for the stored procedure here
	@mahd char(11) = '', 
	@masp char(11) = '',
	@sl int
	as
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	Update sp set sp.SLTONKHO = sp.SLTONKHO + ct.SLMUA 
	 from SANPHAM sp,CHITIETHD ct
	 where sp.MASP = @masp and ct.MASP = sp.MASP
    -- Insert statements for procedure here
	update CHITIETHD set SLMUA = @sl where MAHD = @mahd and  MASP = @masp -- chuẩn sql

	Update SANPHAM set SLTONKHO = SLTONKHO - @sl where MASP = @masp;
END
GO
exec sp_chitiethoadon_update 'HD01','SP02',50
select *
from CHITIETHD
where MAHD = 'HD01' and MASP = 'SP02'
