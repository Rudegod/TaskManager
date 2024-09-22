using Microsoft.Maui.Controls;
using CommunityToolkit.Mvvm.ComponentModel;

namespace TaskManager_V0._1;

public partial class AddGroupPage : ContentPage
{
	public AddGroupPage()
	{
		InitializeComponent();
	}

    private async void OKButton(object sender, EventArgs e)
    {
        var groupName = GroupNameEntry.Text;
        var description = DescriptionEntry.Text;

        if (string.IsNullOrEmpty(groupName) || string.IsNullOrEmpty(description))
        {
            await DisplayAlert("Error", "Please enter both group name and description.", "OK");
            return;
        }

        // Logic to add group to your data source
        // Example:
        // GroupPage.Groups.Add(new Group { GroupName = groupName, Description = description });

        await Navigation.PopAsync();
    }
}