using System;
namespace LTUD1_BACHHOAXANH472
{
    internal class ChiNhanh
    {
        string maCN, tenCN, diaChi;

        public ChiNhanh()
        {

            maCN = string.Empty;
            tenCN = string.Empty;
            diaChi = string.Empty;
        }
        public ChiNhanh(string maCN, string tenCN, string diaChi)
        {
            if (string.IsNullOrEmpty(tenCN))
            {
                throw new Exception("tên chi nhánh Không để trống!");
            }
            else if (tenCN.Length > 30)
            {
                throw new Exception("tên chi nhánh nhiều hơn 30 ký tự");
            }
            this.maCN = maCN;
            this.tenCN = tenCN;
            this.diaChi = diaChi;
        }

        public string MaCN { get => maCN; set => maCN = value; }
        public string TenCN { get => tenCN; set => tenCN = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
    }
}
