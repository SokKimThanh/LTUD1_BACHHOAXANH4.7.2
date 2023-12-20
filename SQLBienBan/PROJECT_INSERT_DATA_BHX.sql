
/***********************************************************
------------------------------------------------------------
-----------Tạo value table theo thứ tự chính ngoại----------
------------------------------------------------------------
Hãy nhập liệu theo thứ tự các bảng trên theo thứ tự như sau: 
`CHINHANH`, `PHONGBAN`, `NHANVIEN`, `KHACHHANG` , `NHACUNGCAP`, `SANPHAM` , `CHITIETCC`, `KHUYENMAI` , `HINHTHUCKM` , `HOADON` , `CHITIETHD` , `CHITIETCC`
************************************************************/
 
set dateformat dmy
-- Thêm dữ liệu vào bảng LOAISP
INSERT INTO LOAISP (MALOAI,TENLOAI,GHICHU)
VALUES 
('L01', N'Gạo', 'Các sản phẩm từ gạo'),
('L02', N'Đậu nành', 'Các sản phẩm từ đậu nành'),
('L03', N'Ngô', 'Các sản phẩm từ ngô'),
('L04', N'Lúa mì', 'Các sản phẩm từ lúa mì'),
('L05', N'Khoai tây', 'Các sản phẩm từ khoai tây'),
('L06', N'Bột', 'Các sản phẩm từ bột'),
('L07', N'Đường', 'Các sản phẩm từ đường'),
('L08', N'Nước', 'Các sản phẩm từ nước'),
('L09', N'Giấm', 'Các sản phẩm từ giấm'),
('L10', N'Dầu', 'Các sản phẩm từ dầu'),
('L11', N'Mì', 'Các sản phẩm từ mì'),
('L12', N'Phô mai', 'Các sản phẩm từ phô mai'),
('L13', N'Nước mắm', 'Các sản phẩm từ nước mắm'),
('L14', N'Tương', 'Các sản phẩm từ tương'),
('L15', N'Kẹo', 'Các sản phẩm từ kẹo'),
('L16', N'Bánh', 'Các sản phẩm từ bánh'),
('L17', N'Cháo', 'Các sản phẩm từ cháo'),
('L18', N'Canh', 'Các sản phẩm từ canh'),
('L19', N'Xôi', 'Các sản phẩm từ xôi'),
('L20', N'Phở', 'Các sản phẩm từ phở'),
('L21', N'Bún', 'Các sản phẩm từ bún'),
('L22', N'Hủ tiếu', 'Các sản phẩm từ hủ tiếu'),
('L23', N'Mì', 'Các sản phẩm từ mì'),
('L24', N'Cơm', 'Các sản phẩm từ cơm'),
('L25', N'Chè', 'Các sản phẩm từ chè'),
('L26', N'Sinh tố', 'Các sản phẩm từ sinh tố'),
('L27', N'Nước ép', 'Các sản phẩm từ nước ép'),
('L28', N'Thức ăn nhanh', 'Các sản phẩm từ thức ăn nhanh'),
('L29', N'Đồ hấp', 'Các sản phẩm từ đồ hấp'),
('L30', N'Đồ nướng', 'Các sản phẩm từ đồ nướng'),
('L31', N'Đồ chiên', 'Các sản phẩm từ đồ chiên'),
('L32', N'Đồ xào', 'Các sản phẩm từ đồ xào'),
('L33', N'Đồ luộc', 'Các sản phẩm từ đồ luộc'),
('L34', N'Đồ hầm', 'Các sản phẩm từ đồ hầm'),
('L35', N'Đồ uống', 'Các sản phẩm từ nước trái cây'),
('L36', N'Đồ ăn vặt', 'Các sản phẩm từ khoai tây chiên'),
('L37', N'Đồ chay', 'Các sản phẩm từ rau củ'),
('L38', N'Đồ hải sản', 'Các sản phẩm từ tôm, cua, mực'),
('L39', N'Đồ ngọt', 'Các sản phẩm từ bánh ngọt'),
('L40', N'Đồ mặn', 'Các sản phẩm từ thịt mặn'),
('L41', N'Đồ chua', 'Các sản phẩm từ dưa chua'),
('L42', N'Đồ cay', 'Các sản phẩm từ ớt'),
('L43', N'Đồ lạnh', 'Các sản phẩm từ kem'),
('L44', N'Đồ nóng', 'Các sản phẩm từ cà phê nóng'),
('L45', N'Đồ khô', 'Các sản phẩm từ thịt bò khô'),
('L46', N'Đồ tươi', 'Các sản phẩm từ rau củ tươi'),
('L47', N'Đồ đông lạnh', 'Các sản phẩm từ thực phẩm đông lạnh'),
('L48', N'Đồ hấp', 'Các sản phẩm từ bánh bao'),
('L49', N'Đồ nướng', 'Các sản phẩm từ thịt nướng'),
('L50', N'Đồ chiên', 'Các sản phẩm từ gà chiên'),
('L51', N'Đồ xào', 'Các sản phẩm từ mì xào'),
('L52', N'Đồ luộc', 'Các sản phẩm từ trứng luộc'),
('L53', N'Đồ hầm', 'Các sản phẩm từ thịt hầm'),
('L54', N'Đồ rang', 'Các sản phẩm từ hạt điều rang');




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
('CN13', N'Chi nhánh Sapa', N'Địa chỉ 13, Sapa'),
('CN14', N'Chi nhánh Hải Phòng', N'Địa chỉ 14, Hải Phòng'),
('CN15', N'Chi nhánh Thanh Hóa', N'Địa chỉ 15, Thanh Hóa'),
('CN16', N'Chi nhánh Nghệ An', N'Địa chỉ 16, Nghệ An'),
('CN17', N'Chi nhánh Hà Tĩnh', N'Địa chỉ 17, Hà Tĩnh'),
('CN18', N'Chi nhánh Quảng Bình', N'Địa chỉ 18, Quảng Bình'),
('CN19', N'Chi nhánh Quảng Trị', N'Địa chỉ 19, Quảng Trị'),
('CN20', N'Chi nhánh Thừa Thiên Huế', N'Địa chỉ 20, Thừa Thiên Huế'),
('CN21', N'Chi nhánh Quảng Nam', N'Địa chỉ 21, Quảng Nam'),
('CN22', N'Chi nhánh Quảng Ngãi', N'Địa chỉ 22, Quảng Ngãi'),
('CN23', N'Chi nhánh Bình Định', N'Địa chỉ 23, Bình Định'),
('CN24', N'Chi nhánh Phú Yên', N'Địa chỉ 24, Phú Yên'),
('CN25', N'Chi nhánh Khánh Hòa', N'Địa chỉ 25, Khánh Hòa'),
('CN26', N'Chi nhánh Ninh Thuận', N'Địa chỉ 26, Ninh Thuận'),
('CN27', N'Chi nhánh Bình Thuận', N'Địa chỉ 27, Bình Thuận'),
('CN28', N'Chi nhánh Kon Tum', N'Địa chỉ 28, Kon Tum'),
('CN29', N'Chi nhánh Gia Lai', N'Địa chỉ 29, Gia Lai'),
('CN30', N'Chi nhánh Đắk Lắk', N'Địa chỉ 30, Đắk Lắk'),
('CN31', N'Chi nhánh Đắk Nông', N'Địa chỉ 31, Đắk Nông'),
('CN32', N'Chi nhánh Lâm Đồng', N'Địa chỉ 32, Lâm Đồng'),
('CN33', N'Chi nhánh Bình Phước', N'Địa chỉ 33, Bình Phước'),
('CN34', N'Chi nhánh Tây Ninh', N'Địa chỉ 34, Tây Ninh'),
('CN35', N'Chi nhánh Bình Dương', N'Địa chỉ 35, Bình Dương'),
('CN36', N'Chi nhánh Đồng Nai', N'Địa chỉ 36, Đồng Nai'),
('CN37', N'Chi nhánh Bà Rịa - Vũng Tàu', N'Địa chỉ 37, Bà Rịa - Vũng Tàu'),
('CN38', N'Chi nhánh Long An', N'Địa chỉ 38, Long An'),
('CN39', N'Chi nhánh Tiền Giang', N'Địa chỉ 39, Tiền Giang'),
('CN40', N'Chi nhánh Bến Tre', N'Địa chỉ 40, Bến Tre'),
('CN41', N'Chi nhánh Trà Vinh', N'Địa chỉ 41, Trà Vinh'),
('CN42', N'Chi nhánh Vĩnh Long', N'Địa chỉ 42, Vĩnh Long'),
('CN43', N'Chi nhánh Đồng Tháp', N'Địa chỉ 43, Đồng Tháp'),
('CN44', N'Chi nhánh An Giang', N'Địa chỉ 44, An Giang'),
('CN45', N'Chi nhánh Kiên Giang', N'Địa chỉ 45, Kiên Giang'),
('CN46', N'Chi nhánh Cần Thơ', N'Địa chỉ 46, Cần Thơ'),
('CN47', N'Chi nhánh Hậu Giang', N'Địa chỉ 47, Hậu Giang'),
('CN48', N'Chi nhánh Sóc Trăng', N'Địa chỉ 48, Sóc Trăng'),
('CN49', N'Chi nhánh Bạc Liêu', N'Địa chỉ 49, Bạc Liêu'),
('CN50', N'Chi nhánh Cà Mau', N'Địa chỉ 50, Cà Mau');

