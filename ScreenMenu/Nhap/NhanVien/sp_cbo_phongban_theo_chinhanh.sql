-- =============================================
-- Author:		<Thanh sok>
-- Create date: <12/12/2023>
-- Description:	<lấy danh sách phòng ban theo mã chi nhánh>
go
drop procedure if exists sp_cbo_laydanhsach_phongban_theo_chinhanh
go
CREATE PROCEDURE sp_cbo_laydanhsach_phongban_theo_chinhanh
	-- Add the parameters for the stored procedure here
	@macn CHAR(11)
AS
BEGIN
	select pb.MAPB, pb.TENPHG from phongban pb, chinhanh cn WHERE cn.MACN = pb.MACN and cn.macn = @macn
END;
go
exec sp_cbo_laydanhsach_phongban_theo_chinhanh 'cn01'
