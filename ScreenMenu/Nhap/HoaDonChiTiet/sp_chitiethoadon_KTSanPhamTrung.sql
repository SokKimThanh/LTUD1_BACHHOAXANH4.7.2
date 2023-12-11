-- ================================================
-- Create Procedure sp_chitiethoadon_update.sql
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
drop procedure if exists sp_chitiethoadon_TimMaSP
go
CREATE PROCEDURE sp_chitiethoadon_TimMaSP
	-- Add the parameters for the stored procedure here
	@masp char(11) = ''
	as
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	Select sp.MASP
	from  CHITIETHD sp
	where sp.MASP = @masp
	-- chuẩn sql
END
GO
