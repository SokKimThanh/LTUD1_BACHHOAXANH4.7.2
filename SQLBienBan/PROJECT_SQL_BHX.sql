﻿/**
* -- PROJECT BACH HOA XANH
* -- DATE: 7/5/2023			THÀNH VIÊN: LÊ DUY ANH TÚ, SOK KIM THANH
* -- DATE: 1/10/2023		THÀNH VIÊN: QUÝ NGÔ, VÕ TÚ, SOK KIM THANH
*/
/***************************************************************************************************
Create Date:7/5/2023
Author: SOK KIM THANH
Description:lược đồ csdl quan hệ từ mô hình thực thế kết hợp
****************************************************************************************************
Tổng kết thay đổi
Date(dd/MM/yyyy)		Author				Comments
------------------- ------------------- ------------------------------------------------------------
7/5/2023 	05:00		Sok Kim Thanh		Viết mã sql dựng lược đồ quan hệ
7/5/2023 	11:43  		Sok Kim Thanh		Viết mã nhập liệu
7/5/2023 	05:58  		Sok Kim Thanh   	Viêt mã sql tác ra 3 phần, tạo bảng, thêm khóa chính, thêm khóa ngoại.
3/11/2023	11:00		Lê Duy Anh Tú		Cập nhật thêm bảng loại sản phẩm
22/11/2023	07:23SA		Sok Kim Thanh		Vẽ lại quan hệ fk_sanpham_khuyenmai, fk_sanpham_loaisp, Thêm khóa chính pk_hinhthuckm
22/11/2023	09:37SA		Sok Kim Thanh		Thêm BẢNG TAIKHOAN, QUYENTRUYCAP
09/12/2023	00:27SA		Sok Kim Thanh		Xóa quan hệ đệ quy quản lý nhân viên, xóa trường quản lý khỏi bảng nhân viên
09/12/2023	10:03SA		Sok Kim Thanh		Thêm trường giới tính nvarchar(10) vào bảng nhân viên
09/12/2023	10:03SA		Sok Kim Thanh		Thêm trường created_date_nv datetime vào bảng nhân viên, giá trị mặc định là ngày hiện tại
10/12/2023	7:44CH		Sok Kim Thanh		Thêm trường created_date_ncc datetime vào bảng nha cung cap, giá trị mặc định là ngày hiện tại
***************************************************************************************************/
------------------------------------------------------------
--Tạo database mới										   -
------------------------------------------------------------
go
use master
go
drop database BACHHOAXANH
go
create database BACHHOAXANH
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
CREATE TABLE CHINHANH (MACN CHAR(4) NOT NULL ,TENCN NVARCHAR(30) NOT NULL,DIACHICN NVARCHAR(100));
------------------------------------------------------------
---------------------Tạo bảng PHONGBAN----------------------
------------------------------------------------------------
CREATE TABLE PHONGBAN (MAPB CHAR(4) NOT NULL ,TENPHG NVARCHAR(30) NOT NULL,	MACN CHAR(4));
------------------------------------------------------------
---------------------Tạo bảng NHANVIEN----------------------
------------------------------------------------------------
CREATE TABLE NHANVIEN (	MANV CHAR(11)NOT NULL, HOTENNV NVARCHAR(30) NOT NULL,DIACHINV NVARCHAR(100),LUONG int NOT NULL,SDTNV INT NULL,NGAYSINH DATE NOT NULL,MAPB CHAR(4), GIOITINH nvarchar(10) NOT NULL, CREATED_DATE_NV datetime not null);
------------------------------------------------------------
---------------------Tạo bảng KHACHHANG---------------------
------------------------------------------------------------
CREATE TABLE KHACHHANG (MAKH CHAR(11) NOT NULL ,HOTENKH NVARCHAR(30) NOT NULL,SDTKH INT   NULL,	DIEMTL INT NULL);
------------------------------------------------------------
---------------------Tạo bảng NHACUNGCAP--------------------
------------------------------------------------------------
CREATE TABLE NHACUNGCAP (MANCC CHAR(11)NOT NULL  ,TENNCC NVARCHAR(30) NOT NULL,DIACHINCC NVARCHAR(100),SDTNCC INT   NULL, CREATED_DATE_NCC datetime not null);
------------------------------------------------------------
---------------------Tạo bảng SANPHAM-----------------------
------------------------------------------------------------
CREATE TABLE SANPHAM (MASP CHAR(11) NOT NULL ,TENSP NVARCHAR(30) NOT NULL,DONVI NVARCHAR(30),NSX DATE NOT NULL,HSD DATE NOT NULL,DONGIA INT NOT NULL,SLTONKHO INT, MALOAI CHAR(11), MANCC CHAR(11), MAKM char(11));
------------------------------------------------------------
---------------------Tạo bảng KHUYENMAI---------------------
------------------------------------------------------------
CREATE TABLE KHUYENMAI (MAKM CHAR(11) NOT NULL,NGAYBD DATE NOT NULL,NGAYKT DATE NOT NULL, MAHT char(11));
------------------------------------------------------------
---------------------Tạo bảng HINHTHUCKM--------------------
------------------------------------------------------------
CREATE TABLE HINHTHUCKM (MAHT CHAR(11)NOT NULL, TENHINHTHUC NVARCHAR(50) NOT NULL, GHICHU NVARCHAR(100));
------------------------------------------------------------
---------------------Tạo bảng HOADON------------------------
------------------------------------------------------------
CREATE TABLE HOADON (MAHD CHAR(11) NOT NULL, NGAYHOADON DATE NOT NULL,TONGTHANHTIEN DECIMAL(18,2) NOT NULL,MANV CHAR(11),MAKH CHAR(11));------------------------------------------------------------
---------------------Tạo bảng CHITIETHD---------------------
------------------------------------------------------------
CREATE TABLE CHITIETHD (MAHD CHAR(11) NOT NULL,MASP CHAR(11) NOT NULL, SLMUA INT NOT NULL);
------------------------------------------------------------
---------------------Tạo bảng CHITIETCC---------------------
------------------------------------------------------------
CREATE TABLE CHITIETCC (MANCC CHAR(11) NOT NULL,MASP CHAR(11) NOT NULL,SLCUNGCCAP INT NOT NULL);
------------------------------------------------------------
----------------------Tạo bảng LOAISP-----------------------
------------------------------------------------------------
CREATE TABLE LOAISP (MALOAI CHAR(11) NOT NULL, TENLOAI NVARCHAR(30) NOT NULL, GHICHU NVARCHAR(100));
------------------------------------------------------------
----------------------Tạo bảng TAIKHOAN-----------------------
------------------------------------------------------------
create table TAIKHOAN(TENTK char(30) not null, MATKHAU char(30) not null, MANV char(11), MAQTC char(11))
------------------------------------------------------------
----------------------Tạo bảng QUYENTRUYCAP-----------------------
------------------------------------------------------------
create table QUYENTRUYCAP(MAQTC char(11) not null,TENQTC nvarchar(30) not null)

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
---------------------Tạo default value----------------------
------------------------------------------------------------
--o	NHANVIEN có LUONG = 0
--o	SANPHAM có SLTONKHO =0
--o	SANPHAM có DONGIA = 0
--o	KHACHHANG có DIEMTL = 0
--o	NGAYHOADON = DateTime.Now
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

