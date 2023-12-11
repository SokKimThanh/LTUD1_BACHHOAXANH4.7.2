using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTUD1_BACHHOAXANH472.ScreenMenu.Nhap.PhongBan
{
    internal class PhongBan
    {
        string maPB, tenPB, maCN;
        public PhongBan()
        {

        }

        public PhongBan(string maPB, string tenPB, string maCN)
        {
            this.maPB = maPB;
            this.tenPB = tenPB;
            this.maCN = maCN;
        }
        public string MaPB { get => maPB; set => maPB = value; }
        public string TenPB { get => tenPB; set => tenPB = value; }
        public string MaCN { get => maCN; set => maCN = value; }
    }
}
