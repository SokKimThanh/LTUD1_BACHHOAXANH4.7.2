using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LTUD1_BACHHOAXANH472.Model
{
    public partial class CardControl : UserControl
    {
        public CardControl()
        {
            InitializeComponent();
        }
        public CardControl(CardItem item)
        {
            InitializeComponent();
            pictureBox.Image = item.Image;
            labelTitle.Text = item.Title;
            labelContent.Text = item.Content;
            labelValue.Text = item.Value.ToString();
            this.BackColor = item.Color;
            this.Size = item.Size;
            this.Location = item.Location;
        }

        private void CardControl_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You clicked on " + labelTitle.Text);
        }

        private void labelTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