/***********************************************************
------------------------------------------------------------
-----------Tạo value table theo thứ tự chính ngoại----------
------------------------------------------------------------
Hãy nhập liệu theo thứ tự các bảng trên theo thứ tự như sau: 
`CHINHANH`, `PHONGBAN`, `NHANVIEN`, `KHACHHANG` , `NHACUNGCAP`, `SANPHAM` , `CHITIETCC`, `KHUYENMAI` , `HINHTHUCKM` , `HOADON` , `CHITIETHD` , `CHITIETCC`
************************************************************/

go
set dateformat dmy
-- Thêm dữ liệu vào bảng LOAISP
INSERT INTO LOAISP
VALUES ('L01', N'Thịt 1', 'Thịt heo'),
	   ('L02', N'Thịt 2', 'Thịt bò'),
	   ('L03', N'Thịt 3', 'Thịt nai'),
	   ('L04', N'Cá 1'  , 'Cá hồi')


-- Thêm dữ liệu vào bảng CHINHANH
INSERT INTO CHINHANH (MACN, TENCN, DIACHICN)
VALUES ('CN01', N'Chi nhánh Hà Nội', N'Số 1 Đại Cồ Việt, Hai Bà Trưng, Hà Nội'),
       ('CN02', N'Chi nhánh TP. Hồ Chí Minh', N'Số 2 Lê Duẩn, Quận 1, TP. Hồ Chí Minh'),
       ('CN03', N'Chi nhánh Đà Nẵng', N'Số 3 Nguyễn Văn Linh, Hải Châu, Đà Nẵng');
--Thêm dữ liệu vào bảng PHONGBAN
go
INSERT INTO PHONGBAN (MAPB, TENPHG, MACN)
VALUES ('PB01', N'Phòng Kế toán', 'CN01'),
       ('PB02', N'Phòng Nhân sự', 'CN01'),
       ('PB03', N'Phòng Kinh doanh', 'CN02');
