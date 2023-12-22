using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using LTUD1_BACHHOAXANH472.Model;
using LTUD1_BACHHOAXANH472.uploads;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Windows.Forms;
namespace LTUD1_BACHHOAXANH472.HeThong
{
    public partial class FormUploadFilesReport : Form
    {
        ReportManager reportManager;
        // Tạo một từ điển để lưu trữ các báo cáo
        Dictionary<string, ReportDocument> reports = new Dictionary<string, ReportDocument>();
        // khởi tạo kết nối
        NhanVienController nvController = new NhanVienController(Utils.ConnectionString);
        ChiNhanhController chinhanhController = new ChiNhanhController(Utils.ConnectionString);
        private TreeNode selectedNode;
        // Hàm hỗ trợ kiểm tra lỗi nhập
        //ErrTxt errtxt;
        ErrColors color = new ErrColors();

        public FormUploadFilesReport()
        {
            InitializeComponent();
        }

        private void FormUploadFilesReport_Load(object sender, EventArgs e)
        {
            // chỉnh style nút tìm kiếm
            CustomButtonHelper customButtonHelper = new CustomButtonHelper();
            customButtonHelper.SetProperties(btnImport);

            // Khởi tạo ReportManager với đường dẫn đến thư mục chứa các báo cáo
            reportManager = new ReportManager(Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName, @"ScreenMenu\Nhap\NhanVien"));

            // hiển thị danh sach báo cáo
            reportManager.LoadReports();

            // Thêm các tiêu đề báo cáo vào TreeView
            foreach (string reportTitle in reportManager.GetReportTitles())
            {
                TreeNode newNode = new TreeNode(reportTitle);
                newNode.Name = reportTitle;
                tvReport.Nodes.Add(newNode);
            }


            // hiển thị danh sach chi nhánh report
            chinhanhController.SelectAll();
            DataTable dtcn = chinhanhController.DataSource;
            cboReportChiNhanh.DataSource = dtcn;
            cboReportChiNhanh.ValueMember = "MACN";
            cboReportChiNhanh.DisplayMember = "TENCN";
            cboReportChiNhanh.SelectedIndex = 0;

            // hiển thị danh sach phong ban theo chi nhánh
            var selectedValue = cboReportChiNhanh.SelectedValue; // Lấy giá trị được chọn
            DataTable dt = chinhanhController.SelectPhongBanByMaCN(selectedValue.ToString());

