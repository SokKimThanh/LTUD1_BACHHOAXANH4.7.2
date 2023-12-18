using System;
namespace LTUD1_BACHHOAXANH472
{
    internal class SanPham
    {
        private string masp, tensp, donvi, mancc, maloai, makm;
        private int dongia;
        private int sltonkho;
        private DateTime ngaySX, hanSD;

        public SanPham()
        {

        }

        public SanPham(string masp, string tensp, string donvi, string nCC, string loaiSP, string makm, int dongia, int soluong, DateTime ngaySX, DateTime hanSD)
        {
            if (string.IsNullOrEmpty(masp) || string.IsNullOrEmpty(tensp) || string.IsNullOrEmpty(donvi) || string.IsNullOrEmpty(nCC) || string.IsNullOrEmpty(loaiSP) || string.IsNullOrEmpty(makm))
            {
                throw new Exception("Field Không được để trống");
            }

            this.MaSP = masp;
            this.TenSP = tensp;
            this.DonVi = donvi;
            this.Mancc = nCC;
            this.MaLoai = loaiSP;
            this.KhuyenMai = makm;
            this.Dongia = dongia;
            this.SLTonKho = soluong;
            this.NgaySX = ngaySX;
            this.HanSD = hanSD;
        }


        public string MaSP { get => masp; set => masp = value; }
        public string TenSP { get => tensp; set => tensp = value; }
        public string DonVi { get => donvi; set => donvi = value; }
        public string Mancc { get => mancc; set => mancc = value; }
        public string MaLoai { get => maloai; set => maloai = value; }
        public string KhuyenMai { get => makm; set => makm = value; }
        public int Dongia { get => dongia; set => dongia = value; }
        public int SLTonKho { get => sltonkho; set => sltonkho = value; }
        public DateTime NgaySX { get => ngaySX; set => ngaySX = value; }
        public DateTime HanSD { get => hanSD; set => hanSD = value; }
    }
}
