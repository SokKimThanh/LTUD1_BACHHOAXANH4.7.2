
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
INSERT INTO LOAISP (MALOAI,TENLOAI,GHICHU)
VALUES 
('L01', N'Thịt', 'Các sản phẩm từ thịt heo'),
('L02', N'Cá', 'Các sản phẩm từ thịt bò'),
('L03', N'Trứng', 'Các sản phẩm từ thịt nai'),
('L04', N'Sữa', 'Các sản phẩm từ cá hồi');



-- Thêm dữ liệu vào bảng CHINHANH
INSERT INTO CHINHANH (MACN, TENCN, DIACHICN)
VALUES 
('CN01', N'Chi nhánh Hà Nội', N'Số 1 Đại Cồ Việt, Hai Bà Trưng, Hà Nội'),
('CN02', N'Chi nhánh TP. Hồ Chí Minh', N'Số 2 Lê Duẩn, Quận 1, TP. Hồ Chí Minh'),
('CN03', N'Chi nhánh Đà Nẵng', N'Số 3 Nguyễn Văn Linh, Hải Châu, Đà Nẵng'),
('CN04', N'Chi nhánh Cần Thơ', N'Địa chỉ 4, Cần Thơ'),
('CN05', N'Chi nhánh Bình Dương', N'Địa chỉ 5, Bình Dương'),
('CN06', N'Chi nhánh Đồng Nai', N'Địa chỉ 6, Đồng Nai'),
('CN07', N'Chi nhánh Vũng Tàu', N'Địa chỉ 7, Vũng Tàu'),
('CN08', N'Chi nhánh Nha Trang', N'Địa chỉ 8, Nha Trang'),
('CN09', N'Chi nhánh Đà Lạt', N'Địa chỉ 9, Đà Lạt'),
('CN10', N'Chi nhánh Phú Quốc', N'Địa chỉ 10, Phú Quốc'),
('CN11', N'Chi nhánh Quảng Ninh', N'Địa chỉ 11, Quảng Ninh'),
('CN12', N'Chi nhánh Huế', N'Địa chỉ 12, Huế'),
('CN13', N'Chi nhánh Sapa', N'Địa chỉ 13, Sapa');

--Thêm dữ liệu vào bảng PHONGBAN
go
INSERT INTO PHONGBAN (MAPB, TENPHG, MACN)
VALUES 
('PB01', N'Phòng Kế toán', 'CN01'),
('PB02', N'Phòng Nhân sự', 'CN01'),
('PB03', N'Phòng Kinh doanh', 'CN02'),
('hack', N'Phòng Maketing', 'CN02'), 
('PB05', N'Phòng Kỹ thuật', 'CN01'),
('PB06', N'Phòng Sản xuất', 'CN01'),
('PB07', N'Phòng Dịch vụ khách hàng', 'CN02'),
('PB08', N'Phòng Hợp đồng', 'CN02'),
('PB09', N'Phòng Tài chính', 'CN01'),
('PB10', N'Phòng Quản lý dự án', 'CN01'),
('PB11', N'Phòng Đảm bảo chất lượng', 'CN02'),
('PB12', N'Phòng Nghiên cứu và phát triển', 'CN02'),
('PB13', N'Phòng Hành chính', 'CN01'),
('PB14', N'Phòng IT', 'CN01');

