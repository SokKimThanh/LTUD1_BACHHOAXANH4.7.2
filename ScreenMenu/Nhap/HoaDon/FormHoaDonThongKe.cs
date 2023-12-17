namespace LTUD1_BACHHOAXANH472.ScreenMenu.Nhap.HoaDon
{
    public partial class FormHoaDonThongKe : Form
    {
        HoaDonController hdConn;
        public FormHoaDonThongKe()
        {
            InitializeComponent();
            hdConn = new HoaDonController(Utils.ConnectionString);
            dgvDanhSach.DefaultCellStyle.ForeColor = Color.Black;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            hdConn.SelectByID(txtTimKiem.Text);
            dgvDanhSach.DataSource = hdConn.DataSource;
        }

        private void FormHoaDonThongKe_Load(object sender, EventArgs e)
        {
            hdConn.SelectByID(txtTimKiem.Text);
            dgvDanhSach.DataSource = hdConn.DataSource;
        }
    }
}
