using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Windows.Forms;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTUD1_BACHHOAXANH472.Model
{
    internal class ReportHelper
    {
        string fileReportName;
        Dictionary<string, string> parameters;
        CrystalReportViewer crystalReportViewer1;
        /// <summary>
        /// Constructor
        /// </summary>
        public ReportHelper()
        {

        }

        public ReportHelper(string fileReportName, Dictionary<string, string> parameters, CrystalReportViewer crystalReportViewer1)
        {
            this.fileReportName = fileReportName;
            this.parameters = parameters;
            this.crystalReportViewer1 = crystalReportViewer1;
        }

        public string FileReportName { get => fileReportName; set => fileReportName = value; }
        public Dictionary<string, string> Parameters { get => parameters; set => parameters = value; }
        public CrystalReportViewer CrystalReportViewer1 { get => crystalReportViewer1; set => crystalReportViewer1 = value; }

        public void LoadReport()
        {
            try
            {
                // khởi tạo file name report muốn hiển thị
                string fileName = fileReportName;

                // Tạo đường dẫn đến thư mục đích
                string targetDirectory = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName, Utils.UploadString);

                //khởi tạo trình quản lý thư mục report
                ReportManager reportManager = new ReportManager(targetDirectory);
                reportManager.LoadReports();

                // Giả sử bạn có một từ điển chứa các tham số và giá trị tương ứng
                //Dictionary<string, string> parameters = new Dictionary<string, string> { { "@tennhanvien", txtHoTen.Text } /*, { "@diachi", txtDiaChi.Text },{ "@manv", txtMaNV.Text } thêm các thông số khác sau dấu phấy*/ };

                //Kiểm tra có tham số nào chưa
                if (parameters.Count > 0)
                {
                    // cập nhật các thông số report vào file report chỉ định
                    reportManager.ApplyParametersToReport(fileName, parameters);

                    // Tải báo cáo từ đường dẫn chỉ định
                    ReportDocument reportDocument = reportManager.GetReport(fileName);

                    // Hiển thị báo cáo
                    crystalReportViewer1.ReportSource = reportDocument;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
    }
}
