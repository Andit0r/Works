int letterCount = 0;
int charCount = 0;

string enteredString = Console.ReadLine();

Console.WriteLine($"Количество символов в строке: {enteredString.Length}");
Console.WriteLine($"Количество символов в строке, без пробелов:{enteredString.Replace(" ", "").Length}");

for (int i = 0; i < enteredString.Length; i++)
    if (Char.IsLetter(enteredString[i]))
        letterCount++;

Console.WriteLine($"Количество букв в строке: {letterCount}");

char enteredChar = Convert.ToChar(Console.ReadLine());

for (int i = 0; i < enteredString.Length; i++)
    if (enteredString[i] == enteredChar)
        charCount++;

if (charCount > 0)
    Console.WriteLine($"Количество символов в строке: {charCount}");
else
    Console.WriteLine("Ничего не найдено");

