using LTUD1_BACHHOAXANH472.ScreenMenu.Nhap.HoaDon;
using System;
using System.Data;
using System.Windows.Forms;

namespace LTUD1_BACHHOAXANH472
{
    public partial class FormChiTietHoaDon : Form
    {
        HoaDonController hdConn;
        SanPhamController spConn;
        ChiTietHoaDonController ctConn;

        public FormChiTietHoaDon()
        {
            InitializeComponent();
            hdConn = new HoaDonController(Utils.ConnectionString);
            spConn = new SanPhamController(Utils.ConnectionString);
            ctConn = new ChiTietHoaDonController(Utils.ConnectionString);
            DataGridViewHelper.ConfigureDataGridView(dgvCTHoaDon);
        }
        private void FormChiTietHoaDon_Load(object sender, EventArgs e)
        {


            try
            {
                hdConn.SelectAll();
                cboHoaDon.DataSource = hdConn.DataSource;
                cboHoaDon.DisplayMember = "MAHD";
                cboHoaDon.ValueMember = "MAHD";

                spConn.SelectAll();
                cboLoaiSanPham.DataSource = spConn.DataSource;
                cboLoaiSanPham.DisplayMember = "TENSP";
                cboLoaiSanPham.ValueMember = "MASP";

                ctConn.SelectByID(cboHoaDon.SelectedValue.ToString());
                dgvCTHoaDon.DataSource = ctConn.DataSource;

                /* txtThanhTien =  cthdController.TongTien(cboHoaDon.SelectedValue.ToString());*/
                txtThanhTien.Text = ctConn.TongTien(cboHoaDon.SelectedValue.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnKTTonKho_Click(object sender, EventArgs e)
        {
            try
            {
                ctConn.KTTonKho(cboLoaiSanPham.SelectedValue.ToString(), int.Parse(txtSoLuong.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ;

            try
            {

                ChiTietHoaDon cthd = new ChiTietHoaDon();
                cthd.MaHD = cboHoaDon.SelectedValue.ToString();
                cthd.MaSP = cboLoaiSanPham.SelectedValue.ToString();
                cthd.SoLuong = int.Parse(txtSoLuong.Text);

                ctConn.Insert(cthd);
                DataTable dt = ctConn.SelectByID(cboHoaDon.SelectedValue.ToString());
                dgvCTHoaDon.DataSource = dt;
                if (ctConn.KTMASP(cthd.MaSP) == false)
                {
                    MessageBox.Show("Thêm sản phẩm thành công!");
                }
                else
                {
                    MessageBox.Show("Thêm sản phẩm không thành công!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void txtCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                ChiTietHoaDon cthd = new ChiTietHoaDon();
                cthd.MaHD = cboHoaDon.SelectedValue.ToString();
                cthd.MaSP = cboLoaiSanPham.SelectedValue.ToString();
                cthd.SoLuong = int.Parse(txtSoLuong.Text);
                if (ctConn.KTTonKho(cboLoaiSanPham.SelectedValue.ToString(), int.Parse(txtSoLuong.Text)) >= 0)
                {
                    ctConn.Update(cthd);
                    FormChiTietHoaDon_Load(sender, e);

                    MessageBox.Show("Sửa sản phẩm thành công!");
                }
                else
                {
                    MessageBox.Show("Sửa sản phẩm không thành công!");
                }
                

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
                ChiTietHoaDon cthd = new ChiTietHoaDon();
                cthd.MaHD = cboHoaDon.SelectedValue.ToString();
                cthd.MaSP = cboLoaiSanPham.SelectedValue.ToString();
                ctConn.Delete(cthd);
                FormChiTietHoaDon_Load(sender, e);

                MessageBox.Show("Xoa sản phẩm thành công!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cboHoaDon_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = ctConn.SelectByID(cboHoaDon.SelectedValue.ToString());
                dgvCTHoaDon.DataSource = dt;

                txtThanhTien.Text = ctConn.TongTien(cboHoaDon.SelectedValue.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormChiTietHoaDon_Load_1(object sender, EventArgs e)
        {

        }
    }
}
