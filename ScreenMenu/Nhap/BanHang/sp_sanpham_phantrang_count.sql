
-- Create Procedure sp_sanpham_phantrang_count.sql
-- Author:		Sok Kim Thanh
-- Create date: <17/12/2023>
drop procedure if exists sp_sanpham_phantrang_count
go
CREATE PROCEDURE sp_sanpham_phantrang_count
    @loaiSanPham char(11) = NULL, -- loại sản phẩm
    @nhaCungCap char(11) = NULL, -- nhà cung cấp
    @searchTerm nvarchar(100) = NULL -- từ khóa tìm kiếm
AS
BEGIN
    SELECT COUNT(*) 
    FROM sanpham sp
    WHERE tensp LIKE '%' + ISNULL(@searchTerm, tensp) + '%'
    AND MALOAI = ISNULL(@loaiSanPham, MALOAI)
    AND MANCC = ISNULL(@nhaCungCap, MANCC)
END
execute sp_sanpham_phantrang_count 'l01', null, null