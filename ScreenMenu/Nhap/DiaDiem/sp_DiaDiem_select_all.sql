set dateformat dmy
-- ================================================
-- Create Procedure sp_diadiem_select_all.sql
-- hoadon select all
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Vo Tu
-- Create date: <13/11/2023>
-- Description:	<dia diem select all>
-- =============================================
drop procedure if exists sp_diadiem_select_all
go
CREATE PROCEDURE sp_diadiem_select_all
	-- Add the parameters for the stored procedure here
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON; 

    -- Insert statements for procedure here
	SELECT * from CHINHANH
END
GO
exec sp_diadiem_select_all
