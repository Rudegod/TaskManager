using CommunityToolkit.Maui.Views;

namespace TaskManager_V0._1;

public partial class ManagerPopup : Popup
{
	public ManagerPopup()
	{
		InitializeComponent();
	}

    private void closeButton(object sender, EventArgs e)
    {
		Close();
    }
}