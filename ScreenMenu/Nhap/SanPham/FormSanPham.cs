using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using LTUD1_BACHHOAXANH472.uploads;
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
            LamMoi();
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

                LamMoi();
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
                LamMoi();
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
                    SanPhamrpt rptSP = new SanPhamrpt();
                    // Khởi tạo một đối tượng mới từ lớp ParameterValues để chứa các giá trị tham số
                    ParameterValues param = new ParameterValues();

                    // Khởi tạo một đối tượng mới từ lớp ParameterDiscreteValue để chứa một giá trị tham số rời rạc
                    ParameterDiscreteValue pdv = new ParameterDiscreteValue();

                    // Đặt giá trị của pdv bằng giá trị trong textBox1
                    pdv.Value = txtTimKiem.Text;

                    // Thêm pdv vào danh sách các giá trị tham số
                    param.Add(pdv);

                    // Áp dụng các giá trị tham số hiện tại cho tham số "@masv" trong định nghĩa dữ liệu của báo cáo
                    rptSP.DataDefinition.ParameterFields["@TENSP"].ApplyCurrentValues(param);

                    // Đặt nguồn báo cáo cho crystalReportViewer1 là báo cáo rpt
                    rptSanPham.ReportSource = rptSP;
                }

                else if (cboTheLoaiTimKiem.Text == "Theo hạn sử dụng")
                {
                    // Khởi tạo một đối tượng mới từ lớp ParameterValues để chứa các giá trị tham số
                    ParameterValues param = new ParameterValues();

                    // Khởi tạo một đối tượng mới từ lớp ParameterDiscreteValue để chứa một giá trị tham số rời rạc
                    ParameterDiscreteValue pdv = new ParameterDiscreteValue
                    {
                        // Đặt giá trị của pdv bằng giá trị trong textBox
                        Value = dtpTKNgay.Value
                    };

                    // Thêm pdv vào danh sách các giá trị tham số
                    param.Add(pdv);

                    SanPhamTheoNgay rptSP = new SanPhamTheoNgay();
                    // Áp dụng các giá trị tham số hiện tại cho tham số "@masv" trong định nghĩa dữ liệu của báo cáo
                    rptSP.DataDefinition.ParameterFields["@NgayHT"].ApplyCurrentValues(param);

                    // Đặt nguồn báo cáo cho crystalReportViewer1 là báo cáo rpt
                    rptSanPham.ReportSource = rptSP;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void dgvDanhSachSP_Click_1(object sender, EventArgs e)
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

        private void cboLoaiTimKiem_TextChanged(object sender, EventArgs e)
        {


        }

        private void cboTheLoaiTimKiem_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cboTheLoaiTimKiem.Text == "Theo tên")
                {
                    ReportDocument reportDocument = new ReportDocument();
                    reportDocument.Load(@"D:\\TDC_HK3\\LTUD1_LETHO\\LTUD1_BACHHOAXANH472\\uploads\\SanPhamrpt.rpt");
                }
                else if (cboTheLoaiTimKiem.Text == "Theo hạn sử dụng")
                {
                    ReportDocument reportDocument = new ReportDocument();
                    reportDocument.Load(@"D:\TDC_HK3\LTUD1_LETHO\LTUD1_BACHHOAXANH472\uploads\SanPhamTheoNgay.rpt");
                }

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }

}

