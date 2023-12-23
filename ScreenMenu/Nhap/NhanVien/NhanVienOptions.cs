using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTUD1_BACHHOAXANH472
{
    public enum NhanVienOptions
    {
        TatCaNhanVien = 1, // In tất cả nhân viên
        TimKiemNhanVien = 2, // In nhân viên theo tìm kiếm
        NhanVienTheoPhongBan = 3, // In nhân viên theo phòng ban
        SoLuongNhanVienTheoChiNhanh = 4, // In ra số lượng nhân viên theo chi nhánh
        DanhSachHoaDonCuaNhanVien = 5, // Lấy danh sách hóa đơn của một nhân viên
        TongThanhTienCuaHoaDonCuaNhanVien = 6, // Tính tổng thành tiền của tất cả hóa đơn của một nhân viên
        DanhSachNhanVienTheoSoLuongHoaDon = 7 // Lấy danh sách nhân viên theo số lượng hóa đơn
    }

    public static class NhanVienOptionsExtensions
    {
        public static string ToFriendlyString(this NhanVienOptions me)
        {
            switch (me)
            {
                case NhanVienOptions.TatCaNhanVien:
                    return "In tất cả nhân viên";
                case NhanVienOptions.TimKiemNhanVien:
                    return "In nhân viên theo tìm kiếm";
                case NhanVienOptions.NhanVienTheoPhongBan:
                    return "In nhân viên theo phòng ban";
                case NhanVienOptions.SoLuongNhanVienTheoChiNhanh:
                    return "In ra số lượng nhân viên theo chi nhánh";
                case NhanVienOptions.DanhSachHoaDonCuaNhanVien:
                    return "Lấy danh sách hóa đơn của một nhân viên";
                case NhanVienOptions.TongThanhTienCuaHoaDonCuaNhanVien:
                    return "Tính tổng thành tiền của tất cả hóa đơn của một nhân viên";
                case NhanVienOptions.DanhSachNhanVienTheoSoLuongHoaDon:
                    return "Lấy danh sách nhân viên theo số lượng hóa đơn";
                default:
                    return "Unknown";
            }
        }
    }

}
