using Microsoft.Maui.ApplicationModel;
using Microsoft.Maui.Controls;

namespace TaskManager_V0._1;

public partial class HomePage : ContentPage
{
    private bool _isMenuOpen = false;
    public HomePage()
	{
        InitializeComponent();
        // Set initial position of the menu off-screen
        OnHamburger.TranslationX = -OnHamburger.Width;
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

    private async void OnHamburgerMenuClicked(object sender, EventArgs e)
    {
        if (_isMenuOpen)
        {
            await CloseMenu();
        }
        else
        {
            await OpenMenu();
        }
    }

    private async Task OpenMenu()
    {
        OnHamburger.IsVisible = true;
        await OnHamburger.TranslateTo(0, 0, 300, Easing.CubicInOut);
        _isMenuOpen = true;
    }

    private async Task CloseMenu()
    {
        await OnHamburger.TranslateTo(-OnHamburger.Width, 0, 300, Easing.CubicInOut);
        _isMenuOpen = false;
    }

    private async void OnMainAreaTapped(object sender, TappedEventArgs e)
    {
        if (_isMenuOpen)
        {
            await CloseMenu();
        }
    }
}