--Thêm dữ liệu vào bảng NHANVIEN
INSERT INTO NHANVIEN (MANV, HOTENNV, DIACHINV, LUONG, SDTNV, NGAYSINH, MAPB, GIOITINH /*created_date auto import*/)
VALUES	('NV01', N'Nguyễn Văn A', N'Số 1 Đại Cồ Việt, Hai Bà Trưng, Hà Nội', 10000000, '0123456789', '1990-01-01', 'PB01', 'nam'),
		('NV02', N'Trần Thị B', N'Số 2 Lê Duẩn, Quận 1, TP. Hồ Chí Minh', 12000000, '0987654321', '1991-02-02', 'PB02', 'nu'),
		('NV03', N'Lê Văn C', N'Số 3 Nguyễn Văn Linh, Hải Châu, Đà Nẵng', 8000000, '0969696969', '1992-03-03', 'PB03', 'nam'),
		('NV04', N'Phạm Thị D', N'Số 4 Trần Hưng Đạo, Hoàn Kiếm, Hà Nội', 9000000, '0123456789', '04/04/1993', 'PB01','nu'),
		('NV05', N'Nguyễn Văn E', N'Số 5 Nguyễn Huệ, Quận 1, TP. Hồ Chí Minh', 11000000, '0987654321', '05/05/1994', 'PB02', 'nam'),
		('NV06', N'Trần Thị F', N'Số 6 Bạch Đằng, Hải Châu, Đà Nẵng', 7000000, '0969696969', '06/06/1995', 'PB03','nu'),
		('NV07', N'Lê Văn G', N'Số 7 Lý Thường Kiệt, Hoàn Kiếm, Hà Nội', 9500000, '0123456789', '07/07/1996', 'PB01','nam'),
		('NV08',N'Phạm Thị H', N'Số 8 Lê Lợi, Quận 1, TP. Hồ Chí Minh', 10500000, '0987654321', '08/08/1997', 'PB02','nu'),
		('NV09', N'Nguyễn Văn I', N'Số 9 Ngô Quyền, Hải Châu, Đà Nẵng', 7500000, '0969696969', '09/09/1998', 'PB03', 'nam'),
		('NV10', N'Trần Thị J', N'Số 10 Phan Chu Trinh, Hoàn Kiếm, Hà Nội', 8500000, '0123456789', '10/10/1999', 'PB01','nu');
-- Thêm dữ liệu vào bảng KHACHHANG
INSERT INTO KHACHHANG (MAKH, HOTENKH, SDTKH, DIEMTL)
VALUES	('KH01', N'Nguyễn Văn A', '0123456789', 0), 
		('KH02', N'Trần Thị B', '0987654321', 0),
		('KH03', N'Lê Thị C', '0123456789', 0),
		('KH04', N'Phạm Văn D', '0987654321', 0),
		('KH05', N'Nguyễn Thị E', '0123456789', 0),
		('KH06', N'Trần Văn F', '0987654321', 0),
		('KH07', N'Lê Thị G', '0123456789', 0),
		('KH08', N'Phạm Văn H', '0987654321', 0),
		('KH09', N'Nguyễn Thị I', '0123456789', 0),
		('KH10', N'Trần Văn J', '0987654321', 0),
		('KH11', N'Lê Thị K', '0123456789', 0),
		('KH12', N'Phạm Văn L', '0987654321', 0);

-- Thêm dữ liệu vào bảng NHACUNGCAP
INSERT INTO NHACUNGCAP (MANCC, TENNCC, DIACHINCC, SDTNCC)
VALUES ('NCC01', N'Công ty TNHH ABC', N'Số 1 Đại Cồ Việt, Hai Bà Trưng, Hà Nội', '0987654321'),
('NCC02', N'Công ty TNHH XYZ', N'Số 2 Lê Duẩn, Quận 1, TP. Hồ Chí Minh', '0123456789'),
('NCC03', N'Công ty TNHH DEF', N'Số 3 Nguyễn Văn Linh, Hải Châu, Đà Nẵng', '0987654321'),
('NCC04', N'Công ty TNHH GHI', N'Số 4 Trần Hưng Đạo, Hoàn Kiếm, Hà Nội', '0123456789');

