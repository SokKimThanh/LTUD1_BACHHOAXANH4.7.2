-- ================================================
-- Author:		Sok Kim Thanh
-- Create date: <07/11/2023>
-- update date: 10-12-2023
-- Create Procedure sp_nhacungcap_insert.sql
-- Nhà cung cấp insert 
-- =============================================
drop procedure if exists sp_nhacungcap_insert
go
CREATE PROCEDURE sp_nhacungcap_insert
	-- Add the parameters for the stored procedure here
	@MANCC CHAR(11),
	@TENNCC NVARCHAR(30) ,
	@DIACHINCC NVARCHAR(100),
	@SDTNCC INT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO NHACUNGCAP(MANCC,TENNCC,DIACHINCC,SDTNCC) VALUES (@MANCC, @TENNCC, @DIACHINCC,@SDTNCC)
END
GO

--exec sp_nhacungcap_insert 'ncc005', 'Hoang CC', 'ly thai to q3', 123123
--exec sp_nhacungcap_select_all
--select * from nhacungcap