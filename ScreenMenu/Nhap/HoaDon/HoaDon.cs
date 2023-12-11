using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTUD1_BACHHOAXANH472.ScreenMenu.Nhap.HoaDon
{
    internal class HoaDon
    {
        private string maHD, maNV, maKH;
        private DateTime ngayHD;
        private float tongTien = 0;
        public HoaDon()
        { }
        public HoaDon(string maHD, string maNV, string maKH, DateTime ngayHD, float tongTien)
        {
            this.MaHD = maHD;
            this.MaNV = maNV;
            this.MaKH = maKH;
            this.NgayHD = ngayHD;
            this.TongTien = tongTien;
        }

        public string MaHD { get => maHD; set => maHD = value; }
        public string MaNV { get => maNV; set => maNV = value; }
        public string MaKH { get => maKH; set => maKH = value; }
        public DateTime NgayHD { get => ngayHD; set => ngayHD = value; }
        public float TongTien { get => tongTien; set => tongTien = value; }
    }
}
