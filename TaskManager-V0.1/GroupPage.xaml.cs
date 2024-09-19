using CommunityToolkit.Maui.Views;

namespace TaskManager_V0._1;

public partial class GroupPage : ContentPage
{
	public GroupPage()
	{
		InitializeComponent();
	}

	private void addButton(object sender, EventArgs e)
	{
		var popup = new addGroupPopup();
		this.ShowPopup(popup);
	}
}