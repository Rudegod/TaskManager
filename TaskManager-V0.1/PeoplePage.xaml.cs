using System.Collections.ObjectModel;
using TaskManager_V0._1;
using TaskManager_V0._1.viewmodel;

public partial class UsersPage : ContentPage
{
    public ObservableCollection<User> Users { get; set; }

    public UsersPage()
    {
        InitializeComponent();
        BindingContext = new UsersViewModel(); // Ensure this is set

        Users = new ObservableCollection<User>
         {
            new User { Name = "John Doe", Password = "1234" , PhoneNumber = "09935126149" },
            new User { Name = "Jane Smith", Password = "101010" , PhoneNumber = "09012949689" } ,
            new User { Name = "Erfan", Password = "erfan1324" , PhoneNumber = "09303999827" }
         };

        UsersListView.ItemSource = Users;
    }

    private void Add (object sender, EventArgs e)
    {
        Navigation.PushModalAsync(new AddUserPage());
    }

    public class User
    {
    public string Name { get; set; }
    public string Password { get; set; }
    public string PhoneNumber { get; set; }

    public string DisplayText => $"{Name} - {Password} - {PhoneNumber}";
    }

}
