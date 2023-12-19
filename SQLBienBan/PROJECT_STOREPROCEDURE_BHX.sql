-- Author:		Sok Kim Thanh
-- Create date: <14/12/2023>
-- Description:	<Tài kho?n delete>
DROP PROCEDURE IF EXISTS sp_quyentruycap_delete
GO
CREATE PROCEDURE sp_quyentruycap_delete
	@maQTC CHAR(11) 
AS
BEGIN
	DELETE FROM quyentruycap WHERE MAQTC = @maQTC
END
GO
-- Create Procedure sp_quyentruycap_insert.sql
-- Tài kho?n insert
-- Author:		Sok Kim Thanh
-- Create date: <14/12/2023>
drop procedure if exists sp_quyentruycap_insert
go
CREATE PROCEDURE sp_quyentruycap_insert
	@MAQTC char(11),
	@TENQTC  CHAR(30)  	
AS
BEGIN
	INSERT INTO quyentruycap VALUES (@MAQTC, @TENQTC)
END
GO
-- Create Procedure sp_quyentruycap_select_all.sql
-- Tài kho?n select all
-- Author:		Sok Kim Thanh
-- Create date: <14/12/2023>
drop procedure if exists sp_quyentruycap_select_all
go
CREATE PROCEDURE sp_quyentruycap_select_all
AS
BEGIN
	SELECT qtc.maqtc, qtc.TENQTC FROM quyentruycap qtc
END
GO
-- Create Procedure sp_quyentruycap_select_one.sql
-- Tài kho?n select one
-- Author:		Sok Kim Thanh
-- Create date: <14/12/2023>
go
drop procedure if exists sp_quyentruycap_select_one
go
CREATE PROCEDURE sp_quyentruycap_select_one
	@MAQTC CHAR(30)
AS
BEGIN
	SELECT * from quyentruycap where MAQTC = @MAQTC --  chính xác mã 100%
END
GO
-- Create Procedure sp_quyentruycap_update.sql
-- Tài kho?n update
-- Author:		Sok Kim Thanh
-- Create date: <14/12/2023>
go
drop procedure if exists sp_quyentruycap_update
go
CREATE PROCEDURE sp_quyentruycap_update
	@TENQTC CHAR(30),
	@MAQTC char (11)
AS
BEGIN
	update quyentruycap set TENQTC= @TENQTC where MAQTC = @MAQTC  -- chu?n sql
END
GO
-- Create Procedure sp_quyentruycap_select_all.sql
-- Tài kho?n select all
-- Author:		Sok Kim Thanh
-- Create date: <14/12/2023>
drop procedure if exists sp_cbo_quyentruycap_select_all
go
CREATE PROCEDURE sp_cbo_quyentruycap_select_all
AS
BEGIN
	SELECT qtc.maqtc, qtc.TENQTC FROM quyentruycap qtc
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
set dateformat dmy
-- Author:		Sok Kim Thanh
-- Create date: <16/11/2023>
-- Description:	<Tài kho?n delete>
DROP PROCEDURE IF EXISTS sp_taikhoan_delete
GO
CREATE PROCEDURE sp_taikhoan_delete
	@TENTK CHAR(30) 
AS
BEGIN
	DELETE FROM taikhoan WHERE tentk = @TENTK
END
GO
-- Create Procedure sp_taikhoan_insert.sql
-- Tài kho?n insert
-- Author:		Sok Kim Thanh
-- Create date: <16/11/2023> 
drop procedure if exists sp_taikhoan_insert
go
CREATE PROCEDURE sp_taikhoan_insert
	@tentk  CHAR(30), 
	@matkhau char(30),
	@manv char(11),
	@maqtc char(11)
AS
BEGIN
	INSERT INTO taikhoan VALUES (@tentk, @matkhau, @manv, @maqtc)
END
GO
-- Create Procedure sp_taikhoan_select_all.sql
-- Tài kho?n select all
-- Author:		Sok Kim Thanh
-- Create date: <16/11/2023>
drop procedure if exists sp_taikhoan_select_all
go
CREATE PROCEDURE sp_taikhoan_select_all
AS
BEGIN
SELECT * from TAIKHOAN
END
GO
-- Create Procedure sp_taikhoan_select_one.sql
-- Tài kho?n select one
-- Author:		Sok Kim Thanh
-- Create date: <16/11/2023>
go
drop procedure if exists sp_taikhoan_select_one
go
CREATE PROCEDURE sp_taikhoan_select_one
	@TENTK CHAR(30)
AS
BEGIN
	SELECT * from taikhoan where TENTK = @TENTK --  chính xác mã 100%
END
GO
-- Create Procedure sp_taikhoan_update.sql
-- Tài kho?n update
-- Author:		Sok Kim Thanh
-- Create date: <16/11/2023>
go
drop procedure if exists sp_taikhoan_update
go
CREATE PROCEDURE sp_taikhoan_update
	@TENTK CHAR(30), 
	@MATKHAU char(16),
	@MANV char(11),
	@MAQTC char (11)
AS
BEGIN
	update taikhoan set matkhau = @MATKHAU, manv = @MANV, MAQTC = @MAQTC where tentk= @TENTK -- chu?n sql
END
GO
-- Create Procedure sp_danhmuc_select_all.sql
-- Danh m?c select all
-- Author:		Sok Kim Thanh
-- Create date: <07/11/2023>
drop procedure if exists sp_cbo_danhmuc_select_all
go
CREATE PROCEDURE sp_cbo_danhmuc_select_all
AS
BEGIN
	SELECT maloai, tenloai from LOAISP
END;
GO
execute sp_cbo_danhmuc_select_all
-- Author:		Sok Kim Thanh
-- Create date: <16/12/2023>
-- Create Procedure sp_cbo_nhacungcap_select_all
drop procedure if exists sp_cbo_nhacungcap_select_all
go
CREATE PROCEDURE sp_cbo_nhacungcap_select_all
AS
BEGIN
	select MANCC, TENNCC from nhacungcap order by created_date_ncc desc
END;
GO
execute sp_cbo_nhacungcap_select_all
-- Create Procedure sp_sanpham_select_all.SQL
-- S?n ph?m gi?m giá
-- Author:		<Sok Kim Thanh>
-- Create date: <17/12/2023>
-- Description:	<S?n ph?m gi?m giá>
drop procedure if exists sp_sanpham_giamgia_select_all
go
CREATE PROCEDURE sp_sanpham_giamgia_select_all
@MAHD CHAR(11)
AS
BEGIN
	Declare  @TT int = 0;
	select   @TT   +=  sp.dongia * (100-km.phantramgiamgia)/100 * ct.SLMUA
	from CHITIETHD ct,HOADON hd,SANPHAM sp,KHUYENMAI km
	where ct.MAHD = hd.MAHD and sp.MASP = ct.MASP and ct.MAHD = @mahd and sp.MAKM = km.MAKM
	--select @TT as 'T?ng thành ti?n'
	Update HOADON
	set TONGTHANHTIEN = @TT
	where MAHD = @mahd; 
	select hd.MAHD,hd.NGAYHOADON,hd.MANV, sp.masp,sp.tensp,cthd.SLMUA 
	,sp.dongia N'Giá G?c'
	, sp.donvi N'Ðon v? tính'
	,km.phantramgiamgia N'Ph?n tram gi?m giá'
	,sp.dongia * (100-km.phantramgiamgia)/100 N'Giá sau gi?m giá'
	,sp.sltonkho N'T?n kho',
	cthd.SLMUA
	,sp.dongia * (100-km.phantramgiamgia)/100 * cthd.SLMUA N'Thành ti?n'
	,hd.TONGTHANHTIEN N'T?ng thành ti?n'
	from SanPham sp,KHUYENMAI km, HOADON hd, CHITIETHD cthd
	where sp.MAKM = km.MAKM and hd.MAHD = @MAHD and cthd.MAHD = hd.MAHD and cthd.MASP = sp.MASP
	select TONGTHANHTIEN  from HoaDon where HOADON.MAHD =@MAHD
