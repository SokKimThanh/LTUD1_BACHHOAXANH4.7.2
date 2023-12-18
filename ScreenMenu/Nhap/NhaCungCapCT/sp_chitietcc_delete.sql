SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
set dateformat dmy
-- Author:		Sok Kim Thanh
-- Create date: <14/12/2023>
-- Description:	<Tài kho?n delete>
DROP PROCEDURE IF EXISTS sp_chitietcc_delete
GO
CREATE PROCEDURE sp_chitietcc_delete
	@MANCC char(11),
	@MASP char(11)	
AS
BEGIN
	DELETE FROM chitietcc WHERE MANCC = @MANCC and  MASP = @MASP
END
GO
--select count(*) from CHITIETCC
--execute sp_chitietcc_delete 'ncc03', 'sp15'
--select count(*) from CHITIETCC
--select * from nhacungcap
--select * from sanpham
--select * from chitietcc
