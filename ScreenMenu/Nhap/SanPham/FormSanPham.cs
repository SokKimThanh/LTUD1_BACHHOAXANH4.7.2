using System;
using System.Windows.Forms;

namespace LTUD1_BACHHOAXANH472.ScreenMenu.Nhap
{
    public partial class FormSanPham : Form
    {
        SanPhamController spConn;
        KhuyenMaiController kmConn;
        DanhMucController loaiConn;
        NhaCungCapController nCCConn;
        public FormSanPham()
        {
            InitializeComponent();
            spConn = new SanPhamController(Utils.ConnectionString);
            kmConn = new KhuyenMaiController(Utils.ConnectionString);
            loaiConn = new DanhMucController(Utils.ConnectionString);
            nCCConn = new NhaCungCapController(Utils.ConnectionString);
            // data grid view setting
            DataGridViewHelper.ConfigureDataGridView(dgvDanhSachSP);
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
                cboNCC.ValueMember = "MANCC";
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
                sp.Ma = txtMaSP.Text;
                sp.Ten = txtTenSP.Text;
                sp.NgaySX = DateTime.Parse(dtpNSX.Text);
                sp.HanSD = DateTime.Parse(dtpHSD.Text);
                sp.Gia = float.Parse(txtDonGia.Text); ;
                sp.Soluong = int.Parse(rtbSL.Text);
                sp.DonVi = rtbDonVi.Text;
                sp.LoaiSP = cboLoaiSP.SelectedValue.ToString();
                sp.NCC = cboNCC.SelectedValue.ToString();
                sp.KhuyenMai = cboKM.SelectedValue.ToString();
                spConn.Insert(sp);
                FormSanPham_Load(sender, e);
                MessageBox.Show("Thêm sản phẩm thành công!");
                clean();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void clean()
        {
            txtMaSP.Text = "";
            txtTenSP.Text = "";
            dtpNSX.Text = "";
            dtpHSD.Text = "";
            txtDonGia.Text = ""; ;
            rtbSL.Text = "";
            rtbDonVi.Text = "";

        }

        private void dgvDanhSachSP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int dong = dgvDanhSachSP.CurrentCell.RowIndex;
            txtMaSP.Text = dgvDanhSachSP.Rows[dong].Cells[0].Value.ToString();
            txtTenSP.Text = dgvDanhSachSP.Rows[dong].Cells[1].Value.ToString();
            dtpNSX.Text = dgvDanhSachSP.Rows[dong].Cells[3].Value.ToString();
            dtpHSD.Text = dgvDanhSachSP.Rows[dong].Cells[4].Value.ToString();
            txtDonGia.Text = dgvDanhSachSP.Rows[dong].Cells[5].Value.ToString();
            rtbSL.Text = dgvDanhSachSP.Rows[dong].Cells[6].Value.ToString();
            rtbDonVi.Text = dgvDanhSachSP.Rows[dong].Cells[2].Value.ToString();
            cboKM.Text = dgvDanhSachSP.Rows[dong].Cells[9].Value.ToString();
            cboLoaiSP.Text = dgvDanhSachSP.Rows[dong].Cells[8].Value.ToString();
            cboNCC.Text = dgvDanhSachSP.Rows[dong].Cells[7].Value.ToString();


        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                spConn.Delete(txtMaSP.Text);
                FormSanPham_Load(sender, e);
                MessageBox.Show("Xóa sản phẩm thành công!");
                clean();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            SanPham sp = new SanPham();
            sp.Ma = txtMaSP.Text;
            sp.Ten = txtTenSP.Text;
            sp.NgaySX = DateTime.Parse(dtpNSX.Text);
            sp.HanSD = DateTime.Parse(dtpHSD.Text);
            sp.Gia = float.Parse(txtDonGia.Text); ;
            sp.Soluong = int.Parse(rtbSL.Text);
            sp.DonVi = rtbDonVi.Text;
            sp.LoaiSP = cboLoaiSP.SelectedValue.ToString();
            sp.NCC = cboNCC.SelectedValue.ToString();
            sp.KhuyenMai = cboKM.SelectedValue.ToString();

            try
            {
                spConn.Update(sp);
                FormSanPham_Load(sender, e);
                MessageBox.Show("Sửa sản phẩm thành công!");
                clean();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
