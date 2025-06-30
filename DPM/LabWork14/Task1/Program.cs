using System.Text.RegularExpressions;

string phoneNumber = "+7(962)659-23-35";
string pattern = @"^(\+7|8)\(9\d{2}\)\d{3}-\d{2}-\d{2}$";

Regex regex = new(pattern);
if (regex.IsMatch(phoneNumber))
    Console.WriteLine(phoneNumber);
else
    Console.WriteLine("Error");