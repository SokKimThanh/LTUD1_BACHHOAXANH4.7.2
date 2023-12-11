-- ================================================
-- Create Procedure sp_nhacungcap_update.sql
-- Nhà cung cấp update
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
drop procedure if exists sp_nhacungcap_update
go
CREATE PROCEDURE sp_nhacungcap_update
	-- Add the parameters for the stored procedure here
	@MANCC CHAR(11),
	@TENNCC NVARCHAR(30) ,
	@DIACHINCC NVARCHAR(100),
	@SDTNCC INT   
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	update nhacungcap set TENNCC = @TENNCC, DIACHINCC = @DIACHINCC,SDTNCC = @SDTNCC where MANCC = @MANCC -- chuẩn sql
END
GO
