using Microsoft.Maui.ApplicationModel;
using Microsoft.Maui.Controls;

namespace TaskManager_V0._1;

public partial class HomePage : ContentPage
{
    public HomePage()
	{
        InitializeComponent();
    }

    private void peopleButton(object sender, EventArgs e)
    {
        Navigation.PushAsync(new PeoplePage());
    }

    private void domainButton(object sender, EventArgs e)
    {
        Navigation.PushAsync(new DomainePage());
    }

    private void taskButton(object sender, EventArgs e)
    {
        Navigation.PushAsync(new TaskPage());
    }
    private void ProfileButton(object sender, EventArgs e)
    {
        Navigation.PushModalAsync(new ProfiePage());
    }
}