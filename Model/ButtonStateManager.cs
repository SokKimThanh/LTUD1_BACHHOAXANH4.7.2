using iTextSharp.text;
using System.Drawing;
using System.Windows.Forms;


public class ButtonStateManager
{
    public Button btnAdd { get; set; }
    public Button btnEdit { get; set; }
    public Button btnDelete { get; set; }
    public Button btnRefresh { get; set; }

    public void SetButtonProperties(Button flatButton)
    {
        ErrColors o = new ErrColors();

        Color backColor = o.Transparent;
        FlatStyle flatStyle = FlatStyle.Flat;
        Color borderColor = o.mes_white;
        int borderSize = 1;
        flatButton.BackColor = backColor;
        flatButton.FlatStyle = flatStyle;
        flatButton.FlatAppearance.BorderColor = borderColor;
        flatButton.FlatAppearance.BorderSize = borderSize;
        flatButton.FlatAppearance.MouseOverBackColor = o.primaryPink;
        flatButton.ForeColor = Color.White;

    }

    public void UpdateButtonStates(string state)
    {
        switch (state)
        {
            case "datagridview_selected":
                btnAdd.Enabled = false;
                btnEdit.Enabled = true;
                btnDelete.Enabled = true;
                btnRefresh.Enabled = true;
                break;
            case "refresh_clicked":
                btnAdd.Enabled = true;
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
                btnRefresh.Enabled = true;
                break;
            case "form_loaded":
                btnAdd.Enabled = true;
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
                btnRefresh.Enabled = true;
                break;
            case "adding_textChanged":
                btnAdd.Enabled = true;
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
                btnRefresh.Enabled = true;
                break;
            default:
                btnAdd.Enabled = false;
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
                btnRefresh.Enabled = false;
                break;
        }
    }
}


