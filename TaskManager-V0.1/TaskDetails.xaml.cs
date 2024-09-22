using CommunityToolkit.Maui.Views;

namespace TaskManager_V0._1;

public partial class TaskDetails : ContentPage
{
	public TaskDetails()
	{
		InitializeComponent();
	}

    private void FirstGroup(object sender, EventArgs e)
    {
        var Popup = new GroupDetailsPopup();
        this.ShowPopupAsync(Popup);
    }

    private void OnBackButtonClicked(object sender, EventArgs e)
    {
        App.Current.MainPage = (new HomePage());
    }
}