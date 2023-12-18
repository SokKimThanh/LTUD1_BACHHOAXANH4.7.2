-- Create Procedure sp_sanpham_select_all.SQL
-- S?n ph?m select all
-- Author:		<Sok Kim Thanh>
-- Create date: <07/11/2023>
-- Description:	<S?n ph?m select all>
drop procedure if exists sp_sanpham_select_all
go
CREATE PROCEDURE sp_sanpham_select_all
AS
BEGIN
	select * from sanpham
END
GO
