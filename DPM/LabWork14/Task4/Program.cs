using System.Text.RegularExpressions;

string password = Console.ReadLine();
string pattern = @"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[.?!]).{6,}$";

Regex regex = new(pattern);

while (!regex.IsMatch(password))
    password = Console.ReadLine();