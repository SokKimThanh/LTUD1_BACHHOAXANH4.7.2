-- ================================================
-- Create Procedure sp_taikhoan_select_all.sql
-- Tài khoản select all
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Sok Kim Thanh
-- Create date: <16/11/2023>
-- Description:	<Mô tả>
-- =============================================
drop procedure if exists sp_taikhoan_select_all
go
CREATE PROCEDURE sp_taikhoan_select_all
	-- Add the parameters for the stored procedure here
	--@MATK CHAR(11), 
	--@TENTK NVARCHAR(30), 
	--@MATKHAU varchar(16),
	--@CREATEDATE datetime,
	--@PHONE varchar(11), 
	--@CCCD varchar(16), 
	--@EMAIL varchar(255)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT tk.TENTK as ID, tk.TENTK, qtc.TENQTC FROM TAIKHOAN tk, QUYENTRUYCAP qtc where tk.MAQTC = qtc.MAQTC
END
GO
 