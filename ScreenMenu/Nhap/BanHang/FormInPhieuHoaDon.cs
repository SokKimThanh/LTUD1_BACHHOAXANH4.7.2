using CrystalDecisions.Shared;
using System;
using System.Windows.Forms;

namespace LTUD1_BACHHOAXANH472.ScreenMenu.Nhap.BanHang
{
    public partial class FormInPhieuHoaDon : Form
    {
        public FormInPhieuHoaDon()
        {
            InitializeComponent();
        }

        private void FormInPhieuHoaDon_Load(object sender, EventArgs e)
        {
            try
            {
                PhieuInHoaDon rptPIHD = new PhieuInHoaDon();
                // Khởi tạo một đối tượng mới từ lớp ParameterValues để chứa các giá trị tham số
                ParameterValues param = new ParameterValues();

                // Khởi tạo một đối tượng mới từ lớp ParameterDiscreteValue để chứa một giá trị tham số rời rạc
                ParameterDiscreteValue pdv = new ParameterDiscreteValue();

                // Đặt giá trị của pdv bằng giá trị trong textBox1
                pdv.Value = "HD01";

                // Thêm pdv vào danh sách các giá trị tham số
                param.Add(pdv);

                // Áp dụng các giá trị tham số hiện tại cho tham số "@masv" trong định nghĩa dữ liệu của báo cáo
                rptPIHD.DataDefinition.ParameterFields["@MAHD"].ApplyCurrentValues(param);

                // Đặt nguồn báo cáo cho crystalReportViewer1 là báo cáo rpt
                crystalReportViewer1.ReportSource = rptPIHD;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
