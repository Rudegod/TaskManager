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
        var Popup = new GroupDetailsPopUp();
        this.ShowPopupAsync(Popup);
    }
}