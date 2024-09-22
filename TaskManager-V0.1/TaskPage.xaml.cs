
using System.Diagnostics;

namespace TaskManager_V0._1;

public partial class TaskPage : ContentPage
{
    public TaskPage()
	{
		InitializeComponent();
    }

    private void AddTaskButton(object sender, EventArgs e)
    {
        Navigation.PushAsync(new AddTaskPage());
    }
}