using LTUD1_BACHHOAXANH472.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
namespace LTUD1_BACHHOAXANH472
{
    public partial class FormHoaDon : Form
    {
        HoaDonController HoaDonController;
        // khởi tạo trạng thái cho nút 
        ButtonStateManager buttonStateManager;
        ReportManager reportManager;// chia se report
        public FormHoaDon(ReportManager reportManager)
        {
            InitializeComponent();
            HoaDonController = new HoaDonController(Utils.ConnectionString);
            dgvHD.DefaultCellStyle.ForeColor = Color.Black;
            CustomButtonHelper customButtonHelper = new CustomButtonHelper();
            customButtonHelper.SetProperties(btnThongKe);
            buttonStateManager = new ButtonStateManager();
            // khai báo trạng thái khóa nút 
            buttonStateManager.BtnAdd = this.btnThem;
            buttonStateManager.BtnEdit = this.btnXoa;
            buttonStateManager.BtnDelete = this.btnSua;
            buttonStateManager.BtnRefresh = this.btnLamMoi;
            this.reportManager = reportManager;// chia se report
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
                if (ErrTextbox.CheckControlValue(txtMaHD))
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
            if (ErrTextbox.CheckControlValue(txtMaHD))
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
            ReportHelper rh = new ReportHelper(reportManager, "rp_hoadon_timkiem", new Dictionary<string, object> { { "@ma", string.IsNullOrEmpty(txtTimKiem.Text) ? null : txtTimKiem.Text } }, this.cryTimTheoten);
            rh.LoadReport();
        }

        private void txtMaHD_TextChanged(object sender, EventArgs e)
        {

            if (ErrTextbox.isText(sender))
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
            ReportHelper rh = new ReportHelper(reportManager, "rp_hoadon_theongay", new Dictionary<string, object> { { "@ngay", string.IsNullOrEmpty(dtpkNgay.Text) ? null : dtpkNgay.Text } }, this.cryRPTheoNgay);
            rh.LoadReport();
        }

        private void cryRPTheoNgay_Load(object sender, EventArgs e)
        {
            ReportHelper rh = new ReportHelper(reportManager, "rp_hoadon_theongay", new Dictionary<string, object> { { "@ngay", "1/1/2022" } }, this.cryRPTheoNgay);
            rh.LoadReport();
        }

        private void CryPThongKe_Load(object sender, EventArgs e)
        {
            ReportHelper rh = new ReportHelper(reportManager, "rp_hoadon_timkiem", new Dictionary<string, object> { { "@ma", string.IsNullOrEmpty(txtTimKiem.Text) ? "a" : txtTimKiem.Text } }, this.cryTimTheoten);
            rh.LoadReport();
        }
    }
}
