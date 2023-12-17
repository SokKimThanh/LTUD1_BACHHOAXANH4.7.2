using System;
using System.Collections.Generic;
using System.Data;
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
        private int currentPage = 1;// số trang hiện tại
        private int pageSize = 4;// số sản phẩm mỗi trang 
        private int pageCount = 0;// tổng số trang có thể hiển thị        
        private string tensanpham;// Tên sản phẩm (tensp)
        private string nhacungcap;// nhà cung cấp (mancc)
        private string loaisanpham;// loại sản phẩm (loaisp)
        SanPhamController sanPhamController = new SanPhamController(Utils.ConnectionString);

        public PhanTrangSanPham(int currentPage, int pageSize, int pageCount, string searchterm = null, string nhacungcap = null, string loaisanpham = null)
        {
            this.currentPage = currentPage;
            this.pageSize = pageSize;
            this.pageCount = pageCount;
            this.tensanpham = searchterm;
            this.nhacungcap = nhacungcap;
            this.loaisanpham = loaisanpham;
        }

        public BindingSource DanhSachSanPham { get => danhSachSP; set => danhSachSP = value; }
        public int CurrentPage { get => currentPage; set => currentPage = value; }
        public int PageSize { get => pageSize; set => pageSize = value; }
        public int PageCount { get => pageCount; set => pageCount = value; }
        public string Tensanpham { get => tensanpham; set => tensanpham = value; }
        public string Nhacungcap { get => nhacungcap; set => nhacungcap = value; }
        public string Loaisanpham { get => loaisanpham; set => loaisanpham = value; }

        public void PhanTrangSP()
        {
            try
            {
                DataTable dt = sanPhamController.PhanTrang(currentPage, pageSize, tensanpham, nhacungcap, loaisanpham);
                this.PageCount = sanPhamController.GetRowCount() / pageSize;
                DanhSachSanPham.DataSource = dt;
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
                if (lblTongSoTrang != null)
                {
                    lblTongSoTrang.Text = GetTongSoTrang();//Trang 1/40
                }
                PhanTrangSP();
            }
        }


        public void btnPrevious_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                Label lblTongSoTrang = sender as Label;
                if (lblTongSoTrang != null)
                {
                    lblTongSoTrang.Text = GetTongSoTrang();//Trang 1/40
                }
                PhanTrangSP();
            }
        }
        public string GetTongSoTrang()
        {

            return $"Trang {this.CurrentPage}/{this.PageCount}";//Trang 1/40
        }
    }
}
