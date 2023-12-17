﻿-- CREATE PROCEDURE SP_SANPHAM_PHANTRANG.SQL
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
END
go
SELECT * FROM LOAISP
SELECT * FROM NHACUNGCAP
EXECUTE sp_sanpham_phantrang 'L01','NCC02','A',1,16

