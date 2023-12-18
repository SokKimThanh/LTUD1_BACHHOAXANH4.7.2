-- Author:		Vo Tu
-- Create date: <13/11/2023>
drop procedure if exists sp_diaiem_update
go
CREATE PROCEDURE sp_diadiem_update
	@maCN char(4) = '',
	@tenCN nvarchar(30),
	@diaChi nvarchar(100)
AS
BEGIN
	update CHINHANH set TENCN = @tenCN, DIACHICN = @diaChi  where MACN = @maCN -- chu?n sql
END
GO
--exec sp_diadiem_update 'CN05', N'Chi nhánh Bình Phu?c', N'S? 3 Nguy?n Van Linh, H?i Châu, Ðà N?ng';
select * from CHINHANH
