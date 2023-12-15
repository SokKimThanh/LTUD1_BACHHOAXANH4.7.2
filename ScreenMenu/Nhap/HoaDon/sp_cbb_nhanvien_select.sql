set dateformat dmy

-- Create Procedure sp_nhanvien_select_all.sql
-- nhan vien select all
-- Author:		Vo Tu
-- Create date: <13/11/2023>
-- Description:	<nhan vien select all>
drop procedure if exists sp_nhanvien_select_all
go
CREATE PROCEDURE sp_nhanvien_select_all
AS
BEGIN
	SELECT nv.MANV,nv.HOTENNV from NHANVIEN nv
END
GO
exec sp_nhanvien_select_all
-- Create Procedure sp_nhacungcap_update.sql
-- Nhà cung cấp update
-- Author:		Vo Tu
-- Create date: <13/11/2023>

drop procedure if exists sp_hoadon_update
go
CREATE PROCEDURE sp_hoadon_update
	@maHD char(11) = '', 
	@ngayHD date,
	@tongTien decimal,
	@maNV char(11),
	@maKH char(11)
AS
BEGIN
	update HOADON set NGAYHOADON = @ngayHD, TONGTHANHTIEN = @tongTien, MANV = @maNV, MAKH =@maKH where MAHD = @maHD -- chuẩn sql
END
GO
--exec sp_hoadon_update'HD03','15/01/2022', 90000,'NV02', 'KH02'



-- Create Procedure sp_nhacungcap_insert.sql
-- Nhà cung cấp insert
-- Author:		Vo Tu
-- Create date: <13/11/2023>

drop procedure if exists sp_hoadon_insert
go
CREATE PROCEDURE sp_hoadon_insert
	@maHD char(11) = '', 
	@ngayHD date,
	@tongTien decimal,
	@maNV char(11),
	@maKH char(11)
AS
BEGIN
	INSERT INTO HOADON VALUES (@maHD, @ngayHD, @tongTien,@maNV,@maKH)
END
GO
--exec sp_hoadon_insert 'HD03','15/01/2022', 90000,'NV02', 'KH02'


-- Create Procedure sp_nhacungcap_delete.sql
-- Nhà cung cấp delete
-- Author:		Vo Tu
-- Create date: <13/11/2023>

DROP PROCEDURE IF EXISTS sp_hoadon_delete
GO
CREATE PROCEDURE sp_hoadon_delete
	@maHD char(11) = ''
AS
BEGIN
	DELETE FROM HOADON WHERE MAHD = @maHD
END
GO

