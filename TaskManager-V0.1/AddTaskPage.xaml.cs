using Microsoft.Maui.Controls;
using Microsoft.VisualBasic;

namespace TaskManager_V0._1;

public partial class AddTaskPage : ContentPage
{
	public AddTaskPage()
	{
        InitializeComponent();
    }

    private void PreShowButton(object sender, EventArgs e)
    {
        Popup.IsVisible = true;
    }

    private void PreCloseButton(object sender, EventArgs e)
    {
        Popup.IsVisible = false;
    }

    private void CouShowButton(object sender, EventArgs e)
    {
        Popup2.IsVisible = true;
    }

    private void CouCloseButton(object sender, EventArgs e)
    {
        Popup2.IsVisible = false;
    }

    private void ManagerShowButton(object sender, EventArgs e)
    {
        Popup3.IsVisible = true;
    }

    private void ManagerCloseButton(object sender, EventArgs e)
    {
        Popup3.IsVisible = false;
    }

    private void PreviousShowButton(object sender, EventArgs e)
    {
        Popup4.IsVisible = true;
    }

    private void PreviousCloseButton(object sender, EventArgs e)
    {
        Popup4.IsVisible = false;
    }

    private void OKButton(object sender, EventArgs e)
    {
        // Navigation.PushAsync(new TaskPage());
        App.Current.MainPage = new TaskPage();
    }

    private void AssignShowButton(object sender, EventArgs e)
    {
        Popup6.IsVisible = true;
    }

    private void AssignCloseButton(object sender, EventArgs e)
    {
        Popup6.IsVisible = false;
    }
}