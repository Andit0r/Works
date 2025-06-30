using System.Text.RegularExpressions;

string email = "pavlovaa03082007@yandex.arcotel.ru";
string pattern = @"^[a-z0-9_-]+@[a-z0-9]+(\.[a-z0-9]+)*\.[a-z]{2,}$";

Regex regex = new(pattern, RegexOptions.IgnoreCase);
if (regex.IsMatch(email))
    Console.WriteLine(email);
else
    Console.WriteLine("Error");