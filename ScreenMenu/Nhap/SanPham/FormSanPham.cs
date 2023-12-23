using CrystalDecisions.CrystalReports.Engine;
using LTUD1_BACHHOAXANH472.Model;
using System;
using System.Data;
using System.Windows.Forms;
namespace LTUD1_BACHHOAXANH472
{
    public partial class FormSanPham : Form
    {
        SanPhamController spConn;
        KhuyenMaiController kmConn;
        DanhMucController loaiConn;
        NhaCungCapController nCCConn;
        ButtonStateManager buttonStateManager = new ButtonStateManager();
        ReportManager reportManager;// chia se report
        CustomButtonHelper buttonHelper = new CustomButtonHelper();
        ReportHelper rp_sanpham_tim_sp_hethan;
        string ngayhientai;
        public FormSanPham(ReportManager reportManager)
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
            Refreshs();
            this.reportManager = reportManager;// chia se report
            buttonHelper.SetProperties(btnThongKe);
            ComboBoxHelper.ConfigureComboBox(cboKM);
            ComboBoxHelper.ConfigureComboBox(cboLoaiSP);
            ComboBoxHelper.ConfigureComboBox(cboNCC);
            ComboBoxHelper.ConfigureComboBox(cboTheLoaiTimKiem);

            cboTheLoaiTimKiem.SelectedIndex = 0;//tim theo ten
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

                Refreshs();
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
                if (txtTenSP.Text == string.Empty)
                {
                    MessageBox.Show("Nhập tên sản phảm ");
                    return;
                }
                if (dtpNSX.Value > dtpHSD.Value)
                {
                    MessageBox.Show("Ngày sản xuất nhỏ hơn hạn sử dụng ");
                    return;
                }
                if (ErrTextbox.NoText_TextChange(txtDonGia) || txtDonGia.Text == string.Empty)
                {
                    MessageBox.Show("Giá nhập số!");
                    txtDonGia.Text = string.Empty;
                    return;
                }
                if (ErrTextbox.NoText_TextChange(rtbSL) || rtbSL.Text == string.Empty)
                {
                    MessageBox.Show("Số lượng tồn kho nhập số!");
                    rtbSL.Text = string.Empty;
                    return;
                }

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
                spConn.Insert(sp);
                Refreshs();
                buttonStateManager.UpdateButtonStates(ButtonState.RefreshClicked);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Refreshs()
        {
            txtMaSP.Text = string.Empty;
            txtTenSP.Text = string.Empty;
            dtpNSX.Text = string.Empty;
            dtpHSD.Text = string.Empty;
            txtDonGia.Text = string.Empty;
            rtbSL.Text = string.Empty;
            rtbDonVi.Text = string.Empty;
            spConn.SelectAll();
            RandomStringGenerator randomStringGenerator = new RandomStringGenerator();
            txtMaSP.Text = randomStringGenerator.GenerateRandomAlphanumericString(11);
            dgvDanhSachSP.DataSource = spConn.DataSource;
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                spConn.Delete(txtMaSP.Text);
                Refreshs();
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
            Refreshs();

            buttonStateManager.UpdateButtonStates(ButtonState.RefreshClicked);
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtpNSX.Value > dtpHSD.Value)
                {
                    MessageBox.Show("Ngày sản xuất nhỏ hơn hạn sử dụng ");
                    return;
                }
                if (ErrTextbox.NoText_TextChange(txtDonGia))
                {
                    MessageBox.Show("Giá nhập số!");
                    txtDonGia.Text = string.Empty;
                    return;
                }
                if (ErrTextbox.NoText_TextChange(rtbSL))
                {
                    MessageBox.Show("Số lượng tồn kho nhập số!");
                    rtbSL.Text = string.Empty;
                    return;
                }
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
                Refreshs();
                buttonStateManager.UpdateButtonStates(ButtonState.RefreshClicked);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboTheLoaiTimKiem.Text == "Theo tên")
                {
                    ReportHelper rh = new ReportHelper(reportManager, "rp_sanpham_timtensp", new System.Collections.Generic.Dictionary<string, object> { { "@TENSP", txtTimKiem.Text }, { "@tennhanvien", "Sok Kim Thanh" } }, rptThongKe);
                    rh.LoadReport();
                }

                else if (cboTheLoaiTimKiem.Text == "Theo hạn sử dụng")
                {
                    rp_sanpham_tim_sp_hethan = new ReportHelper(reportManager, "rp_sanpham_timtheongay", new System.Collections.Generic.Dictionary<string, object> { { "@NgayHT", ngayhientai }, { "@tennhanvien", "Sok Kim Thanh" } }, rptThongKe);
                    rp_sanpham_tim_sp_hethan.LoadReport();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void cboTheLoaiTimKiem_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cboTheLoaiTimKiem.Text == "Theo tên")
                {
                    dtpTKNgay.Enabled = false;
                    txtTimKiem.Enabled = true;
                    ReportHelper rh = new ReportHelper(reportManager, "rp_sanpham_timtensp", new System.Collections.Generic.Dictionary<string, object> { { "@TENSP", txtTimKiem.Text }, { "@tennhanvien", "Sok Kim Thanh" } }, rptThongKe);
                    rh.LoadReport();
                }

                else if (cboTheLoaiTimKiem.Text == "Theo hạn sử dụng")
                {
                    dtpTKNgay.Enabled = true;
                    txtTimKiem.Enabled = false;
                    rp_sanpham_tim_sp_hethan = new ReportHelper(reportManager, "rp_sanpham_timtheongay", new System.Collections.Generic.Dictionary<string, object> { { "@NgayHT", ngayhientai }, { "@tennhanvien", "Sok Kim Thanh" } }, rptThongKe);
                    rp_sanpham_tim_sp_hethan.LoadReport();
                }

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void rptSanPham_Load(object sender, EventArgs e)
        {
            try
            {
                if (cboTheLoaiTimKiem.Text == "Theo tên")
                {
                    ReportHelper rh = new ReportHelper(reportManager, "rp_sanpham_timtensp", new System.Collections.Generic.Dictionary<string, object> { { "@TENSP", txtTimKiem.Text }, { "@tennhanvien", "Sok Kim Thanh" } }, rptThongKe);
                    rh.LoadReport();
                }

                else if (cboTheLoaiTimKiem.Text == "Theo hạn sử dụng")
                {
                    rp_sanpham_tim_sp_hethan = new ReportHelper(reportManager, "rp_sanpham_timtheongay", new System.Collections.Generic.Dictionary<string, object> { { "@NgayHT", ngayhientai }, { "@tennhanvien", "Sok Kim Thanh" } }, rptThongKe);
                    rp_sanpham_tim_sp_hethan.LoadReport();
                }

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void dtpTKNgay_ValueChanged(object sender, EventArgs e)
        {
            ngayhientai = dtpTKNgay.Value.ToString("dd/MM/yyyy");
        }
    }

}