END;
GO
--select * from SANPHAM
exec sp_sanpham_giamgia_select_all 'HD01'
-- CREATE PROCEDURE SP_SANPHAM_PHANTRANG.SQL
-- AUTHOR:		SOK KIM THANH
-- CREATE DATE: <16/12/2023>
-- UPDATE DATE 17/12/2023
DROP PROCEDURE IF EXISTS sp_sanpham_phantrang
GO
CREATE PROCEDURE sp_sanpham_phantrang
    @LOAISANPHAM NVARCHAR(100) = NULL,
    @NHACUNGCAP NVARCHAR(100) = NULL,
    @SEARCHTERM NVARCHAR(100) = NULL,
    @CURRPAGE INT,
    @RECODPERPAGE INT
AS
BEGIN 
    WITH PHANTRANG AS (
        SELECT ROW_NUMBER() OVER (ORDER BY SP.MASP) AS STT
            ,SP.MASP, SP.TENSP, SP.DONVI, SP.DONGIA
            ,KM.PHANTRAMGIAMGIA  AS GIAMGIA
	        ,DONGIA * (100- KM.PHANTRAMGIAMGIA)/100 AS GIABAN
            ,SLTONKHO
        FROM SANPHAM SP
        INNER JOIN KHUYENMAI KM ON SP.MAKM = KM.MAKM
        WHERE TENSP LIKE '%' + ISNULL(@SEARCHTERM, TENSP) + '%'
        AND MALOAI = ISNULL(@LOAISANPHAM, MALOAI)
        AND MANCC = ISNULL(@NHACUNGCAP, MANCC) AND SLTONKHO > 0 
    )
    SELECT STT, MASP, TENSP, DONVI, DONGIA, GIAMGIA, GIABAN, SLTONKHO
    FROM PHANTRANG 
    WHERE STT BETWEEN (@CURRPAGE - 1)*@RECODPERPAGE+1 AND @CURRPAGE*@RECODPERPAGE;
END;
go
SELECT * FROM LOAISP
SELECT * FROM NHACUNGCAP
EXECUTE sp_sanpham_phantrang 'L01','NCC02','A',1,16
-- AUTHOR:		SOK KIM THANH
-- CREATE DATE: <17/12/2023>
-- UPDATE DATE 6:44 CH
DROP PROCEDURE IF EXISTS sp_sanpham_phantrang_count
GO
CREATE PROCEDURE sp_sanpham_phantrang_count
    @LOAISANPHAM NVARCHAR(100) = NULL,
    @NHACUNGCAP NVARCHAR(100) = NULL,
    @SEARCHTERM NVARCHAR(100) = NULL
AS
BEGIN 
    -- L?Y D? LI?U VÀ CH? S? DÒNG (ROW) C?A NÓ
    WITH PHANTRANG AS (
        SELECT ROW_NUMBER() OVER (ORDER BY SP.MASP) AS STT
            ,SP.MASP, SP.TENSP, SP.DONVI, SP.DONGIA
            ,KM.PHANTRAMGIAMGIA  AS GIAMGIA
	        ,DONGIA * (100- KM.PHANTRAMGIAMGIA)/100 AS GIABAN
            ,SLTONKHO
        FROM SANPHAM SP
        INNER JOIN KHUYENMAI KM ON SP.MAKM = KM.MAKM
        WHERE TENSP LIKE '%' + ISNULL(@SEARCHTERM, TENSP) + '%'
        AND MALOAI = ISNULL(@LOAISANPHAM, MALOAI)
        AND MANCC = ISNULL(@NHACUNGCAP, MANCC) AND SLTONKHO > 0
    )
    -- Ð?M S? DÒNG
    SELECT COUNT(*) AS TOTALROWS
    FROM PHANTRANG;
END;
GO
EXECUTE SP_SANPHAM_PHANTRANG_COUNT NULL,NULL,'F'
-- Create Procedure sp_danhmuc_delete.sql
-- Danh m?c delete
-- Author:		Sok Kim Thanh
-- Create date: <07/11/2023>
DROP PROCEDURE IF EXISTS sp_danhmuc_delete
GO
CREATE PROCEDURE sp_danhmuc_delete
	@MALOAI CHAR(11) 
AS
BEGIN
	DELETE FROM LOAISP WHERE MALOAI = @MALOAI
END
GO
-- Create Procedure sp_danhmuc_insert.sql
-- Danh m?c insert
-- Author:		Sok Kim Thanh
-- Create date: <07/11/2023>
drop procedure if exists sp_danhmuc_insert
go
CREATE PROCEDURE sp_danhmuc_insert
	@MALOAI CHAR(11) ,
	@TENLOAI NVARCHAR(255),
	@GHICHU NVARCHAR(100)
AS
BEGIN
	INSERT INTO LOAISP VALUES (@MALOAI, @TENLOAI, @GHICHU)
END
GO
-- Create Procedure sp_danhmuc_select_all.sql
-- Danh m?c select all
-- Author:		Sok Kim Thanh
-- Create date: <07/11/2023>
drop procedure if exists sp_danhmuc_select_all
go
CREATE PROCEDURE sp_danhmuc_select_all
AS
BEGIN
	SELECT * from LOAISP
END
GO
-- Create Procedure sp_danhmuc_select_one.sql
-- Danh m?c select one
-- Author:		Sok Kim Thanh
-- Create date: <07/11/2023>
drop procedure if exists sp_danhmuc_select_one
go
CREATE PROCEDURE sp_danhmuc_select_one
	@MALOAI CHAR(11) 
AS
BEGIN
	SELECT * from LOAISP where MALOAI = @MALOAI --like chính xác mã 100%
END
GO
-- Create Procedure sp_danhmuc_update.sql
-- Danh m?c update
-- Author:		Sok Kim Thanh
-- Create date: <07/11/2023>
drop procedure if exists sp_danhmuc_update
go
CREATE PROCEDURE sp_danhmuc_update
	@MALOAI CHAR(11),
	@TENLOAI NVARCHAR(255),
	@GHICHU NVARCHAR(100)
AS
BEGIN
	update LOAISP set TENLOAI = @TENLOAI, GHICHU = @GHICHU where MALOAI = @MALOAI -- chu?n sql
END
GO
-- Author:		Vo Tu
-- Create date: <13/11/2023>
DROP PROCEDURE IF EXISTS sp_diadiem_delete
GO
CREATE PROCEDURE sp_diadiem_delete
	@maCN char(4) = ''
AS
BEGIN
	DELETE FROM CHINHANH WHERE MACN = @maCN
END
GO
-- Create Procedure sp_diadiem_insert.sql
-- Nhà cung c?p insert
-- Author:		Vo Tu
-- Create date: <13/11/2023>
set dateformat dmy
drop procedure if exists sp_diadiem_insert
go
CREATE PROCEDURE sp_diadiem_insert
	@maCN char(4) = '',
	@tenCN NVARCHAR(255),
	@diaChi nvarchar(100)
