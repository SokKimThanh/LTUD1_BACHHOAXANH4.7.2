using System.Collections.Generic;

namespace LTUD1_BACHHOAXANH472
{
    internal class DanhSachSanPham
    {
        List<SanPham> list;

        public DanhSachSanPham()
        {
            list = new List<SanPham>();
        }

        public void Add(SanPham a)
        {
            list.Add(a);
        }
    }
}
