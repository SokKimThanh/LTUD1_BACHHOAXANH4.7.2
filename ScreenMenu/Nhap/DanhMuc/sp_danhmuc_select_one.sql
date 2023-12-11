﻿-- ================================================
-- Create Procedure sp_danhmuc_select_one.sql
-- Danh mục select one
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
drop procedure if exists sp_danhmuc_select_one
go
CREATE PROCEDURE sp_danhmuc_select_one
	-- Add the parameters for the stored procedure here
	@MALOAI CHAR(11) 
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * from LOAISP where MALOAI like @MALOAI --like chính xác mã 100%
END
GO
