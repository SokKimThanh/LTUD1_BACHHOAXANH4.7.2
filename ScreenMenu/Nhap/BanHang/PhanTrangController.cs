using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace LTUD1_BACHHOAXANH472
{
    internal class PhanTrangController
    {
        int pageIndex = 32;//Đơn vị cách nhau mỗi trang
        private BindingSource danhSachSP = new BindingSource();
        private int currentPage = 1;// số trang hiện tại
        private int pageSize = 8;// số sản phẩm mỗi trang 
        private int pageCount = 0;// tổng số trang có thể hiển thị        
        private string tensanpham;// Tên sản phẩm (tensp)
        private string nhacungcap;// nhà cung cấp (mancc)
        private string loaisanpham;// loại sản phẩm (loaisp)
        SanPhamController sanPhamController = new SanPhamController(Utils.ConnectionString);

        public PhanTrangController(int currentPage, int pageSize, int pageCount, string searchterm = null, string nhacungcap = null, string loaisanpham = null)
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

        public DataTable GetDataPhanTrang()
        {
            try
            {
                danhSachSP.DataSource = sanPhamController.PhanTrang(CurrentPage, PageSize, Tensanpham, loaisanpham, Nhacungcap);
                int rowcount = sanPhamController.GetRowCount(string.IsNullOrEmpty(Tensanpham) ? null : Tensanpham.Trim().ToLower()
                    , string.IsNullOrEmpty(Loaisanpham) ? null : Loaisanpham.Trim().ToLower(),
                    string.IsNullOrEmpty(Nhacungcap) ? null : Nhacungcap.Trim().ToLower());
                this.PageCount = rowcount % pageSize;

            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            return (DataTable)danhSachSP.DataSource;
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
                GetDataPhanTrang();
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
                GetDataPhanTrang();
            }
        }
        public string GetTongSoTrang()
        {

            return $"Trang {this.CurrentPage}/{this.PageCount}";//Trang 1/40
        }
        public void CreatePagesizeCombobox(object sender)
        {
            ComboBox cboPageSize = (ComboBox)sender;
            if (cboPageSize != null)
            {
                // Tạo mảng số cách nhau 4 đơn vị
                int[] array = new int[5];
                for (int i = 1; i < array.Length; i++)
                {
                    array[i] = i * pageIndex;
                }

                // Thêm mảng số vào ComboBox
                cboPageSize.Items.AddRange(array.Cast<object>().ToArray());
            }
        }
    }
}
