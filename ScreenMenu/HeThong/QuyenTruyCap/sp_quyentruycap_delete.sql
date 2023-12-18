-- Author:		Sok Kim Thanh
-- Create date: <14/12/2023>
-- Description:	<Tài khoản delete>
DROP PROCEDURE IF EXISTS sp_quyentruycap_delete
GO
CREATE PROCEDURE sp_quyentruycap_delete
	@maQTC CHAR(11) 
AS
BEGIN
	DELETE FROM quyentruycap WHERE MAQTC = @maQTC
END
GO