--Thêm dữ liệu vào bảng PHONGBAN
go
INSERT INTO PHONGBAN (MAPB, TENPHG, MACN)
VALUES 
('PB01', N'Phòng Kế toán', 'CN01'),
('PB02', N'Phòng Nhân sự', 'CN01'),
('PB03', N'Phòng Kinh doanh', 'CN02'),
('PB04', N'Phòng Maketing', 'CN02'), 
('PB05', N'Phòng Kỹ thuật', 'CN01'),
('PB06', N'Phòng Sản xuất', 'CN01'),
('PB07', N'Phòng Dịch vụ khách hàng', 'CN02'),
('PB08', N'Phòng Hợp đồng', 'CN02'),
('PB09', N'Phòng Tài chính', 'CN01'),
('PB10', N'Phòng Quản lý dự án', 'CN01'),
('PB11', N'Phòng Đảm bảo chất lượng', 'CN02'),
('PB12', N'Phòng Nghiên cứu và phát triển', 'CN02'),
('PB13', N'Phòng Hành chính', 'CN01'),
('PB14', N'Phòng IT', 'CN01'),
('PB15', N'Phòng Kỹ thuật hỗ trợ', 'CN01'),
('PB16', N'Phòng Hỗ trợ khách hàng', 'CN02'),
('PB17', N'Phòng Quản lý hợp đồng', 'CN01'),
('PB18', N'Phòng Quản lý kế hoạch', 'CN02'), 
('PB19', N'Phòng Quản lý vận hành', 'CN01'),
('PB20', N'Phòng Quản lý dự án', 'CN02'),
('PB21', N'Phòng Quản lý sản phẩm', 'CN01'),
('PB22', N'Phòng Quản lý chất lượng', 'CN02'),
('PB23', N'Phòng Quản lý rủi ro', 'CN01'),
('PB24', N'Phòng Quản lý chuỗi cung ứng', 'CN02'), 
('PB25', N'Phòng Quản lý Đối tác', 'CN01'),
('PB26', N'Phòng Quản lý Sản phẩm', 'CN02'),
('PB27', N'Phòng Quản lý Kho hàng', 'CN01'),
('PB28', N'Phòng Quản lý Giao hàng', 'CN02'), 
('PB29', N'Phòng Quản lý Khuyến mãi', 'CN01'),
('PB30', N'Phòng Quản lý Trả hàng', 'CN02'),
('PB31', N'Phòng Quản lý Bảo hành', 'CN01'),
('PB32', N'Phòng Quản lý Phản hồi khách hàng', 'CN02'),
('PB33', N'Phòng Quản lý Chăm sóc khách hàng', 'CN01'),
('PB34', N'Phòng Quản lý Thanh toán', 'CN02');


