using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using LTUD1_BACHHOAXANH472.Model;
using LTUD1_BACHHOAXANH472.ScreenMenu.Nhap.NhanVien;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Windows.Forms;
namespace LTUD1_BACHHOAXANH472
{
    public partial class FormNhanVien : Form
    {
        // khởi tạo kết nối
        NhanVienController nvController = new NhanVienController(Utils.ConnectionString);
        DiaDiemController chinhanhController = new DiaDiemController(Utils.ConnectionString);

        // giả định rằng đang có 1 textbox trên màn hình
        //TextBox txtTieuDeReport;


        // khởi tạo in
        //InFilePDFExcel infile;

        // khởi tạo trạng thái cho nút 
        ButtonStateManager buttonStateManager;

        // Khởi tạo report quản lý report
        private ReportManager reportManager;

        ErrTxt errtxt;

        ErrColors color;

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

            // chỉnh style nút tìm kiếm
            CustomButtonHelper customButtonHelper = new CustomButtonHelper();
            customButtonHelper.SetProperties(btnImport);

            // Khởi tạo ReportManager với đường dẫn đến thư mục chứa các báo cáo
            reportManager = new ReportManager(Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName, @"ScreenMenu\Nhap\NhanVien"));

            // khởi tạo kiểm tra ô nhập
            errtxt = new ErrTxt(this);

            // khởi tạo tô màu
            color = new ErrColors();
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

                /* infile = new InFilePDFExcel(dgvNhanVien);*/



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


                //infile = new InFilePDFExcel(dgvNhanVien);

                // crud button setting state
                buttonStateManager.UpdateButtonStates(ButtonState.FormLoaded);

                // hiển thị danh sach báo cáo
                reportManager.LoadReports();

                // Thêm các tiêu đề báo cáo vào TreeView
                foreach (string reportTitle in reportManager.GetReportTitles())
                {
                    TreeNode newNode = new TreeNode(reportTitle);
                    newNode.Name = reportTitle;
                    tvReport.Nodes.Add(newNode);
                }

