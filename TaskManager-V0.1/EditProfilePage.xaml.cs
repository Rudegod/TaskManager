namespace TaskManager_V0._1;

public partial class EditProfilePage : ContentPage
{
	public EditProfilePage()
	{
		InitializeComponent();
	}
    private async void OnSaveChangesClicked(object sender, EventArgs e)
    {
        // Here you would add logic to save the user data
        await DisplayAlert("Success", "Your changes have been saved!", "OK");
    }

    private async void OnCancelClicked(object sender, EventArgs e)
    {
        // Navigate back or discard changes
        bool confirm = await DisplayAlert("Confirm", "Are you sure you want to cancel?", "Yes", "No");
        if (confirm)
        {
            await Navigation.PopAsync();
        }
    }
}