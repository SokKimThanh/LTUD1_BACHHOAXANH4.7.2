using System.Drawing;
using System.Windows.Forms;


public class CustomButtonHelper
{
    public void SetProperties(Button flatbutton)
    {
        ErrColors o = new ErrColors();
        flatbutton.BackColor = Color.Transparent;
        flatbutton.FlatStyle = FlatStyle.Flat;
        flatbutton.FlatAppearance.BorderColor = Color.White;
        flatbutton.FlatAppearance.BorderSize = 2;
        flatbutton.FlatAppearance.MouseOverBackColor = o.primaryPink;
        flatbutton.FlatAppearance.MouseDownBackColor = o.secondaryPink;
        flatbutton.ForeColor = Color.White;
    }
}