AS
BEGIN
	INSERT INTO CHINHANH VALUES (@maCN,@tenCN,@diaChi)
END
GO
exec sp_diadiem_insert 'CN05', N'Chi nhánh Ðà N?ng', N'S? 3 Nguy?n Van Linh, H?i Châu, Ðà N?ng';
select * from CHINHANH
set dateformat dmy
-- Create Procedure sp_diadiem_select_all.sql
-- hoadon select all
GO
GO
-- Author:		Vo Tu
-- Create date: <13/11/2023>
-- Description:	<dia diem select all>
drop procedure if exists sp_diadiem_select_all
go
CREATE PROCEDURE sp_diadiem_select_all
AS
BEGIN
	SELECT * from CHINHANH
END
GO
exec sp_diadiem_select_all
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
	update CHINHANH set TENCN = @tenCN, DIACHICN = @diaChi  where MACN = @maCN -- chu?n sql
END
GO
--exec sp_diadiem_update 'CN05', N'Chi nhánh Bình Phu?c', N'S? 3 Nguy?n Van Linh, H?i Châu, Ðà N?ng';
select * from CHINHANH
-- Create Procedure sp_hinhthuckm_delete.sql
-- Danh m?c delete
-- Author:		Sok Kim Thanh
-- Create date: <07/11/2023>
DROP PROCEDURE IF EXISTS sp_hinhthuckm_delete
GO
CREATE PROCEDURE sp_hinhthuckm_delete
	@makm char(11) 
AS
BEGIN
	DELETE FROM hinhthuckm WHERE MAHT = @makm
END
GO
-- Create Procedure sp_hinhthuckm_insert.sql
-- Danh m?c insert
-- Author:		Sok Kim Thanh
-- Create date: <07/11/2023>
drop procedure if exists sp_hinhthuckm_insert
go
CREATE PROCEDURE sp_hinhthuckm_insert
	@makm char(11) = '', 
	@hinhthuc nvarchar(50) = N'',
	@ghichu nvarchar(100) = N''
AS
BEGIN 
	INSERT INTO hinhthuckm VALUES (@makm, @hinhthuc, @ghichu)
END
GO
-- Create Procedure sp_hinhthuckm_select_all.sql
-- Danh m?c select all
-- Author:		Sok Kim Thanh
-- Create date: <07/11/2023>
drop procedure if exists sp_hinhthuckm_select_all
go
CREATE PROCEDURE sp_hinhthuckm_select_all
AS
BEGIN
	SELECT * from hinhthuckm
END
GO
-- Create Procedure sp_hinhthuckm_select_one.sql
-- Danh m?c select one
-- Author:		Sok Kim Thanh
-- Create date: <07/11/2023>
drop procedure if exists sp_hinhthuckm_select_one
go
CREATE PROCEDURE sp_hinhthuckm_select_one
	@makm char(11) = '', 
	@hinhthuc nvarchar(50) = N'',
	@ghichu nvarchar(100) = N''
AS
BEGIN
	SELECT * from hinhthuckm where MAHT = @makm --like chính xác mã 100%
END
GO
-- Create Procedure sp_hinhthuckm_update.sql
-- Danh m?c update
-- Author:		Sok Kim Thanh
-- Create date: <07/11/2023>
drop procedure if exists sp_hinhthuckm_update
go
CREATE PROCEDURE sp_hinhthuckm_update
	@makm char(11) = '', 
	@hinhthuc nvarchar(50) = N'',
	@ghichu nvarchar(100) = N''
AS
BEGIN
	update hinhthuckm set TENHINHTHUC = @hinhthuc, ghichu = @ghichu  where MAHT = @makm -- chu?n sql
END
GO
-- Author:		Vo Tu
-- Create date: <13/11/2023>
set dateformat dmy
DROP PROCEDURE IF EXISTS rp_hoadon_theongay
GO
CREATE PROCEDURE rp_hoadon_theongay
	@ngay date
AS
BEGIN
	Select hd.MAHD,hd.NGAYHOADON,hd.TONGTHANHTIEN,nv.HOTENNV,kh.HOTENKH
	from HOADON hd
	INNER Join NHANVIEN nv on hd.MANV = nv.MANV
	INNER Join KHACHHANG kh on hd.MAKH = kh.MAKH
	where hd.NGAYHOADON = @ngay
END
GO
exec rp_hoadon_theongay '1-01-2022'
select * from HOADON
-- Create Procedure sp_nhacungcap_select_all.sql
-- Nhà cung c?p select all
-- Author:		Vo Tu
-- Create date: <13/11/2023>
-- Description:	<Nhà cung c?p select all>
drop procedure if exists sp_cbb_khachhang_select_all
go
CREATE PROCEDURE sp_cbb_khachhang_select_all
AS
BEGIN
	SELECT kh.MAKH, kh.HOTENKH from KHACHHANG kh
END
GO
exec sp_cbb_khachhang_select_all
-- Create Procedure sp_nhacungcap_update.sql
-- Nhà cung c?p update
-- Author:		Vo Tu
-- Create date: <13/11/2023>
drop procedure if exists sp_khachhang_update
go
CREATE PROCEDURE sp_khachhang_update
	@maKH char(11) = '', 
	@tenKH NVARCHAR(255) = N'',
	@sdtKH int = 0,
	@diemTL int = 0
AS
BEGIN
	update KHACHHANG set HOTENKH = @tenKH,SDTKH = @sdtKH, DIEMTL = @diemTL where MAKH = @maKH -- chu?n sql
END
GO
-- Create Procedure sp_nhacungcap_insert.sql
-- Nhà cung c?p insert
-- Author:		Vo Tu
-- Create date: <13/11/2023>
drop procedure if exists sp_nhacungcap_insert
go
CREATE PROCEDURE sp_khachhang_insert
	@maKH char(11) = '', 
	@tenKH NVARCHAR(255) = N'',
	@sdtKH int = 0,
	@diemTL int = 0
AS
BEGIN
	INSERT INTO KHACHHANG VALUES (@maKH, @tenKH, @sdtKH,@diemTL)
END
GO
-- Create Procedure sp_nhacungcap_delete.sql
-- Nhà cung c?p delete
-- Author:		Vo Tu
-- Create date: <13/11/2023>
DROP PROCEDURE IF EXISTS sp_khachhang_delete
GO
CREATE PROCEDURE sp_khachhang_delete
	@maKH char(11) = ''
AS
BEGIN
	DELETE FROM KHACHHANG WHERE MAKH = @maKH
END
GO
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
-- Nhà cung c?p update
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
	update HOADON set NGAYHOADON = @ngayHD, TONGTHANHTIEN = @tongTien, MANV = @maNV, MAKH =@maKH where MAHD = @maHD -- chu?n sql
END
GO
--exec sp_hoadon_update'HD03','15/01/2022', 90000,'NV02', 'KH02'
-- Create Procedure sp_nhacungcap_insert.sql
-- Nhà cung c?p insert
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
-- Nhà cung c?p delete
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
-- Author:		Vo Tu
-- Create date: <13/11/2023> 
DROP PROCEDURE IF EXISTS sp_hoadon_delete
GO
CREATE PROCEDURE sp_hoadon_delete
	@maHD char(11) = ''
AS
BEGIN 
	DELETE FROM HOADON WHERE MAHD = @maHD
	DELETE FROM CHITIETHD WHERE MAHD = @maHD
