using CommunityToolkit.Maui.Views;

namespace TaskManager_V0._1;

public partial class AssignPopup : Popup
{
	public AssignPopup()
	{
        InitializeComponent();
	}

    private void closePopup(object sender, EventArgs e)
    {
        Close();
    }
}