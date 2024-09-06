namespace TaskManager_V0._1;

public partial class GroupPage : ContentPage
{
	public GroupPage()
	{
        InitializeComponent();
	}

    private void Add (object sender, EventArgs e)
	{
		DisplayAlert("New Group", "Successfully Added", "Back");
	}

    private void Back(object sender, EventArgs e)
    {
        DisplayAlert("Go back to the last page", "Hi", "Go");
    }
}