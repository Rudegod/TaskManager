namespace TaskManager_V0._1;

public partial class GroupPage : ContentPage
{
	public GroupPage()
	{
		InitializeComponent();
	}

    /*	public class Title
        {
            public string Name_Of_Groups { get; set;  }
        }
    */
    private void AddButton(object sender, EventArgs e)
    {
        Navigation.PushAsync(new AddGroupPage());
    }


    /*
   private void GroupNum1(object sender, EventArgs e)
   {
       DisplayAlert("Go to group 1", "Hi", "Go");
   }

   private void GroupNum2(object sender, EventArgs e)
   {
       DisplayAlert("Go to group 2", "Hi", "Go");
   }

   private void GrougNum3(object sender, EventArgs e)
   {
       DisplayAlert("Go to group 3", "Hi", "Go");
   }

   private void GrougNum4(object sender, EventArgs e)
   {
       DisplayAlert("Go to group 4", "Hi", "Go");
   }

   private void GroupNumN(object sender, EventArgs e)
   {
       DisplayAlert("Go to group n", "Hi", "Go");
   }
   */
}