using LTUD1_BACHHOAXANH472.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LTUD1_BACHHOAXANH472.CardList
{
    public class CardList : List<CardItem>
    {
        public Panel Panel { get; set; }

        public CardList(Panel panel)
        {
            Panel = panel;
        }

        public void LoadData(string source)
        {
            // Implement the logic to load data from the source
        }

        public void SaveData(string destination)
        {
            // Implement the logic to save data to the destination
        }

        public void Display()
        {
            // Clear the panel
            Panel.Controls.Clear();

            // Loop through the card items
            foreach (CardItem item in this)
            {
                // Create a new card control for each item
                CardControl control = new CardControl(item);

                // Add the control to the panel
                Panel.Controls.Add(control);
            }
        }
    }

}
