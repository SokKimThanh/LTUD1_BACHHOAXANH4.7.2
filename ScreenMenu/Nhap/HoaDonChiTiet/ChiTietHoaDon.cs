using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTUD1_BACHHOAXANH472
{
    internal class ChiTietHoaDon
    {
        private string maHD, maSP;
        private int soLuong;

        public ChiTietHoaDon() { }
        public ChiTietHoaDon(string maHD, string maSP, int soLuong)
        {
            this.MaHD = maHD;
            this.MaSP = maSP;
            this.SoLuong = soLuong;
        }

        public string MaHD { get => maHD; set => maHD = value; }
        public string MaSP { get => maSP; set => maSP = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
    }
}
