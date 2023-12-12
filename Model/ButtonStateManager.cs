using iTextSharp.text;
using System.Drawing;
using System.Windows.Forms;


public class ButtonStateManager : CustomButtonHelper
{
    public ButtonStateManager(Button add, Button edit, Button delete, Button refresh)
    {
        this.BtnAdd = add;
        this.BtnEdit = edit;
        this.BtnDelete = delete;
        this.BtnRefresh = refresh;

        SetProperties(BtnAdd);
        SetProperties(BtnEdit);
        SetProperties(BtnDelete);
        SetProperties(BtnRefresh);
    }

    public Button BtnAdd { get; set; }
    public Button BtnEdit { get; set; }
    public Button BtnDelete { get; set; }
    public Button BtnRefresh { get; set; }

    public void UpdateButtonStates(string state)
    {
        switch (state)
        {
            case "datagridview_selected":
                BtnAdd.Enabled = false;
                BtnEdit.Enabled = true;
                BtnDelete.Enabled = true;
                BtnRefresh.Enabled = true;
                break;
            case "refresh_clicked":
                BtnAdd.Enabled = true;
                BtnEdit.Enabled = false;
                BtnDelete.Enabled = false;
                BtnRefresh.Enabled = true;
                break;
            case "form_loaded":
                BtnAdd.Enabled = true;
                BtnEdit.Enabled = false;
                BtnDelete.Enabled = false;
                BtnRefresh.Enabled = true;
                break;
            case "adding_textChanged":
                BtnAdd.Enabled = true;
                BtnEdit.Enabled = false;
                BtnDelete.Enabled = false;
                BtnRefresh.Enabled = true;
                break;
            default:
                BtnAdd.Enabled = false;
                BtnEdit.Enabled = false;
                BtnDelete.Enabled = false;
                BtnRefresh.Enabled = false;
                break;
        }
    }
}


