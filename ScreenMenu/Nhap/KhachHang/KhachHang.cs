namespace LTUD1_BACHHOAXANH472.Model
{
    internal class KhachHang
    {
        private string ma, ten;
        private int sdt, diem;

        public KhachHang(string ma, string ten, int sdt, int diem)
        {
            this.ma = ma;
            this.ten = ten;
            this.sdt = sdt;
            this.diem = diem;
        }
        public KhachHang()
        {
            ma = string.Empty;
            ten = string.Empty;
            diem = 0;
            sdt = 0;
        }

        public string Ma { get => ma; set => ma = value; }
        public string Ten { get => ten; set => ten = value; }
        public int Sdt { get => sdt; set => sdt = value; }
        public int Diem { get => diem; set => diem = value; }
    }
}
