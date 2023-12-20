-- Author:		Vo Tu
-- Create date: <13/11/2023>
drop procedure if exists sp_diaiem_update
go
CREATE PROCEDURE sp_diadiem_update
	@maCN char(4) = '',
	@tenCN NVARCHAR(255),
	@diaChi nvarchar(100)
AS
BEGIN
	update CHINHANH set TENCN = @tenCN, DIACHICN = @diaChi  where MACN = @maCN -- chuẩn sql
END
GO
--exec sp_diadiem_update 'CN05', N'Chi nhánh Bình Phu?c', N'Số 3 Nguyễn Văn Linh, Hải Châu, Đà Nẵng';
select * from CHINHANH
