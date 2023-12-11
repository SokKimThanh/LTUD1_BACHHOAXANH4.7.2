-- ================================================
-- Create Procedure sp_nhacungcap_insert.sql
-- Nhà cung cấp insert
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
set dateformat dmy
-- =============================================
-- Author:		Vo Tu
-- Create date: <13/11/2023>
-- Description:	<Mô tả>
-- =============================================
drop procedure if exists sp_hoadon_insert
go
CREATE PROCEDURE sp_hoadon_insert
	-- Add the parameters for the stored procedure here
	@maHD char(11) = '', 
	@ngayHD date,
	@tongTien decimal,
	@maNV char(11),
	@maKH char(11)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
    -- Insert statements for procedure here
	INSERT INTO HOADON VALUES (@maHD, @ngayHD, @tongTien,@maNV,@maKH)
END
GO
exec sp_hoadon_insert 'HD03','15/01/2022', 90000,'NV02', 'KH02'

select * from NHANVIEN

