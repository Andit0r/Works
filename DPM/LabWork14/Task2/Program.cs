using System.Text.RegularExpressions;

string text = "a       a         a";
text = Regex.Replace(text, @"\s{2,}", " ");
Console.WriteLine(text);