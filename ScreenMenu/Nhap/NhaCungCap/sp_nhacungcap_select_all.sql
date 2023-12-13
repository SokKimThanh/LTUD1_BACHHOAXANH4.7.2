-- Author:		Sok Kim Thanh
-- Create date: <07/11/2023>
-- update date: 10-12-2023
-- Create Procedure sp_nhacungcap_select_all
drop procedure if exists sp_nhacungcap_select_all
go
CREATE PROCEDURE sp_nhacungcap_select_all
AS
BEGIN
	select * from nhacungcap ncc order by ncc.created_date_ncc desc
END
GO

-- Author:		Sok Kim Thanh
-- Create date: <10/12/2023>
-- Create Procedure sp_nhacungcap_cu_select_all
drop procedure if exists sp_nhacungcap_cu_select_all
go
CREATE PROCEDURE sp_nhacungcap_cu_select_all
AS
BEGIN
	SELECT ncc.MANCC, ncc.TENNCC, sp.TENSP,ccct.SLCUNGCCAP from nhacungcap ncc, sanpham sp, CHITIETCC ccct 
	where ncc.MANCC = ccct.MANCC and sp.MASP = ccct.MASP
	order by ncc.created_date_ncc desc
END
GO

-- Author:		Sok Kim Thanh
-- Create date: <10/12/2023>
-- Create Procedure sp_nhacungcap_moi_select_all
drop procedure if exists sp_nhacungcap_moi_select_all
go
CREATE PROCEDURE sp_nhacungcap_moi_select_all
AS
BEGIN
	select * from NHACUNGCAP ncc where MANCC not in(
	SELECT ncc.MANCC from nhacungcap ncc, sanpham sp, CHITIETCC ccct 
	where ncc.MANCC = ccct.MANCC and sp.MASP = ccct.MASP group by ncc.MANCC)
	order by ncc.created_date_ncc desc
END
GO
--exec sp_nhacungcap_moi_select_all
--exec sp_nhacungcap_cu_select_all
--exec sp_nhacungcap_select_all