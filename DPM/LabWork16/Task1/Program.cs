User user = new("login", "password");

user.PropertyChanged += User_PropertyChanged;
user.Login = "login2";
user.Password = "password";
user.Password = "password1";

void User_PropertyChanged(object? sender, System.ComponentModel.PropertyChangedEventArgs e)
{
    Console.WriteLine($"Изменилось свойство: {e.PropertyName}\n");
}
