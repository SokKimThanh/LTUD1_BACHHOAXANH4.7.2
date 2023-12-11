using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTUD1_BACHHOAXANH472.ScreenMenu.Nhap.DiaDiem
{
    internal class DiaDiem
    {
        string maCN, tenCN, diaChi;

        public DiaDiem()
        {

        }
        public DiaDiem(string maCN, string tenCN, string diaChi)
        {
            this.maCN = maCN;
            this.tenCN = tenCN;
            this.diaChi = diaChi;
        }

        public string MaCN { get => maCN; set => maCN = value; }
        public string TenCN { get => tenCN; set => tenCN = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
    }
}
