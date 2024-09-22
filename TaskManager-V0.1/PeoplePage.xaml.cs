using CommunityToolkit.Maui.Core;
using CommunityToolkit.Maui.Views;

namespace TaskManager_V0._1;

public partial class PeoplePage : ContentPage
{
	public PeoplePage()
	{
		InitializeComponent();
        membersList.ItemsSource = MemberData.members;
        //BindingContext = this;
        membersList.ItemsSource = TempData.members;
        TempData.members.Add(new Member());
        TempData.members.Add(new Member());
        TempData.members.Add(new Member());
    }

    private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
        DisplayAlert("here", "It works", "ok");
    }

    private void TapGestureRecognizer_Tapped_1(object sender, TappedEventArgs e)
    {
        DisplayAlert("here", "It works", "ahaaa");
    }

    private void addButton(object sender, EventArgs e)
    {
        var popup = new addMemberPopup();
        this.ShowPopup(popup);
        popup.Closed += addMember;
    }
    public void addMember(object sender, PopupClosedEventArgs e)
    {
        if (Member.f)
            MemberData.members.Add(new Member(MemberData.fullName, MemberData.userName, MemberData.password, MemberData.age,
                MemberData.gender, MemberData.phone, MemberData.nationalCode, MemberData.active));
        Member.f = false;
    }
}