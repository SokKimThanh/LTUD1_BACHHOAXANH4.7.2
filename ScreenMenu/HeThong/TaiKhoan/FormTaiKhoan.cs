using System;
using System.Data;
using System.Windows.Forms;

namespace LTUD1_BACHHOAXANH472
{
    public partial class FormTaiKhoan : Form
    {
        AccountController controller;
        ButtonStateManager state;

        public FormTaiKhoan()
        {
            InitializeComponent();
            controller = new AccountController(Utils.ConnectionString);
            // data grid view setting
            DataGridViewHelper.ConfigureDataGridView(dgvTaiKhoan);
            //DataGridViewHelper.ConfigureDataGridView(dgvQuyenTruyCap);

        }



        private void FormTaiKhoan_Load(object sender, EventArgs e)
        {
            try
            {
                controller.SelectAll();
                dgvTaiKhoan.DataSource = controller.DataSource;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void Reset()
        {
            try
            {
                controller.SelectAll();
                dgvTaiKhoan.DataSource = controller.DataSource;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                controller.Delete(txtTenTaiKhoan.Text);
                Reset();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void BtnSua_Click(object sender, EventArgs e)
        {

            try
            {
                //controller.Update(new Account(txtTenTaiKhoan.Text, txtMK.Text, "", txtSDT.Text, txtCCCD.Text, txtEmail.Text));
                Reset();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }



        private void TxtTenTK_TextChanged(object sender, EventArgs e)
        {

        }



        private void DgvTaiKhoan_Click(object sender, EventArgs e)
        {
            try
            {
                int dong = dgvTaiKhoan.CurrentCell.RowIndex;
                txtTenTaiKhoan.Text = dgvTaiKhoan.Rows[dong].Cells[0].Value.ToString();
                DataRow row = controller.SelectByID(txtTenTaiKhoan.Text).Rows[0];

                Account o = (Account)controller.FromDataRow(row);
                if (o != null)
                {
                    txtTenTaiKhoan.Text = o.TenTaiKhoan;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tabControl2_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Lấy tabControlXemDuLieu từ form hoặc từ nơi nó được khởi tạo
            TabControl tabControlXemDuLieu = this.tabControlXemDuLieu;
            TabControl tabControlThaoTacDuLieu = this.tabControlThaoTacDuLieu;

            // Đảm bảo rằng tabControlXemDuLieu có đủ số lượng tab
            if (tabControlXemDuLieu.TabCount >= tabControlNhapThongTin.TabCount)
            {
                // Đặt tab được chọn trên tabControlXemDuLieu để khớp với tab được chọn trên tabControl2
                tabControlXemDuLieu.SelectedIndex = tabControlNhapThongTin.SelectedIndex;
                tabControlThaoTacDuLieu.SelectedIndex = tabControlNhapThongTin.SelectedIndex;
            }
            else
            {
                // Xử lý trường hợp khi tabControlXemDuLieu không có đủ số lượng tab
                Console.WriteLine("TabControl1 không có đủ số lượng tab để khớp với TabControl2.");
            }
        }


        private void FormTaiKhoan_Load_1(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}