-- ================================================
-- Create Procedure sp_chitiethoadon_insert.sql
-- Danh mục insert
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Quy Ngo
-- Create date: <10/12/2023>

-- =============================================
drop procedure if exists sp_chitiethoadon_insert
go
CREATE PROCEDURE sp_chitiethoadon_insert
	-- Add the parameters for the stored procedure here
	@mahd char(11) = '', 
    @masp char(11) = '',
	@sl int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO CHITIETHD(mahd, masp, slmua) VALUES (@mahd, @masp, @sl)

	Update SANPHAM set SLTONKHO = SLTONKHO - @sl where MASP = @masp;
END
GO
select count (*) from chitiethd;
exec sp_chitiethoadon_insert 'hd03', 'sp02', 40
exec sp_chitiethoadon_select_one 'hd03'
select count (*) from chitiethd;
