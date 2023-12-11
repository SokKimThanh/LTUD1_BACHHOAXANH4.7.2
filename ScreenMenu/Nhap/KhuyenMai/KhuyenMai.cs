using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTUD1_BACHHOAXANH472
{
    internal class KhuyenMai
    {
        string makm;
        DateTime ngaybd;
        DateTime ngaykt;
        string maht;

        public KhuyenMai()
        {
            makm = string.Empty;
            ngaybd = DateTime.Now;
            ngaykt = DateTime.Now;
            maht = string.Empty;
        }
        public KhuyenMai(string makm, DateTime ngaybd, DateTime ngaykt, string maht)
        {
            this.makm = makm;
            this.ngaybd = ngaybd;
            this.ngaykt = ngaykt;
            this.maht = maht;
        }

        public string Makm { get => makm; set => makm = value; }
        public DateTime Ngaybd { get => ngaybd; set => ngaybd = value; }
        public DateTime Ngaykt { get => ngaykt; set => ngaykt = value; }
        public string Maht { get => maht; set => maht = value; }

        public override string ToString()
        {
            return $"{makm,-15}{Ngaybd.ToString("dd/MM/yyyy"),-10}{Ngaykt.ToString("dd/MM/yyyy"),-10}{Maht,-15}";
        }
    }
}
