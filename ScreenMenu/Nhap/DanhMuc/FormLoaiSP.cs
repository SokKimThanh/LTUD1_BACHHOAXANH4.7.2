using System;
using System.Windows.Forms;

namespace LTUD1_BACHHOAXANH472.ScreenMenu.Nhap.DanhMuc
{
    public partial class FormLoaiSP : Form
    {
        DanhMucController dmConn;
        public FormLoaiSP()
        {
            InitializeComponent();
            dmConn = new DanhMucController(Utils.ConnectionString);
            // setting datagridview
            DataGridViewHelper.ConfigureDataGridView(dgvDS);
        }
        private void FormLoaisp_Load(object sender, EventArgs e)
        {
            try
            {
                dmConn.SelectAll();
                dgvDS.DataSource = dmConn.DataSource;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void dgvDS_Click(object sender, EventArgs e)
        {
            int dong = dgvDS.CurrentCell.RowIndex;
            txtMaLoai.Text = dgvDS.Rows[dong].Cells[0].Value.ToString();
            txtTenMaLoai.Text = dgvDS.Rows[dong].Cells[1].Value.ToString();
            txtGhiChu.Text = dgvDS.Rows[dong].Cells[2].Value.ToString();

            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnThem.Enabled = false;
            txtMaLoai.Enabled = false;
        }
        private void clean()
        {
            txtMaLoai.Text = "";
            txtTenMaLoai.Text = "";
            txtGhiChu.Text = "";
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn sửa không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DanhMuc danhMuc = new DanhMuc();
                danhMuc.Ma = txtMaLoai.Text;
                danhMuc.Ten = txtTenMaLoai.Text;
                danhMuc.Ghichu = txtGhiChu.Text;
                try
                {
                    dmConn.Update(danhMuc);
                    FormLoaisp_Load(sender, e);
                    clean();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            DanhMuc danhMuc = new DanhMuc();
            danhMuc.Ma = txtMaLoai.Text;
            danhMuc.Ten = txtTenMaLoai.Text;
            danhMuc.Ghichu = txtGhiChu.Text;
            try
            {
                dmConn.Insert(danhMuc);
                FormLoaisp_Load(sender, e);
                clean();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    dmConn.Delete(txtMaLoai.Text);
                    FormLoaisp_Load(sender, e);
                    clean();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }
        private void dgvHTKM_DoubleClick(object sender, EventArgs e)
        {
            clean();
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThem.Enabled = true;
            txtMaLoai.Enabled = true;
        }
    }
}
