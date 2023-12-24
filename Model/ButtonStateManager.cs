using System.Windows.Forms;

public enum ButtonState
{
    DataGridViewSelected,
    Clicked,
    FormLoaded,
    RefreshClicked
}
public class ButtonStateManager : CustomButtonHelper
{
    public Button BtnAdd { get; set; }
    public Button BtnEdit { get; set; }
    public Button BtnDelete { get; set; }
    public Button BtnRefresh { get; set; }

    public void UpdateButtonStates(ButtonState state)
    {
        switch (state)
        {
            case ButtonState.DataGridViewSelected:
                BtnAdd.Enabled = false;
                
           
                BtnRefresh.Enabled = true;
                break;
            case ButtonState.RefreshClicked:
            case ButtonState.FormLoaded:
                BtnAdd.Enabled = true;
                
                BtnRefresh.Enabled = true;
                break;
            default:
                BtnAdd.Enabled = false;
                
                BtnRefresh.Enabled = false;
                break;
        }
    }
}