            cboReportPhongBan.DataSource = dt;
            cboReportPhongBan.ValueMember = "MAPB";
            cboReportPhongBan.DisplayMember = "TENPHG";

        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                // After the other action is performed, re-select the previously selected node
                tvReport.SelectedNode = selectedNode;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// Tải report không tham số khác lên để xem báo cáo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnImport_Click(object sender, EventArgs e)
        {
            try
            {
                // Tạo một OpenFileDialog để cho phép người dùng chọn tệp báo cáo
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Report Files|*.rpt";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Lấy đường dẫn tệp từ OpenFileDialog
                    string sourcePath = openFileDialog.FileName;

                    // Lấy tên file từ đường dẫn file
                    string fileName = Path.GetFileName(sourcePath);
                    txtTieuDeReport.Text = fileName;

                    // Tạo đường dẫn đến thư mục "ScreenMenu\Nhap\NhanVien\uploads"
                    string targetDirectory = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName, @"ScreenMenu\Nhap\NhanVien");
                    string targetPath = Path.Combine(targetDirectory, fileName);

                    // Copy tệp đã chọn vào thư mục "ScreenMenu\Nhap\NhanVien\uploads", ghi đè nếu tệp đã tồn tại
                    File.Copy(sourcePath, targetPath, true);

                    // Tải báo cáo từ tệp đã sao chép
                    ReportDocument reportDocument = new ReportDocument();
                    reportDocument.Load(targetPath);

                    // Thêm báo cáo vào từ điển
                    reports.Add(fileName, reportDocument);

                    // Tạo một TreeNode mới với tiêu đề báo cáo
                    TreeNode newNode = new TreeNode(fileName);
                    newNode.Name = fileName;

                    // Thêm TreeNode vào TreeView
                    if (tvReport.SelectedNode == null)
                    {
                        // Nếu không có node nào được chọn, thêm node mới vào gốc của TreeView
                        tvReport.Nodes.Add(newNode);
                        tvReportNhanVien.Nodes.Add(newNode);
                    }

                    // Hiển thị báo cáo

                    //crystalReportViewer1.ReportSource = reportDocument;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public void LoadNhanVienReport(string txtHoTenNV)
        {
            // Khởi tạo một đối tượng mới từ lớp rp_nhanvien_nvtheophongban
            rp_nhanvien_select_all rpt = new rp_nhanvien_select_all();

            // tim theo từng loại báo cáo
            //Khởi tạo một đối tượng mới từ lớp ParameterValues để chứa các giá trị tham số
            ParameterValues paramHOTENNV = new ParameterValues();


            //Khởi tạo một đối tượng mới từ lớp ParameterDiscreteValue để chứa một giá trị tham số rời rạc
            ParameterDiscreteValue pdvHOTENNV = new ParameterDiscreteValue();


            //Đặt giá trị của pdv bằng giá trị trong textBox1
            pdvHOTENNV.Value = txtHoTenNV;

            //Thêm pdv vào danh sách các giá trị tham số
            paramHOTENNV.Add(pdvHOTENNV);

            //Áp dụng các giá trị tham số hiện tại cho tham số "@masv" trong định nghĩa dữ liệu của báo cáo
            rpt.DataDefinition.ParameterFields["@keyword"].ApplyCurrentValues(paramHOTENNV);

            // Đặt nguồn báo cáo cho crystalReportViewer1 là báo cáo rpt
            crystalReportViewer1.ReportSource = rpt;
        }
        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            try
            {
                // Khởi tạo một đối tượng mới từ lớp rp_nhanvien_nvtheophongban
                rp_nhanvien_select_all rpt = new rp_nhanvien_select_all();

                // Khởi tạo một đối tượng mới từ lớp ParameterValues để chứa các giá trị tham số
                ParameterValues paramMaPhongBan = new ParameterValues();
                ParameterValues paramMaChiNhanh = new ParameterValues();

                // Khởi tạo một đối tượng mới từ lớp ParameterDiscreteValue để chứa một giá trị tham số rời rạc
                ParameterDiscreteValue pdvMaPB = new ParameterDiscreteValue();
                ParameterDiscreteValue pdvMaCN = new ParameterDiscreteValue();

                // Đặt giá trị của pdv bằng giá trị trong textBox1
                pdvMaPB.Value = cboReportPhongBan.SelectedValue;
                pdvMaCN.Value = cboReportChiNhanh.SelectedValue;
                // Thêm pdv vào danh sách các giá trị tham số
                paramMaPhongBan.Add(pdvMaPB);
                paramMaChiNhanh.Add(pdvMaCN);
                // Áp dụng các giá trị tham số hiện tại cho tham số "@masv" trong định nghĩa dữ liệu của báo cáo
                rpt.DataDefinition.ParameterFields["@MaPhongBan"].ApplyCurrentValues(paramMaPhongBan);
                rpt.DataDefinition.ParameterFields["@MaChiNhanh"].ApplyCurrentValues(paramMaChiNhanh);

                // Đặt nguồn báo cáo cho crystalReportViewer1 là báo cáo rpt
                crystalReportViewer1.ReportSource = rpt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void tvReport_BeforeSelect(object sender, TreeViewCancelEventArgs e)
        {
            selectedNode = e.Node;
        }
        /// <summary>
        /// Sự kiện report nhấp vào hiển thị report được chọn
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tvReport_AfterSelect(object sender, TreeViewEventArgs e)
        {
            // Lấy tên của node được chọn
            string reportTitle = e.Node.Text;
            // Tô màu node
            e.Node.BackColor = color.primaryGreen;
            // Lấy báo cáo tương ứng
            ReportDocument reportDocument = reportManager.GetReport(reportTitle);

            // Truyền tham số vào báo cáo
            if (reportDocument != null)
            {
                switch (reportTitle)
                {
                    // load all lần đầu 
                    case "rp_nhanvien_select_all":
                        //reportDocument.SetParameterValue("@keyword", string.IsNullOrEmpty(txtHoTenNV.Text) ? "" : txtHoTenNV.Text);

                        // Tạo một instance của form bạn muốn hiển thị
                        //var formToDisplay = new FormToDisplay();

                        // Đặt form này như một control con của panelReportControl
                        //formToDisplay.TopLevel = false;
                        //groupBox10.Controls.Add(formToDisplay);

                        // Hiển thị form
                        //formToDisplay.Show();
                        break;

                    default: break;
                }
                // Thêm các tham số khác nếu cần thiết

                crystalReportViewer1.ReportSource = reportDocument;
            }
        }
        private void cboReportChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cbo = (ComboBox)sender;
            if (cbo.SelectedValue != null) // Kiểm tra xem có giá trị được chọn hay không
            {
                var selectedValue = cbo.SelectedValue.ToString(); // Lấy giá trị được chọn

                // Sử dụng selectedValue ở đây
                DataTable dt = chinhanhController.SelectPhongBanByMaCN(selectedValue);
                cboReportPhongBan.DataSource = dt;
                cboReportPhongBan.ValueMember = "MAPB";
                cboReportPhongBan.DisplayMember = "TENPHG";
            }
        }

    }
}
