namespace TaskManager_V0._1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        string tempUsername = "mahdieh007";
        string tempPassword = "00900090";

        private void loginButton(object sender, EventArgs e)
        {
            string username = userNameEntry.Text;
            string password = passwordEntry.Text;

            if (username == tempUsername && password == tempPassword)
            {
                App.Current.MainPage = new HomePage();
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
