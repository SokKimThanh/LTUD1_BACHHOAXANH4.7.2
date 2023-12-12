using System;
using System.Data;
using System.Windows.Forms;

namespace LTUD1_BACHHOAXANH472 { 
public partial class FormTaiKhoan : Form
{
    readonly AccountController controller;


    public FormTaiKhoan()
    {
        InitializeComponent();
        controller = new AccountController(Utils.ConnectionString);
        // data grid view setting
        DataGridViewHelper.ConfigureDataGridView(dgvTaiKhoan);
        dgvTaiKhoan.Click += new EventHandler(DgvTaiKhoan_Click);
    }



    private void FormTaiKhoan_Load(object sender, EventArgs e)
    {
        try
        {
            controller.SelectAll();
            dgvTaiKhoan.DataSource = controller.DataSource;
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }

    private void BtnAdd_Click(object sender, EventArgs e)
    {
        try
        {
            controller.Insert(new Account(txtTenTaiKhoan.Text, txtMK.Text, "", DateTime.Parse(dtpCreatedDate.Value.ToShortDateString()), txtSDT.Text, txtCCCD.Text, txtEmail.Text));
            Reset();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }

    private void Reset()
    {
        try
        {
            controller.SelectAll();
            dgvTaiKhoan.DataSource = controller.DataSource;
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }

    private void BtnXoa_Click(object sender, EventArgs e)
    {
        try
        {
            controller.Delete(txtTenTaiKhoan.Text);
            Reset();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }

    }

    private void BtnSua_Click(object sender, EventArgs e)
    {

        try
        {
            controller.Update(new Account(txtTenTaiKhoan.Text, txtMK.Text, "", txtSDT.Text, txtCCCD.Text, txtEmail.Text));
            Reset();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }

    }



    private void TxtTenTK_TextChanged(object sender, EventArgs e)
    {

    }



    private void DgvTaiKhoan_Click(object sender, EventArgs e)
    {
        int dong = dgvTaiKhoan.CurrentCell.RowIndex;
        txtTenTaiKhoan.Text = dgvTaiKhoan.Rows[dong].Cells[0].Value.ToString();
        DataRow row = controller.SelectByID(txtTenTaiKhoan.Text).Rows[0];

        Account o = (Account)controller.FromDataRow(row);
        if (o != null)
        {
            txtTenTaiKhoan.Text = o.TenTaiKhoan;
            txtSDT.Text = o.Phone;
            txtEmail.Text = o.Email;
            txtCCCD.Text = o.Cccd;
            txtMK.Text = o.MatKhau;
        }
    }
}
}