using System;
using System.Windows.Forms;
namespace LTUD1_BACHHOAXANH472.ScreenDetail
{
    public partial class FormHinhThucKhuyenMai : Form
    {
        HinhThucKhuyenMaiControler htkmConn;

        public FormHinhThucKhuyenMai()
        {
            InitializeComponent();
            htkmConn = new HinhThucKhuyenMaiControler(Utils.ConnectionString);
            DataGridViewHelper.ConfigureDataGridView(dgvHTKM);
            clean();
            txtMaHTKM.Enabled = false;
        }

        private void FormChiTietKhuyenMai_Load(object sender, EventArgs e)
        {
            htkmConn.SelectAll();
            dgvHTKM.DataSource = htkmConn.DataSource;
            clean();
        }

        private void dgvHTKM_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            if (txtTenHTKM.Text == string.Empty)
            {
                MessageBox.Show("Nhập tên khuyến mãi");
                return;
            }

            try
            {
                HinhThucKhuyenMai htkm = new HinhThucKhuyenMai();
                htkm.Makm = txtMaHTKM.Text;
                htkm.Hinhthuc = txtTenHTKM.Text;
                htkm.Ghichu = txtGhiChu.Text;
                htkmConn.Insert(htkm);
                FormChiTietKhuyenMai_Load(sender, e);
                MessageBox.Show("Thêm hình thúc khuyến mãi thành công");
                clean();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void clean()
        {
            RandomStringGenerator randomStringGenerator = new RandomStringGenerator();
            txtMaHTKM.Text = randomStringGenerator.GenerateRandomAlphanumericString(11);
            txtTenHTKM.Text = "";
            txtGhiChu.Text = "";
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThem.Enabled = true;
            btnLamMoi.Enabled = true;
        }
        private void btnSua_Click(object sender, EventArgs e)
        {

            HinhThucKhuyenMai htkm = new HinhThucKhuyenMai();
            htkm.Makm = txtMaHTKM.Text;
            htkm.Hinhthuc = txtTenHTKM.Text;
            htkm.Ghichu = txtGhiChu.Text;

            try
            {
                htkmConn.Update(htkm);
                FormChiTietKhuyenMai_Load(sender, e);
                dgvHTKM_DoubleClick(sender, e);
                MessageBox.Show("Sửa hình thúc khuyến mãi thành công");
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
                    htkmConn.Delete(txtMaHTKM.Text);
                    FormChiTietKhuyenMai_Load(sender, e);
                    dgvHTKM_DoubleClick(sender, e);
                    MessageBox.Show("Xóa hình thúc khuyến mãi thành công");
                    clean();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void dgvHTKM_Click(object sender, EventArgs e)
        {
            int dong = dgvHTKM.CurrentCell.RowIndex;
            txtMaHTKM.Text = dgvHTKM.Rows[dong].Cells[0].Value.ToString();
            txtTenHTKM.Text = dgvHTKM.Rows[dong].Cells[1].Value.ToString();
            txtGhiChu.Text = dgvHTKM.Rows[dong].Cells[2].Value.ToString();

            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnThem.Enabled = false;
            btnLamMoi.Enabled = false;
        }

        private void dgvHTKM_DoubleClick(object sender, EventArgs e)
        {
            clean();
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThem.Enabled = true;
            btnLamMoi.Enabled = true;
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            clean();
        }
    }
}
