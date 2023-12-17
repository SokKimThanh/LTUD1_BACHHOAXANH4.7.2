﻿using LTUD1_BACHHOAXANH472.ScreenMenu.Nhap.NhaCungCapCT;

namespace LTUD1_BACHHOAXANH472
{
    public partial class FormChiTietNhaCungCap : Form
    {
        NhaCungCapController nccCon;
        SanPhamController spCon;
        ChiTietNCCController ctnccCon;




        ButtonStateManager buttonStateManager;

        public FormChiTietNhaCungCap()
        {
            InitializeComponent();
            DataGridViewHelper.ConfigureDataGridView(dgvNCCCT);
            nccCon = new NhaCungCapController(Utils.ConnectionString);
            spCon = new SanPhamController(Utils.ConnectionString);
            ctnccCon = new ChiTietNCCController(Utils.ConnectionString);

            buttonStateManager = new ButtonStateManager();

            buttonStateManager.BtnEdit = btnEdit;
            buttonStateManager.BtnDelete = btnEdit;
            buttonStateManager.BtnRefresh = btnRefresh;
            buttonStateManager.BtnAdd = btnAdd;
            buttonStateManager.UpdateButtonStates(ButtonState.DataGridViewSelected);
        }

        private void Refresh()
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


            Refresh();
            buttonStateManager.UpdateButtonStates(ButtonState.FormLoaded);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ErrTxt.NoText_TextChange(txtSoLuong))
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

                ctnccCon.Insert(o);
                Refresh();
                buttonStateManager.UpdateButtonStates(ButtonState.RefreshClicked);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void dgvNCCCT_CellContentClick(object sender, EventArgs e)
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
                buttonStateManager.UpdateButtonStates(ButtonState.DataGridViewSelected);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\t1");
            }
        }


    }
}
