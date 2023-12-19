using CrystalDecisions.Shared;
using LTUD1_BACHHOAXANH472.uploads;
using System.Windows.Forms;

namespace LTUD1_BACHHOAXANH472
{
    public partial class FormInPhieuThanhToan : Form
    {
        HoaDon hd = new HoaDon();
        PhieuInHoaDon rptInHoaDon = new PhieuInHoaDon();


        public HoaDon Hd { get => hd; set => hd = value; }

        // Khởi tạo một đối tượng mới từ lớp ParameterDiscreteValue để chứa một giá trị tham số rời rạc
        ParameterDiscreteValue pdv = new ParameterDiscreteValue();


        public FormInPhieuThanhToan(HoaDon hoadon)
        {
            InitializeComponent();
            hd = hoadon;
        }

        private void crystalReportViewer1_Load(object sender, System.EventArgs e)
        {
            // Khởi tạo một đối tượng mới từ lớp ParameterValues để chứa các giá trị tham số
            ParameterValues param = new ParameterValues();

            // Khởi tạo một đối tượng mới từ lớp ParameterDiscreteValue để chứa một giá trị tham số rời rạc
            ParameterDiscreteValue pdv = new ParameterDiscreteValue();

            // Đặt giá trị của pdv bằng giá trị trong textBox1
            pdv.Value = "HD01";

            // Thêm pdv vào danh sách các giá trị tham số
            param.Add(pdv);

            // Áp dụng các giá trị tham số hiện tại cho tham số "@masv" trong định nghĩa dữ liệu của báo cáo
            rptInHoaDon.DataDefinition.ParameterFields["@MAHD"].ApplyCurrentValues(param);

            // Đặt nguồn báo cáo cho crystalReportViewer1 là báo cáo rpt
            rpvInHoaDon.ReportSource = rptInHoaDon;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            pdv.Value = txtTimHoaDon.Text;
            // Khởi tạo một đối tượng mới từ lớp ParameterValues để chứa các giá trị tham số
            ParameterValues param = new ParameterValues
            {
                // Thêm pdv vào danh sách các giá trị tham số
                pdv
            };

            // Áp dụng các giá trị tham số hiện tại cho tham số "@masv" trong định nghĩa dữ liệu của báo cáo
            rptInHoaDon.DataDefinition.ParameterFields["@MAHD"].ApplyCurrentValues(param);

            // Đặt nguồn báo cáo cho crystalReportViewer1 là báo cáo rpt
            rpvInHoaDon.ReportSource = rptInHoaDon;
        }

        private void FormInPhieuThanhToan_Load(object sender, System.EventArgs e)
        {
            // Đặt giá trị của pdv bằng giá trị trong textBox1
            pdv.Value = this.hd.MaHD;
        }
    }
}
