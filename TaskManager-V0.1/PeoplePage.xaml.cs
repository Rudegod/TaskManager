using CommunityToolkit.Maui.Core;
using CommunityToolkit.Maui.Views;

namespace TaskManager_V0._1;

public partial class PeoplePage : ContentPage
{
    public PeoplePage()
    {
        InitializeComponent();
        membersList.ItemsSource = MemberData.members;
    }
    private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
        DisplayAlert("here", "It works", "ahaaa");
    }

    private void TapGestureRecognizer_Tapped_1(object sender, TappedEventArgs e)
    {
        Navigation.PushAsync(new MemberPage());
    }
}