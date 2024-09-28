using CommunityToolkit.Maui.Views;

namespace TaskManager_V0._1;

public partial class ProfiePage : ContentPage
{
    public ProfiePage()
	{
		InitializeComponent();
        membersList.ItemsSource = MemberData.members;
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

    private void EditProfileButton(object sender, EventArgs e)
    {
        Navigation.PushModalAsync (new EditProfilePage());
    }

    private void BackButton(object sender, EventArgs e)
    {
        App.Current.MainPage = new HomePage();
    }
}