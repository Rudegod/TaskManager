using Microsoft.Maui.Storage;
using System.IO.Enumeration;

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
            await Navigation.PopModalAsync();
        }
    }

    private async void OnChangeProfileClicked(object sender, EventArgs e)
    {
        try
        {
            var fileTypes = new FilePickerFileType(new Dictionary<DevicePlatform, IEnumerable<string>>()
            {
                { DevicePlatform.iOS, new[] { "public.image" } }, // iOS image types
                { DevicePlatform.Android, new[] { "image/*" } }, // Android image types
                { DevicePlatform.WinUI, new[] { ".jpg", ".jpeg", ".png", ".gif", ".bmp" } } // Windows image types
            });

            // Open the file picker with specified file types
            var result = await FilePicker.PickAsync(new PickOptions
            {
                PickerTitle = "Pick an Image",
                FileTypes = fileTypes
            });

            if (result != null)
            {
                // Get the file's path
                var filePath = result.FullPath;
                // You can also access the file's stream if needed
                using (var stream = await result.OpenReadAsync())
                {
                    // Process the file stream as needed
                }

                // Update the label to show the picked file
                //FileLabel.Text = $"Picked file: {result.FileName}";
            }
        }
        catch (Exception ex)
        {
            // Handle any exceptions, such as user cancellation
            //FileLabel.Text = $"Error picking file: {ex.Message}";
        }
    }
}