using LTUD1_BACHHOAXANH472.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LTUD1_BACHHOAXANH472.ScreenMenu.Nhap
{
    public partial class FormKhuyenMai : Form
    {
        KhuyenMaiController kmConn;
        HinhThucKhuyenMaiControler htkmConn;
        public FormKhuyenMai()
        {
            InitializeComponent();
            kmConn = new KhuyenMaiController(Utils.ConnectionString);
            htkmConn = new HinhThucKhuyenMaiControler(Utils.ConnectionString);
            dgvDSKM.DefaultCellStyle.ForeColor = Color.Black;

        }
        private void FormKhuyenMai_Load(object sender, EventArgs e)
        {
            try
            {
                kmConn.SelectAll();
                dgvDSKM.DataSource = kmConn.DataSource;

                htkmConn.SelectAll();
                cboMaHT.DataSource = htkmConn.DataSource;
                cboMaHT.DisplayMember = "TENHINHTHUC";
                cboMaHT.ValueMember = "MAHT";
                // setting datagridview
                DataGridViewHelper.ConfigureDataGridView(dgvDSKM);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            KhuyenMai km = new KhuyenMai();
            km.Makm = txtMaKM.Text;
            km.Ngaybd = DateTime.Parse(dtpNBD.Text);
            km.Ngaykt = DateTime.Parse(dtpNKT.Text);
            km.Maht = cboMaHT.SelectedValue.ToString();

            try
            {
                kmConn.Insert(km);
                FormKhuyenMai_Load(sender, e);
                MessageBox.Show("Thêm khuyến mãi thành công!");
                clean();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void clean()
        {
            txtMaKM.Text = "";
            cboMaHT.SelectedIndex = 0;
        }

        private void dgvDSKM_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int dong = dgvDSKM.CurrentCell.RowIndex;
            txtMaKM.Text = dgvDSKM.Rows[dong].Cells[0].Value.ToString();
            cboMaHT.Text = dgvDSKM.Rows[dong].Cells[1].Value.ToString();
            dtpNBD.Text = dgvDSKM.Rows[dong].Cells[2].Value.ToString();
            dtpNKT.Text = dgvDSKM.Rows[dong].Cells[3].Value.ToString();

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                kmConn.Delete(txtMaKM.Text);
                FormKhuyenMai_Load(sender, e);
                MessageBox.Show("Xoá khuyến mãi thành công!");
                clean();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            KhuyenMai km = new KhuyenMai();
            km.Makm = txtMaKM.Text;
            km.Ngaybd = DateTime.Parse(dtpNBD.Text);
            km.Ngaykt = DateTime.Parse(dtpNKT.Text);
            km.Maht = cboMaHT.SelectedValue.ToString();

            try
            {
                kmConn.Update(km);
                FormKhuyenMai_Load(sender, e);
                MessageBox.Show("Sửa khuyến mãi thành công!");
                clean();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
