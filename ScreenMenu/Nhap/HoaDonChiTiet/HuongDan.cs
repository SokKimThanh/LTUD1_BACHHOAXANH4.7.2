using LTUD1_BACHHOAXANH472.model;
using LTUD1_BACHHOAXANH472.ScreenMenu.Nhap.ChiTietHoaDon;
using LTUD1_BACHHOAXANH472.ScreenMenu.Nhap.HoaDon;
using System;
using System.Data;
using System.Windows.Forms;

namespace LTUD1_BACHHOAXANH472
{
    public partial class FormChiTietHoaDon : Form
    {
        private readonly HoaDonController hdConn;
        private readonly SanPhamController spConn;
        private readonly ChiTietHoaDonController ctConn;
        private ButtonStateManager buttonStateManager = new ButtonStateManager();

        public FormChiTietHoaDon()
        {
            InitializeComponent();
            hdConn = new HoaDonController(Utils.ConnectionString);
            spConn = new SanPhamController(Utils.ConnectionString);
            ctConn = new ChiTietHoaDonController(Utils.ConnectionString);

            // vẽ màn hình chi tiết hóa đơn

            DataGridViewHelper.ConfigureDataGridView(dgvHoaDonChiTiet);
            DataGridViewHelper.ConfigureDataGridView(dgvHoaDon);

            buttonStateManager.BtnAdd = this.btnThemHD;
            buttonStateManager.BtnEdit = this.btnCapNhatHD;
            buttonStateManager.BtnDelete = this.btnXoaHD;
            buttonStateManager.BtnRefresh = this.btnLamMoiHD;
            buttonStateManager.SetProperties(btnThemHD);
            buttonStateManager.SetProperties(btnCapNhatHD);
            buttonStateManager.SetProperties(btnXoaHD);
            buttonStateManager.SetProperties(btnLamMoiHD);
            buttonStateManager.SetProperties(btnThemSP);
            buttonStateManager.SetProperties(btnThanhToan);
            buttonStateManager.SetProperties(btnInPhieuHoaDon);
            buttonStateManager.SetProperties(btnXoaSP);
            buttonStateManager.SetProperties(btnCapNhatSoLuongMua);
            //txt tong thanh tien place holder
            PlaceholderTextBox df = new PlaceholderTextBox();
            df.Textbox = txtHoaDon;
            df.PlaceholderText = "Nhập mã hóa đơn";
            df.SettingPlaceholderTextBox();


            // cập nhật màn hình edit
            buttonStateManager.UpdateButtonStates(ButtonState.FormLoaded);
        }

        private void btnEditSanPham_Click(object sender, EventArgs e)
        {

        }

        private void btnKTTonKho_Click(object sender, EventArgs e)
        {

        }

        private void FormChiTietHoaDon_Load(object sender, EventArgs e)
        {
            //mã tự động
            RandomStringGenerator randomStringGenerator = new RandomStringGenerator();
            txtHoaDon.Text = randomStringGenerator.GenerateRandomAlphanumericString(10);
        }

        private void cboHoaDon_SelectedIndexChanged(object sender, EventArgs e)
        {
            // hiển thị danh sách sản phẩm theo hóa đơn, nhóm các sản phẩm theo loại

        }

        private void btnThemHD_Click(object sender, EventArgs e)
        {
            buttonStateManager.UpdateButtonStates(ButtonState.RefreshClicked);
        }

        private void btnCapNhatHD_Click(object sender, EventArgs e)
        {
            buttonStateManager.UpdateButtonStates(ButtonState.RefreshClicked);
        }

        private void btnXoaHD_Click(object sender, EventArgs e)
        {
            buttonStateManager.UpdateButtonStates(ButtonState.RefreshClicked);
        }

        private void btnLamMoiHD_Click(object sender, EventArgs e)
        {
            buttonStateManager.UpdateButtonStates(ButtonState.RefreshClicked);
        }

        private void txtHoaDon_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
