
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using LTUD1_BACHHOAXANH472.Model;
using LTUD1_BACHHOAXANH472.uploads;

namespace LTUD1_BACHHOAXANH472
{
    public partial class FormNhanVien : Form
    {
        // khởi tạo kết nối
        NhanVienController nvController = new NhanVienController(Utils.ConnectionString);
        DiaDiemController chinhanhController = new DiaDiemController(Utils.ConnectionString);

        // giả định rằng đang có 1 textbox trên màn hình
        TextBox txtTieuDeReport;


        // khởi tạo in
        InFilePDFExcel infile;

        // khởi tạo trạng thái cho nút 
        ButtonStateManager buttonStateManager;

        // Khởi tạo report quản lý report
        private ReportManager reportManager;


        // Tạo một từ điển để lưu trữ các báo cáo
        Dictionary<string, ReportDocument> reports = new Dictionary<string, ReportDocument>();

        public FormNhanVien()
        {
            InitializeComponent();

            // combobox phong ban setting
            cboPhongBan.DropDownStyle = ComboBoxStyle.DropDownList;

            // data grid view setting
            DataGridViewHelper.ConfigureDataGridView(dgvNhanVien);

            // data grid view event
            dgvNhanVien.Click += dgvNhanVien_Click;

            rbNam.Checked = true;

            // khởi tạo trạng thái cho nút

            buttonStateManager = new ButtonStateManager();
            // khai báo trạng thái khóa nút 
            buttonStateManager.BtnAdd = this.btnAdd;
            buttonStateManager.BtnEdit = this.btnEdit;
            buttonStateManager.BtnDelete = this.btnDelete;
            buttonStateManager.BtnRefresh = this.btnRefresh;

            // chỉnh style nút
            CustomButtonHelper customButtonHelper = new CustomButtonHelper();
            customButtonHelper.SetProperties(btnTimKiemThongKe);

            txtTieuDeReport = new TextBox();
            txtTieuDeReport.Text = "rp_nhanvien_nvtheophongban";

            // Khởi tạo ReportManager với đường dẫn đến thư mục chứa các báo cáo
            reportManager = new ReportManager(Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName, "uploads"));
        }




