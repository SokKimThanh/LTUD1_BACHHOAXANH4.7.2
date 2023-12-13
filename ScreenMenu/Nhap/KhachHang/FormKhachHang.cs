using CrystalDecisions.Shared;
using LTUD1_BACHHOAXANH472.controller;
using LTUD1_BACHHOAXANH472.Model;
using LTUD1_BACHHOAXANH472.uploads;
using System;
using System.Windows.Forms;

namespace LTUD1_BACHHOAXANH472.ScreenMenu.Nhap
{
    public partial class FormKhachHang : Form
    {
        KhachHangController khachHangController;
        public FormKhachHang()
        {

            InitializeComponent();

            khachHangController = new KhachHangController(Utils.ConnectionString);
            DataGridViewHelper.ConfigureDataGridView(dgvKH);
            CustomButtonHelper customButtonHelper = new CustomButtonHelper();
            customButtonHelper.SetProperties(btnTimKiem);
        }
  
        private void FormKhachHang_Load(object sender, EventArgs e)
        {
            khachHangController.SelectAll();
            dgvKH.DataSource = khachHangController.DataSource;
        }

     

        private void btnThem_Click(object sender, EventArgs e)
        {

            try
            {
                if (ErrTxt.CheckControlValue(txtMa))
                {
                    MessageBox.Show("txtMaKH", "Bắt buộc nhập!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (ErrTxt.CheckControlValue(txtxHoTen))
                {
                    MessageBox.Show("txtHoTen", "Bắt buộc nhập!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (ErrTxt.CheckControlValue(txtSDT))
                {
                    MessageBox.Show("txtSDT", "Bắt buộc nhập!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (ErrTxt.CheckControlValue(txtDTL))
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
                dgvKH.DataSource = khachHangController.DataSource;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void dgvKH_Click(object sender, EventArgs e)
        {
            int dong = dgvKH.CurrentCell.RowIndex;
            txtMa.Text = dgvKH.Rows[dong].Cells[0].Value.ToString();
            txtxHoTen.Text = dgvKH.Rows[dong].Cells[1].Value.ToString();
            txtSDT.Text = dgvKH.Rows[dong].Cells[2].Value.ToString();
            txtDTL.Text = dgvKH.Rows[dong].Cells[3].Value.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (ErrTxt.CheckControlValue(txtMa))
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
                    dgvKH.DataSource = khachHangController.DataSource;
                }
                return;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        
        }

        private void txtMa_TextChanged(object sender, EventArgs e)
        {
            if (ErrTxt.NoSymbol_TextChanged(sender))
            {
                MessageBox.Show("txtHoMaKH", "chỉ được nhập chữ hoặc số!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void txtxHoTen_TextChanged(object sender, EventArgs e)
        {
            if (ErrTxt.NoSymbol_TextChanged(sender))
            {
                MessageBox.Show("txtHoTenKH", "chỉ được nhập chữ hoặc số!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void txtSDT_TextChanged(object sender, EventArgs e)
        {

            if (ErrTxt.NoSymbol_TextChanged(sender) || ErrTxt.NoText_TextChange(sender))
            {
                MessageBox.Show("txtSDT", "chỉ được nhập số!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void txtDTL_TextChanged(object sender, EventArgs e)
        {
            if (ErrTxt.NoSymbol_TextChanged(sender) || ErrTxt.NoText_TextChange(sender))
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
                dgvKH.DataSource = khachHangController.DataSource;
            }
            return;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            // Khởi tạo một đối tượng mới từ lớp CrystalReport1
            khachhangreport rpt = new khachhangreport();

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
    }
}
