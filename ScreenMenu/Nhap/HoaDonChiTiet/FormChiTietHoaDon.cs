using LTUD1_BACHHOAXANH472.Model;
using System;
using System.Data;
using System.Windows.Forms;

namespace LTUD1_BACHHOAXANH472
{
    public partial class FormChiTietHoaDon : Form
    {
        HoaDonController hdConn;
        SanPhamController spConn;
        ChiTietHoaDonController ctConn;
        ButtonStateManager buttonStateManager = new ButtonStateManager();
        ReportManager reportManager;// chia se report

        public FormChiTietHoaDon(ReportManager reportManager)
        {
            InitializeComponent();
            hdConn = new HoaDonController(Utils.ConnectionString);
            spConn = new SanPhamController(Utils.ConnectionString);
            ctConn = new ChiTietHoaDonController(Utils.ConnectionString);
            DataGridViewHelper.ConfigureDataGridView(dgvCTHoaDon);
            buttonStateManager.BtnAdd = this.btnAddSP;
            buttonStateManager.BtnEdit = this.btnEditSanPham;
            buttonStateManager.BtnDelete = this.btnDeleteSP;
            buttonStateManager.BtnRefresh = this.btnRefresh;
            this.reportManager = reportManager;// chia se report
        }
        private void FormChiTietHoaDon_Load(object sender, EventArgs e)
        {
            try
            {
                hdConn.SelectAll();
                cboHoaDon.DataSource = hdConn.DataSource;
                cboHoaDon.DisplayMember = "MAHD";
                cboHoaDon.ValueMember = "MAHD";

                spConn.SelectAll();
                cboSanPham.DataSource = spConn.DataSource;
                cboSanPham.DisplayMember = "TENSP";
                cboSanPham.ValueMember = "MASP";

                ctConn.SelectByID(cboHoaDon.SelectedValue.ToString());
                dgvCTHoaDon.DataSource = ctConn.DataSource;

                /* txtThanhTien =  cthdController.TongTien(cboHoaDon.SelectedValue.ToString());*/
                txtThanhTien.Text = ctConn.TongTien(cboHoaDon.SelectedValue.ToString());

                buttonStateManager.UpdateButtonStates(ButtonState.FormLoaded);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnKTTonKho_Click(object sender, EventArgs e)
        {
            try
            {
                ctConn.KTTonKho(cboSanPham.SelectedValue.ToString(), int.Parse(txtSoLuong.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ;

            try
            {

                ChiTietHoaDon cthd = new ChiTietHoaDon();
                cthd.MaHD = cboHoaDon.SelectedValue.ToString();
                cthd.MaSP = cboSanPham.SelectedValue.ToString();
                cthd.SoLuong = int.Parse(txtSoLuong.Text);

                ctConn.Insert(cthd);
                DataTable dt = ctConn.SelectByID(cboHoaDon.SelectedValue.ToString());
                dgvCTHoaDon.DataSource = dt;
                if (ctConn.KTMASP(cthd.MaSP) == false)
                {
                    MessageBox.Show("Thêm sản phẩm thành công!");
                    txtThanhTien.Text = ctConn.TongTien(cboHoaDon.SelectedValue.ToString());
                    buttonStateManager.UpdateButtonStates(ButtonState.RefreshClicked);
                }
                else
                {
                    MessageBox.Show("Thêm sản phẩm không thành công!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void txtCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                ChiTietHoaDon cthd = new ChiTietHoaDon();
                cthd.MaHD = cboHoaDon.SelectedValue.ToString();
                cthd.MaSP = cboSanPham.SelectedValue.ToString();
                cthd.SoLuong = int.Parse(txtSoLuong.Text);
                if (ctConn.KTTonKho(cboSanPham.SelectedValue.ToString(), int.Parse(txtSoLuong.Text)) >= 0)
                {
                    ctConn.Update(cthd);
                    FormChiTietHoaDon_Load(sender, e);
                    txtThanhTien.Text = ctConn.TongTien(cboHoaDon.SelectedValue.ToString());
                    MessageBox.Show("Sửa sản phẩm thành công!");
                    buttonStateManager.UpdateButtonStates(ButtonState.RefreshClicked);
                }
                else
                {
                    MessageBox.Show("Sửa sản phẩm không thành công!");
                }


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
                ChiTietHoaDon cthd = new ChiTietHoaDon();
                cthd.MaHD = cboHoaDon.SelectedValue.ToString();
                cthd.MaSP = cboSanPham.SelectedValue.ToString();
                ctConn.Delete(cthd);
                FormChiTietHoaDon_Load(sender, e);
                txtThanhTien.Text = ctConn.TongTien(cboHoaDon.SelectedValue.ToString());
                MessageBox.Show("Xoa sản phẩm thành công!");
                buttonStateManager.UpdateButtonStates(ButtonState.RefreshClicked);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cboHoaDon_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = ctConn.SelectByID(cboHoaDon.SelectedValue.ToString());
                dgvCTHoaDon.DataSource = dt;

                txtThanhTien.Text = ctConn.TongTien(cboHoaDon.SelectedValue.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cboHoaDon_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                ctConn.SelectByID(cboHoaDon.SelectedValue.ToString());
                dgvCTHoaDon.DataSource = ctConn.DataSource;
                txtThanhTien.Text = ctConn.TongTien(cboHoaDon.SelectedValue.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {

        }

        /* private void dgvCTHoaDon_Click(object sender, EventArgs e)
         {
             try
             {
                 // Khởi tạo số dòng đang chọn
                 int dong = dgvCTHoaDon.CurrentCell.RowIndex;
                 // lấy ra mã
                 string id = dgvCTHoaDon.Rows[dong].Cells[0].Value.ToString();
                 string id = dgvCTHoaDon.Rows[dong].Cells[1].Value.ToString();
                 // khởi tạo đối tượng bằng mã
                 DataTable dt = ctConn.SelectOne(id);
                 DataRow dr = dt.Rows[0];
                 // chuyển thành class đối tượng
                 ChiTietHoaDon o = (ChiTietHoaDon)ChiTietHoaDonController.FromDataRow(dr);

                 // thiết lập dữ liệu ngược lại mỗi lần click
                 txtSoLuong.Text = o.SoLuong.ToString();
                 // cập nhật lại trang thái các nút
                 buttonStateManager.UpdateButtonStates(ButtonState.DataGridViewSelected);
             }
             catch (Exception ex)
             {
                 MessageBox.Show(ex.Message);
             }
         }*/
    }
}