                // Nếu có ít nhất một báo cáo, hiển thị báo cáo đầu tiên
                //if (tvReport.Nodes.Count > 0)
                //{
                //    tvReport.SelectedNode = tvReport.Nodes[0];
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvNhanVien_Click(object sender, EventArgs e)
        {
            try
            {
                // Khởi tạo số dòng đang chọn
                int dong = dgvNhanVien.CurrentCell.RowIndex;
                // lấy ra mã
                string id = dgvNhanVien.Rows[dong].Cells[0].Value.ToString();
                // khởi tạo đối tượng bằng mã
                DataTable dt = nvController.SelectByID(id);
                DataRow dr = dt.Rows[0];

                // chuyển thành class đối tượng
                NhanVien o = (NhanVien)nvController.FromDataRow(dr);

                // thiết lập dữ liệu ngược lại mỗi lần click
                txtHoTenNV.Text = o.Hotennv;
                txtLuong.Text = o.Luong.ToString();
                txtSDT.Text = o.Sdtnv.ToString();
                rtbDiaChi.Text = o.Diachinv;
                cboPhongBan.SelectedValue = o.Mapb;// chay duoc
                rptNgaySinh.Value = o.Ngaysinh;//  chay duoc
                // kiêm tra giới tính để chọn đúng control
                if (o.Gioitinh.Equals("nam"))
                {
                    rbNam.Checked = true;
                }
                else if (o.Gioitinh.Equals("nu"))
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
            // Chuyển đến tabReport 
            // chọn tab danh sách để tìm kiếm thì
            if (tcNhanVien.SelectedTab.Name.Equals("tbDanhSachNhanVien"))
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
            else
            {
                //TaiLaiDanhSachBaoCao();
            }
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {

            buttonStateManager.UpdateButtonStates(ButtonState.RefreshClicked);
            refresh();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ErrFrm.DialogConfirm("bạn muốn xóa không?"))
                {
                    int dong = dgvNhanVien.CurrentCell.RowIndex;
                    string manv = dgvNhanVien.Rows[dong].Cells[0].Value.ToString();
                    nvController.Delete(manv);
                    buttonStateManager.UpdateButtonStates(ButtonState.RefreshClicked);
                    refresh();
                }
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
                //infile.ExportToPDF();
            });
        }
        private void tsmInFileExcel_Click(object sender, EventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                // Mã hiển thị hộp thoại của bạn ở đây 
                //infile.ExportToExcel();
            });
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                // After the other action is performed, re-select the previously selected node
                tvReport.SelectedNode = selectedNode;

                // Chuyển đến tabReport 
                // chọn tab danh sách để tìm kiếm thì
                if (tcNhanVien.SelectedTab.Name.Equals("tbDanhSachNhanVien"))
                {
                    dgvNhanVien.DataSource = nvController.Search(txtHoTenNV.Text);
                }
                else
                {
                    // Khởi tạo một đối tượng mới từ lớp rp_nhanvien_nvtheophongban
                    rp_nhanvien_select_all rpt = new rp_nhanvien_select_all();

                    // Khởi tạo một đối tượng mới từ lớp ParameterValues để chứa các giá trị tham số
                    //ParameterValues paramMaPhongBan = new ParameterValues();
                    //ParameterValues paramMaChiNhanh = new ParameterValues();

                    // Khởi tạo một đối tượng mới từ lớp ParameterDiscreteValue để chứa một giá trị tham số rời rạc
                    //ParameterDiscreteValue pdvMaPB = new ParameterDiscreteValue();
                    //ParameterDiscreteValue pdvMaCN = new ParameterDiscreteValue();

                    // Đặt giá trị của pdv bằng giá trị trong textBox1
                    //pdvMaPB.Value = cboReportPhongBan.SelectedValue.ToString();
                    //pdvMaCN.Value = cboReportChiNhanh.SelectedValue.ToString();
                    // Thêm pdv vào danh sách các giá trị tham số
                    //paramMaPhongBan.Add(pdvMaPB);
                    //paramMaChiNhanh.Add(pdvMaCN);
                    // Áp dụng các giá trị tham số hiện tại cho tham số "@masv" trong định nghĩa dữ liệu của báo cáo
                    //rpt.DataDefinition.ParameterFields["@MaPhongBan"].ApplyCurrentValues(paramMaPhongBan);
                    //rpt.DataDefinition.ParameterFields["@MaChiNhanh"].ApplyCurrentValues(paramMaChiNhanh);

                    // tim theo từng loại báo cáo
                    //Khởi tạo một đối tượng mới từ lớp ParameterValues để chứa các giá trị tham số
                    ParameterValues paramHOTENNV = new ParameterValues();


                    //Khởi tạo một đối tượng mới từ lớp ParameterDiscreteValue để chứa một giá trị tham số rời rạc
                    ParameterDiscreteValue pdvHOTENNV = new ParameterDiscreteValue();


                    //Đặt giá trị của pdv bằng giá trị trong textBox1
                    pdvHOTENNV.Value = txtHoTenNV.Text.ToString();

                    //Thêm pdv vào danh sách các giá trị tham số
                    paramHOTENNV.Add(pdvHOTENNV);

                    //Áp dụng các giá trị tham số hiện tại cho tham số "@masv" trong định nghĩa dữ liệu của báo cáo
                    rpt.DataDefinition.ParameterFields["@keyword"].ApplyCurrentValues(paramHOTENNV);

                    // Đặt nguồn báo cáo cho crystalReportViewer1 là báo cáo rpt
                    crystalReportViewer1.ReportSource = rpt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        public void ImportBaoCao()
        {

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
                        reportDocument.SetParameterValue("@keyword", string.IsNullOrEmpty(txtHoTenNV.Text) ? "" : txtHoTenNV.Text);
                        break;
                    default: break;
                }
                // Thêm các tham số khác nếu cần thiết

                crystalReportViewer1.ReportSource = reportDocument;
            }
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                nvController.SelectAll();
                //DataRow dongcuoicung = nccController.DataSource.Rows[nccController.DataSource.Rows.Count - 1];
                DataRow dongdautien = nvController.DataSource.Rows[0];
                // id tự động tăng
                //string id_cuoi = (string)dongcuoicung["NhanVienID"];
                string id_dau = (string)dongdautien["NhanVienID"];
                string maNV = GenerateID.generateID("o", id_dau);

                string hotennv = txtHoTenNV.Text;
                float luong = float.Parse(txtLuong.Text);
                int sdtnv = int.Parse(txtSDT.Text);
                string diachinv = rtbDiaChi.Text;
                DateTime ngaysinh = rptNgaySinh.Value;
                string mapb = cboPhongBan.SelectedValue.ToString();
                string gioitinh = rbNam.Checked ? "nam" : rbNu.Checked ? "nu" : string.Empty;
                NhanVien o = new NhanVien(maNV, hotennv, diachinv, luong, sdtnv, ngaysinh, mapb, gioitinh);
                nvController.Insert(o);
                nvController.SelectAll();
                dgvNhanVien.DataSource = nvController.DataSource;
                buttonStateManager.UpdateButtonStates(ButtonState.RefreshClicked);
                refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                rtbDiaChi.Text = ex.Message;
            }
        }

        private void txtLuong_TextChanged(object sender, EventArgs e)
        {
            TextHelper.HandleTextChange_Salary(sender);
        }

        private void txtSDT_TextChanged(object sender, EventArgs e)
        {
            TextHelper.HandleTextChange_PhoneNumber(sender);
        }

        private void txtHoTenNV_TextChanged(object sender, EventArgs e)
        {
            // kiểm tra 1 trong 3 cái nào dính thì chặn luôn
            TextHelper.HandleTextChange_FullName(sender);
        }

        private void rtbDiaChi_TextChanged(object sender, EventArgs e)
        {
            TextHelper.HandleTextChange_DiaChi(sender);
        }

        private void tableLayoutPanel6_Paint(object sender, PaintEventArgs e)
        {

        }
        private TreeNode selectedNode;

        private void tvReport_BeforeSelect(object sender, TreeViewCancelEventArgs e)
        {
            selectedNode = e.Node;
        }

        private void tblTimKiemThongTin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flpTimKiemThongTin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cboPhongBan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
