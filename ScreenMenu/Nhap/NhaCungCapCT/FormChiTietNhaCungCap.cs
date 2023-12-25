using LTUD1_BACHHOAXANH472.Model;
using LTUD1_BACHHOAXANH472.ScreenMenu.Nhap.NhaCungCapCT;
using System;
using System.Data;
using System.Windows.Forms;
namespace LTUD1_BACHHOAXANH472
{
    public partial class FormChiTietNhaCungCap : Form
    {
        NhaCungCapController nccCon;
        SanPhamController spCon;
        ChiTietNCCController ctnccCon;
        ReportManager reportManager;// chia se report



        ButtonStateManager buttonStateManager;

        public FormChiTietNhaCungCap(ReportManager reportManager)
        {
            InitializeComponent();
            DataGridViewHelper.ConfigureDataGridView(dgvNCCCT);
            nccCon = new NhaCungCapController(Utils.ConnectionString);
            spCon = new SanPhamController(Utils.ConnectionString);
            ctnccCon = new ChiTietNCCController(Utils.ConnectionString);

            buttonStateManager = new ButtonStateManager();


            buttonStateManager.BtnRefresh = btnRefresh;
            buttonStateManager.BtnAdd = btnAdd;
            buttonStateManager.BtnEdit = btnEdit;
            buttonStateManager.BtnDelete = btnDelete;
            buttonStateManager.UpdateButtonStates(ButtonState.DataGridViewSelected);
            this.reportManager = reportManager;// chia se report
        }

        private void Refresh2()
        {
            cboNCC.SelectedIndex = 0;
            txtSoLuong.Text = "0";
            cboSanPham.SelectedIndex = 0;
            ctnccCon.SelectAll();
            dgvNCCCT.DataSource = ctnccCon.DataSource;
        }
        private void FormChiTietNhaCungCap_Load(object sender, EventArgs e)
        {
            spCon.SelectAll();
            cboSanPham.DataSource = spCon.DataSource;
            cboSanPham.DisplayMember = "TENSP";
            cboSanPham.ValueMember = "MASP";

            nccCon.SelectAll();
            cboNCC.DataSource = nccCon.DataSource;
            cboNCC.DisplayMember = "TENNCC";
            cboNCC.ValueMember = "MANCC";


            Refresh2();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ErrTextbox.NoText_TextChange(txtSoLuong))
            {
                MessageBox.Show("Nhập số");
                txtSoLuong.Text = string.Empty;
                return;
            }
            try
            {
                NhaCCCT o = new NhaCCCT();
                o.MaNCC = cboNCC.SelectedValue.ToString();
                o.MaSP = cboSanPham.SelectedValue.ToString();
                o.SoLuong = int.Parse(txtSoLuong.Text);
                ctnccCon.Insert(o);
                Refresh2();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (ErrTextbox.NoText_TextChange(txtSoLuong))
                {
                    MessageBox.Show("Nhập số!");
                    return;
                }

                NhaCCCT nha = new NhaCCCT();
                nha.MaSP = cboSanPham.SelectedValue.ToString();
                nha.SoLuong = int.Parse(txtSoLuong.Text);
                nha.MaNCC = cboNCC.SelectedValue.ToString();
                ctnccCon.Update(nha);

                buttonStateManager.UpdateButtonStates(ButtonState.RefreshClicked);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            cboNCC.SelectedIndex = 0;
            cboSanPham.SelectedIndex = 0;
            txtSoLuong.Text = string.Empty;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void dgvNCCCT_Click(object sender, EventArgs e)
        {
            try
            {
                // Khởi tạo số dòng đang chọn
                int dong = dgvNCCCT.CurrentCell.RowIndex;
                // lấy ra mã
                string mancc = dgvNCCCT.Rows[dong].Cells[0].Value.ToString();
                string masp = dgvNCCCT.Rows[dong].Cells[1].Value.ToString();
                NhaCCCT ob = new NhaCCCT();
                ob.MaNCC = mancc;
                ob.MaSP = masp;
                // khởi tạo đối tượng bằng mã
                DataTable dt = ctnccCon.SelectByID(ob);
                DataRow dr = dt.Rows[0];
                NhaCCCT o = (NhaCCCT)ctnccCon.FromDataRow(dr);
                txtSoLuong.Text = o.SoLuong.ToString();
                cboNCC.SelectedValue = o.MaNCC;
                cboSanPham.SelectedValue = o.MaSP;
                // cập nhật lại trang thái các nút
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\t1");
            }
        }
    }
}
