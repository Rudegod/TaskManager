using CommunityToolkit.Maui.Views;

namespace TaskManager_V0._1;

public partial class ProfiePage : ContentPage
{
	public ProfiePage()
	{
		InitializeComponent();
	}

    private void GroupPopUp(object sender, EventArgs e)
    {
        var Popup = new GroupDetailsPopup();
        this.ShowPopupAsync(Popup);
    }
    private void GroupPopUp2(object sender, EventArgs e)
    {
        var Popup2 = new GroupDetailsPopUp2();
        this.ShowPopupAsync(Popup2);
    }
}