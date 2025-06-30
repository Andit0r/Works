User user = new("login", "password");
user.ValueChanged += User_ValueChanged;

user.Login = "login2";
user.Login = "login2";
user.Password = "password";
user.Password = "password1";

void User_ValueChanged(object? sender, EventArgs e)
{
    User? user = sender as User;
    Console.WriteLine($"Изменены данные пользователя со следующим логином: {user?.Login}.");
}

