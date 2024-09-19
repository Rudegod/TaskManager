using System.Collections.ObjectModel;
using System.Windows.Input;
using System.ComponentModel;
using CommunityToolkit.Mvvm.ComponentModel;
using System.Runtime.CompilerServices;

namespace TaskManager_V0._1.ViewModel
{
    internal partial class MainViewModel : INotifyPropertyChanged
    {
        public class User
        {
            public string Name { get; set; }
            public string Email { get; set; }
        }
        private string _name;
        private string _email;

        private ObservableCollection<User> Users { get; set; }

        public string Name
        {
            get => _name;
            set
            {
                _name = value;
            }
        }
        public string Email
        {
            get => _email;
            set
            {
                _email = value;
                OnPropertyChanged();
            }
        }

        public ICommand AddUserCommand { get; }

        public MainViewModel()
        {
            Users = new ObservableCollection<User>();
            AddUserCommand = new Command(OnAddUser);
        }

        private async void OnAddUser()
        {
            if (string.IsNullOrEmpty(Name) || string.IsNullOrEmpty(Email))
            {
                await Application.Current.MainPage.DisplayAlert("Error", "Please enter both name and email.", "OK");
                return;
            }
            else
            {
                Users.Add(new User { Name = Name, Email = Email });

                // Clear input fields
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}