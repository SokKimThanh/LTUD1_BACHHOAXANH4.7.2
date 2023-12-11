using LTUD1_BACHHOAXANH472.controller;
using LTUD1_BACHHOAXANH472.Model;
using System;
using System.Windows.Forms;

namespace LTUD1_BACHHOAXANH472.ScreenMenu.Nhap
{
    public partial class FormKhachHang : Form
    {
        KhachHangController khachHangController;
        public FormKhachHang()
        {

            InitializeComponent();

            khachHangController = new KhachHangController(Utils.ConnectionString);
            DataGridViewHelper.ConfigureDataGridView(dgvKH);
        }

        private void groupBox7_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox8_Enter(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

      
        private void FormKhachHang_Load(object sender, EventArgs e)
        {
            khachHangController.SelectAll();
            dgvKH.DataSource = khachHangController.DataSource;
        }

     

        private void btnThem_Click(object sender, EventArgs e)
        {
             
            try
            {
                KhachHang kh = new KhachHang();
                kh.Ma = txtMa.Text;
                kh.Ten = txtxHoTen.Text;
                kh.Sdt = int.Parse(txtSDT.Text);
                kh.Diem = int.Parse(txtDTL.Text);
                khachHangController.Insert(kh);
                khachHangController.SelectAll();
                dgvKH.DataSource = khachHangController.DataSource;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void button2_Click(object sender, EventArgs e)
        {
            KhachHang kh = new KhachHang();
            kh.Ma = txtMa.Text;       
            khachHangController.Delete(kh.Ma);
            khachHangController.SelectAll();
            dgvKH.DataSource = khachHangController.DataSource;
        }

        private void dgvKH_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            txtMa.Text = dgvKH.Rows[dong].Cells[0].Value.ToString();
            txtxHoTen.Text = dgvKH.Rows[dong].Cells[1].Value.ToString();
            txtSDT.Text = dgvKH.Rows[dong].Cells[2].Value.ToString();
            txtDTL.Text = dgvKH.Rows[dong].Cells[3].Value.ToString();
        }
    }
}
