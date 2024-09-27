using System.Timers;

namespace TaskManager_V0._1;

public partial class SmsPage : ContentPage
{
    private System.Timers.Timer _timer;
    private DateTime _endTime;
    private const int CountdownDuration = 120;

    public SmsPage()
	{
        InitializeComponent();
        StartCountdown();
    }

    private void StartCountdown()
    {
        _endTime = DateTime.Now.AddSeconds(CountdownDuration);
        _timer = new System.Timers.Timer(1000); // Set timer to tick every second
        _timer.Elapsed += OnTimerElapsed;
        _timer.Start();
        CountdownLabel.Text = CountdownDuration.ToString();
    }

    private void OnTimerElapsed(object sender, ElapsedEventArgs e)
    {
        var timeLeft = _endTime - DateTime.Now;
        if (timeLeft.TotalSeconds <= 0)
        {
            _timer.Stop();
            CountdownLabel.Text = "Code Received!";
            return;
        }

        // Update the countdown label on the main thread
        MainThread.BeginInvokeOnMainThread(() =>
        {
            CountdownLabel.Text = Math.Max(0, (int)timeLeft.TotalSeconds).ToString();
        });
    }

    private void LoginButton(object sender, EventArgs e)
    {
        App.Current.MainPage = new NavigationPage(new HomePage());
    }
}