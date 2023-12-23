-- Tạo store quản lý truy cập 
-- Author:		Sok Kim Thanh
-- Create date: <21/12/2023>
-- Cập nhật stored procedure
-- đăng nhập vào thành công thì trả về 1
-- đăng nhập vào thất bại thì trả về 0
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

-- hiển thị kết quả quyền truy cập nếu truy cập thành công thì lúc đó sẽ gọi câu store cấp quyền truy cập
go
CREATE PROCEDURE sp_CapQuyen
    @TENTK CHAR(30),
    @MATKHAU CHAR(30),
    @QUYEN NVARCHAR(255) OUTPUT
AS
BEGIN
    SELECT @QUYEN = Q.TENQTC
    FROM TAIKHOAN TK
    INNER JOIN QUYENTRUYCAP Q ON TK.MAQTC = Q.MAQTC
    WHERE TK.TENTK = @TENTK AND TK.MATKHAU = @MATKHAU
END

-- hien thi ten nhan vien va quyen truy cap 