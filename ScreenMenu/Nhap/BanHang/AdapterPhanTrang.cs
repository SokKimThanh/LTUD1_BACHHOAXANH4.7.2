using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace LTUD1_BACHHOAXANH472
{
    public class AdapterPhanTrang
    {
        //==============================================================================
        //--..........................................................................--
        //------------------.       Cài đặt biến thành viên       .---------------------
        //--..........................................................................--
        //==============================================================================
        private BindingSource bindingSource1 = new BindingSource();
        private TextBox txtTenSanPham = new TextBox();// Tên sản phẩm (tensp)
        private ComboBox cboNhaCungCap = new ComboBox();// nhà cung cấp (mancc)
        private ComboBox cboLoaiSanPham = new ComboBox();// loại sản phẩm (loaisp)
        private ComboBox cboRecordPerPage = new ComboBox();// số sản phẩm mỗi trang 
        private DataGridView dgvDanhSachSanPham = new DataGridView();
        private Label lblTongSoTrang = new Label();
        SanPhamController sanPhamController = new SanPhamController(Utils.ConnectionString);
        private int currentPage = 1;
        private int recordsPerPage = 4;
        private int totalRecords = 0;

        //==============================================================================
        //--..........................................................................--
        //------------------.               constructor           .---------------------
        //--..........................................................................--
        //==============================================================================
        public AdapterPhanTrang(int recordsPerPage)
        {
            this.recordsPerPage = recordsPerPage;
        }
        public AdapterPhanTrang(ComboBox cboRecordPerPage, TextBox txtTenSanPham, ComboBox cboNhaCungCap, ComboBox cboLoaiSanPham, DataGridView dgvDanhSachSanPham, Label lblTongSoTrang, int recordsPerPage)
        {
            this.cboRecordPerPage = cboRecordPerPage;
            this.txtTenSanPham = txtTenSanPham;
            this.cboNhaCungCap = cboNhaCungCap;
            this.cboLoaiSanPham = cboLoaiSanPham;
            this.dgvDanhSachSanPham = dgvDanhSachSanPham;
            this.lblTongSoTrang = lblTongSoTrang;
            this.recordsPerPage = recordsPerPage;
        }
        //==============================================================================
        //--..........................................................................--
        //------------------.               property              .---------------------
        //--..........................................................................--
        //==============================================================================
        public BindingSource DanhSachSanPham { get => bindingSource1; set => bindingSource1 = value; }
        public TextBox Tensanpham { get => txtTenSanPham; set => txtTenSanPham = value; }
        public ComboBox Nhacungcap { get => cboNhaCungCap; set => cboNhaCungCap = value; }
        public ComboBox Loaisanpham { get => cboLoaiSanPham; set => cboLoaiSanPham = value; }
        public ComboBox CboRecordPerPage { get => cboRecordPerPage; set => cboRecordPerPage = value; }
        public DataGridView DgvDanhSachSanPham { get => dgvDanhSachSanPham; set => dgvDanhSachSanPham = value; }
        public Label LblTongSoTrang { get => lblTongSoTrang; set => lblTongSoTrang = value; }
        public int RecordsPerPage { get => recordsPerPage; set => recordsPerPage = value; }


        /// <summary>
        /// Phân trang danh sách sản phẩm
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public DataTable GetData(int recordsPerPage, string tensanpham = null, string loaisanpham = null, string nhacungcap = null)
        {
            try
            {
                bindingSource1.DataSource = sanPhamController.PhanTrang(currentPage, recordsPerPage, tensanpham, loaisanpham, nhacungcap);
                totalRecords = sanPhamController.GetRowCount(tensanpham, nhacungcap, loaisanpham) / recordsPerPage;
                lblTongSoTrang.Text = currentPage + "/" + totalRecords.ToString();
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            return (DataTable)bindingSource1.DataSource;
        }
        /// <summary>
        /// Nút next sang trang kế tiếp
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void btnNext_Click(object sender, EventArgs e)
        {
            if (currentPage < totalRecords)
            {
                currentPage++;
                recordsPerPage = (int)cboRecordPerPage.SelectedItem;
                dgvDanhSachSanPham.DataSource = GetData(recordsPerPage);
            }
        }
        /// <summary>
        /// Nút back quay lại trang cũ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void btnPrevious_Click(object sender, EventArgs e)
        {
            // khởi tạo dữ liệu mới khi lùi trang
            if (totalRecords == 1)
            {
                currentPage = 1;
            }
            if (totalRecords < currentPage)
            {
                currentPage = 1;
            }
            if (currentPage > 1)
            {
                currentPage--;
            }
            recordsPerPage = (int)cboRecordPerPage.SelectedItem;
            dgvDanhSachSanPham.DataSource = GetData(recordsPerPage);
        }
        public void btnTimKiem_Click(object sender, EventArgs e)
        {
            string tensanpham = txtTenSanPham.Text;
            string loaisanpham = cboLoaiSanPham.SelectedValue.ToString();
            string nhacungcap = cboNhaCungCap.SelectedValue.ToString();

            // khởi tạo dữ liệu mới khi tìm kiếm theo tiêu chí
            recordsPerPage = (int)cboRecordPerPage.SelectedItem;
            dgvDanhSachSanPham.DataSource = GetData(recordsPerPage, tensanpham, loaisanpham, nhacungcap);

            currentPage = 1;
            totalRecords = sanPhamController.GetRowCount(null, null, null) / recordsPerPage;
            lblTongSoTrang.Text = currentPage + "/" + totalRecords.ToString();

            // làm mới danh sách 
            dgvDanhSachSanPham.Refresh();
        }

        //==============================================================================
        //--..........................................................................--
        //------------.  Sự kiện làm mới tìm kiếm danh sách sản phẩm        .-----------
        //--..........................................................................--
        //==============================================================================
        public void btnRefresh_Click(object sender, EventArgs e)
        {
            txtTenSanPham.Text = string.Empty;
            cboLoaiSanPham.SelectedIndex = 0;
            cboNhaCungCap.SelectedIndex = 0;
            cboLoaiSanPham.SelectedIndex = 0;
            cboRecordPerPage.SelectedIndex = 1;

            // Quay về trang số 1
            currentPage = 1;

            // Tạo mới tổng số record
            totalRecords = sanPhamController.GetRowCount(null, null, null) / recordsPerPage;

            // Tạo mới phân trang theo tổng số record
            dgvDanhSachSanPham.DataSource = GetData(totalRecords);

            // Tạo mới tổng số trang
            lblTongSoTrang.Text = currentPage + "/" + totalRecords.ToString();

            // làm mới danh sách 
            dgvDanhSachSanPham.Refresh();
        }
        //==============================================================================
        //--..........................................................................--
        //------------------.  Khởi tạocombobox hiển thị số lượng item       .----------
        //--..........................................................................--
        //==============================================================================
        /// <summary>
        /// Tổng số trang của phân trang trên combobox
        /// </summary> 
        /// <param name="howManySpacebetweenTwoItem">Khoảng cách mỗi đơn vị vd: 8 16 32</param>
        /// <param name="howManyItemDoYouWantToShow">Kích thước hiển thị mảng số nguyên trên combbox</param>
        public void SetRecordPerPageCombobox(int howManySpacebetweenTwoItem, int howManyItemDoYouWantToShow)
        {
            if (cboRecordPerPage != null)
            {
                // Tạo mảng số cách nhau 4 đơn vị
                int[] array = new int[howManyItemDoYouWantToShow];
                for (int i = 1; i < array.Length; i++)
                {
                    array[i] = i * howManySpacebetweenTwoItem;
                }

                // Thêm mảng số vào ComboBox
                cboRecordPerPage.Items.AddRange(array.Cast<object>().ToArray());
            }
        }
        public int GetRowCount()
        {
            totalRecords = sanPhamController.GetRowCount(null, null, null) / recordsPerPage;
            return totalRecords;
        }
    }
}
