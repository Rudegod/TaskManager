namespace TaskManager_V0._1;

public partial class ForgotPassPage : ContentPage
{
	public ForgotPassPage()
	{
		InitializeComponent();
	}

    private void ReciveButton(object sender, EventArgs e)
    {
        DisplayAlert("Recive", "Check your email, we send you a code to recover your password", "OK bro" );
    }

    private void BackButton(object sender, EventArgs e)
    {
        App.Current.MainPage = new MainPage();
    }
}