
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
exec sp_hoadon_update'HD03','15/01/2022', 90000,'NV02', 'KH02'