using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LTUD1_BACHHOAXANH472.model
{

    public class PlaceholderTextBox : TextBox
    {
        private bool isPlaceholder = true;
        private string placeholderText;

        public string PlaceholderText
        {
            get { return placeholderText; }
            set
            {
                placeholderText = value;
                SetPlaceholder();
            }
        }

        private void SetPlaceholder()
        {
            if (string.IsNullOrEmpty(this.Text))
            {
                this.Text = PlaceholderText;
                this.ForeColor = Color.Gray;
                this.isPlaceholder = true;
            }
        }

        public PlaceholderTextBox()
        {
            GotFocus += RemovePlaceholder;
            LostFocus += AddPlaceholder;
        }

        private void RemovePlaceholder(object sender, EventArgs e)
        {
            if (isPlaceholder)
            {
                this.Text = "";
                this.ForeColor = Color.Black;
                this.isPlaceholder = false;
            }
        }

        private void AddPlaceholder(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.Text))
            {
                this.Text = PlaceholderText;
                this.ForeColor = Color.Gray;
                this.isPlaceholder = true;
            }
        }
    }

}

