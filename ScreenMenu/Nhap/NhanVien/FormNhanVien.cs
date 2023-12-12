using System;
using System.Data;
using System.Windows.Forms;

namespace LTUD1_BACHHOAXANH472.Screen
{
    public partial class FormNhanVien : Form
    {
        NhanVienController nvController = new NhanVienController(Utils.ConnectionString);
        InFilePDFExcel infile;
        ButtonStateManager buttonStateManager = new ButtonStateManager();
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
            buttonStateManager.BtnAdd = this.btnAdd;
            buttonStateManager.BtnEdit = this.btnEdit;
            buttonStateManager.BtnDelete = this.btnDelete;
            buttonStateManager.BtnRefresh = this.btnRefresh;
        }

        private void FormNhanVien_Load(object sender, EventArgs e)
        {
            try
            {

                nvController.SelectAll();
                dgvNhanVien.DataSource = nvController.DataSource;
                DataTable dt = nvController.GetDanhSachPhongBan();
                cboPhongBan.DataSource = dt;
                cboPhongBan.ValueMember = "MAPB";
                cboPhongBan.DisplayMember = "TENPHG";

                infile = new InFilePDFExcel(dgvNhanVien);

                // crud button setting state
                buttonStateManager.UpdateButtonStates("form_loaded");
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

                nvController.SelectAll();
                //DataRow dongcuoicung = nccController.DataSource.Rows[nccController.DataSource.Rows.Count - 1];
                DataRow dongdautien = nvController.DataSource.Rows[0];
                // id tự động tăng
                //string id_cuoi = (string)dongcuoicung["NhanVienID"];
                string id_dau = (string)dongdautien["NhanVienID"];
                string maNV = GenerateID.generateID("nv", id_dau);

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
                buttonStateManager.UpdateButtonStates("refresh_clicked");
                refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                rtbDiaChi.Text = ex.Message;
            }


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
                buttonStateManager.UpdateButtonStates("datagridview_selected");
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
            buttonStateManager.UpdateButtonStates("refresh_clicked");
            refresh();
        }

        private void txtHoTenNV_TextChanged(object sender, EventArgs e)
        {
            buttonStateManager.UpdateButtonStates("adding_textChanged");
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int dong = dgvNhanVien.CurrentCell.RowIndex;
                string manv = dgvNhanVien.Rows[dong].Cells[0].Value.ToString();
                nvController.Delete(manv);
                buttonStateManager.UpdateButtonStates("refresh_clicked");
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

                buttonStateManager.UpdateButtonStates("refresh_clicked");
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


    }
}
