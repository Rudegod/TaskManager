using CommunityToolkit.Maui.Views;

namespace TaskManager_V0._1;

public partial class CouplePopup : Popup
{
	public CouplePopup()
	{
		InitializeComponent();
	}

    private void closePopup(object sender, EventArgs e)
    {
		Close();
    }
}