--Thêm dữ liệu vào bảng NHANVIEN
INSERT INTO NHANVIEN (MANV, HOTENNV, DIACHINV, LUONG, SDTNV, NGAYSINH, MAPB, GIOITINH /*created_date auto import*/)
VALUES	
('NV01', N'Nguyễn Văn A', N'Số 1 Đại Cồ Việt, Hai Bà Trưng, Hà Nội', 10000000, '0123456789', '1990-01-01', 'PB01', 'nam'),
('NV02', N'Trần Thị B', N'Số 2 Lê Duẩn, Quận 1, TP. Hồ Chí Minh', 12000000, '0987654321', '1991-02-02', 'PB02', 'nu'),
('NV03', N'Lê Văn C', N'Số 3 Nguyễn Văn Linh, Hải Châu, Đà Nẵng', 8000000, '0969696969', '1992-03-03', 'PB03', 'nam'),
('NV04', N'Phạm Thị D', N'Số 4 Trần Hưng Đạo, Hoàn Kiếm, Hà Nội', 9000000, '0123456789', '04/04/1993', 'PB01','nu'),
('NV05', N'Nguyễn Văn E', N'Số 5 Nguyễn Huệ, Quận 1, TP. Hồ Chí Minh', 11000000, '0987654321', '05/05/1994', 'PB02', 'nam'),
('NV06', N'Trần Thị F', N'Số 6 Bạch Đằng, Hải Châu, Đà Nẵng', 7000000, '0969696969', '06/06/1995', 'PB03','nu'),
('NV07', N'Lê Văn G', N'Số 7 Lý Thường Kiệt, Hoàn Kiếm, Hà Nội', 9500000, '0123456789', '07/07/1996', 'PB01','nam'),
('NV08',N'Phạm Thị H', N'Số 8 Lê Lợi, Quận 1, TP. Hồ Chí Minh', 10500000, '0987654321', '08/08/1997', 'PB02','nu'),
('NV09', N'Nguyễn Văn I', N'Số 9 Ngô Quyền, Hải Châu, Đà Nẵng', 7500000, '0969696969', '09/09/1998', 'PB03', 'nam'),
('NV10', N'Trần Thị J', N'Số 10 Phan Chu Trinh, Hoàn Kiếm, Hà Nội', 8500000, '0123456789', '10/10/1999', 'PB01','nu'),
('manv_admin', N'admin', N'????', 8500000, '0123456789', '10/10/1999', 'hack','nu');
-- Thêm dữ liệu vào bảng KHACHHANG
INSERT INTO KHACHHANG (MAKH, HOTENKH, SDTKH, DIEMTL)
VALUES
('01FUNNYA', N'Người Nhện Đi Học', 213213, 500),
('02JOYFULB', N'Captain Việt Nam',213213, 300),
('03CHEERC', N'Người Sắt Đỏ',213213, 700),
('04JOLLYD', N'Thor Đi Bão',213213, 900),
('05MERRYE', N'Hulk Yêu Dấu',213213, 800),
('06GLEEFG', N'Black Widow Nấu Ăn',213213, 600),
('07BLITHEG', N'Hawkeye Cao Thủ',213213, 400),
('08JOCUNDH', N'Quicksilver Chạy Đi Đâu',213213, 350),
('09FESTIVEI', N'Scarlet Witch Học Phép',213213, 450),
('10LIVELYJ', N'Vision Lập Trình',213213, 750);



-- Thêm dữ liệu vào bảng NHACUNGCAP
INSERT INTO NHACUNGCAP (MANCC, TENNCC, DIACHINCC, SDTNCC)
VALUES 
('NCC01', N'Công ty TNHH ABC', N'Số 1 Đại Cồ Việt, Hai Bà Trưng, Hà Nội', '0987654321'),
('NCC02', N'Công ty TNHH XYZ', N'Số 2 Lê Duẩn, Quận 1, TP. Hồ Chí Minh', '0123456789'),
('NCC03', N'Công ty TNHH DEF', N'Số 3 Nguyễn Văn Linh, Hải Châu, Đà Nẵng', '0987654321'),
('NCC04', N'Công ty TNHH GHI', N'Số 4 Trần Hưng Đạo, Hoàn Kiếm, Hà Nội', '0123456789');


