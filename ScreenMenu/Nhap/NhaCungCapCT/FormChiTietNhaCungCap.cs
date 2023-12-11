using System;
using System.Windows.Forms;

namespace LTUD1_BACHHOAXANH472
{
    public partial class FormChiTietNhaCungCap : Form
    {
        public FormChiTietNhaCungCap()
        {
            InitializeComponent();
            DataGridViewHelper.ConfigureDataGridView(dataGridView1);
        }

        private void FormChiTietNhaCungCap_Load(object sender, EventArgs e)
        {
              
        }
    }
}
