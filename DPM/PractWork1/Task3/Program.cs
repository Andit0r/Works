Console.WriteLine("Введите название файла для поиска");
string? fileName = Console.ReadLine();
if (!File.Exists(fileName))
{
    Console.WriteLine("Файл не найден");
    return;
}

Console.WriteLine("Введите текст, который хотите найти");
string enteredText = Console.ReadLine();
var text = File.ReadAllLines(fileName);
for (int i = 0; i < text.Length; i++)
    if (text[i].Contains(enteredText))
        Console.WriteLine($"{i+1}:{text[i]}");