--Thêm dữ liệu vào bảng NHANVIEN
INSERT INTO NHANVIEN (MANV, HOTENNV, DIACHINV, LUONG, SDTNV, NGAYSINH, MAPB, GIOITINH /*created_date auto import*/)
VALUES	
('NV01', N'Người Dơi Đi Làm', '123 Đường A, TP.HCM', 10000000, '0123456789', '2000-01-01', 'PB01', N'Nam'),
('NV02', N'Robin Đi Chợ', '456 Đường B, Hà Nội', 20000000, '0123456789', '1990-02-02', 'PB01', N'Nam'),
('NV03', N'Alfred Nấu Ăn', '789 Đường C, Đà Nẵng', 30000000, '0123456789', '1980-03-03', 'PB01', N'Nam'),
('NV04', N'Superman Việt Nam', '321 Đường D, Cần Thơ', 40000000, '0123456789', '1970-04-04', 'PB02', N'Nam'),
('NV05', N'Lois Lane Phóng Viên', '654 Đường E, Vũng Tàu', 50000000, '0123456789', '1960-05-05', 'PB02', N'Nu'),
('NV06', N'Jimmy Olsen Chụp Ảnh', '987 Đường F, Nha Trang', 60000000, '0123456789', '1950-06-06', 'PB02', N'Nam'),
('NV07', N'Wonder Woman Đỏ', '135 Đường G, Hải Phòng', 70000000, '0123456789', '1940-07-07', 'PB03', N'Nữ'),
('NV08', N'Steve Trevor Phi Công', '246 Đường H, Đà Lạt', 80000000, '0123456789', '1930-08-08', 'PB03', N'Nam'),
('NV09', N'Hippolyta Nữ Hoàng', '357 Đường I, Phú Quốc', 90000000, '0123456789', '1920-09-09', 'PB03', N'Nữ'),
('NV10', N'Aquaman Đi Bơi', '468 Đường J, Huế', 10000000, '0123456789', '2000-10-10', 'PB04', N'Nam'),
('NV11', N'Mera Nấu Ăn', '579 Đường K, Quảng Ninh', 20000000, '0123456789', '1990-11-11', 'PB04', N'Nữ'),
('NV12', N'Black Manta Lặn', '680 Đường L, Quảng Bình', 30000000, '0123456789', '1980-12-12', 'PB04', N'Nam'),
('NV13', N'Flash Chạy', '791 Đường M, Quảng Trị', 40000000, '0123456789', '1970-01-13', 'PB05', N'Nam'),
('NV14', N'Iris West Báo Chí', '802 Đường N, Thừa Thiên Huế', 50000000, '0123456789', '1960-02-14', 'PB05', N'Nữ'),
('NV15', N'Kid Flash Học', '913 Đường O, Đắk Lắk', 60000000, '0123456789', '1950-03-15', 'PB05', N'Nam'),
('NV16', N'Green Lantern Bay', '024 Đường P, Gia Lai', 70000000, '0123456789', '1940-04-16', 'PB01', N'Nam'),
('NV17', N'Hawkgirl Bay', '135 Đường Q, Kon Tum', 80000000, '0123456789', '1930-05-17', 'PB01', N'Nữ'),
('NV18', N'Martian Manhunter Bay', '246 Đường R, Khánh Hòa', 90000000, '0123456789', '1920-06-18', 'PB01', N'Nam'),
('NV19', N'Miss Martian Học', '357 Đường S, Ninh Thuận', 100000000, '0123456789', '1910-07-19', 'PB02', N'Nữ'),
('NV20', N'William Shakespeare', '468 Đường J, Huế', 10000000, '0123456789', '2000-10-10', 'PB02', N'Nam'),
('NV21', N'Jane Austen', '579 Đường K, Hà Nội', 20000000, '0123456789', '1990-11-11', 'PB02', N'Nữ'),
('NV22', N'Ernest Hemingway', '680 Đường L, Đà Nẵng', 30000000, '0123456789', '1980-12-12', 'PB03', N'Nam'),
('NV23', N'Virginia Woolf', '791 Đường M, Cần Thơ', 40000000, '0123456789', '1970-01-13', 'PB03', N'Nữ'),
('NV24', N'F. Scott Fitzgerald', '802 Đường N, Vũng Tàu', 50000000, '0123456789', '1960-02-14', 'PB04', N'Nam'),
('NV25', N'Agatha Christie', '913 Đường O, Nha Trang', 60000000, '0123456789', '1950-03-15', 'PB04', N'Nữ'),
('NV26', N'George Orwell', '024 Đường P, Gia Lai', 70000000, '0123456789', '1940-04-16', 'PB05', N'Nam'),
('NV27', N'Emily Dickinson', '135 Đường Q, Kon Tum', 80000000, '0123456789', '1930-05-17', 'PB05', N'Nữ'),
('NV28', N'Mark Twain', '246 Đường R, Khánh Hòa', 90000000, '0123456789', '1920-06-18', 'PB01', N'Nam'),
('NV29', N'Harper Lee', '357 Đường S, Ninh Thuận', 100000000, '0123456789', '1910-07-19', 'PB01', N'Nữ'),
('NV30', N'J.K. Rowling', '468 Đường A, An Giang', 10000000, '0123456789', '2000-01-01', 'PB01', N'Nữ'),
('NV31', N'J.R.R. Tolkien', '579 Đường B, Bà Rịa - Vũng Tàu', 20000000, '0123456789', '1990-02-02', 'PB02', N'Nam'),
('NV32', N'C.S. Lewis', '680 Đường C, Bắc Giang', 30000000, '0123456789', '1980-03-03', 'PB03', N'Nam'),
('NV33', N'Roald Dahl', '791 Đường D, Bắc Kạn', 40000000, '0123456789', '1970-04-04', 'PB04', N'Nam'),
('NV34', N'George R.R. Martin', '802 Đường E, Bạc Liêu', 50000000, '0123456789', '1960-05-05', 'PB05', N'Nam'),
('NV35', N'J.D. Salinger', '913 Đường F, Bến Tre', 60000000, '0123456789', '1950-06-06', 'PB01', N'Nam'),
('NV36', N'Fyodor Dostoevsky', '024 Đường G, Bình Định', 70000000, '0123456789', '1940-07-07', 'PB02', N'Nam'),
('NV37', N'Haruki Murakami', '135 Đường H, Bình Dương', 80000000, '0123456789', '1930-08-08', 'PB03', N'Nam'),
('NV38', N'Virginia Woolf', '246 Đường I, Bình Phước', 90000000, '0123456789', '1920-09-09', 'PB04', N'Nữ'),
('NV39', N'Leo Tolstoy', '357 Đường J, Bình Thuận', 100000000, '0123456789', '1910-10-10', 'PB05', N'Nam'),
('NV40', N'Alan Turing', '468 Đường A, An Giang', 10000000, '0123456789', '2000-01-01', 'PB14', N'Nam'),
('NV41', N'Grace Hopper', '579 Đường B, Bà Rịa - Vũng Tàu', 20000000, '0123456789', '1990-02-02', 'PB14', N'Nữ'),
('NV42', N'Dennis Ritchie', '680 Đường C, Bắc Giang', 30000000, '0123456789', '1980-03-03', 'PB14', N'Nam'),
('NV43', N'Ada Lovelace', '791 Đường D, Bắc Kạn', 40000000, '0123456789', '1970-04-04', 'PB14', N'Nữ'),
('NV44', N'Linus Torvalds', '802 Đường E, Bạc Liêu', 50000000, '0123456789', '1960-05-05', 'PB14', N'Nam'),
('NV45', N'James Gosling', '913 Đường F, Bến Tre', 60000000, '0123456789', '1950-06-06', 'PB14', N'Nam'),
('NV46', N'Guido van Rossum', '024 Đường G, Bình Định', 70000000, '0123456789', '1940-07-07', 'PB14', N'Nam'),
('NV47', N'Margaret Hamilton', '135 Đường H, Bình Dương', 80000000, '0123456789', '1930-08-08', 'PB14', N'Nữ'),
('NV48', N'Ken Thompson', '246 Đường I, Bình Phước', 90000000, '0123456789', '1920-09-09', 'PB14', N'Nam'),
('NV49', N'Katherine Johnson', '357 Đường J, Bình Thuận', 100000000, '0123456789', '1910-10-10', 'PB14', N'Nữ'),
('NV50', N'John McCarthy', '468 Đường K, Cà Mau', 10000000, '0123456789', '2000-11-11', 'PB14', N'Nam'),
('NV51', N'Edsger Dijkstra', '579 Đường L, Cần Thơ', 20000000, '0123456789', '1990-12-12', 'PB14', N'Nam'),
('NV52', N'Donald Knuth', '680 Đường M, Đà Nẵng', 30000000, '0123456789', '1980-01-13', 'PB14', N'Nam'),
('NV53', N'Ada Lovelace', '791 Đường N, Đắk Lắk', 40000000, '0123456789', '1970-02-14', 'PB14', N'Nữ'),
('NV54', N'Alan Kay', '802 Đường O, Đắk Nông', 50000000, '0123456789', '1960-03-15', 'PB14', N'Nam'),
('NV55', N'Richard Stallman', '913 Đường P, Điện Biên', 60000000, '0123456789', '1950-04-16', 'PB14', N'Nam'),
('NV56', N'Barbara Liskov', '024 Đường Q, Đồng Nai', 70000000, '0123456789', '1940-05-17', 'PB14', N'Nữ'),
('NV57', N'Bjarne Stroustrup', '135 Đường R, Đồng Tháp', 80000000, '0123456789', '1930-06-18', 'PB14', N'Nam'),
('NV58', N'Yukihiro Matsumoto', '246 Đường S, Gia Lai', 90000000, '0123456789', '1920-07-19', 'PB14', N'Nam'),
('NV59', N'Guido van Rossum', '357 Đường T, Hà Giang', 100000000, '0123456789', '1910-08-20', 'PB14', N'Nam'),
('NV92', N'Arthur Conan Doyle', '357 Đường S, Vĩnh Phúc', 100000000, '0123456789', '1910-07-19', 'PB02', N'Nam');

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
('KM10' ,'10/10/2022' ,'10/11/2022','HT02',0),
('KM12', '2022-12-11', '2023-01-11', 'HT03',0),
('KM13', '2023-01-11', '2023-02-11', 'HT03',0),
('KM14', '2023-02-11', '2023-03-11', 'HT03',0),
('KM15', '2023-03-11', '2023-04-11', 'HT03',0),
('KM16', '2023-04-11', '2023-05-11', 'HT03',0),
('KM17', '2023-05-11', '2023-06-11', 'HT03',0),
('KM18', '2023-06-11', '2023-07-11', 'HT03',0),
('KM19', '2023-07-11', '2023-08-11', 'HT03',1),
('KM20', '2023-08-11', '2023-09-11', 'HT03',1),
('KM21', '2023-09-11', '2023-10-11', 'HT03',10);

