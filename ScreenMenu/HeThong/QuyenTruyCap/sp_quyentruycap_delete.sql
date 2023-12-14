
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
set dateformat dmy
-- Author:		Sok Kim Thanh
-- Create date: <14/12/2023>
-- Description:	<Tài khoản delete>
DROP PROCEDURE IF EXISTS sp_quyentruycap_delete
GO
CREATE PROCEDURE sp_quyentruycap_delete
	
	@TENQTC CHAR(30) 
AS
BEGIN
	DELETE FROM quyentruycap WHERE TENQTC = @TENQTC
END
GO
