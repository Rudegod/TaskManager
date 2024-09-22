using CommunityToolkit.Maui;
using CommunityToolkit.Maui.Views;

namespace TaskManager_V0._1;

public partial class DescriptionPopUp : Popup
{
	public DescriptionPopUp()
	{
        InitializeComponent();
	}
    public static async Task ShowAsync(string description)
    {
        var popup = new DescriptionPopUp();
        popup.BindingContext = new { Description = description };

        await Application.Current.MainPage.ShowPopupAsync(popup);
    }
}