using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTUD1_BACHHOAXANH472
{
    internal class HinhThucKhuyenMai
    {
        string makm ;
        string hinhthuc;
        string ghichu;
        public HinhThucKhuyenMai()
        {
            makm = string.Empty;
            hinhthuc = string.Empty;
            ghichu = string.Empty;
        }

        public HinhThucKhuyenMai(string makm, string hinhthuc, string ghichu)
        {
            this.makm = makm;
            this.hinhthuc = hinhthuc;
            this.ghichu = ghichu;
        }

        public string Hinhthuc { get => hinhthuc; set => hinhthuc = value; }
        public string Ghichu { get => ghichu; set => ghichu = value; }
        public string Makm { get => makm; set => makm = value; }

        public override string ToString()
        {
            return  $"{makm,-15}{Hinhthuc,-15}{Ghichu,-15}";
        }
    }
}
