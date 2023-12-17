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
    }

}
