using CrystalDecisions.Shared;
using LTUD1_BACHHOAXANH4._7._2;
using LTUD1_BACHHOAXANH472.ScreenMenu.Nhap.HoaDon;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace LTUD1_BACHHOAXANH472.Screen
{
    public partial class FormHoaDon : Form
    {
        public FormHoaDon()
        {
            InitializeComponent();
            HoaDonController = new HoaDonController(Utils.ConnectionString);
            dgvHD.DefaultCellStyle.ForeColor = Color.Black;
            CustomButtonHelper customButtonHelper = new CustomButtonHelper();
            customButtonHelper.SetProperties(btnTimKiem);
        }
        HoaDonController HoaDonController;
        private void FormHoaDon_Load(object sender, EventArgs e)
        {
            try
            {
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

        private void dgvHD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
                hoaDon.TongTien = float.Parse(txtTongTien.Text);
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
            int dong = dgvHD.CurrentCell.RowIndex;
            txtMaHD.Text = dgvHD.Rows[dong].Cells[0].Value.ToString();
            dtpkNgayLap.Text = dgvHD.Rows[dong].Cells[1].Value.ToString();
            txtTongTien.Text = dgvHD.Rows[dong].Cells[2].Value.ToString();
            cbbMaNV.Text = dgvHD.Rows[dong].Cells[3].Value.ToString();
            cbbMaKH.Text = dgvHD.Rows[dong].Cells[4].Value.ToString();
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
                hoaDon.TongTien = float.Parse(txtTongTien.Text);
                hoaDon.MaNV = cbbMaNV.SelectedValue.ToString();
                hoaDon.MaKH = cbbMaKH.SelectedValue.ToString();
                HoaDonController.Update(hoaDon);
                HoaDonController.SelectAll();
                dgvHD.DataSource = HoaDonController.DataSource;
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
    }
}
