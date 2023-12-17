using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LTUD1_BACHHOAXANH472.ScreenMenu.Nhap.BanHang
{
    internal class PhanTrangSanPham
    {
        private BindingSource danhSachSP = new BindingSource();
        private int currentPage = 1;
        private int pageSize = 4;
        private int pageCount = 0;
        private string searchterm;
        private string nhacungcap;
        private string loaisanpham;
        SanPhamController sanPhamController = new SanPhamController(Utils.ConnectionString);

        public PhanTrangSanPham(BindingSource bindingSource1, int currentPage, int pageSize, int pageCount, string searchterm = null, string nhacungcap = null, string loaisanpham = null)
        {
            this.danhSachSP = bindingSource1;
            this.currentPage = currentPage;
            this.pageSize = pageSize;
            this.pageCount = pageCount;
            this.searchterm = searchterm;
            this.nhacungcap = nhacungcap;
            this.loaisanpham = loaisanpham;
        }

        public BindingSource DanhSachSanPham { get => danhSachSP; set => danhSachSP = value; }
        public int CurrentPage { get => currentPage; set => currentPage = value; }
        public int PageSize { get => pageSize; set => pageSize = value; }
        public int PageCount { get => pageCount; set => pageCount = value; }
        public string Searchterm { get => searchterm; set => searchterm = value; }
        public string Nhacungcap { get => nhacungcap; set => nhacungcap = value; }
        public string Loaisanpham { get => loaisanpham; set => loaisanpham = value; }

        public void GetData()
        {
            try
            {
                danhSachSP.DataSource = sanPhamController.PhanTrang(currentPage, pageSize, searchterm, nhacungcap, loaisanpham);
            }
            catch (SqlException)
            {
                MessageBox.Show("Error");
            }
        }

        public void btnNext_Click(object sender, EventArgs e)
        {
            if (currentPage < pageCount)
            {
                currentPage++;
                Label lblTongSoTrang = sender as Label;
                lblTongSoTrang.Text = $"Trang {currentPage}/{pageCount}";//Trang 1/40
                GetData();
            }
        }

        public void btnPrevious_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                Label lblTongSoTrang = sender as Label;
                lblTongSoTrang.Text = $"Trang {currentPage}/{pageCount}";//Trang 1/40
                GetData();
            }
        }
         
    }
}
