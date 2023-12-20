@echo off
REM Đường dẫn đến tệp đầu ra
set "output=D:\TDC_HK3\LTUD1_LETHO\LTUD1_BACHHOAXANH472\SQLBIENBAN\PROJECT_STOREPROCEDURE_BHX.sql"

REM Kiểm tra xem tệp đầu ra đã tồn tại chưa
if exist "%output%" (
    echo Tệp %output% đã tồn tại. Xóa tệp...
    del /f "%output%"
)

for /R "D:\TDC_HK3\LTUD1_LETHO\LTUD1_BACHHOAXANH472\ScreenMenu\" %%G in (*.sql) do (
    echo Đang xử lý tệp %%G...
    powershell -Command "(Get-Content '%%G' -Encoding Unicode) | Where-Object { $_.Trim() -ne '' } | Set-Content '%%G' -Encoding Unicode"
    type "%%G" >> "%output%"
)
echo Hoàn tất!
