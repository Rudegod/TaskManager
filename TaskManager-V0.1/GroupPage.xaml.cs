using Microsoft.Maui.Controls;
using System.Collections.ObjectModel;

namespace TaskManager_V0._1;

public partial class GroupPage : ContentPage
{
    public ObservableCollection<Group> Groups { get; set; }
    //you are gay

    public GroupPage()
    {
        InitializeComponent();

        Groups = new ObservableCollection<Group>
            {
                new Group { GroupName = "Admins", Description = "System administrators" },
                new Group { GroupName = "Users", Description = "Regular users" } ,
                new Group { GroupName = "Users", Description = "Regular users" } ,
                new Group { GroupName = "Users", Description = "Regular users" } ,
                new Group { GroupName = "Users", Description = "Regular users" }
            };

        GroupsListView.ItemsSource = Groups;
    }

    public class Group
    {
        public string GroupName { get; set; }
        public string Description { get; set; }
    }
    private void AddButton(object sender, EventArgs e)
    {
        Navigation.PushModalAsync(new AddGroupPage());
    }
}