end
set dateformat dmy
-- Create Procedure sp_nhacungcap_insert.sql
-- Nhà cung c?p insert 
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
exec sp_hoadon_insert 'HD03','15/01/2022', 90000,'NV02', 'KH02'
select * from NHANVIEN
-- Create Procedure sp_hoadon_select_all.sql
-- hoadon select all 
-- Author:		Vo Tu
-- Create date: <13/11/2023>
-- Description:	<Hóa don select all>
set dateformat dmy
drop procedure if exists sp_hoadon_select_all
go
CREATE PROCEDURE sp_hoadon_select_all
AS
BEGIN 
	SELECT hd.MAHD, hd.NGAYHOADON, hd.TONGTHANHTIEN , nv.HOTENNV, kh.HOTENKH from HOADON hd, NHANVIEN nv, KHACHHANG kh
	where hd.MANV = nv.MANV and hd.MAKH = kh.MAKH
END
GO
exec sp_hoadon_select_all
-- Author:		Vo Tu
-- Create date: <13/11/2023>
-- Create Procedure sp_nhacungcap_select_one.sql
-- Nhà cung c?p select one
drop procedure if exists sp_hoadon_select_one
go
CREATE PROCEDURE sp_hoadon_select_one
	@maHD char(11) = ''
AS
BEGIN
	SELECT * from HOADON where MAHD  = @maHD --like chính xác mã 100%
END
GO
exec sp_hoadon_select_one '12'
-- Author:		Vo Tu
-- Create date: <13/11/2023>
DROP PROCEDURE IF EXISTS sp_hoadon_TimKiem
GO
CREATE PROCEDURE sp_hoadon_TimKiem
	@ma nvarchar(50)
AS
BEGIN
	Select hd.MAHD,hd.NGAYHOADON,hd.TONGTHANHTIEN,nv.HOTENNV,kh.HOTENKH
	from HOADON hd
	INNER Join NHANVIEN nv on hd.MANV = nv.MANV
	INNER Join KHACHHANG kh on hd.MAKH = kh.MAKH
	where hd.MAHD like N'%'+@ma+'%' or kh.HOTENKH like N'%'+@ma+'%' or nv.HOTENNV like N'%'+@ma+'%'
END
GO
exec sp_hoadon_TimKiem HD01
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
	update HOADON set NGAYHOADON = @ngayHD, TONGTHANHTIEN = @tongTien, MANV = @maNV, MAKH =@maKH where MAHD = @maHD -- chu?n sql
END
GO
exec sp_hoadon_update'HD03','15/01/2022', 90000,'NV02', 'KH02'
-- Create Procedure sp_chitiethoadon_delete.sql
-- Danh m?c delete
GO
GO
-- Author:		Quy Ngo
-- Create date: <10/12/2023>
DROP PROCEDURE IF EXISTS sp_chitiethoadon_delete
GO
CREATE PROCEDURE sp_chitiethoadon_delete
	@mahd char(11) ,
	@masp char(11)
AS
BEGIN
	Update sp set sp.SLTONKHO = sp.SLTONKHO + ct.SLMUA 
	from SANPHAM sp,CHITIETHD ct
	where sp.MASP = @masp and ct.MASP = sp.MASP
	DELETE FROM CHITIETHD WHERE MAHD = @mahd and MASP = @masp
END
GO
Select count (*) from CHITIETHD 
Exec sp_chitiethoadon_delete 'HD01','SP01'
Select count (*) from CHITIETHD 
-- Create Procedure sp_chitiethoadon_insert.sql
-- Danh m?c insert
GO
GO
-- Author:		Quy Ngo
-- Create date: <10/12/2023>
drop procedure if exists sp_chitiethoadon_insert
go
CREATE PROCEDURE sp_chitiethoadon_insert
	@mahd char(11) = '', 
    @masp char(11) = '',
	@sl int
AS
BEGIN
	INSERT INTO CHITIETHD(mahd, masp, slmua) VALUES (@mahd, @masp, @sl)
	Update SANPHAM set SLTONKHO = SLTONKHO - @sl where MASP = @masp;
END
GO
select count (*) from chitiethd;
exec sp_chitiethoadon_insert 'hd03', 'sp02', 40
exec sp_chitiethoadon_select_one 'hd03'
select count (*) from chitiethd;
-- Create Procedure sp_chitiethoadon_update.sql
-- Danh m?c update
GO
GO
-- Author:		Quy Ngo
-- Create date: <10/12/2023>
drop procedure if exists sp_chitiethoadon_TimMaSP
go
CREATE PROCEDURE sp_chitiethoadon_TimMaSP
	@masp char(11) = ''
	as
BEGIN
	Select sp.MASP
	from  CHITIETHD sp
	where sp.MASP = @masp
	-- chu?n sql
END
GO
EXEC sp_chitiethoadon_TimMaSP 'SP03'
-- Create Procedure sp_chitiethoadon_delete.sql
-- Danh m?c delete
GO
GO
-- Author:		Quy Ngo
-- Create date: <10/12/2023>
DROP PROCEDURE IF EXISTS sp_chitiethoadon_Kiemtratonkho
GO
CREATE PROCEDURE sp_chitiethoadon_Kiemtratonkho
	@makm char(11),
	@slmua int
AS
BEGIN
	Select  sp.SLTONKHO - @slmua as 'T?n kho'
	from SANPHAM sp,HOADON hd
	 where  sp.MaSP = @makm 
END
GO
exec sp_chitiethoadon_Kiemtratonkho 'SP33', 36
select *
from SANPHAM
-- Create Procedure sp_chitiethoadon_select_all.sql
-- Danh m?c select all
GO
GO
-- Author:		Quy Ngo
-- Create date: <10/12/2023>
drop procedure if exists sp_chitiethoadon_select_all
go
CREATE PROCEDURE sp_chitiethoadon_select_all
	@mahd char(11) 
AS
BEGIN
	SELECT hd.MAHD,sp.TENSP,ct.SLMUA,sp.DONGIA*ct.SLMUA as "Thành Ti?n"
	from CHITIETHD ct, HOADON hd, SANPHAM sp
	where ct.MAHD = hd.MAHD and sp.MASP = ct.MASP and ct.MAHD = @mahd;
END
GO
exec sp_chitiethoadon_select_all 'HD02'
-- Author:		Quy Ngo
-- Create date: <10/12/2023
-- Create Procedure sp_chitiethoadon_select_one.sql
-- Danh m?c select one
drop procedure if exists sp_chitiethoadon_select_one
go
CREATE PROCEDURE sp_chitiethoadon_select_one
	@mahd char(11) = ''
AS
BEGIN
	SELECT * from CHITIETHD where mahd = @mahd --like chính xác mã 100%
END
GO
exec sp_chitiethoadon_select_one 'hd03'
-- Author:		Vo Tu
-- Create date: <13/11/2023>
DROP PROCEDURE IF EXISTS sp_chitiethoadon_TimKiem
GO
CREATE PROCEDURE sp_chitiethoadon_TimKiem
	@ma nvarchar(50),
	@tensp nvarchar(50)
AS
BEGIN
	Select cthd.MAHD,sp.TENSP,cthd.SLMUA,sp.DONGIA*cthd.SLMUA as 'Thành ti?n'
	from CHITIETHD cthd
	INNER Join SANPHAM sp on sp.MASP = cthd.MASP
	where cthd.MAHD = @ma and sp.TENSP like N'%'+@tensp+'%'
