-- Tạo store quản lý truy cập 
-- Author:		Sok Kim Thanh
-- Create date: <21/12/2023>
-- Cập nhật stored procedure
-- đăng nhập vào thành công thì trả về 1
-- đăng nhập vào thất bại thì trả về 0
drop proc if exists sp_DangNhap
go
CREATE PROCEDURE sp_DangNhap
    @TENTK CHAR(30),
    @MATKHAU CHAR(30),
    @KETQUA int OUTPUT
AS
BEGIN
    IF EXISTS (SELECT 1 FROM TAIKHOAN WHERE TENTK = @TENTK AND MATKHAU = @MATKHAU)
    BEGIN
        -- Thêm dòng mới vào bảng TRUYCAP
        INSERT INTO TRUYCAP (TENTK, THOIDIEM, KETQUA) VALUES (@TENTK, GETDATE(), N'Thành công')

        SET @KETQUA = 1--N'Đăng nhập thành công'
    END
    ELSE
    BEGIN
        -- Thêm dòng mới vào bảng TRUYCAP
        INSERT INTO TRUYCAP (TENTK, THOIDIEM, KETQUA) VALUES (@TENTK, GETDATE(), N'Thất bại')

        SET @KETQUA = 0--N'Tên tài khoản hoặc mật khẩu không đúng'
    END
END;
go
 

-- câu store cấp quyền truy cập 
drop proc if exists sp_CapQuyen
go
CREATE PROCEDURE sp_CapQuyen
    @TENTK CHAR(30),
    @MATKHAU CHAR(30)
AS
BEGIN
    SELECT Q.MAQTC, tk.MANV
    FROM TAIKHOAN TK
    INNER JOIN QUYENTRUYCAP Q ON TK.MAQTC = Q.MAQTC
    WHERE TK.TENTK = @TENTK AND TK.MATKHAU = @MATKHAU
END;
go


-- hien thi ten nhan vien va quyen truy cap 
 
EXEC sp_CapQuyen 'admin', 'admin123' 
go
exec sp_quyentruycap_select_one 'maqtc_full'
