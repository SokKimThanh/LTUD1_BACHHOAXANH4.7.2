namespace LTUD1_BACHHOAXANH472.model
{

    public class PlaceholderTextBox
    {
        private bool isPlaceholder = true;
        private string placeholderText;
        private TextBox textbox;

        /// <summary>
        /// Thêm chữ cho placeholder
        /// </summary>
        public string PlaceholderText
        {
            get { return placeholderText; }
            set
            {
                placeholderText = value;
                SetPlaceholder();
            }
        }

        public TextBox Textbox { get => textbox; set => textbox = value; }


        private void SetPlaceholder()
        {
            if (string.IsNullOrEmpty(textbox.Text))
            {
                textbox.Text = PlaceholderText;
                textbox.ForeColor = Color.Gray;
                isPlaceholder = true;
            }
        }
        /// <summary>
        /// Sự kiện placeholder
        /// </summary>
        public void SettingPlaceholderTextBox()
        {
            textbox.GotFocus += RemovePlaceholder;
            textbox.LostFocus += AddPlaceholder;
        }

        private void RemovePlaceholder(object sender, EventArgs e)
        {
            if (isPlaceholder)
            {
                textbox.Text = "";
                textbox.ForeColor = Color.Black;
                isPlaceholder = false;
            }
        }

        private void AddPlaceholder(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.textbox.Text))
            {
                textbox.Text = PlaceholderText;
                textbox.ForeColor = Color.Gray;
                isPlaceholder = true;
            }
        }
    }

}

