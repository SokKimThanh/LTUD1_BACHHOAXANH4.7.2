using System;
namespace LTUD1_BACHHOAXANH472
{
    internal class KhuyenMai
    {
        string makm;
        DateTime ngaybd;
        DateTime ngaykt;
        string maht;
        int phantramKM;

        public KhuyenMai()
        {
            makm = string.Empty;
            ngaybd = DateTime.Now;
            ngaykt = DateTime.Now;
            maht = string.Empty;
            PhantramKM = 0;
        }
        public KhuyenMai(string makm, DateTime ngaybd, DateTime ngaykt, string maht, int phantramkm)
        {
            this.makm = makm;
            this.ngaybd = ngaybd;
            this.ngaykt = ngaykt;
            this.maht = maht;
            this.PhantramKM = phantramkm;
        }

        public string Makm { get => makm; set => makm = value; }
        public DateTime Ngaybd { get => ngaybd; set => ngaybd = value; }
        public DateTime Ngaykt { get => ngaykt; set => ngaykt = value; }
        public string Maht { get => maht; set => maht = value; }
        public int PhantramKM { get => phantramKM; set => phantramKM = value; }

        public override string ToString()
        {
            return $"{makm,-15}{Ngaybd,-10:dd/MM/yyyy}{Ngaykt,-10:dd/MM/yyyy}{Maht,-15}";
        }
    }
}
