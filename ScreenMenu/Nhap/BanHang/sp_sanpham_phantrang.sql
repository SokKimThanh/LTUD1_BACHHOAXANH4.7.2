 
drop procedure if exists sp_sanpham_phantrang
go
CREATE PROCEDURE sp_sanpham_phantrang
    @loaiSanPham nvarchar(100) = NULL, -- loại sản phẩm
    @nhaCungCap nvarchar(100) = NULL, -- nhà cung cấp
    @searchTerm nvarchar(100) = NULL, -- từ khóa tìm kiếm 
    @currPage int, -- trang hiện tại
    @recodperpage int -- số dòng trên 1 trang
AS
BEGIN 
    -- lấy dữ liệu và chỉ số dòng (row) của nó
    WITH phantrang AS (
        SELECT ROW_NUMBER() OVER (ORDER BY sp.masp) AS STT
            ,sp.masp, sp.tensp, sp.donvi, sp.dongia
            ,km.phantramgiamgia  as N'GiamGia'
	        ,dongia * (100- km.phantramgiamgia)/100 as N'GiaBan'
            ,sltonkho,MALOAI,MANCC
        FROM sanpham sp, khuyenmai km-- tên của bảng cần lấy dữ liệu
        WHERE tensp LIKE '%' + ISNULL(@searchTerm, tensp) + '%'
        AND MALOAI = ISNULL(@loaiSanPham, MALOAI)
        AND MANCC = ISNULL(@nhaCungCap, MANCC)
    )
    -- lấy các dòng có chỉ số row phù hợp các các tiêu chí phân trang
    SELECT * FROM phantrang WHERE STT BETWEEN (@currPage - 1)*@recodperpage+1 AND @currPage*@recodperpage;
END
select * from LOAISP
exec sp_sanpham_phantrang 'l01',null,null,1,8