-- Thêm dữ liệu vào bảng SANPHAM
INSERT INTO SANPHAM (MASP, TENSP, DONVI, NSX, HSD, DONGIA, SLTONKHO, MANCC, MALOAI, MAKM)
VALUES 
('SP01', N'Lon Thịt A', 'Lon', '2022-01-01', '2023-01-01', 150000, 10, 'NCC01', 'L01', 'KM01'),
('SP02', N'Chai Thịt B', 'Chai', '02/02/2022', '02/02/2023', 250000, 20, 'NCC02', 'L01','KM01'),
('SP03', N'Túi Thịt C', 'Túi', '03/03/2022', '03/03/2023', 350000, 30, 'NCC03', 'L01','KM01'),
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
('SP33', N'Kẹp Thịt AB', 'Kẹp', '09/09/2024', '09/09/2025', 3800000, 330, 'NCC01', 'L01','KM01'),
('SP34', N'Gói Thịt AC', 'Gói', '10/10/2024', '10/10/2025', 3900000, 340, 'NCC02', 'L01','KM01'),
('SP35', N'Thùng Thịt AD', 'Thùng', '11/11/2024', '11/11/2025', 4000000, 350, 'NCC03', 'L01','KM01'),
('SP36', N'Gói Thịt AD', 'Gói', '11/11/2024', '11/11/2025', 3500000, 350, 'NCC03', 'L01','KM01'),
('SP37', N'Hộp Thịt A', 'Hộp', '2022-01-01', '2023-01-01', 100000, 10, 'NCC01', 'L01', 'KM01'),
('SP38', N'Hộp Thịt B', 'Hộp', '02/02/2022', '02/02/2023', 200000, 20, 'NCC02', 'L01','KM01'),
('SP39', N'Hộp Thịt C', 'Hộp', '03/03/2022', '03/03/2023', 300000, 30, 'NCC03', 'L01','KM01'),
('SP40', N'Gói Thịt AB', 'Gói', '09/09/2024', '09/09/2025', 3300000, 330, 'NCC01', 'L01','KM01'),
('SP41', N'Thùng Thịt AC', 'Thùng', '10/10/2024', '10/10/2025', 3400000, 340, 'NCC02', 'L01','KM01'),
('SP42', N'Gói Thịt AD', 'Gói', '11/11/2024', '11/11/2025', 3500000, 350, 'NCC03', 'L01','KM01'),
('SP43', N'Lon B', 'Lon', '02/02/2022', '02/02/2023', 200000, 20, 'NCC02', 'L01','KM01'),
('SP44', N'Chai C', 'Chai', '03/03/2022', '03/03/2023', 300000, 30, 'NCC03', 'L01','KM01'),
('SP45', N'Túi D', 'Túi', '04/04/2022', '04/04/2023', 400000, 40, 'NCC04', 'L01','KM01'),
('SP46', N'Kẹp S', 'Kẹp', '07/07/2023', '07/07/2024' ,1900000 ,190 ,'NCC03', 'L01','KM01'),
('SP47' ,N'Gói T', N'Gói' ,'08/08/2023' ,'08/08/2024' ,2000000 ,200 ,'NCC04', 'L01','KM01');



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
('HD02', 'SP02', 2),
('HD03', 'SP03', 3),
('HD04', 'SP04', 4),
('HD05', 'SP05', 5),
('HD01', 'SP06', 6),
('HD02', 'SP07', 7),
('HD03', 'SP08', 8),
('HD04', 'SP09', 9),
('HD05', 'SP10', 10),
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
INSERT INTO quyentruycap VALUES ('QTC05', 'Quyền xem chi tiết sản phẩm');
INSERT INTO quyentruycap VALUES ('QTC06', 'Quyền thêm sản phẩm vào giỏ hàng');
INSERT INTO quyentruycap VALUES ('QTC07', 'Quyền xóa sản phẩm khỏi giỏ hàng');
INSERT INTO quyentruycap VALUES ('QTC08', 'Quyền thực hiện thanh toán');
INSERT INTO quyentruycap VALUES ('QTC09', 'Quyền xem lịch sử mua hàng');
INSERT INTO quyentruycap VALUES ('QTC10', 'Quyền đánh giá sản phẩm');
INSERT INTO quyentruycap VALUES ('QTC11', 'Quyền xem thông tin cá nhân');
INSERT INTO quyentruycap VALUES ('QTC12', 'Quyền cập nhật thông tin cá nhân');
INSERT INTO quyentruycap VALUES ('QTC13', 'Quyền thay đổi mật khẩu');
INSERT INTO quyentruycap VALUES ('QTC14', 'Quyền quản lý danh sách yêu thích');
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

INSERT INTO taikhoan VALUES ('admin', 'admin123', 'NV40', 'maqtc_full');
