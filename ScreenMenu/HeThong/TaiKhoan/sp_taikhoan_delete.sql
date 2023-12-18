SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
set dateformat dmy
-- Author:		Sok Kim Thanh
-- Create date: <16/11/2023>
-- Description:	<Tài kho?n delete>
DROP PROCEDURE IF EXISTS sp_taikhoan_delete
GO
CREATE PROCEDURE sp_taikhoan_delete
	@TENTK CHAR(30) 
AS
BEGIN
	DELETE FROM taikhoan WHERE tentk = @TENTK
END
GO
