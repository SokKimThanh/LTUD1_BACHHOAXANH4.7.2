using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System;
using System.Collections.Generic;
using System.IO;
namespace LTUD1_BACHHOAXANH472.Model
{
    public class ReportManager
    {
        // Tạo một từ điển để lưu trữ các báo cáo
        private Dictionary<string, ReportDocument> reports = new Dictionary<string, ReportDocument>();

        // Đường dẫn đến thư mục chứa các báo cáo
        private string reportDirectory;

        public ReportManager(string reportDirectory)
        {
            this.reportDirectory = reportDirectory;
        }

        public void LoadReports()
        {
            // Duyệt qua tất cả các tệp .rpt trong thư mục
            foreach (string reportPath in Directory.GetFiles(reportDirectory, "*.rpt"))
            {
                // Tải báo cáo từ tệp
                ReportDocument reportDocument = new ReportDocument();
                reportDocument.Load(reportPath);

                // Lấy tên của báo cáo từ tên tệp
                string reportTitle = Path.GetFileNameWithoutExtension(reportPath);

                // Kiểm tra xem khóa đã tồn tại chưa
                if (!reports.ContainsKey(reportTitle))
                {
                    // Nếu khóa chưa tồn tại, thêm báo cáo vào từ điển
                    reports.Add(reportTitle, reportDocument);
                }
            }
        }


        public ReportDocument GetReport(string reportTitle)
        {
            // Tìm báo cáo tương ứng trong từ điển
            if (reports.TryGetValue(reportTitle, out ReportDocument reportDocument))
            {
                return reportDocument;
            }
            else
            {
                return null;
            }
        }

        public List<string> GetReportTitles()
        {
            // Trả về danh sách tiêu đề của tất cả các báo cáo
            return new List<string>(reports.Keys);
        }

        public void ApplyParametersToReport(string reportTitle, Dictionary<string, string> parameters)
        {
            // Tìm báo cáo tương ứng trong từ điển
            if (reports.TryGetValue(reportTitle, out ReportDocument reportDocument))
            {
                // Duyệt qua từ điển các tham số và áp dụng chúng cho báo cáo
                foreach (var param in parameters)
                {
                    ParameterDiscreteValue pdv = new ParameterDiscreteValue();
                    pdv.Value = param.Value;
                    ParameterValues paramValues = new ParameterValues();
                    paramValues.Add(pdv);

                    // Áp dụng các giá trị tham số hiện tại cho tham số tương ứng trong định nghĩa dữ liệu của báo cáo
                    reportDocument.DataDefinition.ParameterFields[param.Key].ApplyCurrentValues(paramValues);
                }
            }
            else
            {
                throw new ArgumentException("Report title not found in the report manager.");
            }
        }

    }

}
