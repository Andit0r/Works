public class User
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
                ValueChanged?.Invoke(this, EventArgs.Empty);
                _login = value;
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
                ValueChanged?.Invoke(this, EventArgs.Empty);
                _password = value;
            }
        }
    }

    public event EventHandler ValueChanged;
}