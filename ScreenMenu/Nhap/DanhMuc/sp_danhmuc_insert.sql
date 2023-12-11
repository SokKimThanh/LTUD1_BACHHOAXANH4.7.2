﻿-- ================================================
-- Create Procedure sp_danhmuc_insert.sql
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
drop procedure if exists sp_danhmuc_insert
go
CREATE PROCEDURE sp_danhmuc_insert
	-- Add the parameters for the stored procedure here
	@MALOAI CHAR(11) ,
	@TENLOAI NVARCHAR(30),
	@GHICHU NVARCHAR(100)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO LOAISP VALUES (@MALOAI, @TENLOAI, @GHICHU)
END
GO
