using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using LTUD1_BACHHOAXANH472.Model;
using LTUD1_BACHHOAXANH472.uploads;
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
        ChiNhanhController chinhanhController = new ChiNhanhController(Utils.ConnectionString);
        // khởi tạo trạng thái cho nút 
        ButtonStateManager buttonStateManager;
        // Hàm hỗ trợ kiểm tra lỗi nhập
        ErrTextbox errtxt;
        ErrColors color;
        //==============================================================================
        //--..........................................................................--
        //---------------.     Chia sẽ lazy load report management       .--------------
        //--..........................................................................--
        //==============================================================================
        private ReportManager reportManager;

        public FormNhanVien(ReportManager reportManager)
        {
            InitializeComponent();

            // combobox phong ban setting
            ComboBoxHelper.ConfigureComboBox(cboPhongBan);

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

            // khởi tạo kiểm tra ô nhập
            errtxt = new ErrTextbox(this);

            // khởi tạo tô màu
            color = new ErrColors();

            //==============================================================================
            //--..........................................................................--
            //---------------.     Chia sẽ lazy load report management       .--------------
            //--..........................................................................--
            //==============================================================================
            // Sử dụng ReportManager được chia sẻ từ MainForm
            this.reportManager = reportManager;

            // style chung combobox
            ComboBoxHelper.ConfigureComboBox(cboLoaiBaoCao);
            ComboBoxHelper.ConfigureComboBox(cboNhanVien);
        }

        private void FormNhanVien_Load(object sender, EventArgs e)
        {
            try
            {
                // hiển thị danh sach nhân viên
                nvController.SelectAll();

                // hiển thị danh sach phòng ban
                dgvNhanVien.DataSource = nvController.GetNhanVienCombobox();
                cboPhongBan.ValueMember = "manv";
                cboPhongBan.DisplayMember = "hotennv";

                DataTable dtpb = nvController.GetDanhSachPhongBan();
                cboPhongBan.DataSource = dtpb;
                cboPhongBan.ValueMember = "MAPB";
                cboPhongBan.DisplayMember = "TENPHG";

                // crud button setting state
                buttonStateManager.UpdateButtonStates(ButtonState.FormLoaded);
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
                TaiLaiBaoCao("rp_nhanvien_select_all");
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
                if (!ErrForm.DialogConfirm("bạn muốn xóa không?"))
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                // Chuyển đến tabReport 
                // chọn tab danh sách để tìm kiếm thì
                if (tcNhanVien.SelectedTab.Name.Equals("tbDanhSachNhanVien"))
                {
                    dgvNhanVien.DataSource = nvController.Search(txtHoTenNV.Text);
                }
                else
                {
                    //In tất cả nhân viên
                    //In nhân viên theo tên
                    //In nhân viên theo phòng ban
                    //In ra số lượng nhân viên theo chi nhánh

                    ReportHelper rh = new ReportHelper(reportManager, "rp_nhanvien_select_all", new Dictionary<string, string> { { "@tennhanvien", string.IsNullOrEmpty(txtHoTenNV.Text) ? null : txtHoTenNV.Text } }, this.crystalReportViewer1);
                    rh.LoadReport();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
            TextboxHelper.HandleTextChange_Salary(sender);
        }

        private void txtSDT_TextChanged(object sender, EventArgs e)
        {
            TextboxHelper.HandlePhoneNumber(sender, e);
        }

        private void txtHoTenNV_TextChanged(object sender, EventArgs e)
        {
            // kiểm tra 1 trong 3 cái nào dính thì chặn luôn 
            TextboxHelper.HandleTextChange_FullName(sender);
        }

        private void rtbDiaChi_TextChanged(object sender, EventArgs e)
        {
            TextboxHelper.HandleTextChange_DiaChi(sender);
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            ReportHelper rh = new ReportHelper(reportManager, "rp_nhanvien_select_all", new Dictionary<string, string> { { "@tennhanvien", string.IsNullOrEmpty(txtHoTenNV.Text) ? null : txtHoTenNV.Text } }, this.crystalReportViewer1);


            rh.LoadReport();
        }
        public void TaiLaiBaoCao(string reportTitle)
        {
            // Người dùng vừa chỉnh sửa báo cáo có tiêu đề là reportTitle
            // Các thay đổi đã được lưu vào tệp .rpt tương ứng

            // Bây giờ, chúng ta cần làm mới báo cáo trong ReportManager để nó biết về các thay đổi
            reportManager.RefreshReport(reportTitle);
        }

        private void cboLoaiBaoCao_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox loaibaocao = sender as ComboBox;
            string selectedOptions = loaibaocao.SelectedItem.ToString();
            //ReportHelper rh = new ReportHelper();
            if (NhanVienOptions.TatCaNhanVien.ToFriendlyString().Equals(selectedOptions))
            {
                //lấy ra danh sách tất cả nhân viên
            }
        }
    }
}
