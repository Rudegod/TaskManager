namespace TaskManager_V0._1;

public partial class HomePage : ContentPage
{
	public HomePage()
	{
		InitializeComponent();
	}

    private void groupButton(object sender, EventArgs e)
    {
        //App.Current.MainPage = new NavigationPage(new GroupPage());
        var groupPage = new GroupPage();
        Navigation.PushAsync(groupPage);
    }

    private void peopleButton(object sender, EventArgs e)
    {
        //App.Current.MainPage = new NavigationPage(new MemberPage());
        var memberPage = new MemberPage();
        Navigation.PushAsync(memberPage);
    }

    private void domainButton(object sender, EventArgs e)
    {

    }

    private void taskButton(object sender, EventArgs e)
    {

    }
}