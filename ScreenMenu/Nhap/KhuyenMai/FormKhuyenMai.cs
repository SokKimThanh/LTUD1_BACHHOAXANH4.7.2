using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
namespace LTUD1_BACHHOAXANH472.ScreenMenu.Nhap
{
    public partial class FormKhuyenMai : Form
    {
        KhuyenMaiController kmConn;
        ButtonStateManager buttonStateManager = new ButtonStateManager();
        HinhThucKhuyenMaiControler htkmConn;
        public FormKhuyenMai()
        {
            InitializeComponent();
            kmConn = new KhuyenMaiController(Utils.ConnectionString);
            htkmConn = new HinhThucKhuyenMaiControler(Utils.ConnectionString);
            dgvDSKM.DefaultCellStyle.ForeColor = Color.Black;

            buttonStateManager.BtnEdit = btnSua;
            buttonStateManager.BtnDelete = btnXoa;
            buttonStateManager.BtnRefresh = btnRefresh;
            buttonStateManager.BtnAdd = btnThem;
            buttonStateManager.UpdateButtonStates(ButtonState.FormLoaded);

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
                buttonStateManager.UpdateButtonStates(ButtonState.FormLoaded);

                Refresh2();
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
                KhuyenMai km = new KhuyenMai();
                km.Makm = txtMaKM.Text;
                km.Ngaybd = DateTime.Parse(dtpNBD.Text);
                km.Ngaykt = DateTime.Parse(dtpNKT.Text);
                km.Maht = cboMaHT.SelectedValue.ToString();
                kmConn.Insert(km);
                FormKhuyenMai_Load(sender, e);
                MessageBox.Show("Thêm khuyến mãi thành công!");
                Refresh2();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void dgvDSKM_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                kmConn.Delete(txtMaKM.Text);
                FormKhuyenMai_Load(sender, e);
                MessageBox.Show("Xoá khuyến mãi thành công!");
                Refresh2();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

            if (dtpNBD.Value > dtpNKT.Value)
            {
                MessageBox.Show("Ngày bắt đầu nhỏ hơn ngày kết thúc");
                return;
            }
            try
            {
                KhuyenMai km = new KhuyenMai();
                km.Makm = txtMaKM.Text;
                km.Ngaybd = DateTime.Parse(dtpNBD.Text);
                km.Ngaykt = DateTime.Parse(dtpNKT.Text);
                km.Maht = cboMaHT.SelectedValue.ToString();

                kmConn.Update(km);
                FormKhuyenMai_Load(sender, e);
                MessageBox.Show("Sửa khuyến mãi thành công!");
                Refresh2();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void TaoMa()
        {
            //mã tự động
            RandomStringGenerator randomStringGenerator = new RandomStringGenerator();
            txtMaKM.Text = randomStringGenerator.GenerateRandomAlphanumericString(10);
        }
        private void Refresh2()
        {
            TaoMa();
            dtpNBD.Value = DateTime.Now;
            dtpNKT.Value = DateTime.Now;
            cboMaHT.SelectedIndex = 0;
            buttonStateManager.UpdateButtonStates(ButtonState.FormLoaded);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Refresh2();
        }

        private void dgvDSKM_Click(object sender, EventArgs e)
        {
            try
            {
                // Khởi tạo số dòng đang chọn
                int dong = dgvDSKM.CurrentCell.RowIndex;
                // lấy ra mã
                string id = dgvDSKM.Rows[dong].Cells[0].Value.ToString();
                // khởi tạo đối tượng bằng mã
                DataTable dt = kmConn.SelectByID(id);
                DataRow dr = dt.Rows[0];

                // chuyển thành class đối tượng
                KhuyenMai o = (KhuyenMai)kmConn.FromDataRow(dr);

                // thiết lập dữ liệu ngược lại mỗi lần click
                txtMaKM.Text = o.Makm;
                dtpNBD.Text = o.Ngaybd.ToString();
                dtpNKT.Text = o.Ngaykt.ToString();
                // cập nhật lại trang thái các nút
                buttonStateManager.UpdateButtonStates(ButtonState.DataGridViewSelected);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
