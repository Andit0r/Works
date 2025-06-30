Console.WriteLine("Введите название файла для чтения");
string? fileName = Console.ReadLine();
if (!File.Exists(fileName))
{
    Console.WriteLine("Файл не найден");
    return;
}
var text = File.ReadAllText(fileName);
Console.WriteLine(text);