using System.Text.RegularExpressions;


string replacement = "($20{year1})${year}-${month}-${day}";

string text = "Сегодня 26.2.25, завтра 27/02/2025"; 
string pattern = @"(?<day>\d{1,2})[./](?<month>\d{1,2})[./]((?<year>\d{4})|(?<year2>\d{2}))";
Regex regex = new(pattern);

text = Regex.Replace(text, pattern, replacement);
Console.WriteLine(text);
