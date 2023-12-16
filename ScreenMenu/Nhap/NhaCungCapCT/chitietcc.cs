namespace LTUD1_BACHHOAXANH472.ScreenMenu.Nhap.NhaCungCapCT
{
    internal class NhaCCCT
    {
        private string maNCC, maSP;
        private int soLuong;

        public NhaCCCT() { }
        public NhaCCCT(string maNCC, string maSP, int soLuong)
        {
            this.MaNCC = maNCC;
            this.MaSP = maSP;
            this.SoLuong = soLuong;
        }

        public string MaNCC { get => maNCC; set => maNCC = value; }
        public string MaSP { get => maSP; set => maSP = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
    }
}
