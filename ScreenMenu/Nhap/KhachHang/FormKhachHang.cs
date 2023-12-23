using LTUD1_BACHHOAXANH472.controller;
using LTUD1_BACHHOAXANH472.Model;
using System;
using System.Data;
using System.Windows.Forms;
namespace LTUD1_BACHHOAXANH472.ScreenMenu.Nhap
{
    public partial class FormKhachHang : Form
    {
        KhachHangController khachHangController;
        // khởi tạo trạng thái cho nút 
        ButtonStateManager buttonStateManager;
        ReportManager reportManager;// chia se report

        public FormKhachHang(ReportManager reportManager)
        {

            InitializeComponent();

            khachHangController = new KhachHangController(Utils.ConnectionString);
            DataGridViewHelper.ConfigureDataGridView(dgvKhachHang);
            CustomButtonHelper customButtonHelper = new CustomButtonHelper();
            customButtonHelper.SetProperties(btnTimKiem);
            buttonStateManager = new ButtonStateManager();
            // khai báo trạng thái khóa nút 
            buttonStateManager.BtnAdd = this.btnThem;
            buttonStateManager.BtnEdit = this.btnXoa;
            buttonStateManager.BtnDelete = this.btnSua;
            buttonStateManager.BtnRefresh = this.btnLamMoi;
            this.reportManager = reportManager;// chia se report
        }

        private void FormKhachHang_Load(object sender, EventArgs e)
        {
            khachHangController.SelectAll();
            dgvKhachHang.DataSource = khachHangController.DataSource;
            //mã tự động
            RandomStringGenerator randomStringGenerator = new RandomStringGenerator();
            txtMa.Text = randomStringGenerator.GenerateRandomAlphanumericString(10);
        }



        private void btnThem_Click(object sender, EventArgs e)
        {

            try
            {
                if (ErrTextbox.CheckControlValue(txtMa))
                {
                    MessageBox.Show("txtMaKH", "Bắt buộc nhập!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (ErrTextbox.CheckControlValue(txtxHoTen))
                {
                    MessageBox.Show("txtHoTen", "Bắt buộc nhập!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (ErrTextbox.CheckControlValue(txtSDT))
                {
                    MessageBox.Show("txtSDT", "Bắt buộc nhập!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (ErrTextbox.CheckControlValue(txtDTL))
                {
                    MessageBox.Show("txtDRL", "Bắt buộc nhập!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                KhachHang kh = new KhachHang();
                kh.Ma = txtMa.Text;
                kh.Ten = txtxHoTen.Text;
                kh.Sdt = int.Parse(txtSDT.Text);
                kh.Diem = int.Parse(txtDTL.Text);
                khachHangController.Insert(kh);
                khachHangController.SelectAll();
                dgvKhachHang.DataSource = khachHangController.DataSource;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void dgvKhachHang_Click(object sender, EventArgs e)
        {
            try
            {
                // Khởi tạo số dòng đang chọn
                int dong = dgvKhachHang.CurrentCell.RowIndex;
                // lấy ra mã
                string id = dgvKhachHang.Rows[dong].Cells[0].Value.ToString();
                // khởi tạo đối tượng bằng mã
                DataTable dt = khachHangController.SelectByID(id);
                DataRow dr = dt.Rows[0];

                // chuyển thành class đối tượng
                KhachHang o = (KhachHang)khachHangController.FromDataRow(dr);

                // thiết lập dữ liệu ngược lại mỗi lần click
                txtMa.Text = o.Ma;
                txtxHoTen.Text = o.Ten;
                txtSDT.Text = o.Sdt.ToString();
                txtDTL.Text = o.Diem.ToString();
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
            try
            {
                if (ErrTextbox.CheckControlValue(txtMa))
                {
                    MessageBox.Show("txtMaKH", "Bắt buộc nhập!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                DialogResult r = MessageBox.Show("Bạn có muốn xoa khong?", "xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    KhachHang kh = new KhachHang();
                    kh.Ma = txtMa.Text;
                    khachHangController.Delete(kh.Ma);
                    khachHangController.SelectAll();
                    dgvKhachHang.DataSource = khachHangController.DataSource;
                    Refresh();
                }
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }

        }

        private void txtMa_TextChanged(object sender, EventArgs e)
        {
            if (ErrTextbox.isText(sender))
            {
                MessageBox.Show("txtHoMaKH", "chỉ được nhập chữ hoặc số!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void txtxHoTen_TextChanged(object sender, EventArgs e)
        {
            if (ErrTextbox.isText(sender))
            {
                MessageBox.Show("txtHoTenKH", "chỉ được nhập chữ hoặc số!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void txtSDT_TextChanged(object sender, EventArgs e)
        {

            if (ErrTextbox.isText(sender) || ErrTextbox.NoText_TextChange(sender))
            {
                MessageBox.Show("txtSDT", "chỉ được nhập số!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void txtDTL_TextChanged(object sender, EventArgs e)
        {
            if (ErrTextbox.isText(sender) || ErrTextbox.NoText_TextChange(sender))
            {
                MessageBox.Show("txtDRL", "chỉ được nhập số!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có muốn sua khong?", "xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                KhachHang kh = new KhachHang();
                kh.Ma = txtMa.Text;
                kh.Ten = txtxHoTen.Text;
                kh.Sdt = int.Parse(txtSDT.Text);
                kh.Diem = int.Parse(txtDTL.Text);
                khachHangController.Update(kh);
                khachHangController.SelectAll();
                dgvKhachHang.DataSource = khachHangController.DataSource;
                Refresh();
            }
            return;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            // Khởi tạo một đối tượng mới từ lớp CrystalReport1
            //khachhangreport rpt = new khachhangreport();

            //// Khởi tạo một đối tượng mới từ lớp ParameterValues để chứa các giá trị tham số
            //ParameterValues param = new ParameterValues();

            //// Khởi tạo một đối tượng mới từ lớp ParameterDiscreteValue để chứa một giá trị tham số rời rạc
            //ParameterDiscreteValue pdv = new ParameterDiscreteValue();

            //// Đặt giá trị của pdv bằng giá trị trong textBox1
            //pdv.Value = txtTimKiem.Text;

            //// Thêm pdv vào danh sách các giá trị tham số
            //param.Add(pdv);

            //// Áp dụng các giá trị tham số hiện tại cho tham số "@masv" trong định nghĩa dữ liệu của báo cáo
            //rpt.DataDefinition.ParameterFields["@ma"].ApplyCurrentValues(param);

            //// Đặt nguồn báo cáo cho crystalReportViewer1 là báo cáo rpt
            //crystalReportViewer1.ReportSource = rpt;
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            refresh();
        }
        public void refresh()
        {
            // Chuyển đến tabReport 
            // chọn tab danh sách để tìm kiếm thì
            RandomStringGenerator randomStringGenerator = new RandomStringGenerator();
            txtMa.Text = randomStringGenerator.GenerateRandomAlphanumericString(10);
            txtxHoTen.Text = string.Empty;
            txtSDT.Text = string.Empty;
            txtDTL.Text = string.Empty;
            khachHangController.SelectAll();
            dgvKhachHang.DataSource = khachHangController.DataSource;
            buttonStateManager.UpdateButtonStates(ButtonState.RefreshClicked);
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void crystalReportViewer1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
