namespace TaskManager_V0._1;

public partial class PeoplePage : ContentPage
{
	public PeoplePage()
	{
		InitializeComponent();
	}

    private void AddUserButton(object sender, EventArgs e)
    {
        Navigation.PushAsync(new AddUserPage());
    }
}