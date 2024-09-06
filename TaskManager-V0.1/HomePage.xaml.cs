namespace TaskManager_V0._1;

public partial class HomePage : ContentPage
{
	public HomePage()
	{
        InitializeComponent();
	}

    private void groupButton(object sender, EventArgs e)
    {
        App.Current.MainPage = new GroupPage();
    }

    private void peopleButton(object sender, EventArgs e)
    {

    }

    private void domainButton(object sender, EventArgs e)
    {

    }

    private void taskButton(object sender, EventArgs e)
    {

    }
}