-- Thêm dữ liệu vào bảng HINHTHUCKM
INSERT INTO HINHTHUCKM (MAHT,TENHINHTHUC, GHICHU)
VALUES ('HT01',N'Giảm giá 10%', N'Áp dụng cho đơn hàng trên 500.000đ'),
('HT02',N'Giảm giá 20%', N'Áp dụng cho đơn hàng trên 1.000.000đ'),
('HT03',N'Giảm giá 30%', N'Áp dụng cho đơn hàng trên 1.500.000đ'),
('HT04',N'Giảm giá 40%', N'Áp dụng cho đơn hàng trên 2.000.000đ'),
('HT05',N'Giảm giá 50%', N'Áp dụng cho đơn hàng trên 2.500.000đ'),
('HT06', N'Tặng phiếu mua hàng', N'Phiếu mua hàng trị giá 200.000đ cho lần mua hàng tiếp theo'),
('HT07', N'Tặng sản phẩm', N'Tặng sản phẩm ngẫu nhiên cho đơn hàng trên 3.000.000đ'),
('HT08', N'Miễn phí vận chuyển', N'Miễn phí vận chuyển cho đơn hàng trên 1.000.000đ'),
('HT09', N'Đổi trả miễn phí', N'Đổi trả miễn phí trong vòng 30 ngày'),
('HT10' , N'Bảo hành miễn phí' ,N'Bảo hành miễn phí trong vòng 1 năm'),
('HT11' , N'Bảo hành vàng' ,N'Bảo hành vàng trong vòng 3 năm');

-- Thêm dữ liệu vào bảng KHUYENMAI
INSERT INTO KHUYENMAI (MAKM, NGAYBD, NGAYKT, MAHT, phantramgiamgia)
VALUES ('KM01', '2022-01-01', '2022-02-01','HT02', 1),
('KM02', '02/02/2022', '02/03/2022','HT02',5),
('KM03', '03/03/2022', '03/04/2022','HT02',1),
('KM04', '04/04/2022', '04/05/2022','HT02',3),
('KM05' ,'05/05/2022' ,'05/06/2022','HT02',6),
('KM06' ,'06/06/2022' ,'06/07/2022','HT02',7),
('KM07' ,'07/07/2022' ,'07/08/2022','HT02',8),
('KM08' ,'08/08/2022' ,'08/09/2022','HT02',33),
('KM09' ,'09/09/2022' ,'09/10/2022','HT02',22),
('KM10' ,'10/10/2022' ,'10/11/2022','HT02',1),
('KM12', '2022-12-11', '2023-01-11', 'HT03',1),
('KM13', '2023-01-11', '2023-02-11', 'HT03',1),
('KM14', '2023-02-11', '2023-03-11', 'HT03',1),
('KM15', '2023-03-11', '2023-04-11', 'HT03',1),
('KM16', '2023-04-11', '2023-05-11', 'HT03',1),
('KM17', '2023-05-11', '2023-06-11', 'HT03',1),
('KM18', '2023-06-11', '2023-07-11', 'HT03',1),
('KM19', '2023-07-11', '2023-08-11', 'HT03',1),
('KM20', '2023-08-11', '2023-09-11', 'HT03',1),
('KM21', '2023-09-11', '2023-10-11', 'HT03',10);

