using System;
using System.Data;
using System.Windows.Forms;
namespace LTUD1_BACHHOAXANH472.ScreenMenu.Nhap.PhongBan
{
    public partial class FormPhongBan : Form
    {
        PhongBanController pbController;
        ButtonStateManager buttonStateManager = new ButtonStateManager();
        public FormPhongBan()
        {
            InitializeComponent();
            pbController = new PhongBanController(Utils.ConnectionString);
            DataGridViewHelper.ConfigureDataGridView(dgvPB);
            buttonStateManager.BtnEdit = btnEdit;
            buttonStateManager.BtnDelete = btnDelete;
            buttonStateManager.BtnRefresh = btnRefresh;
            buttonStateManager.BtnAdd = btnAdd;
            buttonStateManager.UpdateButtonStates(ButtonState.DataGridViewSelected);
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void TaoMa()
        {
            //mã tự động
            RandomStringGenerator randomStringGenerator = new RandomStringGenerator();
            txtMaPB.Text = randomStringGenerator.GenerateRandomAlphanumericString(4);
        }
        private void FormPhongBan_Load(object sender, EventArgs e)
        {
            try
            {
                pbController.SelectAll();
                dgvPB.DataSource = pbController.DataSource;
                pbController.SelectMaCN();
                cbbMaCN.DataSource = pbController.DataSource;
                cbbMaCN.DisplayMember = "TENCN";
                cbbMaCN.ValueMember = "MACN";
                buttonStateManager.UpdateButtonStates(ButtonState.FormLoaded);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvPB_Click(object sender, EventArgs e)
        {
            try
            {
                // Khởi tạo số dòng đang chọn
                int dong = dgvPB.CurrentCell.RowIndex;
                // lấy ra mã
                string id = dgvPB.Rows[dong].Cells[0].Value.ToString();
                // khởi tạo đối tượng bằng mã
                DataTable dt = pbController.SelectByID(id);
                DataRow dr = dt.Rows[0];

                // chuyển thành class đối tượng
                PhongBan o = (PhongBan)pbController.FromDataRow(dr);

                // thiết lập dữ liệu ngược lại mỗi lần click
                txtMaPB.Text = o.MaPB;
                txtTenPB.Text = o.TenPB;
                // cập nhật lại trang thái các nút
                buttonStateManager.UpdateButtonStates(ButtonState.DataGridViewSelected);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            // check dữ liệu
            try
            {
                if (string.IsNullOrEmpty(txtTenPB.Text))
                {
                    MessageBox.Show("Nhập tên phòng ban!");
                }
                else
                {
                    PhongBan phongBan = new PhongBan();
                    phongBan.MaPB = txtMaPB.Text;
                    phongBan.TenPB = txtTenPB.Text;
                    phongBan.MaCN = cbbMaCN.SelectedValue.ToString();
                    pbController.Insert(phongBan);
                    pbController.SelectAll();
                    dgvPB.DataSource = pbController.DataSource;
                    buttonStateManager.UpdateButtonStates(ButtonState.RefreshClicked);
                    Refresh2();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXoa(object sender, EventArgs e)
        {
            try
            {
                if (ErrTextbox.CheckControlValue(txtMaPB))
                {
                    MessageBox.Show("txtMaPB", "Bắt buộc!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                DialogResult r = MessageBox.Show("Bạn có muốn xoa khong?", "xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    PhongBan phongBan = new PhongBan();
                    phongBan.MaPB = txtMaPB.Text;
                    pbController.Delete(phongBan.MaPB);
                    pbController.SelectAll();
                    dgvPB.DataSource = pbController.DataSource;
                    Refresh2();
                    buttonStateManager.UpdateButtonStates(ButtonState.RefreshClicked);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                PhongBan phongBan = new PhongBan();
                phongBan.MaPB = txtMaPB.Text;
                phongBan.TenPB = txtTenPB.Text;
                phongBan.MaCN = cbbMaCN.Text;
                pbController.Update(phongBan);
                pbController.SelectAll();
                dgvPB.DataSource = pbController.DataSource;
                Refresh2();
                buttonStateManager.UpdateButtonStates(ButtonState.RefreshClicked);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Refresh2()
        {
            TaoMa();
            txtTenPB.Text = string.Empty;
            cbbMaCN.SelectedIndex = 0;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Refresh2();
        }
    }
}
