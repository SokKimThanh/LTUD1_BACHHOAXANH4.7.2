/**
* -- PROJECT BACH HOA XANH
* -- DATE: 7/5/2023			THÀNH VIÊN: LÊ DUY ANH TÚ, SOK KIM THANH
* -- DATE: 1/10/2023		THÀNH VIÊN: QUÝ NGÔ, VÕ TÚ, SOK KIM THANH
*/
/***************************************************************************************************
Create Date:7/5/2023
Author: SOK KIM THANH
Description:lược đồ csdl quan hệ từ mô hình thực thế kết hợp
****************************************************************************************************************************************************************
Tổng kết thay đổi
Date(dd/MM/yyyy)		Author				Comments
------------------- ------------------- ------------------------------------------------------------------------------------------------------------------------
7/5/2023 	05:00		Sok Kim Thanh		Viết mã sql dựng lược đồ quan hệ
7/5/2023 	11:43  		Sok Kim Thanh		Viết mã nhập liệu
7/5/2023 	05:58  		Sok Kim Thanh   	Viêt mã sql tác ra 3 phần, tạo bảng, thêm khóa chính, thêm khóa ngoại.
3/11/2023	11:00		Lê Duy Anh Tú		Cập nhật thêm bảng loại sản phẩm
22/11/2023	07:23 SA	Sok Kim Thanh		Vẽ lại quan hệ fk_sanpham_khuyenmai, fk_sanpham_loaisp, Thêm khóa chính pk_hinhthuckm
22/11/2023	09:37 SA	Sok Kim Thanh		Thêm BẢNG TAIKHOAN, QUYENTRUYCAP
09/12/2023	00:27 SA	Sok Kim Thanh		Xóa quan hệ đệ quy quản lý nhân viên, xóa trường quản lý khỏi bảng nhân viên
09/12/2023	10:03 SA	Sok Kim Thanh		Thêm trường giới tính nvarchar(10) vào bảng nhân viên
09/12/2023	10:03 SA	Sok Kim Thanh		Thêm trường created_date_nv datetime vào bảng nhân viên, giá trị mặc định là ngày hiện tại
10/12/2023	07:44 CH	Sok Kim Thanh		Thêm trường created_date_ncc datetime vào bảng nha cung cap, giá trị mặc định là ngày hiện tại
14/12/2023	09:24 CH	Sok Kim Thanh		Thêm dữ liệu cho ứng dụng
17/12/2023	10/42 SA	Sok Kim Thanh		Thêm cột phantramgiamgia int cho khuyến mãi 
19/12/2023	05:04 SA	Sok Kim Thanh		Sửa đoạn code tạo database, thêm dữ liệu cho bảng chi nhánh, nhân viên, khách hàng ,sản phẩm
21/12/2023  02:10 SA    Sok Kim Thanh       Tạo bảng TruyCap, gắn thêm getdate cho mỗi thời điểm đăng nhập, lưu kết quả đăng nhập thành công/thất bại
23/12/2023  04:59 SA	Sok Kim Thanh		Đổi char11 thành char 15
****************************************************************************************************************************************************************/
------------------------------------------------------------
--Tạo database mới										   -
------------------------------------------------------------
IF DB_ID('bachhoaxanh') IS NOT NULL
BEGIN
	use master
    ALTER DATABASE bachhoaxanh SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
    DROP DATABASE bachhoaxanh;
END
 
create database BACHHOAXANH

ALTER DATABASE bachhoaxanh SET MULTI_USER;

go 
use BACHHOAXANH

/***********************************************************
------------------------------------------------------------
----Tạo table-----------------------------------------------
------------------------------------------------------------
************************************************************/