-- Thêm dữ liệu vào bảng SANPHAM
INSERT INTO SANPHAM (MASP, TENSP, DONVI, NSX, HSD, DONGIA, SLTONKHO, MANCC, MALOAI, MAKM)
VALUES ('SP01', N'Sản phẩm A',N'Hộp', '2022-01-01', '2023-01-01', 100000, 10, 'NCC01', 'L01', 'KM01'),
('SP02', N'Sản phẩm B', N'Hộp', '02/02/2022', '02/02/2023', 200000, 20, 'NCC02', 'L01','KM01'),
('SP03', N'Sản phẩm C', N'Hộp', '03/03/2022', '03/03/2023', 300000, 30, 'NCC03', 'L01','KM01'),
('SP04', N'Sản phẩm D', N'Hộp', '04/04/2022', '04/04/2023', 400000, 40, 'NCC04', 'L01','KM01'),
('SP05', N'Sản phẩm E', N'Hộp', '05/05/2022', '05/05/2023', 500000, 50, 'NCC01', 'L02','KM01'),
('SP06', N'Sản phẩm F', N'Hộp', '06/06/2022', '06/06/2023', 600000, 60, 'NCC02', 'L02','KM01'),
('SP07', N'Sản phẩm G', N'Hộp', '07/07/2022', '07/07/2023', 700000, 70, 'NCC03', 'L02','KM01'),
('SP08', N'Sản phẩm H', N'Hộp', '08/08/2022', '08/08/2023', 800000, 80, 'NCC04', 'L02','KM01'),
('SP09', N'Sản phẩm I', N'Hộp', '09/09/2022', '09/09/2023' ,900000 ,90 ,'NCC01', 'L03','KM01'),
('SP10' ,N'Sản phẩm J', N'Hộp' ,'10/10/2022' ,'10/10/2023' ,1000000 ,100 ,'NCC02', 'L03','KM01'),
('SP11' ,N'Sản phẩm K', N'Hộp' ,'12/12/2022' ,'11/11/2023' ,1100000 ,110 ,'NCC03', 'L03','KM01'),
('SP12' ,N'Sản phẩm K', N'Hộp' ,'11/11/2022' ,'12/12/2023' ,1200000 ,120 ,'NCC03', 'L03','KM01'),
('SP13', N'Sản phẩm M', N'Hộp', '01/01/2023', '01/01/2024', 1300000, 130, 'NCC01', 'L04','KM01'),
('SP14', N'Sản phẩm N', N'Hộp', '02/02/2023', '02/02/2024', 1400000, 140, 'NCC02', 'L04','KM01'),
('SP15', N'Sản phẩm O', N'Hộp', '03/03/2023', '03/03/2024', 1500000, 150, 'NCC03', 'L04','KM01'),
('SP16', N'Sản phẩm P', N'Hộp', '04/04/2023', '04/04/2024', 1600000, 160, 'NCC04', 'L04','KM01'),
('SP17', N'Sản phẩm Q', N'Hộp', '05/05/2023', '05/05/2024', 1700000, 170, 'NCC01', 'L01','KM01'),
('SP18', N'Sản phẩm R', N'Hộp', '06/06/2023', '06/06/2024', 1800000, 180, 'NCC02', 'L01','KM01'),
('SP19', N'Sản phẩm S', N'Hộp', '07/07/2023', '07/07/2024' ,1900000 ,190 ,'NCC03', 'L01','KM01'),
('SP20' ,N'Sản phẩm T', N'Hộp' ,'08/08/2023' ,'08/08/2024' ,2000000 ,200 ,'NCC04', 'L01','KM01'),
('SP21', N'Sản phẩm U', N'Gói', '09/09/2023', '09/09/2024', 2100000, 210, 'NCC01', 'L02','KM01'),
('SP22', N'Sản phẩm V', N'Thùng', '10/10/2023', '10/10/2024', 2200000, 220, 'NCC02', 'L02','KM01'),
('SP23', N'Sản phẩm W', N'Gói', '11/11/2023', '11/11/2024', 2300000, 230, 'NCC03', 'L02','KM01'),
('SP24', N'Sản phẩm X', N'Thùng', '12/12/2023', '12/12/2024' ,2400000 ,240 ,'NCC04', 'L02','KM01'),
('SP25' ,N'Sản phẩm Y', N'Gói' ,'01/01/2024' ,'01/01/2025' ,2500000 ,250 ,'NCC01', 'L03','KM01'),
('SP26', N'Cá', N'Hộp', '02/02/2024', '02/02/2025', 2600000, 260, 'NCC02', 'L03','KM01'),
('SP27', N'Thịt', N'Hộp', '03/03/2024', '03/03/2025', 2700000, 270, 'NCC03', 'L03','KM01'),
('SP28', N'Rau', N'Hộp', '04/04/2024', '04/04/2025' ,2800000 ,280 ,'NCC04', 'L03','KM01'),
('SP29' ,N'Củ' , N'Hộp' ,'05/05/2024' ,'05/05/2025' ,2900000 ,290 ,'NCC01', 'L04','KM01'),
('SP30' ,N'Quả' , N'Hộp' ,'06/06/2024' ,'06/06/2025' ,3000000 ,300 ,'NCC02', 'L04','KM01'),
('SP31', N'Sản phẩm Z',N'Gói', '07/07/2024', '07/07/2025', 3100000, 310, 'NCC03', 'L04','KM01'),
('SP32', N'Sản phẩm AA', N'Thùng', '08/08/2024', '08/08/2025' ,3200000 ,320 ,'NCC04', 'L04','KM01'),
('SP33' ,N'Sản phẩm AB' , N'Gói' ,'09/09/2024' ,'09/09/2025' ,3300000 ,330 ,'NCC01', 'L01','KM01'),
('SP34' ,N'Sản phẩm AC' , N'Thùng' ,'10/10/2024' ,'10/10/2025' ,3400000 ,340 ,'NCC02', 'L01','KM01'),
('SP35' ,N'Sản phẩm AD' , N'Gói' ,'11/11/2024' ,'11/11/2025' ,3500000 ,350 ,'NCC03', 'L01','KM01');


