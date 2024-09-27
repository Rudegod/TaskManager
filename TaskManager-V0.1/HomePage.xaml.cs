namespace TaskManager_V0._1;

using Microsoft.Maui.ApplicationModel;
using Microsoft.Maui.Controls;
using System;
using System.Threading.Tasks;



public partial class HomePage : ContentPage
{
    public bool _isMenuOpen = false;

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
       
    }

    private void taskButton(object sender, EventArgs e)
    {
        Navigation.PushAsync(new TaskPage());
    }
    private void ProfileButton(object sender, EventArgs e)
    {
        Navigation.PushModalAsync(new ProfiePage());
    }

    private void OnMainAreaTapped(object sender, TappedEventArgs e)
    {
        if (_isMenuOpen)
        {
            CloseMenu();
        }
    }

    private void HomeButton(object sender, EventArgs e)
    {

    }

    private void MyTasksButton(object sender, EventArgs e)
    {

    }

    private void MyGroupsButton(object sender, EventArgs e)
    {

    }

    private void InboxButton(object sender, EventArgs e)
    {

    }

    private void OnHamburgerMenuClicked(object sender, EventArgs e)
    {
        if (_isMenuOpen)
        {
            CloseMenu();
        }
        else
        {
            OpenMenu();
        }
    }
    private async void OpenMenu()
    {
        OnHamburger.IsVisible = true;
        await OnHamburger.TranslateTo(0, 0, 300);
        _isMenuOpen = true;
    }

    private async void CloseMenu()
    {
        await OnHamburger.TranslateTo(-OnHamburger.Width, 0, 300, Easing.CubicInOut);
        OnHamburger.IsVisible = false;
        _isMenuOpen = false;
    }

    private void Button_Clicked(object sender, EventArgs e)
    {

    }
}