using System.ComponentModel;
using System.Runtime.CompilerServices;

class User
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
                string errorText = String.Empty == _login ? "Пустой логин" : "";
                OnPropertyChanged(errorText);
            }
        }
    }
    public string Password
    {
        get => _password;
        set
        {
            _password = value;
            string errorText = _password.Length < 6 || _password.Length > 20 ? "Пароль должен быть от 6 до 20 символов" : "";
            OnPropertyChanged(errorText);
        }
    }

    public event EventHandler<InfoEventArgs> PropertyChanged;

    private void OnPropertyChanged(string errorText, [CallerMemberName] string propertyName = "")
    {
        PropertyChanged?.Invoke(this, new InfoEventArgs(propertyName, errorText, DateTime.Now));
    }
}