

using System;

namespace LTUD1_BACHHOAXANH472
{
    internal class SanPham
    {
        private string ma, ten,donVi,nCC,loaiSP,khuyenMai;
        private double gia;
        private int soluong;
        private DateTime ngaySX, hanSD;

        public SanPham()
        {
            
        }

        public SanPham(string ma, string ten, string donVi, string nCC, string loaiSP, string khuyenMai, double gia, int soluong, DateTime ngaySX, DateTime hanSD)
        {
            this.Ma = ma;
            this.Ten = ten;
            this.DonVi = donVi;
            this.NCC = nCC;
            this.LoaiSP = loaiSP;
            this.KhuyenMai = khuyenMai;
            this.Gia = gia;
            this.Soluong = soluong;
            this.NgaySX = ngaySX;
            this.HanSD = hanSD;
        }

        public string Ma { get => ma; set => ma = value; }
        public string Ten { get => ten; set => ten = value; }
        public string DonVi { get => donVi; set => donVi = value; }
        public string NCC { get => nCC; set => nCC = value; }
        public string LoaiSP { get => loaiSP; set => loaiSP = value; }
        public string KhuyenMai { get => khuyenMai; set => khuyenMai = value; }
        public double Gia { get => gia; set => gia = value; }
        public int Soluong { get => soluong; set => soluong = value; }
        public DateTime NgaySX { get => ngaySX; set => ngaySX = value; }
        public DateTime HanSD { get => hanSD; set => hanSD = value; }
    }
}