END
GO
exec sp_chitiethoadon_TimKiem 'HD01','B'
-- Create Procedure sp_chitiethoadon_update.sql
-- Danh m?c update
-- Author:		Quy Ngo
-- Create date: <10/12/2023>
drop procedure if exists sp_chitiethoadon_TongTien
go
CREATE PROCEDURE sp_chitiethoadon_TongTien 
	@mahd char(11) = ''
AS
BEGIN 
	Declare  @TT int = 0;
	select   @TT   += ct.SLMUA * sp.DONGIA 
	from CHITIETHD ct,HOADON hd,SANPHAM sp
	where ct.MAHD = hd.MAHD and sp.MASP = ct.MASP and ct.MAHD = @mahd
	--select @TT as 'T?ng thành ti?n'
	Update HOADON
	set TONGTHANHTIEN = @TT
	where MAHD = @mahd;
	select @TT as 'Thanh tien'
END
GO
exec sp_chitiethoadon_TongTien 'HD01'
-- Create Procedure sp_hinhthuckm_update.sql
-- Danh m?c update
GO
GO
-- Author:		Quy Ngo
-- Create date: <10/12/2023>
drop procedure if exists sp_chitiethoadon_update
go
CREATE PROCEDURE sp_chitiethoadon_update
	@mahd char(11) = '', 
	@masp char(11) = '',
	@sl int
	as
BEGIN
	Update sp set sp.SLTONKHO = sp.SLTONKHO + ct.SLMUA 
	 from SANPHAM sp,CHITIETHD ct
	 where sp.MASP = @masp and ct.MASP = sp.MASP
	update CHITIETHD set SLMUA = @sl where MAHD = @mahd and  MASP = @masp -- chu?n sql
	Update SANPHAM set SLTONKHO = SLTONKHO - @sl where MASP = @masp;
END
GO
exec sp_chitiethoadon_update 'HD01','SP02',50
select *
from CHITIETHD
where MAHD = 'HD01' and MASP = 'SP02'
-- Author:		Vo Tu
-- Create date: <13/11/2023>
-- Create Procedure sp_khachhang_delete.sql
-- Nhà cung c?p delete
DROP PROCEDURE IF EXISTS sp_khachhang_delete
GO
CREATE PROCEDURE sp_khachhang_delete
	@maKH char(11)
AS
BEGIN
	DELETE FROM KHACHHANG WHERE MAKH = @maKH
END
GO
-- Author:		Vo Tu
-- Create date: <13/11/2023>
-- Create Procedure sp_khachhang_insert.sql
-- Nhà cung c?p insert
drop procedure if exists sp_khachhang_insert
go
CREATE PROCEDURE sp_khachhang_insert
	@maKH char(11),
	@tenKH NVARCHAR(255),
	@sdtKH int = 0,
	@diemTL int = 0
AS
BEGIN
	INSERT INTO KHACHHANG VALUES (@maKH, @tenKH, @sdtKH,@diemTL)
END
GO
-- Author:		Vo Tu
-- Create date: <13/11/2023>
-- Create Procedure sp_nhacungcap_select_all.sql
-- Description:	<Nhà cung c?p select all>
drop procedure if exists sp_khachhang_select_all
go
CREATE PROCEDURE sp_khachhang_select_all
AS
BEGIN
	SELECT * from KHACHHANG
END
GO
exec sp_khachhang_select_all
-- Author:		Vo Tu
-- Create date: <13/11/2023>
-- Create Procedure sp_khachhang_select_one.sql
-- Nhà cung c?p select one
drop procedure if exists sp_khachhang_select_one
go
CREATE PROCEDURE sp_khachhang_select_one
	@maKH char(11)
AS
BEGIN
	SELECT * from KHACHHANG where  MAKH = @maKH --like chính xác mã 100%
END
GO
-- Create Procedure sp_khachhang_update.sql
-- Nhà cung c?p update
-- Author:		Vo Tu
-- Create date: <13/11/2023>
drop procedure if exists sp_khachhang_update
go
CREATE PROCEDURE sp_khachhang_update
	@maKH char(11) = '', 
	@tenKH NVARCHAR(255) = N'',
	@sdtKH int = 0,
	@diemTL int = 0
AS
BEGIN
	update KHACHHANG set HOTENKH = @tenKH,SDTKH = @sdtKH, DIEMTL = @diemTL where MAKH = @maKH -- chu?n sql
END
GO
-- Author:		Vo Tu
-- Create date: <13/11/2023>
DROP PROCEDURE IF EXISTS sp_khachhang_TimKiem
GO
CREATE PROCEDURE sp_khachhang_TimKiem
	@ma nvarchar(50)
AS
BEGIN
    -- Delete statements for procedure here
	Select *
	from KHACHHANG
	where MAKH like N'%'+@ma+'%' or HOTENKH like N'%'+@ma+'%' or SDTKH like N'%'+@ma+'%'
END
GO
select * from KHACHHANG
exec sp_khachhang_TimKiem 'Lê'
-- Create Procedure sp_khuyenmai_update.sql
-- Danh m?c update
-- Author:		Sok Kim Thanh
-- Create date: <07/11/2023>
drop procedure if exists sp_cbo_hinhthuckm
go
CREATE PROCEDURE sp_cbo_hinhthuckm
	--@makm char(11) = '', 
	--@hinhthuc nvarchar(50) = N'',
	--@ghichu nvarchar(100) = N''
AS
BEGIN
	SELECT MAHT from hinhthuckm-- chu?n sql
END
GO
-- Create Procedure sp_khuyenmai_delete.sql
-- Danh m?c delete
-- Author:		Sok Kim Thanh
-- Create date: <07/11/2023>
DROP PROCEDURE IF EXISTS sp_khuyenmai_delete
GO
CREATE PROCEDURE sp_khuyenmai_delete
	@makm char(11) = '', 
	@ngaybd date,
	@ngaykt date,
	@masp char(11) = N''
AS
BEGIN
	DELETE FROM khuyenmai WHERE makm = @makm
END
GO
-- Create Procedure sp_khuyenmai_insert.sql
-- Author:		Sok Kim Thanh
-- Create date: <07/11/2023>
drop procedure if exists sp_khuyenmai_insert
go
CREATE PROCEDURE sp_khuyenmai_insert
	@makm char(11) = '', 
	@ngaybd date,
	@ngaykt date,
	@maht char(11) = N'',
	@phantramgiamgia int = 0
AS
BEGIN
	INSERT INTO khuyenmai VALUES (@makm, @ngaybd, @ngaykt,@maht, @phantramgiamgia)
END
GO
-- Create Procedure sp_khuyenmai_select_all.sql
-- Danh m?c select all
-- Author:		NgoQuy
-- Create date: <07/11/2023>
drop procedure if exists sp_khuyenmai_select_all
go
CREATE PROCEDURE sp_khuyenmai_select_all
AS
BEGIN
	SELECT km.*,ht.TENHINHTHUC from KHUYENMAI km , HINHTHUCKM ht
	where km.MAHT = ht.MAHT 
END
GO
exec sp_khuyenmai_select_all
exec sp_sanpham_select_all
-- Create Procedure sp_khuyenmai_select_one.sql
-- Danh m?c select one
-- Author:		Sok Kim Thanh
-- Create date: <07/11/2023>
drop procedure if exists sp_khuyenmai_select_one
go
CREATE PROCEDURE sp_khuyenmai_select_one
	@MAKM CHAR(11) 
AS
BEGIN
	SELECT * from khuyenmai where MAKM = @MAKM --like chính xác mã 100%
