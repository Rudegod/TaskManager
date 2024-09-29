using CommunityToolkit.Maui.Views;
using Microsoft.Maui.Controls;
using Microsoft.VisualBasic;

namespace TaskManager_V0._1;

public partial class AddTaskPage : ContentPage
{
	public AddTaskPage()
	{
        InitializeComponent();
        // tasksList.ItemsSource = TaskData.tasks;
    }

    private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        importanceValueLabel.Text = ((int)e.NewValue).ToString();
    }

    private void okButton(object sender, EventArgs e)
    {
        // DisplayAlert("HaHaHa", "its not work hon", "Ok");
        if (Task.f)
            TaskData.tasks.Add(new Task(TaskData.name, TaskData.assign, TaskData.deadline, TaskData.cost, TaskData.time,
                TaskData.prerequisites, TaskData.manager, TaskData.couple, TaskData.previousTask, TaskData.description, TaskData.priority));
        Task.f = false;
    }

    private void assignButton(object sender, EventArgs e)
    {
        var popup = new AssignPopup();
        this.ShowPopup(popup);
    }

    private void PreButton(object sender, EventArgs e)
    {
        var popup = new PrerequisitesPopUp();
        this.ShowPopup(popup);
    }

    private void coupleButton(object sender, EventArgs e)
    {
        var popup = new CouplePopup();
        this.ShowPopup(popup);
    }

    private void managerButton(object sender, EventArgs e)
    {
        var popup = new ManagerPopup();
        this.ShowPopup(popup);
    }

    private void PreviousButton(object sender, EventArgs e)
    {
        var popup = new PrevioousTaskPopup();
        this.ShowPopup(popup);
    }
}