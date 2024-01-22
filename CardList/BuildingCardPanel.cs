using LTUD1_BACHHOAXANH472.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace LTUD1_BACHHOAXANH472.CardList
{
    public partial class BuildingCardPanel : Form
    {
        public BuildingCardPanel()
        {
            InitializeComponent();
        }

        private void BuildingCardPanel_Load(object sender, EventArgs e)
        {
            // Create a new card list and pass the panel on the form
            CardList cardList = new CardList(panelCard);

            // Create some card items
            CardItem item1 = new CardItem(Properties.Resources.r0, "Card 1", "This is the first card", 100, Color.LightBlue, new Size(200, 200), new Point(0, 0));
            CardItem item2 = new CardItem(Properties.Resources.r1, "Card 2", "This is the second card", 200, Color.LightGreen, new Size(200, 200), new Point(0, 0));
            CardItem item3 = new CardItem(Properties.Resources.r2, "Card 3", "This is the third card", 300, Color.LightPink, new Size(200, 200), new Point(0, 0));
            CardItem item11 = new CardItem(Properties.Resources.r3, "Card 1", "This is the first card", 100, Color.LightBlue, new Size(200, 200), new Point(0, 0));
            CardItem item22 = new CardItem(Properties.Resources.r4, "Card 2", "This is the second card", 200, Color.LightGreen, new Size(200, 200), new Point(0, 0));
            CardItem item33 = new CardItem(Properties.Resources.r5, "Card 3", "This is the third card", 300, Color.LightPink, new Size(200, 200), new Point(0, 0));
            CardItem item111 = new CardItem(Properties.Resources.rr1, "Card 1", "This is the first card", 100, Color.LightBlue, new Size(200, 200), new Point(0, 0));
            CardItem item222 = new CardItem(Properties.Resources.rrr1, "Card 2", "This is the second card", 200, Color.LightGreen, new Size(200, 200), new Point(0, 0));

            // Add the card items to the card list
            cardList.Add(item1);
            cardList.Add(item2);
            cardList.Add(item3);
            cardList.Add(item11);
            cardList.Add(item22);
            cardList.Add(item33);
            cardList.Add(item111);
            cardList.Add(item222);
            // Display the card items in the panel
            cardList.Display();
        }
    }
}
