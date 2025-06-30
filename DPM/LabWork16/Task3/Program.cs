User user = new("login", "password");

user.PropertyChanged += User_PropertyChanged;

user.Login = "login2";
user.Password = "password";

void User_PropertyChanged(object? sender, InfoEventArgs e)
{
    User? user = sender as User;
    Console.WriteLine($"{e.ChangeDate}: у пользователя {user?.Login} изменено {e.PropertyName}.");
    if (e.ErrorText != "")
        Console.WriteLine(e.ErrorText);
};