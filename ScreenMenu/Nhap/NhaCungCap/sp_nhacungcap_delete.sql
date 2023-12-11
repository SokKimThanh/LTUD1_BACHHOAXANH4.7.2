-- ================================================
-- Create Procedure sp_nhacungcap_delete.sql
-- Nhà cung cấp delete
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
DROP PROCEDURE IF EXISTS sp_nhacungcap_delete
GO
CREATE PROCEDURE sp_nhacungcap_delete
	-- Add the parameters for the stored procedure here
	@MANCC CHAR(11)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Delete statements for procedure here
	DELETE FROM nhacungcap WHERE MANCC = @MANCC
END
GO
--exec sp_nhacungcap_delete 'ncc04'-- khoa nay dang duoc su dung khong the delete
--select * from chitietcc