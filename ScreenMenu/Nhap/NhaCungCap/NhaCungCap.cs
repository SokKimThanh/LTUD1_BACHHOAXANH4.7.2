

namespace LTUD1_BACHHOAXANH472
{
    internal class NhaCungCap
    {
        private string ma, ten, diachi;
        int sdt;
        public NhaCungCap(string ma = "", string ten = "", string diachi = "", int sdt = 3254234)
        {
            this.ma = ma;
            this.ten = ten;
            this.diachi = diachi;
            this.sdt = sdt;
        }

        public int Sdt { get => sdt; set => sdt = value; }
        public string Ma { get => ma; set => ma = value; }
        public string Ten { get => ten; set => ten = value; }
        public string Diachi { get => diachi; set => diachi = value; }
    }
}
