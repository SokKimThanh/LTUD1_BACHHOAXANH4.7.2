using LTUD1_BACHHOAXANH472.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
namespace LTUD1_BACHHOAXANH472
{
    public partial class FormTaiKhoan : Form
    {
        AccountController acountController;
        //ButtonStateManager buttonStateManager;
        QuyenTruyCapController quyenTruyCapController;
        //AccountController sanPhamController;
        ButtonStateManager buttonStateManager;
        ReportManager reportManager;
        public FormTaiKhoan(ReportManager reportManager)
        {
            InitializeComponent();
            acountController = new AccountController(Utils.ConnectionString);
            quyenTruyCapController = new QuyenTruyCapController(Utils.ConnectionString);
            // data grid view setting
            DataGridViewHelper.ConfigureDataGridView(dgvTaiKhoan);

            DataGridViewHelper.ConfigureDataGridView(dgvQTC);
            DataGridViewHelper.ConfigureDataGridView(dgvQuanLyDangNhap);

            ComboBoxHelper.ConfigureComboBox(cboNV);
            ComboBoxHelper.ConfigureComboBox(cboQTC);
            ComboBoxHelper.ConfigureComboBox(cbotaikhoan);
             
            this.reportManager = reportManager;
        }

        private void FormTaiKhoan_Load(object sender, EventArgs e)
        {
            try
            {
                // load dữ liệu tài khoản
                acountController.SelectAll();
                dgvTaiKhoan.DataSource = acountController.DataSource;

                // load dữ liệu combobox quyền truy cập
                acountController.select_cbo_quyentruycap();
                cboQTC.DataSource = acountController.DataSource;
                cboQTC.DisplayMember = "TENQTC";
                cboQTC.ValueMember = "MAQTC";

                // load dữ liệu quyền truy cập
                quyenTruyCapController.SelectAll();
                dgvQTC.DataSource = quyenTruyCapController.DataSource;

               
                // load dữ liệu combobox nhân viên
                acountController.select_cbo_nhanvien();
                cboNV.DataSource = acountController.DataSource;
                cboNV.DisplayMember = "HOTENNV";
                cboNV.ValueMember = "MANV";

                // load dữ liệu combobox tài khoản
                cbotaikhoan.DataSource = acountController.select_cbo_taikhoan();
                cbotaikhoan.DisplayMember = "TENTK";
                cbotaikhoan.ValueMember = "MATK";

                // load dữ liệu chức năng quản lí quyền truy cập
                dgvQuanLyDangNhap.DataSource = acountController.GetDanhSachDangNhapTuNgayDenNgay(dtpTuNgay.Value, dtpDenNgay.Value, cbotaikhoan.SelectedValue.ToString()); ;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void Reset()
        {
            try
            {
                // load dữ liệu tài khoản
                acountController.SelectAll();
                dgvTaiKhoan.DataSource = acountController.DataSource;
                // load dữ liệu combobox quyền truy cập
                acountController.select_cbo_quyentruycap();
                cboQTC.DataSource = acountController.DataSource;
                cboQTC.DisplayMember = "TENQTC";
                cboQTC.ValueMember = "MAQTC";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void tabControl2_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Lấy tabControlXemDuLieu từ form hoặc từ nơi nó được khởi tạo
            TabControl tabControlXemDuLieu = this.tabControlXemDuLieu;
            TabControl tabControlThaoTacDuLieu = this.tabControlThaoTacDuLieu;

            // Đảm bảo rằng tabControlXemDuLieu có đủ số lượng tab
            if (tabControlXemDuLieu.TabCount >= tabControlNhapThongTin.TabCount)
            {
                // Đặt tab được chọn trên tabControlXemDuLieu để khớp với tab được chọn trên tabControl2
                tabControlXemDuLieu.SelectedIndex = tabControlNhapThongTin.SelectedIndex;
                tabControlThaoTacDuLieu.SelectedIndex = tabControlNhapThongTin.SelectedIndex;
            }
            else
            {
                // Xử lý trường hợp khi tabControlXemDuLieu không có đủ số lượng tab
                Console.WriteLine("TabControl1 không có đủ số lượng tab để khớp với TabControl2.");
            }
        }

        private void btnAddQuyenTruyCap_Click(object sender, EventArgs e)
        {
            try
            {
                QuyenTruyCap quyenTruyCap = new QuyenTruyCap();
                quyenTruyCap.Maqtc = txtMaQTC.Text;
                quyenTruyCap.Tenqtc = txtTenQTC.Text;
                quyenTruyCapController.Insert(quyenTruyCap);
                quyenTruyCapController.SelectAll();
                dgvQTC.DataSource = quyenTruyCapController.DataSource;
                Reset();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDeleteQuyenTruycap_Click(object sender, EventArgs e)
        {
            try
            {
                string ma = txtMaQTC.Text;
                quyenTruyCapController.Delete(ma);
                quyenTruyCapController.SelectAll();
                dgvQTC.DataSource = quyenTruyCapController.DataSource;
                Reset();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvQTC_Click(object sender, EventArgs e)
        {
            try
            {
                // Khởi tạo số dòng đang chọn
                int dong = dgvQTC.CurrentCell.RowIndex;
                // lấy ra mã
                string id = dgvQTC.Rows[dong].Cells[0].Value.ToString();
                // khởi tạo đối tượng bằng mã
                DataTable dt = quyenTruyCapController.SelectByID(id);
                DataRow dr = dt.Rows[0];

                // chuyển thành class đối tượng
                QuyenTruyCap o = (QuyenTruyCap)quyenTruyCapController.FromDataRow(dr);

                // thiết lập dữ liệu ngược lại mỗi lần click
                txtMaQTC.Text = o.Maqtc;
                txtTenQTC.Text = o.Tenqtc;
                // cập nhật lại trang thái các nút
                buttonStateManager.UpdateButtonStates(ButtonState.DataGridViewSelected);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvTaiKhoan_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Khởi tạo số dòng đang chọn
                int dong = dgvTaiKhoan.CurrentCell.RowIndex;
                // lấy ra mã
                string id = dgvTaiKhoan.Rows[dong].Cells[0].Value.ToString();
                // khởi tạo đối tượng bằng mã
                DataTable dt = acountController.SelectByID(id);
                DataRow dr = dt.Rows[0];

                // chuyển thành class đối tượng
                Account o = (Account)acountController.FromDataRow(dr);

                // thiết lập dữ liệu ngược lại mỗi lần click
                txtTenTK.Text = o.Tentk;
                txtMK.Text = o.Matkhau;
                cboNV.Text = o.Manv;
                txtTenQTC.Text = o.Maqtc;
                // cập nhật lại trang thái các nút
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAddThemTaiKhoan_Click(object sender, EventArgs e)
        {
            try
            {
                Account account = new Account();
                account.Tentk = txtTenTK.Text;
                account.Matkhau = txtMK.Text;
                account.Manv = cboNV.SelectedValue.ToString();
                account.Maqtc = cboQTC.SelectedValue.ToString();
                acountController.Insert(account);
                acountController.SelectAll();
                dgvTaiKhoan.DataSource = acountController.DataSource;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEditQuyenTruyCap_Click(object sender, EventArgs e)
        {
            try
            {
                QuyenTruyCap quyenTruyCap = new QuyenTruyCap();
                quyenTruyCap.Maqtc = txtMaQTC.Text;
                quyenTruyCap.Tenqtc = txtTenQTC.Text;
                quyenTruyCapController.Update(quyenTruyCap);
                quyenTruyCapController.SelectAll();
                dgvQTC.DataSource = quyenTruyCapController.DataSource;
                Reset();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDeleteTaiKhoan_Click(object sender, EventArgs e)
        {
            try
            {
                Account account = new Account();
                account.Tentk = txtTenTK.Text;
                acountController.Delete(account.Tentk);
                acountController.SelectAll();
                dgvTaiKhoan.DataSource = acountController.DataSource;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEditTaiKhoan_Click(object sender, EventArgs e)
        {
            try
            {
                Account account = new Account();
                account.Tentk = txtTenTK.Text;
                account.Matkhau = txtMK.Text;
                account.Manv = cboNV.SelectedValue.ToString();
                account.Maqtc = cboQTC.SelectedValue.ToString();
                acountController.Update(account);
                acountController.SelectAll();
                dgvTaiKhoan.DataSource = acountController.DataSource;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRefreshTaiKhoan_Click(object sender, EventArgs e)
        {
            try
            {
                txtTenTK.Text = string.Empty;
                txtMK.Text = string.Empty;
                cboNV.SelectedIndex = 0;
                cboQTC.SelectedIndex = 0;
                /*  buttonStateManager.UpdateButtonStates(ButtonState.RefreshClicked);*/
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnRefreshQuyenTruyCap_Click(object sender, EventArgs e)
        {
            try
            {
                txtMK.Text = string.Empty;
                txtMaQTC.Text = string.Empty;
                /*                buttonStateManager.UpdateButtonStates(ButtonState.RefreshClicked);*/
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            ReportHelper rh = new ReportHelper(reportManager, "rp_dangnhap_tungaydenngay", new Dictionary<string, object> { { "@tungay", dtpTuNgay.Value }, { "@denngay", dtpDenNgay.Value }, { "@tentk", cbotaikhoan.SelectedValue.ToString() } }, crystalReportViewer1);
            rh.LoadReport();
        }

        private void btnReportSearch_Click(object sender, EventArgs e)
        {
            if (dtpTuNgay.Value.ToString().CompareTo(dtpDenNgay.Value.ToString()) > 0)
            {
                MessageBox.Show("Ngày bắt đầu không thể lớn hơn ngày kết thúc!");
                return;
            }
            else
            {
                dgvQuanLyDangNhap.DataSource = acountController.GetDanhSachDangNhapTuNgayDenNgay(dtpTuNgay.Value, dtpDenNgay.Value, cbotaikhoan.SelectedValue.ToString());
            }
        }
    }
}