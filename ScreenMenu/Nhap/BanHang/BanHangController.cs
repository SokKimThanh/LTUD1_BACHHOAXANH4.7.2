using System.Data.SqlClient;
using System.Windows.Forms;
using System;
using LTUD1_BACHHOAXANH472.controller;

namespace LTUD1_BACHHOAXANH472.ScreenMenu.Nhap.BanHang
{
    public class BanHangController
    {
        DataGridView dgvThongTinHoaDon;
        DataGridView dgvDanhSachSanPham;
        SanPhamController sanphamController = new SanPhamController(Utils.ConnectionString);
        int soluongmua;
        double tongtien;
        public BanHangController(DataGridView dgvThongTinHoaDon, DataGridView dgvDanhSachSanPham)
        {
            this.dgvThongTinHoaDon = dgvThongTinHoaDon;
            this.dgvDanhSachSanPham = dgvDanhSachSanPham;
        }

        //Map datarow từ grid sản phẩm sang grid hóa đơn
        private DataGridViewRow MapDataRow(DataGridViewRow rowDanhSachSanPham)
        {
            //Thêm 1 obj cho dgvThongTinHoaDon vì dữ các cột không đồng bộ

            DataGridViewRow row = new DataGridViewRow();

            //Tạo columns cho từng hàng
            for (int i = 0; i < dgvThongTinHoaDon.Columns.Count - 2; i++)
            {
                row.Cells.Add(new DataGridViewTextBoxCell());
            }
            row.Cells[0].Value = rowDanhSachSanPham.Cells[1].Value;
            row.Cells[1].Value = rowDanhSachSanPham.Cells[2].Value;
            row.Cells[2].Value = rowDanhSachSanPham.Cells[3].Value;
            row.Cells[3].Value = TinhToanKhuyenMai(rowDanhSachSanPham.Cells[5].Value.ToString());
            row.Cells[4].Value = 0;
            row.Cells[5].Value = 0;

            row.Cells.Add(new DataGridViewButtonCell());
            row.Cells[6].Value = "+";
            row.Cells.Add(new DataGridViewButtonCell());
            row.Cells[7].Value = "-";
            return row;
        }

        private double TinhToanKhuyenMai(string maKM)
        {
            return sanphamController.getGiaSauGiamGia(makm);
        }

        private int TinhSoLuongTonTheoMa(string maSP)
        {
            int soLuongTon = 0;
            foreach (DataGridViewRow row in dgvDanhSachSanPham.Rows)
            {
                if (maSP.Trim() == row.Cells[1].Value.ToString().Trim())
                    soLuongTon += Convert.ToInt32(row.Cells[4].Value.ToString());
            }
            return soLuongTon;
        }

        private bool KiemTraLonHonTon(string maSP)
        {
            int soLuongTruocKhiThem = 0;
            int soLuongTon = TinhSoLuongTonTheoMa(maSP);

            foreach (DataGridViewRow row in dgvThongTinHoaDon.Rows)
            {
                if (maSP.Trim() == row.Cells[0].Value.ToString().Trim())
                {
                    soLuongTruocKhiThem += Convert.ToInt32(row.Cells[4].Value.ToString().Trim());
                }
            }

            if (soLuongTruocKhiThem < soLuongTon)
            {
                return true;
            }
            return false;
        }

        private void SetTongTienVaTongSoLuong()
        {
            foreach (DataGridViewRow row in dgvThongTinHoaDon.Rows)
            {
                soluongmua += Convert.ToInt32(row.Cells[4].Value);
                tongtien += Convert.ToDouble(row.Cells[5].Value);
            }
        }

    }

}
