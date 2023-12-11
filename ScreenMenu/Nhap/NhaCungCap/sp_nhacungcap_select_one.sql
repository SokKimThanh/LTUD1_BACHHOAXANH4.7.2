-- ================================================
-- Create Procedure sp_nhacungcap_select_one.sql
-- Nhà cung cấp select one
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Sok Kim Thanh
-- Create date: <07/11/2023>
-- update date: 10-12-2023
-- =============================================
drop procedure if exists sp_nhacungcap_select_one
go
CREATE PROCEDURE sp_nhacungcap_select_one
	-- Add the parameters for the stored procedure here
	@MANCC CHAR(11)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * from nhacungcap where MANCC like @MANCC --like chính xác mã 100%
END
GO
