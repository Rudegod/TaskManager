using System.Collections.ObjectModel;
using TaskManager_V0._1;
using TaskManager_V0._1.viewmodel;

public partial class UsersPage : ContentPage
{
    public UsersPage()
    {
        InitializeComponent();

    }

    private void Add(object sender, EventArgs e)
    {
        Navigation.PushModalAsync(new AddUserPage());
    }
}
