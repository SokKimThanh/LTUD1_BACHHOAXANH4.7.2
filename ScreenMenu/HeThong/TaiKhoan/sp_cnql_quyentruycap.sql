SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
set dateformat dmy
-- Author:		Sok Kim Thanh
-- Create date: <16/11/2023>
-- Description:	<account delete>
DROP PROCEDURE IF EXISTS sp_taikhoan_cnql_dangnhap
GO
CREATE PROCEDURE sp_taikhoan_cnql_dangnhap
	@tungay datetime,
	@denngay datetime 
AS
BEGIN
	Select * FROM taikhoan tk, nhanvien nv, truycap tc  WHERE tk.manv = nv.manv and tk.tentk = tc.tentk
END