        private void FormNhanVien_Load(object sender, EventArgs e)
        {
            try
            {
                // hiển thị danh sach nhân viên
                nvController.SelectAll();

                // hiển thị danh sach phòng ban
                dgvNhanVien.DataSource = nvController.DataSource;
                DataTable dtpb = nvController.GetDanhSachPhongBan();
                cboPhongBan.DataSource = dtpb;
                cboPhongBan.ValueMember = "MAPB";
                cboPhongBan.DisplayMember = "TENPHG";

/*                infile = new InFilePDFExcel(dgvNhanVien);*/



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


                infile = new InFilePDFExcel(dgvNhanVien);

                // crud button setting state
                buttonStateManager.UpdateButtonStates(ButtonState.FormLoaded);


                // Load các báo cáo
                reportManager.LoadReports();

                // Thêm các tiêu đề báo cáo vào TreeView
                foreach (string reportTitle in reportManager.GetReportTitles())
                {
                    TreeNode newNode = new TreeNode(reportTitle);
                    newNode.Name = reportTitle;
                    tvReport.Nodes.Add(newNode);
                }

                // Nếu có ít nhất một báo cáo, hiển thị báo cáo đầu tiên
                if (tvReport.Nodes.Count > 0)
                {
                    tvReport.SelectedNode = tvReport.Nodes[0];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void dgvNhanVien_Click(object sender, EventArgs e)
        {
            try
            {
                // Khởi tạo số dòng đang chọn
                int dong = dgvNhanVien.CurrentCell.RowIndex;
                // lấy ra mã
                string manv = dgvNhanVien.Rows[dong].Cells[0].Value.ToString();
                // khởi tạo đối tượng bằng mã
                DataTable dt = nvController.SelectByID(manv);
                DataRow dr = dt.Rows[0];

                // chuyển thành class đối tượng
                NhanVien nv = (NhanVien)nvController.FromDataRow(dr);

                // thiết lập dữ liệu ngược lại mỗi lần click
                txtHoTenNV.Text = nv.Hotennv;
                txtLuong.Text = nv.Luong.ToString();
                txtSDT.Text = nv.Sdtnv.ToString();
                rtbDiaChi.Text = nv.Diachinv;
                cboPhongBan.SelectedValue = nv.Mapb;// chay duoc
                rptNgaySinh.Value = nv.Ngaysinh;//  chay duoc
                // kiêm tra giới tính để chọn đúng control
                if (nv.Gioitinh.Equals("nam"))
                {
                    rbNam.Checked = true;
                }
                else if (nv.Gioitinh.Equals("nu"))
                {
                    rbNu.Checked = true;
                }
                // cập nhật lại trang thái các nút
                buttonStateManager.UpdateButtonStates(ButtonState.DataGridViewSelected);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public void refresh()
        {
            txtHoTenNV.Text = string.Empty;
            rptNgaySinh.Text = string.Empty;
            rtbDiaChi.Text = string.Empty;
            txtLuong.Text = string.Empty;
            txtSDT.Text = string.Empty;
            cboPhongBan.SelectedIndex = 0;
            nvController.SelectAll();
            dgvNhanVien.DataSource = nvController.DataSource;
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            buttonStateManager.UpdateButtonStates(ButtonState.RefreshClicked);
            refresh();
        }

        private void txtHoTenNV_TextChanged(object sender, EventArgs e)
        {

        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int dong = dgvNhanVien.CurrentCell.RowIndex;
                string manv = dgvNhanVien.Rows[dong].Cells[0].Value.ToString();
                nvController.Delete(manv);
                buttonStateManager.UpdateButtonStates(ButtonState.RefreshClicked);
                refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                //Kiem tra nhap thong tin
                if (ErrTxt.CheckControlValue(txtHoTenNV))
                {
                    MessageBox.Show("txtHoTenNV", "Bắt buộc nhập!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (ErrTxt.CheckControlValue(txtLuong))
                {
                    MessageBox.Show("txtLuong", "Bắt buộc nhập!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    return;
                }
                if (ErrTxt.CheckControlValue(txtSDT))
                {
                    MessageBox.Show("txtSDT", "Bắt buộc nhập!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    return;
                }
                if (ErrTxt.CheckControlValue(rtbDiaChi))
                {
                    MessageBox.Show("rtbDiaChi", "Bắt buộc nhập!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    return;
                }
                if (ErrTxt.CheckControlValue(rptNgaySinh))
                {
                    MessageBox.Show("rptNgaySinh", "Bắt buộc nhập!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    return;
                }

                Random d = new Random();

                int dong = dgvNhanVien.CurrentCell.RowIndex;
                string maNV = dgvNhanVien.Rows[dong].Cells[0].Value.ToString();

                string hotennv = txtHoTenNV.Text;
                float luong = float.Parse(txtLuong.Text);
                int sdtnv = int.Parse(txtSDT.Text);
                string diachinv = rtbDiaChi.Text;
                DateTime ngaysinh = rptNgaySinh.Value;
                string mapb = cboPhongBan.SelectedValue.ToString();
                string gioitinh = rbNam.Checked ? "nam" : rbNu.Checked ? "nu" : string.Empty;
                NhanVien o = new NhanVien(maNV, hotennv, diachinv, luong, sdtnv, ngaysinh, mapb, gioitinh);
                nvController.Update(o);

                buttonStateManager.UpdateButtonStates(ButtonState.RefreshClicked);
                refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                rtbDiaChi.Text = ex.Message;
            }
        }
        private void tsmThongKe_Click(object sender, EventArgs e)
        {
            try
            {
                dgvNhanVien.DataSource = nvController.ThongKeNhanVien();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Thong ke: " + ex.Message);
            }
        }

        private void tsmInFilePDF_Click(object sender, EventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                // Mã hiển thị hộp thoại của bạn ở đây 
                infile.ExportToPDF();
            });
        }
        private void tsmInFileExcel_Click(object sender, EventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                // Mã hiển thị hộp thoại của bạn ở đây 
                infile.ExportToExcel();
            });
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                dgvNhanVien.DataSource = nvController.Search(txtHoTen.Text);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Tim kiem: " + ex.Message);
            }
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            try
            {
                // Khởi tạo một đối tượng mới từ lớp rp_nhanvien_nvtheophongban
                rp_nhanvien_nvtheophongban rpt = new rp_nhanvien_nvtheophongban();

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

        private void btnTimKiemThongKe_Click(object sender, EventArgs e)
        {
            try
            {
                // Khởi tạo một đối tượng mới từ lớp rp_nhanvien_nvtheophongban
                rp_nhanvien_nvtheophongban rpt = new rp_nhanvien_nvtheophongban();

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
        public void ImportBaoCao()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Report Files|*.rpt";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string reportPath = openFileDialog.FileName;
                CrystalDecisions.CrystalReports.Engine.ReportDocument reportDocument = new CrystalDecisions.CrystalReports.Engine.ReportDocument();
                reportDocument.Load(reportPath);
                crystalReportViewer1.ReportSource = reportDocument;
            }

        }

        /// <summary>
        /// Tải report không tham số khác lên để xem báo cáo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnImport_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem người dùng đã nhập tiêu đề báo cáo chưa
            if (string.IsNullOrEmpty(txtTieuDeReport.Text))
            {
                MessageBox.Show("Vui lòng nhập tiêu đề báo cáo.");
                return;
            }

            // Tạo một OpenFileDialog để cho phép người dùng chọn tệp báo cáo
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Report Files|*.rpt";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Tải báo cáo từ tệp đã chọn
                ReportDocument reportDocument = new ReportDocument();
                reportDocument.Load(openFileDialog.FileName);

                // Thêm báo cáo vào từ điển
                reports.Add(txtTieuDeReport.Text, reportDocument);

                // Tạo một TreeNode mới với tiêu đề báo cáo
                TreeNode newNode = new TreeNode(txtTieuDeReport.Text);
                newNode.Name = txtTieuDeReport.Text;

                // Thêm TreeNode vào TreeView
                if (tvReport.SelectedNode == null)
                {
                    // Nếu không có node nào được chọn, thêm node mới vào gốc của TreeView
                    tvReport.Nodes.Add(newNode);
                }
                else
                {
                    // Nếu có node được chọn, thêm node mới làm con của node được chọn
                    tvReport.SelectedNode.Nodes.Add(newNode);
                }

                // Hiển thị báo cáo
                crystalReportViewer1.ReportSource = reportDocument;
            }
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

            // Lấy báo cáo tương ứng
            ReportDocument reportDocument = reportManager.GetReport(reportTitle);

            // Hiển thị báo cáo
            if (reportDocument != null)
            {
                crystalReportViewer1.ReportSource = reportDocument;
            }
        }

    }
}
