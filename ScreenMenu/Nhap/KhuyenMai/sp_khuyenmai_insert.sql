-- ================================================
-- Create Procedure sp_khuyenmai_insert.sql
-- Danh mục insert
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Sok Kim Thanh
-- Create date: <07/11/2023>
-- Description:	<Mô tả>
-- =============================================
drop procedure if exists sp_khuyenmai_insert
go
CREATE PROCEDURE sp_khuyenmai_insert
	-- Add the parameters for the stored procedure here
	@makm char(11) = '', 
	@ngaybd date,
	@ngaykt date,
	@maht char(11) = N''
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO khuyenmai VALUES (@makm, @ngaybd, @ngaykt,@maht)
END
GO
