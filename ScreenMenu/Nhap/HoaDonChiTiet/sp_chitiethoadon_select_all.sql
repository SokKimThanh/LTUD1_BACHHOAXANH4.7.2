-- ================================================
-- Create Procedure sp_chitiethoadon_select_all.sql
-- Danh mục select all
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Quy Ngo
-- Create date: <10/12/2023>

-- =============================================
drop procedure if exists sp_chitiethoadon_select_all
go
CREATE PROCEDURE sp_chitiethoadon_select_all
	-- Add the parameters for the stored procedure here
	@mahd char(11) 
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT hd.MAHD,sp.TENSP,ct.SLMUA,sp.DONGIA*ct.SLMUA as 'Thành Tiền'
	from CHITIETHD ct, HOADON hd, SANPHAM sp, DANHMUC dm
	where ct.MAHD = hd.MAHD and sp.MASP = ct.MASP and ct.MAHD = @mahd and sp.MALOAI = dm.
END
GO
exec sp_chitiethoadon_select_all 'HD02'
