using System;
using System.Windows.Forms;

namespace LTUD1_BACHHOAXANH472.ScreenMenu.Nhap.PhongBan
{
    public partial class FormPhongBan : Form
    {
        PhongBanController controller;
        public FormPhongBan()
        {
            InitializeComponent();
            controller = new PhongBanController(Utils.ConnectionString);
            DataGridViewHelper.ConfigureDataGridView(dgvPB);

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void FormPhongBan_Load(object sender, EventArgs e)
        {
            controller.SelectAll();
            dgvPB.DataSource = controller.DataSource;
            controller.SelectMaCN();
            cbbMaCN.DataSource = controller.DataSource;
            cbbMaCN.DisplayMember = "TENCN";
            cbbMaCN.ValueMember = "MACN";
        }

        private void dgvPB_Click(object sender, EventArgs e)
        {
            int dong = dgvPB.CurrentCell.RowIndex;
            txtMaPB.Text = dgvPB.Rows[dong].Cells[0].Value.ToString();
            txtTenPB.Text = dgvPB.Rows[dong].Cells[1].Value.ToString();
            cbbMaCN.Text = dgvPB.Rows[dong].Cells[2].Value.ToString();
        }
        private void groupBox7_Enter(object sender, EventArgs e)
        {

        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            PhongBan phongBan = new PhongBan();
            phongBan.MaPB = txtMaPB.Text;
            phongBan.TenPB = txtTenPB.Text;
            phongBan.MaCN = cbbMaCN.SelectedValue.ToString();
            controller.Insert(phongBan);
            controller.SelectAll();
            dgvPB.DataSource = controller.DataSource;
        }

        private void btnXoa(object sender, EventArgs e)
        {
            PhongBan phongBan = new PhongBan();
            phongBan.MaPB = txtMaPB.Text;
            controller.Delete(phongBan.MaPB);
            controller.SelectAll();
            dgvPB.DataSource = controller.DataSource;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            PhongBan phongBan = new PhongBan();
            phongBan.MaPB = txtMaPB.Text;
            phongBan.TenPB = txtTenPB.Text;
            phongBan.MaCN = cbbMaCN.Text;
            controller.Update(phongBan);
            controller.SelectAll();
            dgvPB.DataSource = controller.DataSource;
        }
    }
}
