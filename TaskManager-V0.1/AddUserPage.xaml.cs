using Microsoft.Maui.Controls;
using TaskManager_V0._1.viewmodel;

namespace TaskManager_V0._1;

public partial class AddUserPage : ContentPage
{
	public AddUserPage()
	{
		InitializeComponent();
        BindingContext = new UsersViewModel();
    }

    private void PreButton(object sender, EventArgs e)
    {

    }
}