using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Windows.Forms;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LTUD1_BACHHOAXANH472.Model
{
    /// <summary>
    /// Chia sẽ các báo cáo con mỗi khi được gọi 
    /// không tải tất cả các báo cáo cùng lúc để tránh lỗi tràn bộ nhớ
    /// </summary>
    public class ReportHelper
    {
        private ReportManager reportManager;
        private string fileReportName;
        private Dictionary<string, object> parameters;
        private CrystalReportViewer crystalReportViewer1;

        /// <summary>
        /// Cho phép thêm tham số sau
        /// </summary>
        public ReportHelper() { }
        public ReportHelper(ReportManager reportManager, string fileReportName, Dictionary<string, object> parameters, CrystalReportViewer crystalReportViewer1)
        {
            this.reportManager = reportManager;
            this.fileReportName = fileReportName;
            this.parameters = parameters;
            this.crystalReportViewer1 = crystalReportViewer1;
        }

        public void LoadReport()
        {
            if (parameters.Count >= 0)//có thể tải các report không có tham số 
            {
                // Kiểm tra xem tên báo cáo có tồn tại trong tài nguyên hay không
                // LƯU Ý: BƯỚC NÀY LÀ KIỂM TRA TÊN CÓ TÊN REPORT TRONG RESOURCE HAY KHÔNG!!!!
                // NẾU KHÔNG THÌ PHẢI XÓA HẾT RESOURCE COPY BỎ REPORT VÔ RESOURCE
                if (reportManager.ReportExists(fileReportName, Utils.ReportsString))
                {
                    // Nếu có, tải báo cáo và gán nó vào CrystalReportViewer
                    ReportDocument reportDocument = reportManager.GetReport(fileReportName);
                    if (reportDocument == null)
                    {
                        // Xử lý trường hợp reportDocument là null
                        throw new System.Exception("Không tải được report vui lòng xem lại formmain đang tải từ folder uploads hay resource!");
                    }
                    else
                    {
                        // Tiếp tục như bình thường
                        // Đặt giá trị cho các tham số
                        foreach (var parameter in parameters)
                        {
                            reportDocument.SetParameterValue(parameter.Key, parameter.Value.ToString());
                        }
                    }
                    crystalReportViewer1.ReportSource = reportDocument;
                }
                else
                {
                    // Nếu không, thông báo cho người dùng
                    MessageBox.Show("Báo cáo '" + fileReportName + "' không tồn tại trong tài nguyên.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
