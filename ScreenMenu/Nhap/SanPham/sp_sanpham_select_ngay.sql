﻿-- Create Procedure sp_sanpham_select_one.sql
-- Sản phẩm select one
-- Author:		Ngô Công Quý
-- Create date: <07/11/2023>
set dateformat ymd
drop procedure if exists sp_sanpham_select_ngay
go
CREATE PROCEDURE sp_sanpham_select_ngay
	@NgayHT date
AS
BEGIN
	SELECT * from sanpham sp,NHACUNGCAP ncc,LOAISP lsp where sp.HSD = @NgayHT--like chính xác mã 100%
	
END
GO
select * From SANPHAM
exec sp_sanpham_select_ngay
