using System.ComponentModel;
using System.Runtime.CompilerServices;

public class User : INotifyPropertyChanged
{
    private string _login;
    private string _password;

    public User(string login, string password)
    {
        Login = login;
        Password = password;
    }

    public string Login
    {
        get => _login;
        set
        {
            if (_login != value)
            {
                _login = value;
                OnPropertyChanged();
            }
        }
    }
    public string Password
    {
        get => _password;
        set
        {
            if (_password != value)
            {
                _password = value;
                OnPropertyChanged();
            }
        }
    }

    private void OnPropertyChanged([CallerMemberName] string propertyName = "")
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    public event PropertyChangedEventHandler? PropertyChanged;
}