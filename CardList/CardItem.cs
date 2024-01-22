using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTUD1_BACHHOAXANH472.Model
{
    public class CardItem
    {
        public Image Image { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int Value { get; set; }
        public Color Color { get; set; }
        public Size Size { get; set; }
        public Point Location { get; set; }


        public CardItem()
        {
        }

        public CardItem(Image image, string title, string content, int value, Color color, Size size, Point location)
        {
            Image = image;
            Title = title;
            Content = content;
            Value = value;
            Color = color;
            Size = size;
            Location = location;
        }

       
    }

}
