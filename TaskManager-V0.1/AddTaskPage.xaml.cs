using Microsoft.Maui.Controls;
using Microsoft.VisualBasic;

namespace TaskManager_V0._1;

public partial class AddTaskPage : ContentPage
{
	public AddTaskPage()
	{
        InitializeComponent();
    }

    private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        importanceValueLabel.Text = ((int)e.NewValue).ToString();
    }

    private void okButton(object sender, EventArgs e)
    {

    }
}