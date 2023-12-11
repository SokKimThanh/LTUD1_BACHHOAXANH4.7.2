

using System;

namespace LTUD1_BACHHOAXANH472
{
    public class NhanVien
    {
        private string manv;
        private string hotennv;
        private string diachinv;
        private float luong;
        private int sdtnv;
        private DateTime ngaysinh;
        private string mapb;
        private string gioitinh; 

        public NhanVien()
        {
            this.manv = string.Empty;
            this.hotennv = string.Empty;
            this.diachinv = string.Empty;
            this.luong = 0;
            this.sdtnv = 0;
            this.ngaysinh = new DateTime();
            this.mapb = string.Empty;
            this.gioitinh = string.Empty;
        }

        public NhanVien(string manv, string hotennv, string diachinv, float luong, int sdtnv, DateTime ngaysinh, string mapb, string gioitinh)
        {
            if (string.IsNullOrEmpty(manv))
            {
                throw new Exception("Mã nhân viên không được để trống!");
            }
            if (string.IsNullOrEmpty(hotennv))
            {
                throw new Exception("Tên nhân viên không được để trống!");
            }

            this.manv = manv;
            this.hotennv = hotennv;
            this.diachinv = diachinv;
            this.luong = luong;
            this.sdtnv = sdtnv;
            this.ngaysinh = ngaysinh;
            this.mapb = mapb;
            this.gioitinh = gioitinh;
        }

        public string Manv { get => manv; set => manv = value; }
        public string Hotennv { get => hotennv; set => hotennv = value; }
        public string Diachinv { get => diachinv; set => diachinv = value; }
        public float Luong { get => luong; set => luong = value; }
        public int Sdtnv { get => sdtnv; set => sdtnv = value; }
        public DateTime Ngaysinh { get => ngaysinh; set => ngaysinh = value; }
        public string Mapb { get => mapb; set => mapb = value; }
        public string Gioitinh { get => gioitinh; set => gioitinh = value; }

        public void Nhap()
        {
            this.Manv = "dfasdf";
            this.Hotennv = "sok kim thanh";
            this.Diachinv = "diachi001";
            this.Luong = 123123;
            this.Sdtnv = 123123123;
            this.ngaysinh = DateTime.Parse("2023/2/2");
            this.mapb = "pb3123";
            this.gioitinh = "nam";
        }
        public string Xuat()
        {
            return $"{this.manv}#{this.hotennv}#{this.diachinv}#{this.luong}#{this.mapb}#{this.gioitinh}";
        }
    }
}
