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

        public FormChiTietHoaDon()
        {
            InitializeComponent();
            hdConn = new HoaDonController(Utils.ConnectionString);
            spConn = new SanPhamController(Utils.ConnectionString);
            ctConn = new ChiTietHoaDonController(Utils.ConnectionString);
            DataGridViewHelper.ConfigureDataGridView(dgvHoaDonChiTiet);
            DataGridViewHelper.ConfigureDataGridView(dgvHoaDon);
            //ButtonStateManager buttonStateManager = new ButtonStateManager();
            //buttonStateManager.UpdateButtonStates(ButtonState.FormLoaded);
            //buttonStateManager.SetProperties(btnThemHD);

            //txt tong thanh tien place holder
            //PlaceholderTextBox df = new PlaceholderTextBox();
            //df.Textbox = txtTongThanhTien;
            //df.PlaceholderText = "Tổng thành tiền";

            //df.SettingPlaceholderTextBox();

        }

        private void btnEditSanPham_Click(object sender, EventArgs e)
        {

        }

        private void btnKTTonKho_Click(object sender, EventArgs e)
        {

        }

        private void FormChiTietHoaDon_Load(object sender, EventArgs e)
        {


        }

        private void cboHoaDon_SelectedIndexChanged(object sender, EventArgs e)
        {
            // hiển thị danh sách sản phẩm theo hóa đơn, nhóm các sản phẩm theo loại

        }

        private void btnThemHD_Click(object sender, EventArgs e)
        {

        }
    }
}
