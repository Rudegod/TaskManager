using Microsoft.Maui.Controls;
using System.Collections.ObjectModel;

namespace TaskManager_V0._1;

public partial class TaskPage : ContentPage
{
    public ObservableCollection<TaskItem> Tasks { get; set; }

    public TaskPage()
	{
		InitializeComponent();
        Tasks = new ObservableCollection<TaskItem>
            {
                new TaskItem { TaskName = "cpsa", DueDate = "2024-09-20" },
                new TaskItem { TaskName = "plan2", DueDate = "2024-09-22" }
            };
        TasksListView.ItemsSource = Tasks;
    }

    private void AddTaskButton(object sender, EventArgs e)
    {
        Navigation.PushModalAsync(new AddTaskPage());
    }
    public class TaskItem
    {
        public string TaskName { get; set; }
        public string DueDate { get; set; }
    }
}