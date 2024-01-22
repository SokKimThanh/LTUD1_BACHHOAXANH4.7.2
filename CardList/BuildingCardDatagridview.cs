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
    public partial class BuildingCardDatagridview : Form
    {
        DataGridView dataGridView;
        public BuildingCardDatagridview()
        {
            InitializeComponent();

            dataGridView = new DataGridView();

            //dataGridView.View = View.LargeIcon;
            dataGridView.Dock = DockStyle.Fill;
            //dataGridView.ItemSize = new Size(200, 200);
            //dataGridView.DrawMode = DrawMode.OwnerDrawVariable;
            //dataGridView.MeasureItem += DataGridView_MeasureItem;
            //dataGridView.DrawItem += DataGridView_DrawItem;
        }

        private void BDatagridCard_Load(object sender, EventArgs e)
        { 
            this.Controls.Add(dataGridView);
            CardItem item1 = new CardItem(Properties.Resources.banner, "Card 1", "This is the first card", 100, Color.LightBlue, new Size(200, 200), new Point(0, 0));
            CardItem item2 = new CardItem(Properties.Resources.banner, "Card 2", "This is the second card", 200, Color.LightGreen, new Size(200, 200), new Point(0, 0));
            CardItem item3 = new CardItem(Properties.Resources.banner, "Card 3", "This is the third card", 300, Color.LightPink, new Size(200, 200), new Point(0, 0));

            dataGridView.Rows.Add(item1);
            dataGridView.Rows.Add(item2);
            dataGridView.Rows.Add(item3);

            
        }
        private void DataGridView_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            e.ItemHeight = 200;
        }

        private void DataGridView_DrawItem(object sender, DrawItemEventArgs e)
        {
            //DataRow row = dataGridView.Rows[e.Index];
            //CardItem item = row[0] as CardItem;
            //CardControl control = new CardControl(item);
            //Bitmap bitmap = new Bitmap(control.Width, control.Height);
            //control.DrawToBitmap(bitmap, new Rectangle(0, 0, control.Width, control.Height));
            //e.Graphics.DrawImage(bitmap, e.Bounds.X, e.Bounds.Y);
        }

    }
}
