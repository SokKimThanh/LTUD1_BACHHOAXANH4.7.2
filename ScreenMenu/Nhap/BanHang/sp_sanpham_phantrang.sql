
-- Create Procedure sp_sanpham_phantrang.sql
-- Author:		Sok Kim Thanh
-- Create date: <16/12/2023>

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
        SELECT ROW_NUMBER() OVER (ORDER BY dongia) AS STT
            ,masp, tensp, donvi, dongia
            ,phantramgiam N'% giảm giá'
	        ,dongia * (100-phantramgiamgia)/100 N'Giá sau giảm giá'
            ,sltonkho
        FROM sanpham sp-- tên của bảng cần lấy dữ liệu
        WHERE tensp LIKE '%' + ISNULL(@searchTerm, tensp) + '%'
        AND MALOAI = ISNULL(@loaiSanPham, MALOAI)
        AND MANCC = ISNULL(@nhaCungCap, MANCC)
    )
    -- lấy các dòng có chỉ số row phù hợp các các tiêu chí phân trang
    SELECT * FROM phantrang WHERE Row BETWEEN (@currPage - 1)*@recodperpage+1 AND @currPage*@recodperpage
END



execute sp_sanpham_phantrang null,null,null,1,4