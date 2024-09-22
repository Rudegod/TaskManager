
namespace TaskManager_V0._1;

public partial class SmsPage : ContentPage
{
	public SmsPage()
	{
        InitializeComponent();
	}

    private void LoginButton(object sender, EventArgs e)
    {
        App.Current.MainPage = new NavigationPage(new HomePage());
    }
}