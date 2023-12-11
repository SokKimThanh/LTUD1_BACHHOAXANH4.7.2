-- ================================================
-- Create Procedure sp_taikhoan_update.sql
-- Tài khoản update
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
drop procedure if exists sp_taikhoan_update
go
CREATE PROCEDURE sp_taikhoan_update
	-- Add the parameters for the stored procedure here
	@MATK CHAR(11), 
	@TENTK NVARCHAR(30), 
	@MATKHAU varchar(16),
	--@CREATEDATE datetime,
	@PHONE varchar(11), 
	@CCCD varchar(16), 
	@EMAIL varchar(255)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	update taikhoan set tentk =  @tentk, matkhau = @matkhau, phone = @phone, cccd= @cccd, email = @email  where matk= @matk -- chuẩn sql
END
GO
