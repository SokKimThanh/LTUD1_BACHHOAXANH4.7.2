using CrystalDecisions.Shared;
using LTUD1_BACHHOAXANH4._7._2.ScreenMenu.Nhap.NhanVien;
using LTUD1_BACHHOAXANH472.ScreenMenu.Nhap.DiaDiem;
using System;
using System.Data;
using System.Windows.Forms;

namespace LTUD1_BACHHOAXANH472
{
    public partial class FormNhanVien : Form
    {
        // khởi tạo kết nối
        NhanVienController nvController = new NhanVienController(Utils.ConnectionString);
        DiaDiemController chinhanhController = new DiaDiemController(Utils.ConnectionString);

        // khởi tạo in
     /*   InFilePDFExcel infile;*/
        // khởi tạo trạng thái cho nút 
        ButtonStateManager buttonStateManager;



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

                // crud button setting state
                buttonStateManager.UpdateButtonStates(ButtonState.FormLoaded);
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
/*                infile.ExportToPDF();*/
            });
        }
        private void tsmInFileExcel_Click(object sender, EventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                // Mã hiển thị hộp thoại của bạn ở đây 
/*                infile.ExportToExcel();*/
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
            //try
            //{
            //    // Khởi tạo một đối tượng mới từ lớp CrystalReport1
            //    CrystalReport1 rpt = new CrystalReport1();

            //    // Khởi tạo một đối tượng mới từ lớp ParameterValues để chứa các giá trị tham số
            //    ParameterValues paramMaPhongBan = new ParameterValues();
            //    ParameterValues paramMaChiNhanh = new ParameterValues();

            //    // Khởi tạo một đối tượng mới từ lớp ParameterDiscreteValue để chứa một giá trị tham số rời rạc
            //    ParameterDiscreteValue pdvMaPB = new ParameterDiscreteValue();
            //    ParameterDiscreteValue pdvMaCN = new ParameterDiscreteValue();

            //    // Đặt giá trị của pdv bằng giá trị trong textBox1
            //    pdvMaPB.Value = cboReportPhongBan.SelectedValue;
            //    pdvMaCN.Value = cboReportChiNhanh.SelectedValue;
            //    // Thêm pdv vào danh sách các giá trị tham số
            //    paramMaPhongBan.Add(pdvMaPB);
            //    paramMaChiNhanh.Add(pdvMaCN);
            //    // Áp dụng các giá trị tham số hiện tại cho tham số "@masv" trong định nghĩa dữ liệu của báo cáo
            //    rpt.DataDefinition.ParameterFields["@MaPhongBan"].ApplyCurrentValues(paramMaPhongBan);
            //    rpt.DataDefinition.ParameterFields["@MaChiNhanh"].ApplyCurrentValues(paramMaChiNhanh);

            //    // Đặt nguồn báo cáo cho crystalReportViewer1 là báo cáo rpt
            //    crystalReportViewer1.ReportSource = rpt;
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void btnTimKiemThongKe_Click(object sender, EventArgs e)
        {
            try
            {
                // Khởi tạo một đối tượng mới từ lớp CrystalReport1
                CrystalReport1 rpt = new CrystalReport1();

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

    }
}