-- Thêm dữ liệu vào bảng CHITIETCC
INSERT INTO CHITIETCC (MANCC, MASP, SLCUNGCCAP)
VALUES 
('NCC01', 'SP01', 10),
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
('NCC03' ,'SP15' ,150);



-- Thêm dữ liệu vào bảng HOADON
INSERT INTO HOADON (MAHD, NGAYHOADON, TONGTHANHTIEN, MANV, MAKH)
VALUES 
('HD01', '2022-01-01', 500000, 'NV01', '01FUNNYA'),
('HD02', '2022-01-02', 600000, 'NV01', '01FUNNYA'),
('HD03', '2022-01-03', 700000, 'NV01', '02JOYFULB'),
('HD04', '2022-01-04', 800000, 'NV01', '02JOYFULB'),
('HD05', '2022-01-05', 900000, 'NV01', '03CHEERC'),
('HD06', '2022-01-05', 100000, 'NV01', '03CHEERC'),
('HD07', '2022-01-05', 200000, 'NV01', '04JOLLYD'),
('HD08', '2022-01-05', 300000, 'NV01', '04JOLLYD'),
('HD09', '2022-01-05', 400000, 'NV01', '05MERRYE'),
('HD010', '2022-01-05', 400000, 'NV01', '05MERRYE'),
-- thêm các hóa đơn khác tương tự
('HD20', '2022-01-20', 1500000, 'NV01', '01FUNNYA');


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

--Thêm dữ liệu cho bảng quyền truy cập
INSERT INTO quyentruycap VALUES ('QTC01', 'Quyền đọc');
INSERT INTO quyentruycap VALUES ('QTC02', 'Quyền ghi');
INSERT INTO quyentruycap VALUES ('QTC03', 'Quyền cập nhật');
INSERT INTO quyentruycap VALUES ('QTC04', 'Quyền xóa');

INSERT INTO quyentruycap VALUES ('maqtc_full', 'Đầy đủ Quyền');

--Thêm dữ liệu cho bảng tài khoản
INSERT INTO taikhoan VALUES ('tentaikhoan1', 'matkhau1', 'nv01', 'QTC01');
INSERT INTO taikhoan VALUES ('tentaikhoan2', 'matkhau1', 'nv01', 'QTC02');
INSERT INTO taikhoan VALUES ('tentaikhoan3', 'matkhau1', 'nv01', 'QTC03');
INSERT INTO taikhoan VALUES ('tentaikhoan4', 'matkhau1', 'nv01', 'QTC04');

INSERT INTO taikhoan VALUES ('tentaikhoan5', 'matkhau2', 'nv02', 'QTC01');
INSERT INTO taikhoan VALUES ('tentaikhoan6', 'matkhau2', 'nv02', 'QTC02');
INSERT INTO taikhoan VALUES ('tentaikhoan7', 'matkhau2', 'nv02', 'QTC03');
 

INSERT INTO taikhoan VALUES ('tentaikhoan8', 'matkhau3', 'nv03', 'QTC01');
INSERT INTO taikhoan VALUES ('tentaikhoan9', 'matkhau3', 'nv03', 'QTC02');
 

INSERT INTO taikhoan VALUES ('tentaikhoan10', 'matkhau4', 'nv04', 'QTC01');
INSERT INTO taikhoan VALUES ('admin', 'admin123', 'manv_admin', 'maqtc_full');
