-- Create Procedure sp_chitiethoadon_select_all.sql
-- Danh mục select all
GO
GO
-- Author:		Quy Ngo
-- Create date: <10/12/2023>
drop procedure if exists sp_chitiethoadon_select_all
go
CREATE PROCEDURE sp_chitiethoadon_select_all
	@mahd char(11) 
AS
BEGIN
	SELECT hd.MAHD,sp.TENSP,ct.SLMUA,sp.DONGIA*ct.SLMUA as "Thành tiền"
	from CHITIETHD ct, HOADON hd, SANPHAM sp
	where ct.MAHD = hd.MAHD and sp.MASP = ct.MASP and ct.MAHD = @mahd;
END
GO
exec sp_chitiethoadon_select_all 'HD02'
