string text = "hello, world,. goodbye a";
var words = text.Split(new char[] { ' ', '.', ',' }, StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);

foreach (var word in words)
{
    Console.WriteLine(word);
}