END
GO
-- Create Procedure sp_khuyenmai_update.sql
-- Danh m?c update
-- Author:		Sok Kim Thanh
-- Create date: <07/11/2023>
drop procedure if exists sp_khuyenmai_update
go
CREATE PROCEDURE sp_khuyenmai_update
	@makm char(11) = '', 
	@ngaybd date,
	@ngaykt date,
	@maht char(11),
	@phantramgiamgia int
AS
BEGIN
	update khuyenmai set ngaybd = @ngaybd, ngaykt = @ngaykt, maht=@maht, 
	phantramgiamgia = isnull(@phantramgiamgia, phantramgiamgia) where makm = @makm -- chu?n sql
END
GO
-- Create Procedure sp_nhacungcap_delete.sql
-- Nhà cung c?p delete
-- Author:		Sok Kim Thanh
-- Create date: <07/11/2023>
-- update date: 10-12-2023
DROP PROCEDURE IF EXISTS sp_nhacungcap_delete
GO
CREATE PROCEDURE sp_nhacungcap_delete
	@MANCC CHAR(11)
AS
BEGIN
	DELETE FROM nhacungcap WHERE MANCC = @MANCC
END
GO
--exec sp_nhacungcap_delete 'ncc04'-- khoa nay dang duoc su dung khong the delete
--select * from chitietcc
-- Author:		Sok Kim Thanh
-- Create date: <07/11/2023>
-- update date: 10-12-2023
-- Create Procedure sp_nhacungcap_insert.sql
-- Nhà cung c?p insert 
drop procedure if exists sp_nhacungcap_insert
go
CREATE PROCEDURE sp_nhacungcap_insert
	@MANCC CHAR(11),
	@TENNCC NVARCHAR(255) ,
	@DIACHINCC NVARCHAR(100),
	@SDTNCC INT
AS
BEGIN
	INSERT INTO NHACUNGCAP(MANCC,TENNCC,DIACHINCC,SDTNCC) VALUES (@MANCC, @TENNCC, @DIACHINCC,@SDTNCC)
END
GO
--exec sp_nhacungcap_insert 'ncc005', 'Hoang CC', 'ly thai to q3', 123123
--exec sp_nhacungcap_select_all
--select * from nhacungcap
-- Author:		Sok Kim Thanh
-- Create date: <07/11/2023>
-- update date: 10-12-2023
-- Create Procedure sp_nhacungcap_select_all
drop procedure if exists sp_nhacungcap_select_all
go
CREATE PROCEDURE sp_nhacungcap_select_all
AS
BEGIN
	select * from nhacungcap ncc order by ncc.created_date_ncc desc
END
GO
-- Author:		Sok Kim Thanh
-- Create date: <10/12/2023>
-- Create Procedure sp_nhacungcap_cu_select_all
drop procedure if exists sp_nhacungcap_cu_select_all
go
CREATE PROCEDURE sp_nhacungcap_cu_select_all
AS
BEGIN
	SELECT ncc.MANCC, ncc.TENNCC, sp.TENSP,ccct.SLCUNGCCAP from nhacungcap ncc, sanpham sp, CHITIETCC ccct 
	where ncc.MANCC = ccct.MANCC and sp.MASP = ccct.MASP
	order by ncc.created_date_ncc desc
END
GO
-- Author:		Sok Kim Thanh
-- Create date: <10/12/2023>
-- Create Procedure sp_nhacungcap_moi_select_all
drop procedure if exists sp_nhacungcap_moi_select_all
go
CREATE PROCEDURE sp_nhacungcap_moi_select_all
AS
BEGIN
	select * from NHACUNGCAP ncc where MANCC not in(
	SELECT ncc.MANCC from nhacungcap ncc, sanpham sp, CHITIETCC ccct 
	where ncc.MANCC = ccct.MANCC and sp.MASP = ccct.MASP group by ncc.MANCC)
	order by ncc.created_date_ncc desc
END
GO
--exec sp_nhacungcap_moi_select_all
--exec sp_nhacungcap_cu_select_all
--exec sp_nhacungcap_select_all
-- Create Procedure sp_nhacungcap_select_one.sql
-- Nhà cung c?p select one
-- Author:		Sok Kim Thanh
-- Create date: <07/11/2023>
-- update date: 10-12-2023
drop procedure if exists sp_nhacungcap_select_one
go
CREATE PROCEDURE sp_nhacungcap_select_one
	@MANCC CHAR(11)
AS
BEGIN
	SELECT * from nhacungcap where MANCC = @MANCC --like chính xác mã 100%
END
GO
-- Create Procedure sp_nhacungcap_update.sql
-- Nhà cung c?p update
-- Author:		Sok Kim Thanh
-- Create date: <07/11/2023>
-- update date: 10-12-2023
drop procedure if exists sp_nhacungcap_update
go
CREATE PROCEDURE sp_nhacungcap_update
	@MANCC CHAR(11),
	@TENNCC NVARCHAR(255) ,
	@DIACHINCC NVARCHAR(100),
	@SDTNCC INT   
AS
BEGIN
	update nhacungcap set TENNCC = @TENNCC, DIACHINCC = @DIACHINCC,SDTNCC = @SDTNCC where MANCC = @MANCC -- chu?n sql
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
set dateformat dmy
-- Author:		Sok Kim Thanh
-- Create date: <14/12/2023>
-- Description:	<Tài kho?n delete>
DROP PROCEDURE IF EXISTS sp_chitietcc_delete
GO
CREATE PROCEDURE sp_chitietcc_delete
	@MANCC char(11),
	@MASP char(11)	
AS
BEGIN
	DELETE FROM chitietcc WHERE MANCC = @MANCC and  MASP = @MASP
END
GO
--select count(*) from CHITIETCC
--execute sp_chitietcc_delete 'ncc03', 'sp15'
--select count(*) from CHITIETCC
--select * from nhacungcap
--select * from sanpham
--select * from chitietcc
-- Create Procedure sp_chitietcc_insert.sql
-- Tài kho?n insert
-- Author:		Sok Kim Thanh
-- Create date: <14/12/2023>
drop procedure if exists sp_chitietcc_insert
go
CREATE PROCEDURE sp_chitietcc_insert
	@MANCC char(11),
	@MASP char(11),
	@SLCUNGCCAP int
AS
BEGIN
	INSERT INTO chitietcc(MANCC,MASP,SLCUNGCCAP)
	Values(@MANCC,@MASP,@SLCUNGCCAP)
	Update SanPham set SLTONKHO += SLTONKHO + @SLCungCCap;
END
GO
--select count(*) from CHITIETCC
--execute sp_chitietcc_insert 'ncc01', 'sp02', 123 
--select count(*) from CHITIETCC
-- Create Procedure sp_chitietcc_select_all.sql
-- Tài kho?n select all
-- Author:		Sok Kim Thanh
-- Create date: <14/12/2023>
drop procedure if exists sp_chitietcc_select_all
go
CREATE PROCEDURE sp_chitietcc_select_all
AS
BEGIN
	select ncc.TENNCC,sp.TENSP,ct.SLCUNGCCAP  from chitietcc ct, nhacungcap ncc, sanpham sp
	where ct.MANCC = ncc.MANCC and ct.MASP = sp.MASP
END
GO
execute sp_chitietcc_select_all
-- Create Procedure sp_chitietcc_select_one.sql
-- Tài kho?n select one
-- Author:		Sok Kim Thanh
-- Create date: <14/12/2023>
go
drop procedure if exists sp_chitietcc_select_one
go
CREATE PROCEDURE sp_chitietcc_select_one	
	@MANCC CHAR(11),
	@MASP CHAR(11)
