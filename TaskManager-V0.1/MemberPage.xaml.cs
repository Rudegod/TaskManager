using CommunityToolkit.Maui.Core;
using CommunityToolkit.Maui.Views;
using System.Collections.ObjectModel;
using System.Security.Cryptography.X509Certificates;

namespace TaskManager_V0._1;

public partial class MemberPage : ContentPage
{
    public ObservableCollection<Member> members = new ObservableCollection<Member>();
    public MemberPage()
	{
		InitializeComponent();
        membersList.ItemsSource = members;
        //BindingContext = this;
    }

	public void addButton(object sender, EventArgs e)
	{
        var popup = new addMemberPopup();
        this.ShowPopup(popup);
        popup.Closed += addMember;
    }
    public void addMember(object sender, PopupClosedEventArgs e)
    {
        members.Add(new Member(MemberData.fullName, MemberData.userName, MemberData.password, MemberData.age,
            MemberData.gender, MemberData.phone, MemberData.nationalCode, MemberData.active));
    }

}