using LTUD1_BACHHOAXANH472.ScreenMenu.Nhap.HoaDon;
using System;
using System.Windows.Forms;
namespace LTUD1_BACHHOAXANH472.ScreenMenu.Nhap.ChiTietHoaDon
{
    public partial class ChiTietHoaDonThongKe : Form
    {
        ChiTietHoaDonController ctConn;
        HoaDonController hdConn;
        public ChiTietHoaDonThongKe()
        {
            InitializeComponent();
            ctConn = new ChiTietHoaDonController(Utils.ConnectionString);
            hdConn = new HoaDonController(Utils.ConnectionString);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            hdConn.SelectAll();
            cboHD.DataSource = hdConn.DataSource;
            cboHD.DisplayMember = "MAHD";
            cboHD.ValueMember = "MAHD";

            ctConn.SelectByID(cboHD.SelectedValue.ToString());
            dgvDanhSach.DataSource = ctConn.DataSource;
        }

        private void cboHD_TextChanged(object sender, EventArgs e)
        {
            ctConn.SelectByID(cboHD.SelectedValue.ToString());
            dgvDanhSach.DataSource = ctConn.DataSource;
        }
    }
}
