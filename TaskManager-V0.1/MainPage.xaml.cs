namespace TaskManager_V0._1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        string tempUsername = "hi";
        string tempPassword = "bye";

        private void loginButton(object sender, EventArgs e)
        {
            string username = userNameEntry.Text;
            string password = passwordEntry.Text;

            if (username == tempUsername && password == tempPassword)
            {
                App.Current.MainPage = new NavigationPage(new HomePage());
            }
            else
            {
                DisplayAlert("Stupid", "UserName or Password Wrong :/", "Bedeh SHihs");
            }

        }

        private void forgotPasswordButton(object sender, EventArgs e)
        {

        }
    }

}
