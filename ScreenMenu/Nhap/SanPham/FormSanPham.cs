using System;
using System.Data;
using System.Windows.Forms;
namespace LTUD1_BACHHOAXANH472.ScreenMenu.Nhap
{
    public partial class FormSanPham : Form
    {
        SanPhamController spConn;
        KhuyenMaiController kmConn;
        DanhMucController loaiConn;
        NhaCungCapController nCCConn;
        ButtonStateManager buttonStateManager = new ButtonStateManager();
        public FormSanPham()
        {
            InitializeComponent();
            spConn = new SanPhamController(Utils.ConnectionString);
            kmConn = new KhuyenMaiController(Utils.ConnectionString);
            loaiConn = new DanhMucController(Utils.ConnectionString);
            nCCConn = new NhaCungCapController(Utils.ConnectionString);
            // data grid view setting
            DataGridViewHelper.ConfigureDataGridView(dgvDanhSachSP);
            buttonStateManager.BtnAdd = btnThem;
            buttonStateManager.BtnEdit = btnSua;
            buttonStateManager.BtnDelete = btnXoa;
            buttonStateManager.BtnRefresh = btnLamMoi;
            buttonStateManager.UpdateButtonStates(ButtonState.FormLoaded);
        }
        private void FormSanPham_Load(object sender, EventArgs e)
        {
            try
            {
                spConn.SelectAll();
                dgvDanhSachSP.DataSource = spConn.DataSource;
                kmConn.SelectAll();
                cboKM.DataSource = kmConn.DataSource;
                cboKM.DisplayMember = "TENHINHTHUC";
                cboKM.ValueMember = "MAKM";

                loaiConn.SelectAll();
                cboLoaiSP.DataSource = loaiConn.DataSource;
                cboLoaiSP.DisplayMember = "TENLOAI";
                cboLoaiSP.ValueMember = "MALOAI";
                nCCConn.SelectAll();
                cboNCC.DataSource = nCCConn.DataSource;
                cboNCC.DisplayMember = "TENNCC";
                cboNCC.ValueMember = "Mancc";
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
                SanPham sp = new SanPham();
                RandomStringGenerator randomStringGenerator = new RandomStringGenerator();
                txtMaSP.Text = randomStringGenerator.GenerateRandomAlphanumericString(11);
                sp.MaSP = txtMaSP.Text;
                sp.TenSP = txtTenSP.Text;
                sp.NgaySX = DateTime.Parse(dtpNSX.Text);
                sp.HanSD = DateTime.Parse(dtpHSD.Text);
                sp.Dongia = int.Parse(txtDonGia.Text); ;
                sp.SLTonKho = int.Parse(rtbSL.Text);
                sp.DonVi = rtbDonVi.Text;
                sp.MaLoai = cboLoaiSP.SelectedValue.ToString();
                sp.Mancc = cboNCC.SelectedValue.ToString();
                sp.KhuyenMai = cboKM.SelectedValue.ToString();
                spConn.Insert(sp);
                LamMoi();
                buttonStateManager.UpdateButtonStates(ButtonState.RefreshClicked);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void LamMoi()
        {
            txtMaSP.Text = "";
            txtTenSP.Text = "";
            dtpNSX.Text = "";
            dtpHSD.Text = "";
            txtDonGia.Text = "";
            rtbSL.Text = "";
            rtbDonVi.Text = "";
            spConn.SelectAll();
            dgvDanhSachSP.DataSource = spConn.DataSource;
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                spConn.Delete(txtMaSP.Text);
                LamMoi();
                buttonStateManager.UpdateButtonStates(ButtonState.RefreshClicked);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void dgvDanhSachSP_Click(object sender, EventArgs e)
        {
            try
            {
                // Khởi tạo số dòng đang chọn
                int dong = dgvDanhSachSP.CurrentCell.RowIndex;
                // lấy ra mã
                string id = dgvDanhSachSP.Rows[dong].Cells[0].Value.ToString();
                // khởi tạo đối tượng bằng mã
                DataTable dt = spConn.SelectByID(id);
                DataRow dr = dt.Rows[0];
                // chuyển thành class đối tượng
                SanPham o = (SanPham)spConn.FromDataRow(dr);
                // thiết lập dữ liệu ngược lại mỗi lần click
                txtMaSP.Text = o.MaSP;
                txtTenSP.Text = o.TenSP;
                dtpNSX.Value = o.NgaySX;
                dtpHSD.Value = o.HanSD;
                txtDonGia.Text = o.Dongia.ToString();
                rtbSL.Text = o.SLTonKho.ToString();
                rtbDonVi.Text = o.DonVi.ToString();
                cboKM.SelectedValue = object.Equals(o.KhuyenMai, null) ? "" : o.KhuyenMai;
                cboLoaiSP.SelectedValue = o.MaLoai;
                cboNCC.Text = o.Mancc;
                // cập nhật lại trang thái các nút
                buttonStateManager.UpdateButtonStates(ButtonState.DataGridViewSelected);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LamMoi();
            buttonStateManager.UpdateButtonStates(ButtonState.RefreshClicked);
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                SanPham sp = new SanPham();
                sp.MaSP = txtMaSP.Text;
                sp.TenSP = txtTenSP.Text;
                sp.NgaySX = DateTime.Parse(dtpNSX.Text);
                sp.HanSD = DateTime.Parse(dtpHSD.Text);
                sp.Dongia = int.Parse(txtDonGia.Text); ;
                sp.SLTonKho = int.Parse(rtbSL.Text);
                sp.DonVi = rtbDonVi.Text;
                sp.MaLoai = cboLoaiSP.SelectedValue.ToString();
                sp.Mancc = cboNCC.SelectedValue.ToString();
                sp.KhuyenMai = cboKM.SelectedValue.ToString();
                spConn.Update(sp);
                LamMoi();
                buttonStateManager.UpdateButtonStates(ButtonState.RefreshClicked);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