-- Thêm dữ liệu vào bảng SANPHAM
INSERT INTO SANPHAM (MASP, TENSP, DONVI, NSX, HSD, DONGIA, SLTONKHO, MANCC)
VALUES ('SP01', N'Sản phẩm A',N'Hộp', '2022-01-01', '2023-01-01', 100000, 10, 'NCC01'),
('SP02', N'Sản phẩm B', N'Hộp', '02/02/2022', '02/02/2023', 200000, 20, 'NCC02'),
('SP03', N'Sản phẩm C', N'Hộp', '03/03/2022', '03/03/2023', 300000, 30, 'NCC03'),
('SP04', N'Sản phẩm D', N'Hộp', '04/04/2022', '04/04/2023', 400000, 40, 'NCC04'),
('SP05', N'Sản phẩm E', N'Hộp', '05/05/2022', '05/05/2023', 500000, 50, 'NCC01'),
('SP06', N'Sản phẩm F', N'Hộp', '06/06/2022', '06/06/2023', 600000, 60, 'NCC02'),
('SP07', N'Sản phẩm G', N'Hộp', '07/07/2022', '07/07/2023', 700000, 70, 'NCC03'),
('SP08', N'Sản phẩm H', N'Hộp', '08/08/2022', '08/08/2023', 800000, 80, 'NCC04'),
('SP09', N'Sản phẩm I', N'Hộp', '09/09/2022', '09/09/2023' ,900000 ,90 ,'NCC01'),
('SP10' ,N'Sản phẩm J', N'Hộp' ,'10/10/2022' ,'10/10/2023' ,1000000 ,100 ,'NCC02'),
('SP11' ,N'Sản phẩm K', N'Hộp' ,'12/12/2022' ,'11/11/2023' ,1100000 ,110 ,'NCC03'),
('SP12' ,N'Sản phẩm K', N'Hộp' ,'11/11/2022' ,'12/12/2023' ,1200000 ,120 ,'NCC03'),
('SP13', N'Sản phẩm M', N'Hộp', '01/01/2023', '01/01/2024', 1300000, 130, 'NCC01'),
('SP14', N'Sản phẩm N', N'Hộp', '02/02/2023', '02/02/2024', 1400000, 140, 'NCC02'),
('SP15', N'Sản phẩm O', N'Hộp', '03/03/2023', '03/03/2024', 1500000, 150, 'NCC03'),
('SP16', N'Sản phẩm P', N'Hộp', '04/04/2023', '04/04/2024', 1600000, 160, 'NCC04'),
('SP17', N'Sản phẩm Q', N'Hộp', '05/05/2023', '05/05/2024', 1700000, 170, 'NCC01'),
('SP18', N'Sản phẩm R', N'Hộp', '06/06/2023', '06/06/2024', 1800000, 180, 'NCC02'),
('SP19', N'Sản phẩm S', N'Hộp', '07/07/2023', '07/07/2024' ,1900000 ,190 ,'NCC03'),
('SP20' ,N'Sản phẩm T', N'Hộp' ,'08/08/2023' ,'08/08/2024' ,2000000 ,200 ,'NCC04'),
('SP21', N'Sản phẩm U', N'Gói', '09/09/2023', '09/09/2024', 2100000, 210, 'NCC01'),
('SP22', N'Sản phẩm V', N'Thùng', '10/10/2023', '10/10/2024', 2200000, 220, 'NCC02'),
('SP23', N'Sản phẩm W', N'Gói', '11/11/2023', '11/11/2024', 2300000, 230, 'NCC03'),
('SP24', N'Sản phẩm X', N'Thùng', '12/12/2023', '12/12/2024' ,2400000 ,240 ,'NCC04'),
('SP25' ,N'Sản phẩm Y', N'Gói' ,'01/01/2024' ,'01/01/2025' ,2500000 ,250 ,'NCC01'),
('SP26', N'Cá', N'Hộp', '02/02/2024', '02/02/2025', 2600000, 260, 'NCC02'),
('SP27', N'Thịt', N'Hộp', '03/03/2024', '03/03/2025', 2700000, 270, 'NCC03'),
('SP28', N'Rau', N'Hộp', '04/04/2024', '04/04/2025' ,2800000 ,280 ,'NCC04'),
('SP29' ,N'Củ' , N'Hộp' ,'05/05/2024' ,'05/05/2025' ,2900000 ,290 ,'NCC01'),
('SP30' ,N'Quả' , N'Hộp' ,'06/06/2024' ,'06/06/2025' ,3000000 ,300 ,'NCC02'),
('SP31', N'Sản phẩm Z',N'Gói', '07/07/2024', '07/07/2025', 3100000, 310, 'NCC03'),
('SP32', N'Sản phẩm AA', N'Thùng', '08/08/2024', '08/08/2025' ,3200000 ,320 ,'NCC04'),
('SP33' ,N'Sản phẩm AB' , N'Gói' ,'09/09/2024' ,'09/09/2025' ,3300000 ,330 ,'NCC01'),
('SP34' ,N'Sản phẩm AC' , N'Thùng' ,'10/10/2024' ,'10/10/2025' ,3400000 ,340 ,'NCC02'),
('SP35' ,N'Sản phẩm AD' , N'Gói' ,'11/11/2024' ,'11/11/2025' ,3500000 ,350 ,'NCC03');

