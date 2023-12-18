-- Author:		Sok Kim Thanh
-- Create date: <16/12/2023>
-- Create Procedure sp_cbo_nhacungcap_select_all
drop procedure if exists sp_cbo_nhacungcap_select_all
go
CREATE PROCEDURE sp_cbo_nhacungcap_select_all
AS
BEGIN
	select MANCC, TENNCC from nhacungcap order by created_date_ncc desc
END;
GO
execute sp_cbo_nhacungcap_select_all