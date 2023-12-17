using LTUD1_BACHHOAXANH472.ScreenMenu.Nhap.HoaDon;
using LTUD1_BACHHOAXANH472.uploads;

namespace LTUD1_BACHHOAXANH472.Screen
{
    public partial class FormHoaDon : Form
    {
        HoaDonController HoaDonController;
        // khởi tạo trạng thái cho nút 
        ButtonStateManager buttonStateManager;
        public FormHoaDon()
        {
            InitializeComponent();
            HoaDonController = new HoaDonController(Utils.ConnectionString);
            dgvHD.DefaultCellStyle.ForeColor = Color.Black;
            CustomButtonHelper customButtonHelper = new CustomButtonHelper();
            customButtonHelper.SetProperties(btnTimKiem);
            buttonStateManager = new ButtonStateManager();
            // khai báo trạng thái khóa nút 
            buttonStateManager.BtnAdd = this.btnThem;
            buttonStateManager.BtnEdit = this.btnXoa;
            buttonStateManager.BtnDelete = this.btnSua;
            buttonStateManager.BtnRefresh = this.btnLamMoi;
        }
        private void FormHoaDon_Load(object sender, EventArgs e)
        {
            try
            {
                //mã tự động
                RandomStringGenerator randomStringGenerator = new RandomStringGenerator();
                txtMaHD.Text = randomStringGenerator.GenerateRandomAlphanumericString(10);
                txtTongTien.Text = "0";
                HoaDonController.SelectAll();
                dgvHD.DataSource = HoaDonController.DataSource;
                HoaDonController.SelectAllNhanVien();
                cbbMaNV.DataSource = HoaDonController.DataSource;
                cbbMaNV.DisplayMember = "HOTENNV";
                cbbMaNV.ValueMember = "MANV";
                HoaDonController.SelectAllKhachHang();
                cbbMaKH.DataSource = HoaDonController.DataSource;
                cbbMaKH.DisplayMember = "HOTENKH";
                cbbMaKH.ValueMember = "MAKH";
                // setting datagridview
                DataGridViewHelper.ConfigureDataGridView(dgvHD);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (ErrTxt.CheckControlValue(txtMaHD))
                {
                    MessageBox.Show("txtMaHD", "Bắt buộc nhập!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                HoaDon hoaDon = new HoaDon();
                hoaDon.MaHD = txtMaHD.Text;
                hoaDon.NgayHD = DateTime.Parse(dtpkNgayLap.Text);
                hoaDon.TongTien = decimal.Parse(txtTongTien.Text);
                hoaDon.MaNV = cbbMaNV.SelectedValue.ToString();
                hoaDon.MaKH = cbbMaKH.SelectedValue.ToString();
                HoaDonController.Insert(hoaDon);
                HoaDonController.SelectAll();
                dgvHD.DataSource = HoaDonController.DataSource;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvHD_Click(object sender, EventArgs e)
        {
            try
            {
                // Khởi tạo số dòng đang chọn
                int dong = dgvHD.CurrentCell.RowIndex;
                // lấy ra mã
                string id = dgvHD.Rows[dong].Cells[0].Value.ToString();
                // khởi tạo đối tượng bằng mã
                DataTable dt = HoaDonController.SelectByID(id);
                DataRow dr = dt.Rows[0];
                // chuyển thành class đối tượng
                HoaDon o = (HoaDon)HoaDonController.FromDataRow(dr);

                // thiết lập dữ liệu ngược lại mỗi lần click
                txtMaHD.Text = o.MaKH.ToString();
                dtpkNgayLap.Value = o.NgayHD;
                txtTongTien.Text = o.TongTien.ToString();
                cbbMaNV.SelectedValue = o.MaNV;
                cbbMaKH.SelectedValue = o.MaKH;
                // cập nhật lại trang thái các nút
                buttonStateManager.UpdateButtonStates(ButtonState.DataGridViewSelected);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (ErrTxt.CheckControlValue(txtMaHD))
            {
                MessageBox.Show("phai chon thông tin để xóa", "Bắt buộc!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult r = MessageBox.Show("Bạn có muốn xoa khong?", "xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                HoaDon hoaDon = new HoaDon();
                hoaDon.MaHD = txtMaHD.Text;
                HoaDonController.Delete(hoaDon.MaHD);
                HoaDonController.SelectAll();
                dgvHD.DataSource = HoaDonController.DataSource;
                buttonStateManager.UpdateButtonStates(ButtonState.RefreshClicked);
                refech();

            }
            return;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

            DialogResult r = MessageBox.Show("Bạn có muốn sua khong?", "xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                HoaDon hoaDon = new HoaDon();
                hoaDon.MaHD = txtMaHD.Text;
                hoaDon.NgayHD = DateTime.Parse(dtpkNgayLap.Text);
                hoaDon.TongTien = decimal.Parse(txtTongTien.Text);
                hoaDon.MaNV = cbbMaNV.SelectedValue.ToString();
                hoaDon.MaKH = cbbMaKH.SelectedValue.ToString();
                HoaDonController.Update(hoaDon);
                HoaDonController.SelectAll();
                dgvHD.DataSource = HoaDonController.DataSource;
                buttonStateManager.UpdateButtonStates(ButtonState.RefreshClicked);
                refech();
            }
            return;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {

            // Khởi tạo một đối tượng mới từ lớp CrystalReport1
            reportHD rpt = new reportHD();

            // Khởi tạo một đối tượng mới từ lớp ParameterValues để chứa các giá trị tham số
            ParameterValues param = new ParameterValues();

            // Khởi tạo một đối tượng mới từ lớp ParameterDiscreteValue để chứa một giá trị tham số rời rạc
            ParameterDiscreteValue pdv = new ParameterDiscreteValue();

            // Đặt giá trị của pdv bằng giá trị trong textBox1
            pdv.Value = txtTimKiem.Text;

            // Thêm pdv vào danh sách các giá trị tham số
            param.Add(pdv);

            // Áp dụng các giá trị tham số hiện tại cho tham số "@masv" trong định nghĩa dữ liệu của báo cáo
            rpt.DataDefinition.ParameterFields["@ma"].ApplyCurrentValues(param);

            // Đặt nguồn báo cáo cho crystalReportViewer1 là báo cáo rpt
            crystalReportViewer1.ReportSource = rpt;
        }

        private void txtMaHD_TextChanged(object sender, EventArgs e)
        {

            if (ErrTxt.NoSymbol_TextChanged(sender))
            {
                MessageBox.Show("txtHoMaHD", "chỉ được nhập chữ hoặc số!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }
        public void refech()
        {
            RandomStringGenerator randomStringGenerator = new RandomStringGenerator();
            txtMaHD.Text = randomStringGenerator.GenerateRandomAlphanumericString(10);
            dtpkNgayLap.Value = DateTime.Now;
            cbbMaKH.SelectedIndex = 0;
            cbbMaNV.SelectedIndex = 0;
            txtTongTien.Text = "0";
        }
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            buttonStateManager.UpdateButtonStates(ButtonState.RefreshClicked);
            refech();
        }
        private void btnTiemKiemTheoNgay_Click(object sender, EventArgs e)
        {

            // Khởi tạo một đối tượng mới từ lớp CrystalReport1
            //rp_hoadon_theongay rpt = new rp_hoadon_theongay();

            // Khởi tạo một đối tượng mới từ lớp ParameterValues để chứa các giá trị tham số
            ParameterValues param = new ParameterValues();

            // Khởi tạo một đối tượng mới từ lớp ParameterDiscreteValue để chứa một giá trị tham số rời rạc
            ParameterDiscreteValue pdv = new ParameterDiscreteValue();

            // Đặt giá trị của pdv bằng giá trị trong textBox1
            pdv.Value = dtpkNgay.Text;

            // Thêm pdv vào danh sách các giá trị tham số
            param.Add(pdv);

            // Áp dụng các giá trị tham số hiện tại cho tham số "@masv" trong định nghĩa dữ liệu của báo cáo
            //rpt.DataDefinition.ParameterFields["@ngay"].ApplyCurrentValues(param);

            // Đặt nguồn báo cáo cho crystalReportViewer1 là báo cáo rpt
            //crystalReportViewer2.ReportSource = rpt;
        }
    }
}