-- Thêm dữ liệu vào bảng CHITIETCC
INSERT INTO CHITIETCC (MANCC, MASP, SLCUNGCCAP)
VALUES ('NCC01', 'SP01', 10),
('NCC02', 'SP02', 20),
('NCC03', 'SP03', 30),
('NCC04', 'SP04', 40),
('NCC01', 'SP05', 50),
('NCC02', 'SP06', 60),
('NCC03', 'SP07', 70),
('NCC04', 'SP08', 80),
('NCC01', 'SP09', 90),
('NCC02', 'SP10' ,100),
('NCC03' ,'SP11' ,110),
('NCC04' ,'SP12' ,120),
('NCC01' ,'SP13' ,130),
('NCC02' ,'SP14' ,140),
('NCC03' ,'SP15' ,150);;

-- Thêm dữ liệu vào bảng KHUYENMAI
INSERT INTO KHUYENMAI (MAKM, NGAYBD, NGAYKT)
VALUES ('KM01', '2022-01-01', '2022-02-01'),
('KM02', '02/02/2022', '02/03/2022'),
('KM03', '03/03/2022', '03/04/2022'),
('KM04', '04/04/2022', '04/05/2022'),
('KM05' ,'05/05/2022' ,'05/06/2022'),
('KM06' ,'06/06/2022' ,'06/07/2022'),
('KM07' ,'07/07/2022' ,'07/08/2022'),
('KM08' ,'08/08/2022' ,'08/09/2022'),
('KM09' ,'09/09/2022' ,'09/10/2022'),
('KM10' ,'10/10/2022' ,'10/11/2022'),
('KM11' ,'11/11/2022' ,'11/12/2022')

-- Thêm dữ liệu vào bảng HINHTHUCKM
INSERT INTO HINHTHUCKM (MAHT,TENHINHTHUC, GHICHU)
VALUES ('KM01',N'Giảm giá 10%', NULL),
('KM02',N'Giảm giá 20%', NULL),
('KM03',N'Giảm giá 30%', NULL),
('KM04',N'Giảm giá 40%', NULL),
('KM05',N'Giảm giá 50%', NULL),
('KM06', N'Tặng phiếu mua hàng', NULL),
('KM07', N'Tặng sản phẩm', NULL),
('KM08', N'Miễn phí vận chuyển', NULL),
('KM09', N'Đổi trả miễn phí', NULL),
('KM10' , N'Bảo hành miễn phí' ,NULL),
('KM11' , N'Bảo hành vàng' ,NULL);

-- Thêm dữ liệu vào bảng HOADON
INSERT INTO HOADON (MAHD, NGAYHOADON, TONGTHANHTIEN, MANV, MAKH)
VALUES ('HD01', '15/01/2022', 90000,'NV01', 'KH01')
 

-- Thêm dữ liệu vào bảng CHITIETHD
INSERT INTO CHITIETHD (MAHD, MASP, SLMUA) VALUES
('HD01', 'SP01', 1),
('HD01', 'SP02', 2),
('HD01', 'SP03', 3),
('HD01', 'SP04', 4),
('HD01', 'SP05', 5),
('HD01', 'SP06', 6),
('HD01', 'SP07', 7),
('HD01', 'SP08', 8),
('HD01', 'SP09', 9),
('HD01', 'SP10', 10),
('HD01', 'SP11', 11),
('HD01', 'SP12', 12),
('HD01', 'SP13', 13),
('HD01', 'SP14', 14),
('HD01', 'SP15', 15),
('HD01', 'SP16', 16),
('HD01', 'SP17', 17),
('HD01', 'SP18', 18),
('HD01', 'SP19', 19),
('HD01', 'SP20', 20),
('HD01', 'SP21', 21),
('HD01', 'SP22', 22),
('HD01', 'SP23', 23),
('HD01', 'SP24', 24),
('HD01', 'SP25', 25),
('HD01', 'SP26', 26),
('HD01', 'SP27', 27),
('HD01', 'SP28', 28),
('HD01', 'SP29', 29)										   