------------------------------------------------------------
---------------------Tạo bảng CHINHANH----------------------
------------------------------------------------------------
go 
CREATE TABLE CHINHANH (MACN CHAR(15) NOT NULL ,TENCN NVARCHAR(255) NOT NULL,DIACHICN NVARCHAR(100));
------------------------------------------------------------
---------------------Tạo bảng PHONGBAN----------------------
------------------------------------------------------------
go 
CREATE TABLE PHONGBAN (MAPB CHAR(15) NOT NULL ,TENPHG NVARCHAR(255) NOT NULL, MACN CHAR(15));
------------------------------------------------------------
---------------------Tạo bảng NHANVIEN----------------------
------------------------------------------------------------
go 
CREATE TABLE NHANVIEN (	MANV CHAR(15)NOT NULL, HOTENNV NVARCHAR(255) NOT NULL,DIACHINV NVARCHAR(100),LUONG int NOT NULL,SDTNV INT NULL,NGAYSINH DATE NOT NULL,MAPB CHAR(15), GIOITINH nvarchar(10) NOT NULL, CREATED_DATE_NV datetime not null);
------------------------------------------------------------
---------------------Tạo bảng KHACHHANG---------------------
------------------------------------------------------------
go 
CREATE TABLE KHACHHANG (MAKH CHAR(15) NOT NULL ,HOTENKH NVARCHAR(255) NOT NULL,SDTKH INT   NULL,	DIEMTL INT NULL);
------------------------------------------------------------
---------------------Tạo bảng NHACUNGCAP--------------------
------------------------------------------------------------
go 
CREATE TABLE NHACUNGCAP (MANCC CHAR(15)NOT NULL  ,TENNCC NVARCHAR(255) NOT NULL,DIACHINCC NVARCHAR(100),SDTNCC INT   NULL, CREATED_DATE_NCC datetime not null);
------------------------------------------------------------
---------------------Tạo bảng SANPHAM-----------------------
------------------------------------------------------------
go 
CREATE TABLE SANPHAM (MASP CHAR(15) NOT NULL ,TENSP NVARCHAR(255) NOT NULL,DONVI NVARCHAR(255),NSX DATE NOT NULL,HSD DATE NOT NULL,DONGIA INT NOT NULL,SLTONKHO INT, MALOAI CHAR(15), MANCC CHAR(15), MAKM CHAR(15));
------------------------------------------------------------
---------------------Tạo bảng KHUYENMAI---------------------
------------------------------------------------------------
CREATE TABLE KHUYENMAI (MAKM CHAR(15) NOT NULL,NGAYBD DATE NOT NULL,NGAYKT DATE NOT NULL, MAHT CHAR(15));
------------------------------------------------------------
---------------------Tạo bảng HINHTHUCKM--------------------
------------------------------------------------------------
go 
CREATE TABLE HINHTHUCKM (MAHT CHAR(15)NOT NULL, TENHINHTHUC NVARCHAR(50) NOT NULL, GHICHU NVARCHAR(100));
------------------------------------------------------------
---------------------Tạo bảng HOADON------------------------
------------------------------------------------------------
go 
CREATE TABLE HOADON (MAHD CHAR(15) NOT NULL, NGAYHOADON DATE NOT NULL,TONGTHANHTIEN DECIMAL(18,2) NOT NULL,MANV CHAR(15),MAKH CHAR(15));
------------------------------------------------------------
---------------------Tạo bảng CHITIETHD---------------------
------------------------------------------------------------
CREATE TABLE CHITIETHD (MAHD CHAR(15) NOT NULL,MASP CHAR(15) NOT NULL, SLMUA INT NOT NULL);
------------------------------------------------------------
---------------------Tạo bảng CHITIETCC---------------------
------------------------------------------------------------
go 
CREATE TABLE CHITIETCC (MANCC CHAR(15) NOT NULL,MASP CHAR(15) NOT NULL,SLCUNGCCAP INT NOT NULL);
------------------------------------------------------------
----------------------Tạo bảng LOAISP-----------------------
------------------------------------------------------------
go 
CREATE TABLE LOAISP (MALOAI CHAR(15) NOT NULL, TENLOAI NVARCHAR(255) NOT NULL, GHICHU NVARCHAR(100));
------------------------------------------------------------
----------------------Tạo bảng TAIKHOAN-----------------------
------------------------------------------------------------
go 
create table TAIKHOAN(TENTK char(30) not null, MATKHAU char(30) not null, MANV CHAR(15), MAQTC CHAR(15))
------------------------------------------------------------
----------------------Tạo bảng QUYENTRUYCAP-----------------------
------------------------------------------------------------
go 
create table QUYENTRUYCAP(MAQTC CHAR(15) not null,TENQTC NVARCHAR(255) not null)
------------------------------------------------------------
----------------------Tạo bảng QUYENTRUYCAP-----------------------
------------------------------------------------------------
go 
CREATE TABLE TRUYCAP (TENTK CHAR(30) NOT NULL, THOIDIEM DATETIME NOT NULL, KETQUA NVARCHAR(255) NOT NULL)
/***********************************************************
------------------------------------------------------------
----Tạo khóa chính------------------------------------------
------------------------------------------------------------
************************************************************/
ALTER TABLE CHINHANH ADD CONSTRAINT PK_CHINHANH PRIMARY KEY (MACN);
ALTER TABLE PHONGBAN ADD CONSTRAINT PK_PHONGBAN PRIMARY KEY (MAPB);
ALTER TABLE NHANVIEN ADD CONSTRAINT PK_NHANVIEN PRIMARY KEY (MANV);
ALTER TABLE KHACHHANG ADD CONSTRAINT PK_KHACHHANG PRIMARY KEY (MAKH);
ALTER TABLE NHACUNGCAP ADD CONSTRAINT PK_NHACUNGCAP PRIMARY KEY (MANCC);
ALTER TABLE SANPHAM ADD CONSTRAINT PK_SANPHAM PRIMARY KEY (MASP);
ALTER TABLE LOAISP ADD CONSTRAINT PK_LOAISP PRIMARY KEY (MALOAI);
ALTER TABLE KHUYENMAI ADD CONSTRAINT PK_KHUYENMAI PRIMARY KEY (MAKM);
ALTER TABLE HINHTHUCKM ADD CONSTRAINT PK_HINHTHUCKM PRIMARY KEY (MAHT);
ALTER TABLE HOADON ADD CONSTRAINT PK_HOADON PRIMARY KEY (MAHD);
ALTER TABLE TAIKHOAN add constraint PK_TAIKHOAN primary key (TENTK)
ALTER TABLE QUYENTRUYCAP add constraint PK_QUYENTRUYCAP primary key (MAQTC)
/***********************************************************
------------------------------------------------------------
----Tạo khóa ngoại----------------------------------------
------------------------------------------------------------
************************************************************/
ALTER TABLE PHONGBAN ADD CONSTRAINT FK_PHONGBAN_CHINHANH FOREIGN KEY (MACN) REFERENCES CHINHANH (MACN);
ALTER TABLE NHANVIEN ADD CONSTRAINT FK_NHANVIEN_PHONGBAN FOREIGN KEY (MAPB) REFERENCES PHONGBAN (MAPB);
ALTER TABLE SANPHAM ADD CONSTRAINT FK_SANPHAM_LOAISP FOREIGN KEY (MALOAI) REFERENCES LOAISP (MALOAI);--ok
ALTER TABLE SANPHAM ADD CONSTRAINT FK_SANPHAM_KHUYENMAI FOREIGN KEY (MAKM) REFERENCES KHUYENMAI (MAKM);--ok
ALTER TABLE KHUYENMAI ADD CONSTRAINT FK_KHUYENMAI_HINHTHUCKM FOREIGN KEY (MAHT) REFERENCES HINHTHUCKM (MAHT);--ok
ALTER TABLE HOADON ADD CONSTRAINT FK_HOADON_NHANVIEN FOREIGN KEY (MANV) REFERENCES NHANVIEN (MANV);
ALTER TABLE HOADON ADD CONSTRAINT FK_HOADON_KHACHHANG FOREIGN KEY (MAKH) REFERENCES KHACHHANG (MAKH);
ALTER TABLE CHITIETHD ADD CONSTRAINT FK_CHITIETHD_HOADON FOREIGN KEY (MAHD) REFERENCES HOADON (MAHD);
ALTER TABLE CHITIETHD ADD CONSTRAINT FK_CHITIETHD_SANPHAM FOREIGN KEY (MASP) REFERENCES SANPHAM (MASP);--ok
ALTER TABLE CHITIETCC ADD CONSTRAINT FK_CHITIETCC_NHACUNGCAP FOREIGN KEY (MANCC) REFERENCES NHACUNGCAP (MANCC);
ALTER TABLE CHITIETCC ADD CONSTRAINT FK_CHITIETCC_SANPHAM FOREIGN KEY (MASP) REFERENCES SANPHAM (MASP);
alter table TAIKHOAN add constraint FK_TAIKHOAN_NHANVIEN foreign key (MANV) references NHANVIEN(MANV)
alter table TAIKHOAN add constraint FK_TAIKHOAN_QUYENTRUYCAP foreign key (MAQTC) references QUYENTRUYCAP(MAQTC)