AS
BEGIN
	SELECT * from chitietcc  --  chính xác mã 100%
END
GO
execute sp_chitietcc_select_one  'ncc01' , 'sp01'
-- Create Procedure sp_chitietcc_update.sql
-- Tài kho?n update
-- Author:		Sok Kim Thanh
-- Create date: <14/12/2023>
go
drop procedure if exists sp_chitietcc_update
go
CREATE PROCEDURE sp_chitietcc_update
	@MANCC char(11),
	@MASP char(11),
	@SLCUNGCCAP int
AS
BEGIN
	update chitietcc set SLCUNGCCAP = @SLCUNGCCAP where MANCC = @MANCC and MASP = @MASP  -- chu?n sql
END
GO
--execute sp_chitietcc_update 'ncc01', 'sp01', 10
--execute sp_chitietcc_select_one 'ncc01', 'sp01'
--execute sp_chitietcc_update 'ncc01', 'sp01', 100
--execute sp_chitietcc_select_one 'ncc01', 'sp01'
-- =============================================
-- Author:		<Thanh sok>
-- Create date: <12/12/2023>
-- Description:	<l?y danh sách phòng ban theo mã chi nhánh>
go
drop procedure if exists sp_cbo_laydanhsach_phongban_theo_chinhanh
go
CREATE PROCEDURE sp_cbo_laydanhsach_phongban_theo_chinhanh
	-- Add the parameters for the stored procedure here
	@macn char(4)
AS
BEGIN
	select pb.MAPB, pb.TENPHG from phongban pb, chinhanh cn WHERE cn.MACN = pb.MACN and cn.macn = @macn
END;
go
exec sp_cbo_laydanhsach_phongban_theo_chinhanh 'cn01'
-- Author:		Sok Kim Thanh
-- Create date: <06/12/2023>
go
drop procedure if exists sp_cbo_phongban
go
CREATE PROCEDURE sp_cbo_phongban
AS
BEGIN 
	Select MAPB, TENPHG FROM PHONGBAN
END;
go
-- Author:		Sok Kim Thanh
-- Create date: <06/12/2023 10:57 CH>
-- update date: <12/12/2023 10:57 ch>
-- Description:	<Hi?n th? report nhân viên theo chi nhánh theo phòng ban>
go
drop procedure if exists sp_nhanvien_danhsach_theophongban_chinhanh
go
CREATE PROCEDURE sp_nhanvien_danhsach_theophongban_chinhanh
		@MaChiNhanh char(4), 
		@MaPhongBan char(4)
AS
BEGIN 
	SELECT cn.TENCN as 'Tên Chi Nhánh', pb.TENPHG as 'Phòng ban', STUFF((SELECT ', ' + nv.HOTENNV 
	FROM nhanvien nv 
	WHERE pb.MAPB = nv.MAPB AND cn.MACN = pb.MACN FOR XML PATH('')), 1, 2, '') as 'Danh sách nhân viên' 
	FROM PHONGBAN pb, CHINHANH cn 
	WHERE cn.MACN  =  @MaChiNhanh or  pb.MAPB = @MaPhongBan  
	--GROUP BY pb.TENPHG, cn.TENCN, pb.MAPB, cn.MACN, pb.MACN;
END;
go
--select * from chinhanh
--select * from phongban 
--select * from nhanvien
--exec sp_nhanvien_danhsach_theophongban_chinhanh 'cn01','pb01'
-- Author:		Sok Kim Thanh
-- Create date: <06/12/2023 9:39 CH>
go
drop procedure if exists sp_nhanvien_insert
go
CREATE PROCEDURE sp_nhanvien_insert
	@manv char(11),
	@hotennv NVARCHAR(255),
	@diachinv nvarchar(100),
	@luong float,
	@sdtnv int,
	@ngaysinh date,
	@mapb char(4),
	@gioitinh char(4)
AS
BEGIN 
	-- Ð?i 50 milliseconds
	WAITFOR DELAY '00:00:00.050';
	INSERT INTO nhanvien(manv, hotennv, diachinv, luong, sdtnv, ngaysinh,mapb, gioitinh) 
	VALUES (@manv, @hotennv, @diachinv, @luong, @sdtnv, @ngaysinh,@mapb, @gioitinh);
END;
go
--exec sp_nhanvien_insert 'nv', 'hoang van dung', '222 dia chi ma', 3214232, 123123,'09-09-2000','pb01', 'nam'
--Select * from nhanvien order by created_date asc where gioitinh = 'nam';
-- Author:		Sok Kim Thanh
-- Create date: <10/12/2023 9:33 SA>
go
drop procedure if exists sp_nhanvien_search
go
CREATE PROCEDURE sp_nhanvien_search
	@keyword nvarchar(100)
AS
BEGIN 
	SELECT MANV, Hotennv, ngaysinh, gioitinh, luong, sdtnv from nhanvien where HOTENNV like '%' + isnull(@keyword,HOTENNV) + '%'--like chính xác mã 100%
END;
go
--select * from nhanvien
--exec sp_nhanvien_search 'b' --test ok
-- Author:		Sok Kim Thanh
-- Create date: <06/12/2023 10:57 CH>
go
drop procedure if exists sp_nhanvien_select_nhanvien_phongban
go
CREATE PROCEDURE sp_nhanvien_select_nhanvien_phongban
AS
BEGIN
    SELECT nv.MANV as NhanVienID, pb.MAPB as PhongBanID, nv.HOTENNV as 'H? và tên', pb.TENPHG as 'Tên phòng ban'
	FROM NHANVIEN nv, PHONGBAN pb
    where nv.MAPB = PB.MAPB
	order by nv.created_date_nv desc
END;
go
--exec sp_nhanvien_select_nhanvien_phongban
-- Author:		Sok Kim Thanh
-- Create date: <06/12/2023 9:39 CH>
go
drop procedure if exists sp_nhanvien_select_one
go
CREATE PROCEDURE sp_nhanvien_select_one
	@manv char(11)
AS
BEGIN 
	SELECT * from nhanvien where MANV = isnull(@manv,manv) --like chính xác mã 100%
END;
go
-- Author:		Sok Kim Thanh
-- Create date: <06/12/2023 9:39 CH>
go
drop procedure if exists sp_nhanvien_update
go
CREATE PROCEDURE sp_nhanvien_update
	@manv char(11),
	@hotennv NVARCHAR(255),
	@diachinv nvarchar(100),
	@luong float,
	@sdtnv int,
	@ngaysinh date,
	@mapb char(4),
	@gioitinh nvarchar(10)
AS
BEGIN 
	update nhanvien set hotennv = @hotennv, diachinv = @diachinv,luong=@luong,sdtnv=@sdtnv ,ngaysinh=@ngaysinh, mapb = @mapb, gioitinh = @gioitinh where manv = @manv-- chu?n sql
END;
go
-- Create Procedure sp_PhongBan_select_all.sql
-- Nhân viên phongban all
-- Author:		vo tu
-- Create date: <10/11/2023>
-- Description:	<vo tu select all>
drop procedure if exists sp_cbb_chinhanh_select
go
CREATE PROCEDURE sp_cbb_chinhanh_select
AS
BEGIN
	SELECT * from CHINHANH
END
GO
exec sp_cbb_chinhanh_select
-- Create Procedure sp_phongban_delete.sql
-- Nhân viên delete
-- Author:		vo tu
-- Create date: <10/11/2023>
DROP PROCEDURE IF EXISTS sp_phongban_delete
GO
CREATE PROCEDURE sp_phongban_delete
	@maPB char(11)
