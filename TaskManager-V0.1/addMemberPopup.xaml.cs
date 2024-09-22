using CommunityToolkit.Maui.Views;
namespace TaskManager_V0._1;

public partial class addMemberPopup : Popup
{
	public addMemberPopup()
	{
		InitializeComponent();
	}

    private void addMember(object sender, EventArgs e)
    {
        MemberData.fullName = FullNameEntry.Text;
        MemberData.userName = UserNameEntry.Text;
        MemberData.password = PasswordEntry.Text;
        MemberData.age = AgeEntry.Text;
        MemberData.phone = PhoneEntry.Text;
        MemberData.nationalCode = NationalEntry.Text;
        Close();
    }

    private void Genderpicker(object sender, EventArgs e)
    {
        var picker = (Picker)sender;
        var selectedItem = (string)picker.SelectedItem;
        if (selectedItem == "male") {
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
}