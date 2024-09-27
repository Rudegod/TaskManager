using CommunityToolkit.Maui.Views;
using System.Globalization;
namespace TaskManager_V0._1;

public partial class addMemberPopup : Popup
{
    private bool f = true;
    public addMemberPopup()
    {
        InitializeComponent();
    }

    private void addMember()
    {
        MemberData.fullName = FullNameEntry.Text;
        MemberData.userName = UserNameEntry.Text;
        MemberData.password = PasswordEntry.Text;
        MemberData.age = Convert.ToInt32(AgeEntry.Text);
        MemberData.phone = PhoneEntry.Text;
        MemberData.nationalCode = NationalEntry.Text;
        Member.f = true;
        f = true;
        Close();
    }

    private void checker(object sender, EventArgs e)
    {
        if (FullNameEntry is null)
        {
            nameError.IsVisible = true;
            f = false;
        }
        else
            nameError.IsVisible = false;

        if (UserNameEntry is null || checkUsernameExist(UserNameEntry.Text))
        {
            usernameError.IsVisible = true;
            f = false;
        }
        else
            usernameError.IsVisible = false;

        if (!checkPassword())
        {
            passwordError.IsVisible = true;
            f = false;
        }
        else
            passwordError.IsVisible = false;

        if (AgeEntry.Text is null)
        {
            ageError.IsVisible = true;
            f = false;
        }
        else
            ageError.IsVisible = false;

        if (PhoneEntry.Text is null)
        {
            phoneError.IsVisible = true;
            f = false;
        }
        else
            phoneError.IsVisible = false;

        if (NationalEntry.Text is null)
        {
            nationalError.IsVisible = true;
            f = false;
        }
        else
            nationalError.IsVisible = false;

        if (genderPicker.SelectedItem is null)
        {
            genderError.IsVisible = true;
            f = false;
        }
        else
            genderError.IsVisible = false;

        if (activeOption.SelectedItem is null)
        {
            activeError.IsVisible = true;
            f = false;
        }
        else
            activeError.IsVisible = false;

        if (f)
            addMember();
        else
        {
            f = true;
            return;
        }

    }

    private bool checkPassword()
    {
        if (PasswordEntry.Text is null)
            return false;
        if (PasswordEntry.Text.Length < 8)
            return false;
        bool one = false, two = false, three = false, four = false;
        foreach (char c in PasswordEntry.Text)
        {
            if (char.IsUpper(c))
                one = true;
            if (char.IsLower(c))
                two = true;
            if (char.IsDigit(c))
                three = true;
        }
        if (one && two && three)
        {
            return true;
        }
        return false;

    }

    public bool checkUsernameExist(string userName)
    {
        foreach (Member member in MemberData.members)
        {
            if (userName == member.userName)
            {
                return true;
            }
        }
        return false;
    }



    private void Genderpicker(object sender, EventArgs e)
    {
        var picker = (Picker)sender;
        var selectedItem = (string)picker.SelectedItem;
        if (selectedItem == "male")
        {
            MemberData.gender = true;
        }
        else
            MemberData.gender = false;
    }


    private void activeOptionPicker(object sender, EventArgs e)
    {
        var picker = (Picker)sender;
        var selectedItem = (string)picker.SelectedItem;
        if (selectedItem == "active")
        {
            MemberData.gender = true;
        }
        else
            MemberData.gender = false;
    }

    private void closePopup(object sender, EventArgs e)
    {
        Member.f = false;
        Close();
    }
    private async void OnChooseProfileClicked(object sender, EventArgs e)
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