/***********************************************************
------------------------------------------------------------
---------------------CHỈNH SỬA BẢNG-------------------------
------------------------------------------------------------
************************************************************/
alter table khuyenmai add phantramgiamgia int null;




/***********************************************************
------------------------------------------------------------
---------------------Tạo default value----------------------
------------------------------------------------------------
--o	NHANVIEN có LUONG = 0
--o	SANPHAM có SLTONKHO =0
--o	SANPHAM có DONGIA = 0
--o	KHACHHANG có DIEMTL = 0
--o	NGAYHOADON = DateTime.Now
--o	KHUYENMAI có phantramgiamgia = 0
************************************************************/
-- default lương nhân viên
go
alter table NHANVIEN
add constraint d_luong default 0 for LUONG
-- default ngày tạo nhân viên
go
alter table NHANVIEN
add constraint d_created_date_nv default getdate() for created_date_nv
-- default  số lượng tồn kho sản phẩm
go
alter table SANPHAM
add constraint d_sltonkho default 0 for SLTONKHO
-- default đơn giá sản phẩm
go
alter table SANPHAM
add constraint d_dongiasp default 0 for DONGIA
--default điểm tích lũy của khách hàng
go
alter table KHACHHANG
add constraint d_diemtl default 0 for DIEMTL
--default ngày hóa đơn là ngày hiện tại cua hoa don
go
alter table HOADON
add constraint d_ngayhoadon default GETDATE() for NGAYHOADON

-- default ngày tạo nhà cung cấp
go
alter table NHACUNGCAP
add constraint d_created_date_ncc default getdate() for created_date_ncc

--default giá trị giảm giá
go
alter table KHUYENMAI
add constraint d_phantramgiamgia default 0 for phantramgiamgia

go
alter table TRUYCAP
add constraint d_thoidiemtruycap default getdate() for thoidiem
/***********************************************************
------------------------------------------------------------
---------------------Tạo check value------------------------
------------------------------------------------------------
--o	KHUYENMAI có check phamtramgiamgia >=0 and phantramgiamgia <= 90
************************************************************/
ALTER TABLE KHUYENMAI
ADD CONSTRAINT check_phantramgiamgia CHECK (phantramgiamgia >= 0 AND phantramgiamgia <= 90);



