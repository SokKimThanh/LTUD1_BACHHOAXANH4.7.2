using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Windows.Forms;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        private Dictionary<string, string> parameters;
        private CrystalReportViewer crystalReportViewer1;

        public ReportHelper(ReportManager reportManager, string fileReportName, Dictionary<string, string> parameters, CrystalReportViewer crystalReportViewer1)
        {
            this.reportManager = reportManager;
            this.fileReportName = fileReportName;
            this.parameters = parameters;
            this.crystalReportViewer1 = crystalReportViewer1;
        }

        public void LoadReport()
        {
            if (parameters.Count > 0)
            {
                // Kiểm tra xem tên báo cáo có tồn tại trong tài nguyên hay không
                if (reportManager.ReportExists(fileReportName))
                {
                    // Nếu có, tải báo cáo và gán nó vào CrystalReportViewer
                    ReportDocument reportDocument = reportManager.GetReport(fileReportName);

                    // Đặt giá trị cho các tham số
                    foreach (var parameter in parameters)
                    {
                        reportDocument.SetParameterValue(parameter.Key, parameter.Value);
                    }

                    crystalReportViewer1.ReportSource = reportDocument;
                }
                else
                {
                    // Nếu không, thông báo cho người dùng
                    MessageBox.Show("Báo cáo '" + fileReportName + "' không tồn tại trong tài nguyên.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Nếu không có tham số, thông báo cho người dùng
                MessageBox.Show("Không có tham số nào được cung cấp.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