AS
BEGIN
	DELETE FROM PHONGBAN WHERE MAPB = @maPB
END
GO
-- Create Procedure sp_nhanvien_insert.sql
-- Nhân viên insert
-- Author:		Sok Kim Thanh
-- Create date: <10/11/2023>
drop procedure if exists sp_phongban_insert
go
CREATE PROCEDURE sp_PhongBan_insert
 @maPB char(11),
	@tenPB NVARCHAR(255),
	@maCN nvarchar(100)
AS
BEGIN
	INSERT INTO PHONGBAN VALUES (@maPB, @tenPB, @maCN)
END
GO
-- Create Procedure sp_PhongBan_select_all.sql
-- Nhân viên phongban all
-- Author:		vo tu
-- Create date: <10/11/2023>
-- Description:	<vo tu select all>
drop procedure if exists sp_phongban_select_all
go
CREATE PROCEDURE sp_phongban_select_all
AS
BEGIN
	SELECT pb.MAPB, pb.TENPHG as 'Tên phòng ban' , cn.TENCN as 'Tên chi nhánh'  from PHONGBAN pb, CHINHANH cn
END
GO
exec sp_phongban_select_all
-- Author:		Sok Kim Thanh
-- Create date: <06/12/2023 9:39 CH>
go
drop procedure if exists sp_phongban_select_one
go
CREATE PROCEDURE sp_phongban_select_one
	@mapb char(11)
AS
BEGIN 
	SELECT * from phongban where mapb = @mapb --like chính xác mã 100%
END;
go
--execute sp_phongban_select_one 'pb01'
-- Create Procedure sp_nhanvien_update.sql
-- Nhân viên update
-- Author:		Sok Kim Thanh
-- Create date: <10/11/2023>
drop procedure if exists sp_phongban_update
go
CREATE PROCEDURE sp_phongban_update
	@maPB char(11),
	@tenPB NVARCHAR(255),
	@maCN nvarchar(100)
AS
BEGIN
	update PHONGBAN set TENPHG = @tenPB, MACN = @maCN where MACN = @maCN -- chu?n sql
END
GO
-- Create Procedure sp_sanpham_delete.sql
-- S?n ph?m delete
-- Author:		Sok Kim Thanh
-- Create date: <07/11/2023>
DROP PROCEDURE IF EXISTS sp_sanpham_delete
GO
CREATE PROCEDURE sp_sanpham_delete
	@MASP CHAR(11)
AS
BEGIN
	DELETE FROM sanpham WHERE MASP = @MASP
END
GO
-- Create Procedure sp_sanpham_insert.sql
-- S?n ph?m insert
-- Author:		Sok Kim Thanh
-- Create date: <07/11/2023>
drop procedure if exists sp_sanpham_insert
go
CREATE PROCEDURE sp_sanpham_insert
	@MASP CHAR(11),
	@TENSP NVARCHAR(255) ,
	@DONVI NVARCHAR(255),
	@NSX DATE ,
	@HSD DATE ,
	@DONGIA INT ,
	@SLTONKHO INT, 
	@MALOAI CHAR(11), 
	@MANCC CHAR(11), 
	@MAKM char(11)
AS
BEGIN
	INSERT INTO sanpham (MASP,TENSP,DONVI ,NSX  ,HSD  ,DONGIA  ,SLTONKHO , MALOAI , MANCC, MAKM ) 
	VALUES (@MASP,@TENSP,@DONVI ,@NSX  ,@HSD  ,@DONGIA  ,@SLTONKHO , @MALOAI , @MANCC, @MAKM )
END
GO
-- Create Procedure sp_sanpham_select_all.SQL
-- S?n ph?m select all
-- Author:		<Sok Kim Thanh>
-- Create date: <07/11/2023>
-- Description:	<S?n ph?m select all>
drop procedure if exists sp_sanpham_select_all
go
CREATE PROCEDURE sp_sanpham_select_all
AS
BEGIN
	select * from sanpham
END
GO
-- Create Procedure sp_sanpham_select_all.SQL
-- S?n ph?m select all
-- Author:		<Sok Kim Thanh>
-- Create date: <07/11/2023>
-- update date: <14/12/2023> 3:34 CH
-- Description:	<S?n ph?m select all>
drop procedure if exists sp_sanpham_select_all
go
CREATE PROCEDURE sp_sanpham_select_all
AS
BEGIN
	select masp, tensp , donvi N'Ðon v?', nsx N'Ngày s?n xu?t', hsd N'H?n s? d?ng', dongia N'Ðon giá',sltonkho N'T?n kho' 
	from SanPham
END
GO
exec sp_sanpham_select_all
-- Create Procedure sp_sanpham_select_one.sql
-- S?n ph?m select one
-- Author:		Ngô Công Quý
-- Create date: <07/11/2023>
set dateformat ymd
drop procedure if exists sp_sanpham_select_ngay
go
CREATE PROCEDURE sp_sanpham_select_ngay
	@NgayHT date = null
AS
BEGIN
	SELECT * from sanpham sp,NHACUNGCAP ncc,LOAISP lsp where sp.HSD = isnull(@NgayHT,sp.hsd)--like chính xác mã 100%
END
GO
select * From SANPHAM
exec sp_sanpham_select_ngay
-- Create Procedure sp_sanpham_select_one.sql
-- S?n ph?m select one
-- Author:		Sok Kim Thanh
-- Create date: <07/11/2023>
drop procedure if exists sp_sanpham_select_one
go
CREATE PROCEDURE sp_sanpham_select_one
	@MASP CHAR(11)
AS
BEGIN
	SELECT * from sanpham where MASP = @MASP --like chính xác mã 100%
END
GO
-- Create Procedure sp_sanpham_select_one.sql
-- S?n ph?m select one
-- Author:		Ngô Công Quý
-- Create date: <07/11/2023>
drop procedure if exists sp_sanpham_select_ten
go
CREATE PROCEDURE sp_sanpham_select_ten
	@TenSP nvarchar(50)
AS
BEGIN
	SELECT * from sanpham sp,NHACUNGCAP ncc,LOAISP lsp where sp.TENSP like N'%'+ @TenSP+'%' and sp.MANCC = ncc.MANCC and lsp.MALOAI=sp.MALOAI--like chính xác mã 100%
END
GO
select * from sanpham
exec sp_sanpham_select_ten 'CÁ'
-- Create Procedure sp_sanpham_update.sql
-- S?n ph?m update
-- Author:		Sok Kim Thanh
-- Create date: <07/11/2023>
drop procedure if exists sp_sanpham_update
go
CREATE PROCEDURE sp_sanpham_update
	@MASP CHAR(11),
	@TENSP NVARCHAR(255) ,
	@DONVI NVARCHAR(255),
	@NSX DATE ,
	@HSD DATE ,
	@DONGIA INT ,
	@SLTONKHO INT, 
	@MALOAI CHAR(11), 
	@MANCC CHAR(11), 
	@MAKM char(11)
AS
BEGIN
	update sanpham set TENSP = @TENSP, DONVI = @DONVI, NSX = @NSX,HSD = @HSD,DONGIA = @DONGIA,SLTONKHO = @SLTONKHO,MALOAI = @MALOAI,MANCC = @MANCC,MAKM = @MAKM where MASP = @MASP -- chu?n sql
END
GO
select * from LOAISP
--execute sp_sanpham_update 
