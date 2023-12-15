using LTUD1_BACHHOAXANH472.Model;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace LTUD1_BACHHOAXANH472
{
    public partial class FormDiaDiem : Form
    {
        DiaDiemController DiaDiemController;
        ButtonStateManager buttonStateManager = new ButtonStateManager();
        RandomStringGenerator randomStringGenerator = new RandomStringGenerator();
        public FormDiaDiem()
        {
            InitializeComponent();
            DiaDiemController = new DiaDiemController(Utils.ConnectionString);
            DataGridViewHelper.ConfigureDataGridView(dgvDD);
            buttonStateManager.BtnEdit = btnSua;
            buttonStateManager.BtnDelete = btnXoa;
            buttonStateManager.BtnAdd = btnThem;
            buttonStateManager.BtnRefresh = btnRefresh;
            buttonStateManager.UpdateButtonStates(ButtonState.FormLoaded);
            txtMaCN.Text = randomStringGenerator.GenerateRandomAlphanumericString(4);
            //txtMaCN.ReadOnly = false;
            txtMaCN.Enabled = false;
        }

        private void FormDiaDiem_Load(object sender, EventArgs e)
        {
            try
            {
                DiaDiemController.SelectAll();
                dgvDD.DataSource = DiaDiemController.DataSource;
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
                if (ErrTxt.CheckControlValue(txtDC) || ErrTxt.CheckControlValue(txtTenCN))
                {
                    MessageBox.Show("Các trường dữ liệu không được để trống!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string macn = randomStringGenerator.GenerateRandomAlphanumericString(4);
                DiaDiem diaDiem = new DiaDiem(macn, txtTenCN.Text, txtDC.Text);
                DiaDiemController.Insert(diaDiem);
                DiaDiemController.SelectAll();
                dgvDD.DataSource = DiaDiemController.DataSource;
                buttonStateManager.UpdateButtonStates(ButtonState.RefreshClicked);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void dgvDD_Click(object sender, EventArgs e)
        {
            try
            {
                int dong = dgvDD.CurrentCell.RowIndex;
                txtMaCN.Text = dgvDD.Rows[dong].Cells[0].Value.ToString();
                txtTenCN.Text = dgvDD.Rows[dong].Cells[1].Value.ToString();
                txtDC.Text = dgvDD.Rows[dong].Cells[2].Value.ToString();
                buttonStateManager.UpdateButtonStates(ButtonState.DataGridViewSelected);
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
                DiaDiem diaDiem = new DiaDiem();
                diaDiem.MaCN = txtMaCN.Text;
                diaDiem.TenCN = txtTenCN.Text;
                diaDiem.DiaChi = txtDC.Text;
                DiaDiemController.Update(diaDiem);
                DiaDiemController.SelectAll();
                dgvDD.DataSource = DiaDiemController.DataSource;
                buttonStateManager.UpdateButtonStates(ButtonState.RefreshClicked);
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
                if (!ErrFrm.DialogConfirm("Bạn có chắc chắn muốn xóa?"))
                {
                    DiaDiem diaDiem = new DiaDiem();
                    diaDiem.MaCN = txtMaCN.Text;
                    DiaDiemController.Delete(diaDiem.MaCN);
                    DiaDiemController.SelectAll();
                    dgvDD.DataSource = DiaDiemController.DataSource;
                    buttonStateManager.UpdateButtonStates(ButtonState.RefreshClicked);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                buttonStateManager.UpdateButtonStates(ButtonState.RefreshClicked);
                txtMaCN.Text = randomStringGenerator.GenerateRandomAlphanumericString(4);
                txtTenCN.Text = string.Empty;
                txtDC.Text = string.Empty;
                DiaDiemController.SelectAll();
                dgvDD.DataSource = DiaDiemController.DataSource;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void txtTenCN_TextChanged(object sender, EventArgs e)
        {
            TextHelper.HandleTextChange_TenChiNhanh(sender);
        }

        private void txtDC_TextChanged(object sender, EventArgs e)
        {
            TextHelper.HandleTextChange_DiaChi(sender);
        }
    }
}
