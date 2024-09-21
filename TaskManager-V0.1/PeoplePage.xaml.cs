namespace TaskManager_V0._1;

public partial class PeoplePage : ContentPage
{
	public PeoplePage()
	{
		InitializeComponent();
        membersList.ItemsSource = TempData.members;
        TempData.members.Add(new Member());
        TempData.members.Add(new Member());
        TempData.members.Add(new Member());
    }

    private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
        DisplayAlert("here", "It works", "ok");
    }

    private void TapGestureRecognizer_Tapped_1(object sender, TappedEventArgs e)
    {
        DisplayAlert("here", "It works", "ahaaa");
    }
}