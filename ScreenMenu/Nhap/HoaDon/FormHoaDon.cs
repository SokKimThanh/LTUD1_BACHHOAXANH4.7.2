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
            HoaDon hoaDon = new HoaDon();
            hoaDon.MaHD = txtMaHD.Text;
            HoaDonController.Delete(hoaDon.MaHD);
            HoaDonController.SelectAll();
            dgvHD.DataSource = HoaDonController.DataSource;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            HoaDon hoaDon = new HoaDon();
            hoaDon.MaHD = txtMaHD.Text;
            hoaDon.NgayHD = DateTime.Parse(dtpkNgayLap.Text);
            hoaDon.TongTien = float.Parse(txtTongTien.Text);
            hoaDon.MaNV = cbbMaNV.Text;
            hoaDon.MaKH = cbbMaKH.Text;
            HoaDonController.Update(hoaDon);
            HoaDonController.SelectAll();
            dgvHD.DataSource = HoaDonController.DataSource;
        }
    }
}
