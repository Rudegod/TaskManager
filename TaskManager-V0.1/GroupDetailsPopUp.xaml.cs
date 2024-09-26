using CommunityToolkit.Maui.Views;

namespace TaskManager_V0._1;

public partial class GroupDetailsPopup : Popup
{
    public GroupDetailsPopup()
    {
        InitializeComponent();
    }

    private void FirstTask(object sender, EventArgs e)
    {
        Close();
        App.Current.MainPage = new NavigationPage(new TaskDetails());
    }
}