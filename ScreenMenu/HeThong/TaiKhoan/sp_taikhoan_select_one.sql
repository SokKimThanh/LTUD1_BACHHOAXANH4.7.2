-- Create Procedure sp_taikhoan_select_one.sql
-- T�i kho?n select one
-- Author:		Sok Kim Thanh
-- Create date: <16/11/2023>
go
drop procedure if exists sp_taikhoan_select_one
go
CREATE PROCEDURE sp_taikhoan_select_one
	@TENTK CHAR(30)
AS
BEGIN
	SELECT * from taikhoan where TENTK = @TENTK --  ch�nh x�c m� 100%
END
GO
