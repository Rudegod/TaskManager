using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace TaskManager_V0._1.viewmodel
{
    internal partial class UsersViewModel : INotifyPropertyChanged
    {
        public class User
        {
            public string Name { get; set; }
            public string Password { get; set; }
            public string PhoneNumber { get; set; }
        }

        private string _name;
        private string _password;
        private string _phonenumber;

        private ObservableCollection<User> Users { get; set; }

        public string Name
        {
            get => _name;
            set
            {
                _name = value;
            }
        }

        public string Password
        {
            get => _password;
            set
            {
                _password = value;
                OnPropertyChanged();
            }
        }

        public string PhoneNumber
        {
            get => _phonenumber;
            set
            {
                _phonenumber = value;
            }
        }

        public ICommand AddUserCommand { get; }

        public UsersViewModel()
        {
            Users = new ObservableCollection<User>();
            AddUserCommand = new Command(OnAddUser);
        }

        private async void OnAddUser()
        {
            if (string.IsNullOrEmpty(Name) || string.IsNullOrEmpty(Password))
            {
                await Application.Current.MainPage.DisplayAlert("Error", "Please fill in all fields.", "OK");
                return;
            }
            else
            {
                Users.Add(new User { Name = Name, Password = Password, PhoneNumber = PhoneNumber, });
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
