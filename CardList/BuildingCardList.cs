using LTUD1_BACHHOAXANH472.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LTUD1_BACHHOAXANH472.CardList
{
    public partial class BuildingCardList : Form
    {
        public BuildingCardList()
        {
            InitializeComponent();
            listBox.DrawMode = DrawMode.OwnerDrawVariable;
            listBox.MeasureItem += ListBox_MeasureItem;
            listBox.DrawItem += ListBox_DrawItem;
            this.Controls.Add(listBox);

        }

        private void BuildingCardList_Load(object sender, EventArgs e)
        {
            CardItem item1 = new CardItem(Properties.Resources.bgshlasinggreen2, "Card 1", "This is the first card", 100, Color.LightBlue, new Size(200, 200), new Point(0, 0));
            CardItem item2 = new CardItem(Properties.Resources.BXHLOGO2, "Card 2", "This is the second card", 200, Color.LightGreen, new Size(200, 200), new Point(0, 0));
            CardItem item3 = new CardItem(Properties.Resources.green_user, "Card 3", "This is the third card", 300, Color.LightPink, new Size(200, 200), new Point(0, 0));
            CardItem[] items = new CardItem[] { item1, item2, item3 };
            listBox.Items.AddRange(items);
        }
        private void ListBox_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            e.ItemHeight = 200;
        }

        private void ListBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            CardItem item = listBox.Items[e.Index] as CardItem;
            CardControl control = new CardControl(item);
            Bitmap bitmap = new Bitmap(control.Width, control.Height);
            control.DrawToBitmap(bitmap, new Rectangle(0, 0, control.Width, control.Height));
            e.Graphics.DrawImage(bitmap, e.Bounds.X, e.Bounds.Y);
        }
        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the selected item
            CardItem item = listBox.SelectedItem as CardItem;
            if (item == null) return;
            
            // Create a new user control to display the selected item with red border
            CardControl control = new CardControl(item);
            control.BorderStyle = BorderStyle.FixedSingle; // Set the border style to fixed single
            control.BackColor = Color.Red; // Set the border color to red
            
            // Create a bitmap from the user control
            Bitmap bitmap = new Bitmap(control.Width, control.Height);
            control.DrawToBitmap(bitmap, new Rectangle(0, 0, control.Width, control.Height));

            // Get the graphics object of the list box
            Graphics g = listBox.CreateGraphics();

            // Draw the bitmap on the selected item
            g.DrawImage(bitmap, item.Location.X, item.Location.Y);
        }
    }
}
