using CommunityToolkit.Maui.Views;
using System.Globalization;
namespace TaskManager_V0._1;

public partial class addMemberPopup : Popup
{
    private bool f = false;
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
        Close();
    }

    private void checker(object sender, EventArgs e)
    {
        if (FullNameEntry is null)
        {
            nameError.isVisible = true;
            f = false;
        }
        if (UserNameEntry is null || !checkUsernameExist(UserNameEntry.Text)) {
            userError.isVisible = true;
            f = false;
        }
        if (!checkPassword())
        {
            passwordError.isVisible = true;
            f = false;
        }
        if(AgeEntry.Text is null)
        {
            ageError.isVisible = true;
            f = false;
        }
        if (PhoneEntry.Text is null)
        {
            phoneError.isVisible = true;
            f = false;
        }
        if (NationalEntry.Text is null)
        {
            nationalError.isVisible = true;
            f = false;
        }
        if (f)
            addMember();
        else
            return;

    }

    private bool checkPassword()
    {
        if(PasswordEntry.Text is null)
            return false;
        if(PasswordEntry.Text.Length < 8)
            return false;
        bool one = false, two = false, three = false, four = false;
        foreach (char c in PasswordEntry.Text) 
        {
            if(char.IsUpper(c))
                one = true;
            if(char.IsLower(c))
                two = true;
            if (char.IsDigit(c))
                three = true;
            if (char.IsSymbol(c))
                four = true;
        }
        if (one && two && three && four)
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

    private void closePopup(object sender, EventArgs e)
    {
        Member.f = false;
        Close();
    }
}