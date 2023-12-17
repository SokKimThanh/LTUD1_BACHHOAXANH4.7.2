-- Create Procedure sp_sanpham_phantrang.sql
-- Author:		Sok Kim Thanh
-- Create date: <16/12/2023>
-- update date 17/12/2023
drop procedure if exists sp_sanpham_phantrang
go
CREATE PROCEDURE sp_sanpham_phantrang
    @loaiSanPham nvarchar(100) = NULL,
    @nhaCungCap nvarchar(100) = NULL,
    @searchTerm nvarchar(100) = NULL,
    @currPage int,
    @recodperpage int
AS
BEGIN 
    WITH phantrang AS (
        SELECT ROW_NUMBER() OVER (ORDER BY sp.masp) AS STT
            ,sp.masp, sp.tensp, sp.donvi, sp.dongia
            ,km.phantramgiamgia  as GiamGia
	        ,dongia * (100- km.phantramgiamgia)/100 as GiaBan
            ,sltonkho
        FROM sanpham sp
        INNER JOIN khuyenmai km ON sp.MAKM = km.MAKM
        WHERE tensp LIKE '%' + ISNULL(@searchTerm, tensp) + '%'
        AND MALOAI = ISNULL(@loaiSanPham, MALOAI)
        AND MANCC = ISNULL(@nhaCungCap, MANCC)
    )
    SELECT STT, masp, tensp, donvi, dongia, GiamGia, GiaBan, sltonkho
    FROM phantrang 
    WHERE STT BETWEEN (@currPage - 1)*@recodperpage+1 AND @currPage*@recodperpage;
END

select * from LOAISP
select * from nhacungcap
execute sp_sanpham_phantrang 'l01','ncc02','a',1,16