-- Create Procedure sp_sanpham_phantrang_count.sql
-- Author:		Sok Kim Thanh
-- Create date: <17/12/2023>
drop procedure if exists sp_sanpham_phantrang_count
go
CREATE PROCEDURE sp_sanpham_phantrang_count
    @loaiSanPham nvarchar(100) = NULL,
    @nhaCungCap nvarchar(100) = NULL,
    @searchTerm nvarchar(100) = NULL
AS
BEGIN 
    -- lấy dữ liệu và chỉ số dòng (row) của nó
    WITH phantrang AS (
        SELECT ROW_NUMBER() OVER (ORDER BY sp.masp) AS STT
            ,sp.masp, sp.tensp, sp.donvi, sp.dongia
            ,km.phantramgiamgia  as N'GiamGia'
	        ,dongia * (100- km.phantramgiamgia)/100 as N'GiaBan'
            ,sltonkho
        FROM sanpham sp
        INNER JOIN khuyenmai km ON sp.masp = km.masp
        WHERE tensp LIKE '%' + ISNULL(@searchTerm, tensp) + '%'
        AND MALOAI = ISNULL(@loaiSanPham, MALOAI)
        AND MANCC = ISNULL(@nhaCungCap, MANCC)
    )
    -- đếm số dòng
    SELECT COUNT(*) as TotalRows
    FROM phantrang;
END
